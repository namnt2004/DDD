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
    public partial class DSSV : Form
    {
        public DSSV()
        {
            InitializeComponent();
        }
        
        private string Search = "";

        private void LoadDSSV()
        {
            string sql = "SelectAllStudent";

            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@Search",
                value = Search
            });

            dgvdssv.DataSource = new Database().SelectData("SelectAllStudents", lstPara);


            dgvdssv.Columns["StudentCode"].HeaderText = "Student Code";
            dgvdssv.Columns["StudentName"].HeaderText = "Name";
            dgvdssv.Columns["birth"].HeaderText = "Birth Day ";
            dgvdssv.Columns["sex"].HeaderText = "Sex";
            dgvdssv.Columns["Email"].HeaderText = "Email";
            dgvdssv.Columns["Phone"].HeaderText = "Phone";
        }


        private void dgvdssv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvdssv.Rows[e.RowIndex].Cells["StudentCode"].Value.ToString();
                new Form1(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            Search = txtsearch.Text;
            LoadDSSV();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            new Form1(null).ShowDialog();
            LoadDSSV();
        }

        private void DSSV_Load(object sender, EventArgs e)
        {
            LoadDSSV();
        }
    }
}
