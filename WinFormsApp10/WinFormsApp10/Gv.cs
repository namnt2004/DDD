using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Gv : Form
    {
        public Gv(string Gv)
        {
            this.mgv = Gv;
            InitializeComponent();
        }

        private string mgv;
        private string Executor = "NamNT_BH00888";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gv_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mgv))
            {
                this.Text = "Add New Teacher ";
            }
            else
            {
                this.Text = "Update New Teacher";
                var r = new Database().Select("selectGV '" + int.Parse(mgv) + "'");
                txtname.Text = r["TeacherName"].ToString();
                rbtnam.Checked = r["Sex"].ToString() == "1" ? true : false;
                mtbngaysinh.Text = r["Birth"].ToString();
                txtemail.Text = r["Email"].ToString();
                txtphone.Text = r["Phone"].ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sql = "";
            DateTime Birth;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            try
            {
                Birth = DateTime.ParseExact(mtbngaysinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Invalid date of birth ");
                mtbngaysinh.Select();
                return;
            }

            if (string.IsNullOrEmpty(mgv))
            {
                sql = "InsertGV";
                lstPara.Add(new CustomParameter
                {
                    key = "@Creator",
                    value = Executor
                });
            }
            else
            {
                sql = "updateGV";
                lstPara.Add(new CustomParameter
                {
                    key = "@Updater",
                    value = Executor
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@TeacherCode",
                    value = mgv
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@TeacherName",
                    value = txtname.Text
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@Sex",
                    value = rbtnam.Checked ? "1" : "0"
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@Birth",
                    value = Birth.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@Email",
                    value = txtemail.Text
                });
                lstPara.Add(new CustomParameter
                {
                    key = "@Phone",
                    value = txtphone.Text
                });
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mgv))
                    {
                        MessageBox.Show("Added new teachers successfully ");
                    }
                    else
                    {
                        MessageBox.Show("Update  new teacher success ");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Query execution failed");
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
