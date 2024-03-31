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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }
        private string Search = "";

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search = txtsearch.Text;
            LoadDSLH();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            LoadDSLH();
        }
        private void LoadDSLH()
        {
            string sql = "allClass";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@Search",
                    value = Search
                }
            };
            dgvclass.DataSource = new Database().SelectData(sql, lstPara);
        }

       

        private void btnadd_Click(object sender, EventArgs e)
        {
            new Class(null).ShowDialog();
            LoadDSLH();
        }

        private void dgvclass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new Class(dgvclass.Rows[e.RowIndex].Cells["ClassCode"].Value.ToString()).ShowDialog();
                LoadDSLH();
            }
        }
    }

    

}
