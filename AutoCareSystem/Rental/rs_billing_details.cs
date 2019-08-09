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
    public partial class rs_billing_details : UserControl
    {
        int noOfDates =0;
        float extraCharges = 0;
        int totalKm = 0;
        int maxKm = 0 ;
        int exeedKms =0;
        float totalBill = 0;
        float finalAmount = 0;
        float chargeforRentDates = 0;
        DateTime rentDate;

        public rs_billing_details()
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

        String q1 = "SELECT * FROM rental_bill_details";
        db.sqlQuery(q1);
        DataTable dt = db.executeQuery();
        bunifuCustomDataGrid1.DataSource = dt;
         db.closeConnection();

        for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
        {
            bunifuCustomDataGrid1.Columns[i].Visible = false;
        }
            try
            { 
                bunifuCustomDataGrid1.Columns[0].Visible = true;
                bunifuCustomDataGrid1.Columns[0].HeaderText = "Bill ID";
                bunifuCustomDataGrid1.Columns[1].Visible = true;
                bunifuCustomDataGrid1.Columns[1].HeaderText = "Rent ID";
                bunifuCustomDataGrid1.Columns[2].Visible = true;
                bunifuCustomDataGrid1.Columns[2].HeaderText = "Bill Date";
                bunifuCustomDataGrid1.Columns[3].Visible = true;
                bunifuCustomDataGrid1.Columns[3].HeaderText = "Total Amount";
                bunifuCustomDataGrid1.Columns[4].Visible = true;
                bunifuCustomDataGrid1.Columns[4].HeaderText = "Final Millage";
                bunifuCustomDataGrid1.Columns[5].Visible = true;
                bunifuCustomDataGrid1.Columns[5].HeaderText = "Damage Amount";

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            //get rent id  which not issued a bill, to combo box
            String q3 = "SELECT rnt_id FROM rental_details WHERE rnt_bill_is_issued = 'no'";
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
            cmb_bill_rent_id.DataSource = list;

             db.closeConnection();

            btn_update.Visible = false;
            btn_remove.Visible = false;
            btn_add.Enabled = true;
            crystalReportViewer1.Visible = false;
            btn_back.Visible = false;

            clear();

            txt_bill_id.Text = CodeGenerator.generateRentalBillCode();
            txt_bill_damage_amount.Text = "0";
            lbl_tot_bill.Text = "0";
            lbl_adv_payment.Text = "0";
            lbl_balance.Text = "0";
        }

    

    private void search()
    {

        try
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "select * from rental_bill_details where bill_id like '%" + txt_search.Text + "%' ";

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
            txt_bill_id.Text = string.Empty;
            cmb_bill_rent_id.Text = string.Empty;
            lbl_tot_bill.Text = string.Empty;
            txt_bill_final_millage.Text = string.Empty;
            txt_search.Text = string.Empty;
            datepicker_bill_date.Text = string.Empty;
            txt_bill_damage_amount.Text = string.Empty;
            
        }
        

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.openConnection();

                bool test = Validte_Data();
                if (test == true)
                {

                        string query = "INSERT INTO rental_bill_details VALUES  ( '" + txt_bill_id.Text + "','" + cmb_bill_rent_id.Text + "' ,'" + datepicker_bill_date.Text + "', '" + float.Parse(lbl_tot_bill.Text) + "', '" + Convert.ToInt32(txt_bill_final_millage.Text) + "', '" + float.Parse(txt_bill_damage_amount.Text) + "')";
                        db.sqlQuery(query);
                        db.nonQuery();

                        string query2 = "UPDATE rental_details SET rnt_bill_is_issued = 'yes' Where rnt_id = '" + cmb_bill_rent_id.Text + "'";
                        db.sqlQuery(query2);
                        db.nonQuery();

                         db.closeConnection();

                        loadData();

                        MyDialog.Show("Insert Successful..", "Bill Was Successfully Added");
                    
                    
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

                        string query = "UPDATE rental_bill_details SET bill_rnt_id ='" + cmb_bill_rent_id.Text + "',bill_date ='" + datepicker_bill_date.Text + "', bill_tot_amount ='" + float.Parse(lbl_tot_bill.Text) + "',bill_final_millage ='" + Convert.ToInt32(txt_bill_final_millage.Text) + "',bill_damage_amount ='" + float.Parse(txt_bill_damage_amount.Text) + "' WHERE bill_id = '" + txt_bill_id.Text + "' ";
                        
                        db.sqlQuery(query);
                        db.nonQuery();

                        string query2 = "UPDATE rental_details SET rnt_bill_is_issued = 'yes' Where rnt_id = '" + cmb_bill_rent_id.Text + "'";
                        db.sqlQuery(query2);
                        db.nonQuery();

                         db.closeConnection();

                        loadData();

                        MyDialog.Show("Update Successful..", "Bill Record Successfully Updated");
                    
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

                string query = "DELETE FROM rental_bill_details WHERE bill_id = '" + txt_bill_id.Text+ "' ";


                db.sqlQuery(query);


                if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete the item 
                    db.nonQuery();
                    MessageBox.Show("DELETE");

                    //update bill is issued to 'no'
                    string query2 = "UPDATE rental_details SET rnt_bill_is_issued = 'no' Where rnt_id = '" + cmb_bill_rent_id.Text + "'";
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
            cmb_bill_rent_id.DataSource = list;

           

            txt_bill_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            cmb_bill_rent_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            datepicker_bill_date.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            lbl_tot_bill.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            txt_bill_final_millage.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            txt_bill_damage_amount.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();

            //get advanced payment
            string q1 = "SELECT in_advanced_payment FROM rental_invoice WHERE in_rnt_id = '" + cmb_bill_rent_id.Text + "'";
            db.sqlQuery(q1);

            float advPayment;
            advPayment = float.Parse(db.getDataByScaller());
            lbl_adv_payment.Text = Convert.ToString(advPayment);


            float finalAmount = float.Parse(lbl_tot_bill.Text) - advPayment;
            lbl_balance.Text = Convert.ToString(finalAmount);

             db.closeConnection();

            btn_update.Visible = true;
            btn_remove.Visible = true;
            btn_add.Enabled = false;

        }

        private void cmb_bill_rent_id_DropDown(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //get rent id  which not issued a bill, to combo box
            String q3 = "SELECT rnt_id FROM rental_details WHERE rnt_bill_is_issued = 'no'";
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
            cmb_bill_rent_id.DataSource = list;

             db.closeConnection();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }
        
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            calculations();

        }
        private void rs_billing_details_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private bool Validte_Data()
        {
            Regex validate_number = new Regex("[0-9]+$");
            Regex validate_float = new Regex("^[0-9]+(\\.[0-9][0-9]?)?$");


            if (!validate_number.IsMatch(txt_bill_final_millage.Text))
            {
                MyDialog.Show("Error...!", "Invalid Final Millage");
            }
            else
            {
                if (!validate_float.IsMatch(txt_bill_damage_amount.Text))
                {
                    MyDialog.Show("Error...!", "Invalid Damage Amount");
                }
                else
                {
                    if (!validate_float.IsMatch(lbl_tot_bill.Text))
                    {
                        MyDialog.Show("Error...!", "Invalid Total Amount");
                    }
                    else
                    {
                        return true;
                    }

                    return false;
                }
                return false;
            }
            return false;
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            btn_back.Visible = true;
            crystalReportViewer1.Visible = true;
            
            calculations();
            
            Database db = new Database();
            db.openConnection();

            string query = " select cus.c_code as 'c_code', CONCAT(cus.fname+' ',cus.lname) as 'FullName',cus.nic as 'nic',cus.mobile as 'mobile', concat(cus.address_1+',',cus.address_2+',', cus.city) as 'address' , rv.rv_id as 'rv_id', concat(rv.rv_brand+' / ',rv.rv_model) as 'brnd/model' , rv.rv_millage as 'millage', rv.rv_number as 'number', rv.rv_km_per_day as 'kmperday', rv.rv_rate_per_day as 'rateperday', rv.rv_exceed_rate as 'exeedRate', rv.rv_minimum_diposit as 'minDeposit', rb.bill_id as 'billID', rb.bill_date as 'billDate', rd.rnt_date as 'RentDate' , rb.bill_final_millage as 'finalMillage', rb.bill_damage_amount as 'damageAmount',  rb.bill_tot_amount as 'TotalBill', ri.in_advanced_payment as 'advPayment' from customers cus, rental_bill_details rb, rental_details rd, rental_invoice ri, rental_vehicle rv where cus.c_code = rd.rnt_cus_id AND rb.bill_rnt_id = rd.rnt_id AND ri.in_rnt_id = rd.rnt_id  and rd.rnt_id ='" + cmb_bill_rent_id.Text + "'";

            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(query, db.getConnection());

            cmd.ExecuteNonQuery();
            rpt_ds_bill ds = new rpt_ds_bill();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "bill");

            rpt_bill myreport = new rpt_bill();
            myreport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myreport;


            myreport.SetParameterValue("pNoofDays", noOfDates);
            myreport.SetParameterValue("pExtraCharges", extraCharges);
            myreport.SetParameterValue("pMaxKm", maxKm);
            myreport.SetParameterValue("PtotKm", totalKm);
            myreport.SetParameterValue("PexeedKm", exeedKms);
            myreport.SetParameterValue("PchargeRentDates", chargeforRentDates);
            myreport.SetParameterValue("PrentDate", rentDate);
            myreport.SetParameterValue("pBalance", finalAmount);
            
             db.closeConnection();
            

        }
        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = false;
            btn_back.Visible = false;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //update the vehicle millage
            string query2 = "UPDATE rental_vehicle SET rv_millage ='" + Convert.ToInt32(txt_bill_final_millage.Text) + "' Where rv_id = (select rnt_vehicle_id from rental_details where rnt_id = '" + cmb_bill_rent_id.Text + "')";
            db.sqlQuery(query2);
            db.nonQuery();

            //update vehicle status to Available
            string query3 = "UPDATE rental_vehicle SET rv_status = 'Available' Where rv_id =(select rnt_vehicle_id from rental_details where rnt_id = '" + cmb_bill_rent_id.Text + "') ";
            db.sqlQuery(query3);
            db.nonQuery();

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
                    string q1 = "SELECT in_advanced_payment FROM rental_invoice WHERE in_rnt_id = '" + cmb_bill_rent_id.Text + "'";
                    db.sqlQuery(q1);

                    float advPayment;
                    advPayment = float.Parse(db.getDataByScaller());

                    //get current millage
                    string q2 = "SELECT rnt_current_millage FROM  rental_details WHERE rnt_id = '" + cmb_bill_rent_id.Text + "'";
                    db.sqlQuery(q2);

                    int currentMillage;
                    currentMillage = Convert.ToInt32(db.getDataByScaller());

                    //get Final millage
                    int finalMillage = Convert.ToInt32(txt_bill_final_millage.Text);

                    //get rent date
                    string q3 = "SELECT rnt_date FROM  rental_details WHERE rnt_id= '" + cmb_bill_rent_id.Text + "'";
                    db.sqlQuery(q3);

                    rentDate = Convert.ToDateTime(db.getDataByScaller());

                    //get actual return date (expected date)
                    string q4 = "SELECT rnt_return_date FROM  rental_details WHERE rnt_id= '" + cmb_bill_rent_id.Text + "'";
                    db.sqlQuery(q4);

                    DateTime actualReturnDate;
                    actualReturnDate = Convert.ToDateTime(db.getDataByScaller());

                    //get bill date / return date
                    DateTime returndate = datepicker_bill_date.Value;

                    //get rental vehicle details
                    String q5 = "SELECT rv_km_per_day, rv_exceed_rate, rv_rate_per_day FROM rental_vehicle WHERE rv_id = (SELECT rnt_vehicle_id FROM rental_details WHERE rnt_id= '" + cmb_bill_rent_id.Text + "' ) ";
                    db.sqlQuery(q5);
                    DataTable dt = db.executeQuery();

                    int kmPerDay = Convert.ToInt32(dt.Rows[0][0]);
                    float exeedRate = float.Parse(dt.Rows[0][1].ToString());
                    float ratePerDate = float.Parse(dt.Rows[0][2].ToString());

                    //get damage / extra charge
                    float damageAmmount = float.Parse(txt_bill_damage_amount.Text);

                    //get num of days rent the vehicle
                    noOfDates = Convert.ToInt32((returndate - rentDate).TotalDays) + 1;

                    //calculate max km per rent period
                    maxKm = kmPerDay * noOfDates;

                    //calculate total km travelld
                    totalKm = Convert.ToInt32(txt_bill_final_millage.Text) - currentMillage;

                    //calculate exeed km's
                    exeedKms = totalKm - maxKm;


                    //calculate total bill



                    if (maxKm < totalKm)
                    {
                        extraCharges = exeedKms * exeedRate;
                    }

                    else if (maxKm >= totalKm)
                    {
                        extraCharges = 0;
                        exeedKms = 0;
                    }

                    chargeforRentDates = (noOfDates * ratePerDate);

                    totalBill = chargeforRentDates + extraCharges + damageAmmount;


                    finalAmount = totalBill - advPayment;

                    db.closeConnection();

                    lbl_tot_bill.Text = Convert.ToString(totalBill);
                    lbl_adv_payment.Text = Convert.ToString(advPayment);
                    lbl_balance.Text = Convert.ToString(finalAmount);


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }



        }

    }

    

}
                    