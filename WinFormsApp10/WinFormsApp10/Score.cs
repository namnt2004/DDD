using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Score : Form
    {
        public Score()
        {
            InitializeComponent();
        }
        private string Search = "";
       


        private void LoadDSD()
        {
            string sql = "score";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@Search",
                    value = Search
                }
            };
            dgvscore.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            Search = txtsearch.Text;
            LoadDSD();
        }

        private void Score_Load_1(object sender, EventArgs e)
        {
            LoadDSD();
        }
    }
}
