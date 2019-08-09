using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutoCareSystem
{
    class Database
    {
        private static String conString = "server=localhost;Trusted_Connection=yes;database=auto_care;connection timeout=30";
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public Database()
        {
            try
            {
                con = new SqlConnection(conString);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public void openConnection()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
}

        public void sqlQuery(String query)
        {
            try
            {
                cmd = new SqlCommand(query, con);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable executeQuery()
        {
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String executeQuery(String para)
        {
            try
            {
                DataTable dt = executeQuery();
                return Convert.ToString(dt.Rows[0][para]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public SqlDataReader getData()
        {
            try
            {
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool nonQuery()
        {
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static String getLastInsertId(String tbl_name, String clm_name)
        {
            try {
                String query = "SELECT TOP 1 " + clm_name + " FROM " + tbl_name + " ORDER BY " + clm_name + " DESC";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                String id = db.executeQuery(clm_name);
                db.closeConnection();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string getDataByScaller()
        {
            try
            {
                return cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
