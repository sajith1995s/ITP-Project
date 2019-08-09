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
    public partial class customer_manage_sub : UserControl
    {
        public customer_manage_sub()
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
            db.getConnection().Close();



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
            txt_cus_id.Text = CodeGenerator.generateCustomerID();

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
                db.getConnection().Close();

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
                MyDialog.Show("First Name Is Not Correct", "Please enter a correct name");
            }
            else
            {
                if (!validate_alphabatic.IsMatch(txt_cus_lname.Text))
                {
                    MyDialog.Show("Last Name Is Not Correct", "Please enter a correct name");
                }
                else
                {
                    if (!validate_nic.IsMatch(txt_cus_NIC.Text))
                    {
                        MyDialog.Show("NIC Is Not Correct", "Please enter a correct NIC number ");
                    }
                    else
                    {
                        if (!validate_phone_num.IsMatch(txt_cus_mobile.Text))
                        {
                            MyDialog.Show("Mobile number Is Not Correct", "Please enter a correct Mobile number");
                        }
                        else
                        {
                            if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L1.Text))
                            {
                                MyDialog.Show("Address Line 1 is Not correct","Please enter a correct address");
                            }
                            else
                            {
                                if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L2.Text))
                                {
                                    MyDialog.Show("Address Line 2 is Not correct", "Please enter a correct address");
                                }
                                else
                                {
                                    if (!Validate_alpha_numaric.IsMatch(txt_cus_city.Text))
                                    {
                                        MyDialog.Show("City is Not correct", "Please enter a correct city name");
                                    }
                                    else
                                    {
                                        if (!validate_email.IsMatch(txt_cus_email.Text))
                                        {
                                            MyDialog.Show("Email is invalid", "Please enter a correct email address");
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
        private void txt_cus_id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void customer_manage_sub_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           

                try
                {
                Database db = new Database();
                db.openConnection();

                bool test = Validte_Data();
                    if (test == true)
                    {
                        String cusId = CodeGenerator.generateCustomerID();
                        string query = "INSERT INTO customers VALUES  ('" + cusId + "','" + txt_cus_fname.Text + "', '" + txt_cus_lname.Text + "', '" + txt_cus_NIC.Text + "', '" + txt_cus_mobile.Text + "', '" + txt_cus_addrees_L1.Text + "','" + txt_cus_addrees_L2.Text + "','" + txt_cus_city.Text + "','" + txt_cus_email.Text + "')";

                        db.sqlQuery(query);
                        db.nonQuery();

                        loadData();
                    }
                    db.getConnection().Close();

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

                string query = "UPDATE customers SET fname ='" + txt_cus_fname.Text + "', lname ='" + txt_cus_lname.Text + "',NIC ='" + txt_cus_NIC.Text + "',Mobile ='" + txt_cus_mobile.Text + "',address_1 ='" + txt_cus_addrees_L1.Text + "',address_2 ='" + txt_cus_addrees_L2.Text + "',city ='" + txt_cus_city.Text + "',email ='" + txt_cus_email.Text + "' WHERE c_code = '" + txt_cus_id.Text + "' ";
                db.sqlQuery(query);
                db.nonQuery();
                loadData();
                db.getConnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private bool Validate_Data()
        {
            Regex validate_email = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            Regex Validate_alpha_numaric = new Regex("^[0-9a-zA-Z #,-]+$");
            Regex validate_phone_num = new Regex("^[0-9]{10}$");
            Regex validate_nic = new Regex("^[0-9]{9}[V,v]$");
            Regex validate_alphabatic = new Regex("^[a-zA-Z]+$");

            if (!validate_alphabatic.IsMatch(txt_cus_fname.Text))
            {
                MyDialog.Show("First Name Is Not Correct", "Please Enter a valid name");
            }
            else
            {
                if (!validate_alphabatic.IsMatch(txt_cus_lname.Text))
                {
                    MyDialog.Show("Last Name Is Not Correct", "Please Enter a valid name");
                }
                else
                {
                    if (!validate_nic.IsMatch(txt_cus_NIC.Text))
                    {
                        MyDialog.Show("NIC is Not Correct", "Please Enter a valid NIC number");
                    }
                    else
                    {
                        if (!validate_phone_num.IsMatch(txt_cus_mobile.Text))
                        {
                            MyDialog.Show("Mobile Number Is Not Valid", "Please Enter a mobile number");
                        }
                        else
                        {
                            if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L1.Text))
                            {
                                MyDialog.Show("Address Line 1 is Not correct", "Please Enter a valid address");
                            }
                            else
                            {
                                if (!Validate_alpha_numaric.IsMatch(txt_cus_addrees_L2.Text))
                                {
                                    MyDialog.Show("Address Line 2 is Not correct","Please Enter a valid address");
                                }
                                else
                                {
                                    if (!Validate_alpha_numaric.IsMatch(txt_cus_city.Text))
                                    {
                                        MyDialog.Show("City is Not correct","Please Enter a valid City");
                                    }
                                    else
                                    {
                                        if (!validate_email.IsMatch(txt_cus_email.Text))
                                        {
                                            MyDialog.Show("E-mail is Not Valid","Please Enter a valid E-mai address");
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String id = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM customers WHERE c_code = '" + id + "'";
                Database db = new Database();
                db.openConnection();

                db.sqlQuery(query);
                db.nonQuery();
                db.getConnection().Close();
                loadData();
                clear();
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

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
