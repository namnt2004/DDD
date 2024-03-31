using System.Globalization;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Add Student";
            }
            else
            {
                this.Text = "Update student information";
                var r = new Database().Select("selectSv '" + msv + "'");
                txtname.Text = r["StudentName"].ToString();
                mtbbirth.Text = r["Birth"].ToString();
                if (int.Parse(r["Sex"].ToString()) == 0)
                {
                    rbtmale.Checked = true;
                }
                else { rbtmale.Checked = true; }
                txtemail.Text = r["Email"].ToString();
                txtphone.Text = r["Phone"].ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            string Name = txtname.Text;
            DateTime Birth;
            try
            {
                Birth = DateTime.ParseExact(mtbbirth.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid date of birth ");
                mtbbirth.Select();
                return;
            }
            string sex = rbtmale.Checked ? "0" : "1";
            string Email = txtemail.Text;
            string Phone = txtphone.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ADDSV";
            }
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@StudentCode",
                    value = msv,
                });

            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Name",
                value = Name
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Sex",
                value = sex
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Birth",
                value = Birth.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = Email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Phone",
                value = Phone
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Add new students successfully");
                }
                else
                {
                    MessageBox.Show("Successful student updates");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Execution failed");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}