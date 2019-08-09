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

namespace AutoCareSystem
{
    public partial class rs_Rental_Detail_new_sub1_mannage_rental_deti1 : UserControl
    {
        public rs_Rental_Detail_new_sub1_mannage_rental_deti1()
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

            String q1 = "SELECT * FROM rental_details";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;
            

            for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Visible = false;
            }

            bunifuCustomDataGrid1.Columns[0].Visible = true;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "Rent ID";
            bunifuCustomDataGrid1.Columns[1].Visible = true;
            bunifuCustomDataGrid1.Columns[1].HeaderText = "Customer ID";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Vehicle ID";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "Rent Date";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "Return Date";
            bunifuCustomDataGrid1.Columns[5].Visible = true;
            bunifuCustomDataGrid1.Columns[5].HeaderText = "Minimum Deposit";


            //get customer id's to combo box
            String q2 = "SELECT c_code FROM customers";
            db.sqlQuery(q2);
            DataTable table = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list1 = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                list1.Add("Select Customer");
                list1.Add(dr["c_code"].ToString());
            }

            list1 = list1.Distinct().ToList();
            cmb_cus_id.DataSource = list1;



            //get Available Vehicle's to combo box
            String q3 = "SELECT rv_id FROM rental_vehicle WHERE rv_status = 'Available'";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                    list.Add("Select A Vehicle");
                    list.Add(dr["rv_id"].ToString());
            }
            
            list = list.Distinct().ToList();
            cmb_vehicle_id.DataSource = list;
        
             db.closeConnection();

            btn_update.Visible = false;
            btn_remove.Visible = false;
            btn_add.Enabled = true;
            
            clear();
            txt_rnt_id.Text = CodeGenerator.generateRentalDetailsCode();
        }


        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select * from rental_details where rnt_id like '%" + txt_search.Text + "%'";

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
            txt_rnt_id.Text = string.Empty;
            cmb_cus_id.Text = string.Empty;
            cmb_vehicle_id.Text = string.Empty;
            datepicker_rentDate.Text = string.Empty;
            datepicker_returnDate.Text = string.Empty;
            txt_rnt_min_deposit.Text = string.Empty;
            txt_rnt_current_millage.Text = string.Empty;

            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                bool test = Validte_Data();
                if (test == true)
                {

                    if (datepicker_rentDate.Value.Date != DateTime.Today)
                    {
                        MyDialog.Show("Error...!", "Rent Date Date Is Not Valid");
                    }
                    else
                    {

                        if (datepicker_rentDate.Value.Date > datepicker_returnDate.Value.Date)
                        {
                            MyDialog.Show("Error...!", "Return Date Date Is Not Valid");
                        }
                        else
                        {
                            Database db = new Database();
                            db.openConnection();

                            float tot = 0;
                            string issued = "no";

                            string query = "INSERT INTO rental_details VALUES  ( '" + txt_rnt_id.Text + "', '" + cmb_cus_id.Text + "', '" + cmb_vehicle_id.Text + "', '" + datepicker_rentDate.Text + "', '" + datepicker_returnDate.Text + "', '" + float.Parse(txt_rnt_min_deposit.Text) + "','" + Convert.ToInt32(txt_rnt_current_millage.Text) + "','" + tot + "','" + issued + "','" + issued + "')";
                            db.sqlQuery(query);
                            db.nonQuery();


                            string query2 = "UPDATE rental_vehicle SET rv_status = 'Not-Available' Where rv_id = '" + cmb_vehicle_id.Text + "'";
                            db.sqlQuery(query2);
                            db.nonQuery();

                             db.closeConnection();

                            loadData();
                            
                            MyDialog.Show("Insert Successful..", "Rental Detail Was Successfully Added");
                        }
                       
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
                    if (datepicker_rentDate.Value.Date > datepicker_returnDate.Value.Date)
                    {
                        MyDialog.Show("Error...!", "Return Date Date Is Not Valid");
                    }
                    else
                    {
                        float tot1 = 0; // total amount no in the table
                        string issued = "no";

                        Database db = new Database();
                        db.openConnection();

                        string query = "UPDATE rental_details SET rnt_cus_id ='" + cmb_cus_id.Text + "', rnt_vehicle_id ='" + cmb_vehicle_id.Text + "',rnt_date ='" + datepicker_rentDate.Text + "',rnt_return_date ='" + datepicker_returnDate.Text + "',rnt_deposit_amount ='" + float.Parse(txt_rnt_min_deposit.Text) + "',rnt_current_millage ='" + Convert.ToInt32(txt_rnt_current_millage.Text) + "', rnt_amount ='" + tot1 + "',rnt_invoice_is_issued='" + issued + "',rnt_bill_is_issued='" + issued + "' WHERE rnt_id = '" + txt_rnt_id.Text + "' ";
                        db.sqlQuery(query);
                        db.nonQuery();

                        string query2 = "UPDATE rental_vehicle SET rv_status = 'Not-Available' Where rv_id = '" + cmb_vehicle_id.Text + "'";
                        db.sqlQuery(query2);
                        db.nonQuery();

                         db.closeConnection();

                        loadData();

                        MyDialog.Show("Update Successful..", "Rental Detail Record Successfully Updated");
                    }

                    
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

                string query = "DELETE FROM rental_details WHERE rnt_id = '" + txt_rnt_id.Text + "' ";
                db.sqlQuery(query);

                if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete the item 
                    db.nonQuery();
                    MessageBox.Show("DELETE");

                    //update vehicle status to Available
                    string query2 = "UPDATE rental_vehicle SET rv_status = 'Available' Where rv_id = '" + cmb_vehicle_id.Text + "'";
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

        private void cmb_vehicle_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            string type = cmb_vehicle_id.Text;

           switch (type)
            {
                case "Select A Vehicle":
                    break;

                default:
                    {
                        try
                        {
                            

                            //get minimum diposit vluve
                            string q2 = "SELECT rv_minimum_diposit FROM rental_vehicle WHERE rv_id = '" + cmb_vehicle_id.Text + "'";
                            db.sqlQuery(q2);

                            float minDiposit;
                            minDiposit = float.Parse(db.getDataByScaller());

                            txt_rnt_min_deposit.Text = minDiposit.ToString();

                            // get current millage from the vehicle table
                            string q1 = "SELECT rv_millage FROM rental_vehicle WHERE rv_id = '" +cmb_vehicle_id.Text + "'";
                            db.sqlQuery(q1);

                            int millage;
                            millage = Convert.ToInt32(db.getDataByScaller());

                            txt_rnt_current_millage.Text = millage.ToString();

                             db.closeConnection();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(Convert.ToString(ex));
                        }

                    }
                    break;
            }
            
        }

        private bool Validte_Data()
        {
            Regex validate_float = new Regex("^[0-9]+(\\.[0-9][0-9]?)?$");


            if (cmb_cus_id.Text == "Select Customer")
            {
                MyDialog.Show("Error...!", "Invalid Selected Customer ID");
            }
            else
            {
                if (cmb_vehicle_id.Text == "Select A Vehicle")
                {
                    MyDialog.Show("Error...!", "Invalid Selected Rental Vehicle ID");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
         

        private void rs_Rental_Detail_new_sub2_mannage_rental_deti_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        } 

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //get all Vehicle's ID's to combo box
            String q3 = "SELECT rv_id FROM rental_vehicle ";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                list.Add("Select A Vehicle");
                list.Add(dr["rv_id"].ToString());
            }

            list = list.Distinct().ToList();
            cmb_vehicle_id.DataSource = list;

            txt_rnt_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            cmb_cus_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            cmb_vehicle_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            datepicker_rentDate.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            datepicker_returnDate.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            txt_rnt_min_deposit.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            txt_rnt_current_millage.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();

             db.closeConnection();

            btn_update.Visible = true;
            btn_remove.Visible = true;
            btn_add.Enabled = false;
        }

        private void cmb_vehicle_id_DropDown(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            //get Available Vehicle's to combo box
            String q3 = "SELECT rv_id FROM rental_vehicle WHERE rv_status = 'Available'";
            db.sqlQuery(q3);
            DataTable table1 = db.executeQuery();

            // select distinct valuves to the combo box
            IList<string> list = new List<string>();
            foreach (DataRow dr in table1.Rows)
            {

                list.Add("Select A Vehicle");
                list.Add(dr["rv_id"].ToString());
            }

             db.closeConnection();

            list = list.Distinct().ToList();
            cmb_vehicle_id.DataSource = list;
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        } 
    }
}
