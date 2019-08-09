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
    public partial class rs_Manage_Customers_sub_manage_cus : UserControl
    {
        public rs_Manage_Customers_sub_manage_cus()
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

            String q1 = "SELECT * FROM customers";
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
            bunifuCustomDataGrid1.Columns[1].HeaderText = "First Name";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Last Name";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "NIC";
            bunifuCustomDataGrid1.Columns[7].Visible = true;
            bunifuCustomDataGrid1.Columns[7].HeaderText = "City";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "Mobile";

            btn_update.Visible = false;
            btn_remove.Visible = false;
            btn_add.Enabled = true;

            
            clear();
            txt_cus_id.Text = CodeGenerator.generateCustomerCode();

        }



        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select* from customers where fname like '%" + txt_search.Text + "%'";
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
            txt_cus_id.Text = string.Empty;
            txt_cus_fname.Text = string.Empty;
            txt_cus_lname.Text = string.Empty;
            txt_cus_NIC.Text = string.Empty;
            txt_cus_mobile.Text = string.Empty;
            txt_cus_addrees_L1.Text = string.Empty;
            txt_cus_addrees_L2.Text = string.Empty;
            txt_cus_city.Text = string.Empty;
            txt_cus_email.Text = string.Empty;
            txt_search.Text = string.Empty;
            

        }
        

        private void bunifuCustomDataGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_cus_id.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            txt_cus_fname.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            txt_cus_lname.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            txt_cus_NIC.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();
            txt_cus_mobile.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();
            txt_cus_addrees_L1.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            txt_cus_addrees_L2.Text = bunifuCustomDataGrid1.CurrentRow.Cells[6].Value.ToString();
            txt_cus_city.Text = bunifuCustomDataGrid1.CurrentRow.Cells[7].Value.ToString();
            txt_cus_email.Text = bunifuCustomDataGrid1.CurrentRow.Cells[8].Value.ToString();
            
            btn_update.Visible = true;
            btn_remove.Visible = true;
            btn_add.Enabled = false;

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {

            Database db = new Database();
            db.openConnection();

            try
            {

                bool test = Validte_Data();
                if (test == true)
                {
                    string query = "INSERT INTO customers VALUES  ( '" + txt_cus_id.Text + "','" + txt_cus_fname.Text + "', '" + txt_cus_lname.Text + "', '" + txt_cus_NIC.Text + "', '" + txt_cus_mobile.Text + "', '" + txt_cus_addrees_L1.Text + "','" + txt_cus_addrees_L2.Text + "','" + txt_cus_city.Text + "','" + txt_cus_email.Text + "')";
                    db.sqlQuery(query);
                    db.nonQuery();
                    loadData();

                    MyDialog.Show("Insert Successful..", "Customer Was Successfully Added");
                }

                 db.closeConnection();

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            
            
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.openConnection();

                bool test = Validte_Data();
                if (test == true)
                {
                    string query = "UPDATE customers SET fname ='" + txt_cus_fname.Text + "', lname ='" + txt_cus_lname.Text + "',NIC ='" + txt_cus_NIC.Text + "',Mobile ='" + txt_cus_mobile.Text + "',address_1 ='" + txt_cus_addrees_L1.Text + "',address_2 ='" + txt_cus_addrees_L2.Text + "',city ='" + txt_cus_city.Text + "',email ='" + txt_cus_email.Text + "' WHERE c_code = '" + txt_cus_id.Text + "' ";

                    db.sqlQuery(query);
                    db.nonQuery();

                    loadData();

                    MyDialog.Show("Update Successful..", "Customer Record Successfully Updated");
                }
                
                 db.closeConnection();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            
            
        }

       private bool Validte_Data()
        {
            Regex validate_email = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            Regex Validate_alpha_numaric = new Regex("^[0-9a-zA-Z #,-]+$");
            Regex validate_phone_num = new Regex("^[0-9]{10}$");
            Regex validate_nic = new Regex("^[0-9]{9}[V,v]$");
            Regex validate_alphabatic = new Regex("^[a-zA-Z]+$");

            if (!validate_alphabatic.IsMatch(txt_cus_fname.Text))
            {
                MyDialog.Show("Error...!", "Invalid First Name");
            }
            else
            {
                if (!validate_alphabatic.IsMatch(txt_cus_lname.Text))
                {
                    MyDialog.Show("Error...!", "Invalid Last Name");
                }
                else
                {
                    if (!validate_nic.IsMatch(txt_cus_NIC.Text))
                    {
                        MyDialog.Show("Error...!", "Invalid NIC Number");
                    }
                    else
                    {
                        if (!validate_phone_num.IsMatch(txt_cus_mobile.Text))
                        {
                            MyDialog.Show("Error...!", "Invalid Mobile Number");
                        }
                        else
                        {
                            if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L1.Text))
                            {
                                MyDialog.Show("Error...!", "Invalid Address Line 1");
                            }
                            else
                            {
                                if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L2.Text))
                                {
                                    MyDialog.Show("Error...!", "Invalid Address Line 2");
                                }
                                else
                                {
                                    if (!Validate_alpha_numaric.IsMatch(txt_cus_city.Text))
                                    {
                                        MyDialog.Show("Error...!", "Invalid City");
                                    }
                                    else
                                    {
                                        if (!validate_email.IsMatch(txt_cus_email.Text))
                                        {
                                            MyDialog.Show("Error...!", "Invalid Email Address");
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
        
        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.openConnection();

                string query = "DELETE FROM customers WHERE c_code = '" + txt_cus_id.Text + "' ";
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }
        
    }
}
