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
using AutoCareSystem.Rental.RentalReports;

namespace AutoCareSystem
{
    public partial class rs_reports : UserControl
    {
        public rs_reports()
        {
            InitializeComponent();
            cmb_rpt_type.SelectedIndex = 0 ;
        }

        private void rs_reports_Load(object sender, EventArgs e)
        {

        }

        private void cmb_rpt_type_SelectedIndexChanged(object sender, EventArgs e)
        {

            string type = cmb_rpt_type.Text;

            switch (type)
            {
                case "Select Report Type":
                    break;

                case "Rental Vehicle Details":
                    {
                        Database db = new Database();
                        db.openConnection();

                        string query = "select * from rental_vehicle";
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, db.getConnection());

                        cmd.ExecuteNonQuery();
                        rs_ds_rentalVehi ds = new rs_ds_rentalVehi();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "rental_vehicle");

                        rs_rpt_vehicleDetails myReport = new rs_rpt_vehicleDetails();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;

                         db.closeConnection();
                        break;
                    }


                case "Rental Information":
                    {
                       Database db = new Database();
                        db.openConnection();

                        string query = "select rd.rnt_id as 'id', CONCAT(cus.fname+' ',cus.lname) as 'fullname' ,cus.nic as 'nic',cus.city as 'city', rv.rv_brand as 'brand', rv.rv_model as 'model', rv.rv_number as 'num', rv.rv_millage as 'millage' from customers cus, rental_details rd, rental_vehicle rv where cus.c_code=rd.rnt_cus_id AND rd.rnt_vehicle_id = rv.rv_id ";
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand(query, db.getConnection());

                        cmd.ExecuteNonQuery();
                        rs_ds_rentalInfo ds = new rs_ds_rentalInfo();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "rentalInfo");

                        rs_rpt_rentalDetails myReport = new rs_rpt_rentalDetails();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;

                         db.closeConnection();
                        break;
                    }
            }
            }
    }
}
