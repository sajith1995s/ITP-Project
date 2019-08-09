using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoCareSystem.Sales;

namespace AutoCareSystem
{
    public partial class Sales_report : UserControl
    {
        private static Sales_report _instance;
        public static Sales_report Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sales_report();
                return _instance;
            }
        }



        public Sales_report()
        {
            InitializeComponent();
        }

        private void Sales_report_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenarete_Click(object sender, EventArgs e)
        {
            try{
                
                Database db = new Database();

                string query = "select * from sales where created_at BETWEEN'" + Convert.ToDateTime(DPstartdate.Text) + "' AND '" + Convert.ToDateTime(DPenddate.Text) + "'";
                db.openConnection();
                db.sqlQuery(query);
                SqlDataReader reader = db.getData();
                while (reader.Read())
                {

                    chart1.Series["Sales"].Points.AddXY(reader["created_at"].ToString(), reader["total_price"].ToString());

                }
                db.getConnection().Close();

            }
            catch (Exception ex) {

                MessageBox.Show("error" + ex);




            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new cristalreport().Show();
        }
    }
}
