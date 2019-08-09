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
    public partial class rs_Rental_Vehicle_sub_manageVehicle : UserControl
    {
        public rs_Rental_Vehicle_sub_manageVehicle()
        {
            InitializeComponent();
            loadData();

            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            

        }

        public  void loadData()
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "SELECT * FROM rental_vehicle";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;

             db.closeConnection();

            for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Visible = false;
            }

            bunifuCustomDataGrid1.Columns[0].Visible = true;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "ID";
            bunifuCustomDataGrid1.Columns[1].Visible = true;
            bunifuCustomDataGrid1.Columns[1].HeaderText = "Brand";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Model";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "Year";
            bunifuCustomDataGrid1.Columns[6].Visible = true;
            bunifuCustomDataGrid1.Columns[6].HeaderText = "Status";
            bunifuCustomDataGrid1.Columns[9].Visible = true;
            bunifuCustomDataGrid1.Columns[9].HeaderText = "Number";
            bunifuCustomDataGrid1.Columns[11].Visible = true;
            bunifuCustomDataGrid1.Columns[11].HeaderText = "Catagory";

            cmb_status.SelectedIndex = 3;
            cmb_catagory.SelectedIndex = 4;
            cmb_fual_type.SelectedIndex = 2;

            btn_update.Visible = false;
            btn_remove.Visible = false;
            btn_add.Enabled = true;

           
            clear();
            txt_v_id.Text = CodeGenerator.generateRentalVehicleCode();


        }


        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select* from rental_vehicle where rv_brand like '%" + txt_serch.Text + "%'";
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
            txt_v_id.Text = string.Empty;
            txt_v_brand.Text = string.Empty;
            txt_v_model.Text = string.Empty;
            txt_v_year.Text = string.Empty;
            cmb_fual_type.Text = string.Empty;
            txt_v_milage.Text = string.Empty;
            cmb_status.Text = string.Empty;
            txt_v_km_per_day.Text = string.Empty;
            txt_v_rate_per_day.Text = string.Empty;
            txt_serch.Text = string.Empty;
            cmb_catagory.Text = string.Empty;
            txt_v_number.Text = string.Empty;
            txt_v_min_deposit.Text = string.Empty;
            txt_v_exceed_rate.Text = string.Empty;
            
        }
        

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_v_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            txt_v_brand.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            txt_v_model.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            txt_v_year.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            cmb_fual_type.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            txt_v_milage.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            cmb_status.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
            txt_v_km_per_day.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
            txt_v_rate_per_day.Text = bunifuCustomDataGrid1.CurrentRow.Cells[8].Value.ToString();
            txt_v_number.Text = bunifuCustomDataGrid1.CurrentRow.Cells[9].Value.ToString();
            txt_v_exceed_rate.Text = bunifuCustomDataGrid1.CurrentRow.Cells[10].Value.ToString();
            cmb_catagory.Text = bunifuCustomDataGrid1.CurrentRow.Cells[11].Value.ToString();
            txt_v_min_deposit.Text = bunifuCustomDataGrid1.CurrentRow.Cells[12].Value.ToString();


            btn_update.Visible = true;
            btn_remove.Visible = true;
            btn_add.Enabled = false;
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                bool test = Validte_Data();
                if (test == true)
                {
                    Database db = new Database();
                    db.openConnection();

                    string query = "INSERT INTO rental_vehicle VALUES  ('" + txt_v_id.Text + "', '" + txt_v_brand.Text + "', '" + txt_v_model.Text + "', '" + Convert.ToInt32(txt_v_year.Text) + "', '" + cmb_fual_type.Text + "', '" + Convert.ToInt32(txt_v_milage.Text) + "','" + cmb_status.Text + "','" + Convert.ToInt32(txt_v_km_per_day.Text) + "','" + Convert.ToDecimal(txt_v_rate_per_day.Text) + "','" + txt_v_number.Text + "','" + Convert.ToDecimal(txt_v_exceed_rate.Text) + "', '" + cmb_catagory.Text + "','" + txt_v_min_deposit.Text + "'  )";
                    db.sqlQuery(query);
                    db.nonQuery();

                     db.closeConnection();

                    loadData();

                    MyDialog.Show("Insert Successful..", "Rental Vehicle Was Successfully Added");
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
                Database db = new Database();
                db.openConnection();

                bool test = Validte_Data();
                if (test == true)
                {
                    string query = "UPDATE rental_vehicle SET rv_brand ='" + txt_v_brand.Text + "', rv_model ='" + txt_v_model.Text + "',rv_year ='" + txt_v_year.Text + "',rv_fual_type ='" + cmb_fual_type.Text + "',rv_millage ='" + txt_v_milage.Text + "',rv_status ='" + cmb_status.Text + "',rv_km_per_day ='" + txt_v_km_per_day.Text + "',rv_rate_per_day ='" + txt_v_rate_per_day.Text + "', rv_number ='" + txt_v_number.Text + "',rv_exceed_rate ='" + txt_v_exceed_rate.Text + "',rv_category ='" + cmb_catagory.Text + "',rv_minimum_diposit ='" + txt_v_min_deposit.Text + "' WHERE rv_id = '" + txt_v_id.Text + "' ";
                    db.sqlQuery(query);
                    db.nonQuery();

                     db.closeConnection();

                    loadData();
                    
                    MyDialog.Show("Update Successful..", "Rental Vehicle Record Successfully Updated");
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

                string query = "DELETE FROM rental_vehicle WHERE rv_id = '" + txt_v_id.Text + "' ";
                db.sqlQuery(query);

                if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //delete the item 
                    db.nonQuery();
                    MessageBox.Show("DELETE");
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
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_serch_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }
        

        private void rs_Rental_Vehicle_sub_manageVehicle_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }
        private bool Validte_Data()
        {
            Regex Validate_alpha_numaric = new Regex("^[0-9a-zA-Z #,-]+$");
            Regex validate_alphabatic = new Regex("^[a-zA-Z]+$");
            Regex validate_year = new Regex("^(19|20)[0-9][0-9]$");
            Regex validate_number = new Regex("[0-9]+$"); 
            Regex validate_float = new Regex("^[0-9]+(\\.[0-9][0-9]?)?$");
            Regex validate_vehicle_no = new Regex("^[A-Z]{2,3}-[0-9]{4}$");
            
            if (!validate_alphabatic.IsMatch(txt_v_brand.Text))
            {
                MyDialog.Show("Error...!", "Invalid Vehicle Brand");
            }
            else
            {
                if (!Validate_alpha_numaric.IsMatch(txt_v_model.Text))
                {
                    MyDialog.Show("Error...!", "Invalid Vehicle Model");
                }
                else
                {
                    if (!validate_year.IsMatch(txt_v_year.Text))
                    {
                        MyDialog.Show("Error...!", "Invalid Year");
                    }
                    else
                    {
                        if (cmb_fual_type.Text == "Select The Fual Type")
                        {
                            MyDialog.Show("Error...!", "Invalid Selected Type");
                        }
                        else
                        {
                            if (!validate_number.IsMatch(txt_v_milage.Text))
                            {
                                MyDialog.Show("Error...!", "Invalid Millage");
                            }
                            else
                            {
                                if (cmb_status.Text== "Select The Status")
                                {
                                    MyDialog.Show("Error...!", "Invalid Selected Status");
                                }
                                else {
                                    if (!validate_number.IsMatch(txt_v_km_per_day.Text))
                                    {
                                        MyDialog.Show("Error...!", "Invalid KM Per Day");
                                    }
                                    else
                                    {
                                        if (!validate_float.IsMatch(txt_v_rate_per_day.Text))
                                        {
                                            MyDialog.Show("Error...!", "Invalid Rate Per Day");
                                        }
                                        else
                                        {
                                            if (!validate_float.IsMatch(txt_v_exceed_rate.Text))
                                            {
                                                MyDialog.Show("Error...!", "Invalid Exceed Rate");
                                            }
                                            else
                                            {
                                                if (cmb_catagory.Text== "Select The Category")
                                                {
                                                    MyDialog.Show("Error...!", "Invalid Selected Catagory");
                                                }
                                                else {
                                                    if (!validate_vehicle_no.IsMatch(txt_v_number.Text))
                                                    {
                                                        MyDialog.Show("Error...!", "Invalid Vehicle Number");
                                                    }
                                                    else
                                                    {
                                                        if (!validate_float.IsMatch(txt_v_min_deposit.Text))
                                                        {
                                                            MyDialog.Show("Error...!", "Invalid Minimum Deposit Amount");
                                                        }
                                                        else
                                                        {
                                                            return true;
                                                        }
                                                    }
                                                    return false;
                                                }
                                                return false;
                                            }
                                            return false;
                                        }
                                        return false;
                                    }
                                    return false;
                                }
                                return false;
                            }
                            return false;
                        }
                        return false;
                    }
                    return false;
                }
                return false;

            }
            return false;

        }

    }
}
