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
    public partial class DSMH : Form
    {
        public DSMH()
        {
            InitializeComponent();
        }

        private string Search = "";

        
        private void LoadDSMH()

        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@Search",
                value = Search
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllSubject", lstPara);
        }





        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            Search = txtsearch.Text;
            LoadDSMH();
        }

        private void DSMH_Load_1(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["SubjectCode"].HeaderText = "Subject Code";
            dgvDSMH.Columns["SubjectName"].HeaderText = "Subject Name";
        }

        private void dgvDSMH_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvDSMH.Rows[e.RowIndex].Cells["SubjectCode"].Value.ToString();
                new Subject(mamh).ShowDialog();
                LoadDSMH();
            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            new Subject(null).ShowDialog();
            LoadDSMH();
        }
    }
}

