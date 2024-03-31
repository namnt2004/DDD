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
    public partial class Subject : Form
    {
        public Subject(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }
        private string mamh;
        private string implementer = "NamNT_BH00888";

      




        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Subject_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = " Add Subject";
            }
            else
            {
                this.Text = "Update Subject";
                var r = new Database().Select("exec selectMH'" + mamh + "'");
                txttenmh.Text = r["SubjectName"].ToString();
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttenmh.Text))
            {
                MessageBox.Show("Subject names cannot be left blank");
                txttenmh.Select();
                return;
            }
            string sql = "";

            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Creator",
                    value = implementer
                });
            }
            else
            {
                sql = "updateMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@SubjectCode",
                    value = mamh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@Updater",
                    value = implementer
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@SubjectName",
                    value = txttenmh.Text
                });
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mamh))
                    {
                        MessageBox.Show("Add subjects successfully");
                    }
                    else
                    {
                        MessageBox.Show("Update subject successfully");
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Failed implementation");
                }
            }
          }
    }
}
