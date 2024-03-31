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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string UserName;
        private string loaitk;


        private void AddForm(Form f)
        {
            this.pnlcontent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlcontent.Controls.Add(f);
            f.Show();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void teacherToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DSGV f = new DSGV();
            AddForm(f);
        }

        private void subjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DSMH f = new DSMH();
            AddForm(f);
        }

        private void classToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmClass f = new frmClass();
            AddForm(f);
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Score f = new Score();
            AddForm(f);
        }

        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DSSV f = new DSSV();
            AddForm(f);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var fn = new frmLogin();
            fn.ShowDialog();
            UserName = fn.UserName;
            loaitk = fn.loaitk;
            if (loaitk.Equals("Student"))
            {
                teacherToolStripMenuItem.Visible = false;
                subjectToolStripMenuItem.Visible = false;
                classToolStripMenuItem.Visible = false;
            }
            else
            {
                teacherToolStripMenuItem.Visible = true;
            }

            Wellcome f = new Wellcome();
            AddForm(f);
        }
    }
}
