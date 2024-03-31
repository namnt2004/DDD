using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Class : Form
    {
        public Class(string ClassCode)
        {
            this.ClassCode = ClassCode;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private string ClassCode;
        private Database db;
        private string Implementer = "NamNT_BH00888";

        private void Class_Load(object sender, EventArgs e)

        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@Search",
                    value = ""
                }
            };
            cbbsubject.DataSource = db.SelectData("selectAllSubject", lst);
            cbbsubject.DisplayMember = "SubjectName";
            cbbsubject.ValueMember = "SubjectCode";
            cbbsubject.SelectedIndex = -1;



            cbbteacher.DataSource = db.SelectData("selectAllGV", lst);
            cbbteacher.DisplayMember = "TeacherName";
            cbbteacher.ValueMember = "TeacherCode";
            cbbteacher.SelectedIndex = -1;
            if (string.IsNullOrEmpty(ClassCode))
            {
                this.Text = "Add Class ";
            }
            else
            {
                this.Text = "Update Class";
                var r = db.Select("exec selectClass'" + ClassCode + "'");
                cbbteacher.SelectedValue = r["TeacherCode"].ToString();
                cbbsubject.SelectedValue = r["SubjectCode"].ToString();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (cbbsubject.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a subject");
                return;
            }
            if (cbbteacher.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a teacher ");
                return;
            }

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(ClassCode))
            {
                sql = "insertClass";
                lst.Add(new CustomParameter()
                {
                    key = "@Creator",
                    value = Implementer
                });
            }
            else
            {
                sql = "updateClass";
                lst.Add(new CustomParameter()
                {
                    key = "@Updater",
                    value = Implementer
                });

                lst.Add(new CustomParameter()
                {
                    key = "@ClassCode",
                    value = ClassCode
                });
            }

            lst.Add(new CustomParameter()
            {
                key = "@SubjectCode",
                value = cbbsubject.SelectedValue.ToString()
            });

            lst.Add(new CustomParameter()
            {
                key = "@TeacherCode",
                value = cbbteacher.SelectedValue.ToString()
            });
            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {
                if (string.IsNullOrEmpty(ClassCode))
                {
                    MessageBox.Show("Add new class successfully");
                }
                else
                {
                    MessageBox.Show("Successful class update");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Data storage failed");
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

