using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp10
{
    public class Database
    {
        private string connectionString = "Data Source=DESKTOP-QP8RA3I\\MSSQLSERVER01;Initial Catalog=NamNT_BH00888;Integrated Security=True";
        private SqlConnection conn;

        private DataTable dt;
        private SqlCommand cmd;
        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connected Fail " + ex.Message);
            }
        }
        public DataTable SelectData(string sql, List<CustomParameter> lstPara)

        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure
                    ;
                foreach (var para in lstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
                return null;
            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show("Information error " + ex.Message);
                return null;
            }
            finally { conn.Close(); }


        }
        public int ExeCute(string sql, List<CustomParameter> lstPara)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Command execution error " + ex.Message);
                return -100;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
        }
    }
}
