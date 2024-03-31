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
    public partial class DSGV : Form
    {
        public DSGV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string Search = "";
        private void LoadDSGV()
        {
            string sql = "selectAllGV";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@Search",
                value = Search
            });
            dgvdsgv.DataSource = new Database().SelectData(sql, lstPara);
        }



        private void dgvdsgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvdsgv_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mgv = dgvdsgv.Rows[e.RowIndex].Cells["TeacherCode"].Value.ToString();
                new Gv(mgv).ShowDialog();
                LoadDSGV();

            }
        }

        private void DSGV_Load_1(object sender, EventArgs e)
        {
            LoadDSGV();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search = txtsearch.Text;
            LoadDSGV();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Gv(null).ShowDialog();
            LoadDSGV();
        }
    }
}
