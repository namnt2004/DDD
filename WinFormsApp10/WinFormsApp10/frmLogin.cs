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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string UserName = "";
        public string loaitk;
       


        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            #region
            if (cbbtype.SelectedIndex < 0)
            {
                MessageBox.Show("Please select account type ");
                return;
            }
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please enter your account ");
                txtusername.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtpass.Text))
            {
                MessageBox.Show("Please enter your password ");
                txtpass.Select();
                return;
            }
            #endregion
            UserName = txtusername.Text;
            loaitk = "";
            #region
            switch (cbbtype.Text)
            {
                case "Administrators":
                    loaitk = "admin";
                    break;
                case "Teacher":
                    loaitk = "Teacher";
                    break;
                case "Student":
                    loaitk = "Student";
                    break;
            }
            #endregion
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key ="@AccountType",
                    value=loaitk
                },
                new CustomParameter()
                {
                    key ="@UserName",
                    value=txtusername.Text
                },
                new CustomParameter()
                {
                    key ="@PassWord",
                    value=txtpass.Text
                },
            };
            var rs = new Database().SelectData("loginAccount", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfull ");
                this.Hide();
            }
            else
            {
                MessageBox.Show("This Account is invalid");
            }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
