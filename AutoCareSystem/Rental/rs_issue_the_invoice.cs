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
using System.Text.RegularExpressions;
using AutoCareSystem.Rental.RentalReports;

namespace AutoCareSystem
{

    public partial class rs_issue_the_invoice : UserControl
    {
        int noOfDates;
        int maxKm;
        float chargeforRentDates = 0;
        DateTime rentDate;

        public rs_issue_the_invoice()
        {
            InitializeComponent();

            loadData();


            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        public void loadData()
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "SELECT * FROM rental_invoice";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;


            for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Visible = false;
            }

            bunifuCustomDataGrid1.Columns[0].Visible = true;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "Invoice ID";
            bunifuCustomDataGrid1.Columns[1].Visible = true;
            bunifuCustomDataGrid1.Columns[1].HeaderText = "Rent ID";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Issued Date";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "Advanced Payment";

            btn_update.Visible = false;
            btn_remove.Visible = false;
            btn_add.Enabled = true;
            crystalReportViewer1.Visible = false;
            btn_back.Visible = false;

            //get rent id  which not issued a bill, to combo box
            String q3 = "SELECT rnt_id FROM rental_details WHERE rnt_invoice_is_issued = 'no'";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                list.Add("Rent ID");
                list.Add(dr["rnt_id"].ToString());
            }

            list = list.Distinct().ToList();
            cmb_inv_rnt_id.DataSource = list;


             db.closeConnection();

            clear();
            txt_inv_id.Text = CodeGenerator.generateRentalInvoiceCode();

        }


        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select* from rental_invoice where in_id like '%" + txt_search.Text + "%'";

                db.sqlQuery(q1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = dt;

                 db.closeConnection();

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void clear()
        {
            txt_inv_id.Text = string.Empty;
            cmb_inv_rnt_id.Text = string.Empty;
            txt_search.Text = string.Empty;
            txt_inv_adv_payment.Text = string.Empty;
            datepicker_issueDate.Text = string.Empty;


        }

        private void btn_v_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                bool test = Validte_Data();
                if (test == true)
                {
                    if (datepicker_issueDate.Value.Date != DateTime.Today)
                    {
                        MyDialog.Show("Error...!", "Invoice Isuue Date Is Not Valid");
                    }
                    else
                    {
                        Database db = new Database();
                        db.openConnection();

                        string query = "INSERT INTO rental_invoice VALUES  ( '" + txt_inv_id.Text + "', '" + cmb_inv_rnt_id.Text + "', '" + datepicker_issueDate.Text + "','" + float.Parse(txt_inv_adv_payment.Text) + "' )";
                        db.sqlQuery(query);
                        db.nonQuery();

                        string query2 = "UPDATE rental_details SET rnt_invoice_is_issued = 'yes' Where rnt_id = '" + cmb_inv_rnt_id.Text + "'";
                        db.sqlQuery(query2);
                        db.nonQuery();

                         db.closeConnection();

                        loadData();

                        MyDialog.Show("Insert Successful..", "Invoice Was Successfully Added");
                    }



                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                bool test = Validte_Data();
                if (test == true)
                {
                    Database db = new Database();
                    db.openConnection();

                    string query = "UPDATE rental_invoice SET in_rnt_id ='" + cmb_inv_rnt_id.Text + "',in_date ='" + datepicker_issueDate.Text + "', in_advanced_payment ='" + float.Parse(txt_inv_adv_payment.Text) + "' WHERE in_id = '" + txt_inv_id.Text + "' ";
                    db.sqlQuery(query);
                    db.nonQuery();

                    string query2 = "UPDATE rental_details SET rnt_invoice_is_issued = 'yes' Where rnt_id = '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(query2);
                    db.nonQuery();

                     db.closeConnection();

                    loadData();

                    MyDialog.Show("Update Successful..", "Invoice Record Successfully Updated");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.openConnection();

                string query = "DELETE FROM rental_invoice WHERE in_id = '" + txt_inv_id.Text + "' ";

                db.sqlQuery(query);

                if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete the item 
                    db.nonQuery();
                    MessageBox.Show("DELETE");

                    //update invoice is issued to no
                    string query2 = "UPDATE rental_details SET rnt_invoice_is_issued = 'no' Where rnt_id = '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(query2);
                    db.nonQuery();
                }
                else
                {
                    //Cancel action 
                    MessageBox.Show("ABORT");
                }

                 db.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            loadData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //get all rent id's  to combo box
            String q3 = "SELECT rnt_id FROM rental_details ";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                list.Add("Rent ID");
                list.Add(dr["rnt_id"].ToString());
            }

            list = list.Distinct().ToList();
            cmb_inv_rnt_id.DataSource = list;

             db.closeConnection();

            txt_inv_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            cmb_inv_rnt_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            datepicker_issueDate.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            txt_inv_adv_payment.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();

            btn_update.Visible = true;
            btn_remove.Visible = true;
            btn_add.Enabled = false;
        }

        private void rs_issue_the_invoice_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }

       

        private bool Validte_Data()
        {
            Regex validate_float = new Regex("^[0-9]+(\\.[0-9][0-9]?)?$");


            if (!validate_float.IsMatch(txt_inv_adv_payment.Text))
            {
                MyDialog.Show("Error...!", "Invalid Advabced Payment");
            }
            else
            {
                return true;
            }
            return false;
        }

        private void cmb_inv_rnt_id_DropDown(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //get rent id  which not issued a bill, to combo box
            String q3 = "SELECT rnt_id FROM rental_details WHERE rnt_invoice_is_issued = 'no'";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                list.Add("Rent ID");
                list.Add(dr["rnt_id"].ToString());
            }

            list = list.Distinct().ToList();
            cmb_inv_rnt_id.DataSource = list;


             db.closeConnection();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btn_back.Visible = true;
            crystalReportViewer1.Visible = true;
            crystalReportViewer1.Refresh();

            calculations();
            
            Database db = new Database();
            db.openConnection();

            string query = "SELECT * FROM rental_details rd, rental_invoice ri, rental_bill_details rb, customers cus, rental_vehicle rv Where rd.rnt_cus_id = cus.c_code  AND rb.bill_rnt_id = rd.rnt_id AND ri.in_rnt_id = rd.rnt_id AND rv.rv_id = rd.rnt_vehicle_id AND bill_rnt_id = '" + cmb_inv_rnt_id.Text + "'";

            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(query, db.getConnection());

            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "rental_invoice");

            rpt_invoice myreport = new rpt_invoice();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;

            myreport.SetParameterValue("pNoofDays", noOfDates);
            myreport.SetParameterValue("PmaximumKm", maxKm);
            myreport.SetParameterValue("PchargeRentDates", chargeforRentDates);

             db.closeConnection();

           

        }

        private void calculations()
        {
            try
            {
                bool test = Validte_Data();
                if (test == true)
                {
                    Database db = new Database();
                    db.openConnection();

                    //get advanced payment
                    string q1 = "SELECT in_advanced_payment FROM rental_invoice WHERE in_rnt_id = '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(q1);

                    float advPayment;
                    advPayment = float.Parse(db.getDataByScaller());

                    //get current millage
                    string q2 = "SELECT rnt_current_millage FROM  rental_details WHERE rnt_id = '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(q2);

                    int currentMillage;
                    currentMillage = Convert.ToInt32(db.getDataByScaller());
                    

                    //get actual return date (expected date)
                    string q4 = "SELECT rnt_return_date FROM  rental_details WHERE rnt_id= '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(q4);

                    DateTime actualReturnDate;
                    actualReturnDate = Convert.ToDateTime(db.getDataByScaller());

                    //get rent date
                    string q3 = "SELECT rnt_date FROM  rental_details WHERE rnt_id= '" + cmb_inv_rnt_id.Text + "'";
                    db.sqlQuery(q3);

                    rentDate = Convert.ToDateTime(db.getDataByScaller());

                    //get km per day and rate per day
                    String q5 = "SELECT rv_km_per_day, rv_exceed_rate, rv_rate_per_day FROM rental_vehicle WHERE rv_id = (SELECT rnt_vehicle_id FROM rental_details WHERE rnt_id= '" + cmb_inv_rnt_id.Text + "' ) ";
                    db.sqlQuery(q5);
                    DataTable dt = db.executeQuery();

                    int kmPerDay = Convert.ToInt32(dt.Rows[0][0]);
                    float ratePerDate = float.Parse(dt.Rows[0][2].ToString());

                    //MessageBox.Show("kmPerDay : " +kmPerDay);
                    //MessageBox.Show("advPayment : " + advPayment);
                    //MessageBox.Show("ratePerDate : " + ratePerDate);
                    

                    //get num of days rent the vehicle
                    noOfDates = Convert.ToInt32((actualReturnDate - rentDate).TotalDays) + 1;

                    //calculate max km per rent period
                    maxKm = kmPerDay * noOfDates;

                    chargeforRentDates = (noOfDates * ratePerDate);


                    MessageBox.Show("maxKm : " + maxKm);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }



        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            btn_back.Visible = false;
            crystalReportViewer1.Visible = false;

        }

        
    }
}