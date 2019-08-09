using AutoCareSystem.Sales;
using AutoCareSystem.Sales.SalesReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class Sales_Bill : Form
    {
        public Sales_Bill()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void Sales_SubView_Load(object sender, EventArgs e)
        {
            string salesid = CodeGenerator.getLastInsertId("sales", "sales_id");
            Database db = new Database();
            db.openConnection();
            SqlConnection conn = db.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select distinct * from sales s ,salescustomer cs,sales_items si where s.cus_id=cs.cus_id AND s.sales_id=si.sales_id AND s.sales_id ='" + salesid + "'", conn);
            DataSet dst = new DataSet();
            sda.Fill(dst, "sales");


            CrystalReport1 cryrpt = new CrystalReport1();

            cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
            db.getConnection().Close();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void sales_report1_Load(object sender, EventArgs e)
        {

        }

        private void sales_Items1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRepairUpdate_Click(object sender, EventArgs e)
        {
            new SalesSubFunc().Show();
        }
    }
}
