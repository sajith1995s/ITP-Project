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
using System.IO;
using System.Text.RegularExpressions;

namespace AutoCareSystem
{
    public partial class Employee_details : UserControl
    {
        public Employee_details()
        {
            InitializeComponent();
            EmployeeGridView();
        }


        private bool Validte_Data()
        {
            Regex validate_email = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            Regex Validate_alpha_numaric = new Regex("^[0-9a-zA-Z #,-]+$");
            Regex validate_phone_num = new Regex("^[0-9]{10}$");
            Regex validate_nic = new Regex("^[0-9]{9}[V,v]$");
            Regex validate_alphabatic = new Regex("^[a-zA-Z]+$");
         

            if (!validate_alphabatic.IsMatch(txtFname.Text))
            {
                MyDialog.Show("Error...!", "First Name Is Not Correct");
            }
            else
            {
                if (!validate_alphabatic.IsMatch(txtLame.Text))
                {
                    MyDialog.Show("Error...!", "Last Name Is Not Correct");

                }
                else
                {
                    if (!validate_nic.IsMatch(txtNIC.Text))
                    {
                        MyDialog.Show("Error...!", "NIC is Not Correct");

                    }
                    else
                    {
                        if (!validate_phone_num.IsMatch(txtTelephone.Text))
                        {
                            MyDialog.Show("Error...!", "Mobile Number Is Not Valid");

                        }
                        else
                        {
                            if (!Validate_alpha_numaric.IsMatch(txtAddressLine1.Text))
                            {
                                MyDialog.Show("Error...!", "Address Line 1 is Not correct");

                            }
                            else
                            {
                                if (!Validate_alpha_numaric.IsMatch(txtAddressline2.Text))
                                {
                                    MyDialog.Show("Error...!", "Address Line 2 is Not correct");

                                }
                                else
                                {
                                    if (!Validate_alpha_numaric.IsMatch(txtCity.Text))
                                    {
                                        MyDialog.Show("Error...!", "City is Not correct");
                                    }
                                    else
                                    {
                                        if ((!rbMale.Checked) && (!rbFemale.Checked))
                                        {
                                            MyDialog.Show("Error...!", "Gender selecction is Not correct");
                                        }
                                        else
                                        {
                                            
                                                if (cmbPosition.SelectedIndex == -1)
                                                {
                                                    MyDialog.Show("Error...!", "Position selection Not correct");
                                                }
                                                else
                                                {
                                                    return true;
                                                }
                                            
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
        private void EmployeeGridView()
        {
            try
            {
                Database db = new Database();
                db.openConnection();
                string query = "select e_code AS 'Employee ID',fname AS 'FirstName',nic AS 'NIC',gender AS 'Gender',tel_phone AS 'Telephone' from employee";

                db.getConnection();
                SqlConnection conn = db.getConnection();
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                DataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridEmployee.DataSource = bsource;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }


        private void EmployeeGridViewBySearch(String Searchkey)
        {
            try
            {
                Database db = new Database();
                db.openConnection();
                string query = "select e_code AS 'Employee ID',fname AS 'FirstName',nic AS 'NIC',gender AS 'Gender',tel_phone AS 'Telephone' from employee WHERE fname like '%" + Searchkey + "%'";

                db.getConnection();
                SqlConnection conn = db.getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                DataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridEmployee.DataSource = bsource;
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }



        private void resetFields()
        {
            txtEmpID.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtLame.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtsearch.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtAddressLine1.Text = string.Empty;
            txtAddressline2.Text = string.Empty;
            txtCardid.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtORate.Text = string.Empty;
            txtRate.Text = string.Empty;
          
            rbFemale.Checked = false;
            rbMale.Checked = false;
            cmbPosition.SelectedIndex= 0;
            dpBirthday.Text = string.Empty;
            EmployeeGridView();



        }


        public Decimal get_employee_work_hours_and_rate(string EmpID, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee_work_hours_and_rate WHERE emp_id ='" + EmpID + "'";
                Database db = new Database();
                db.openConnection();
                db.getConnection();
                db.sqlQuery(query);
                decimal NeedDECIMAL = Convert.ToDecimal(db.executeQuery(clm_name));
                db.getConnection().Close();
                return NeedDECIMAL;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }



        public  String getNeedeStringvalues(String EmployeeId, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee WHERE e_code='" + EmployeeId + "'";
                Database db = new Database();
                
                db.openConnection();
                db.getConnection();
                db.sqlQuery(query);
                String NeedString = db.executeQuery(clm_name);
                db.getConnection().Close();
                return NeedString;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       
        public int getNeedINTvalues(String EmployeeId, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee WHERE e_code='" + EmployeeId + "' ";
                Database db = new Database();
                db.openConnection();
                db.getConnection();
                db.sqlQuery(query);
                int NeedINT = Convert.ToInt32(db.executeQuery(clm_name));
                db.getConnection().Close();
                return NeedINT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }



        void update_employee_work_hours_and_rate(string Eid, decimal rate_per_hour,decimal rate_per_ot_hour)
        {

            string query = "UPDATE employee_work_hours_and_rate SET rate_per_hour='" + rate_per_hour + "',rate_per_ot_hour='"+ rate_per_ot_hour + "'  WHERE emp_id = '" + Eid + "'";
            Database db = new Database();
            db.openConnection();
            db.getConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.getConnection().Close();
           





        }












        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_details_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.openConnection();
                string query = "select *from Employee";
                db.getConnection();


                SqlConnection conn = db.getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
            
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            EmployeeGridViewBySearch(txtsearch.Text);
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            EmployeeGridViewBySearch(txtsearch.Text);
        }

        private void DataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = DataGridEmployee.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DataGridEmployee.Rows[selectedrowindex];

            string EmpID = Convert.ToString(selectedRow.Cells[0].Value);
            txtEmpID.Text = EmpID;
            txtFname.Text = Convert.ToString(selectedRow.Cells[1].Value);
                txtNIC.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtTelephone.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtLame.Text = getNeedeStringvalues(EmpID, "lname");
            txtAddressLine1.Text = getNeedeStringvalues(EmpID, "add_line_01");
            txtAddressline2.Text = getNeedeStringvalues(EmpID, "add_line_02");
            txtCardid.Text= Convert.ToString( getNeedINTvalues(EmpID, "card_id"));
            txtCity.Text = getNeedeStringvalues(EmpID, "city");
          

            dpBirthday.Value = DateTime.Parse(getNeedeStringvalues(EmpID, "b_date"));

            int index = cmbPosition.FindString(getNeedeStringvalues(EmpID, "position"));
            cmbPosition.SelectedIndex = index;

            if (Convert.ToString(selectedRow.Cells[3].Value)=="Male")
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
            }
            else if (Convert.ToString(selectedRow.Cells[3].Value) == "Female")
            {

                rbFemale.Checked = true;
                rbMale.Checked = false;
            }

            decimal rate_per_hour = get_employee_work_hours_and_rate(EmpID, "rate_per_hour");

            txtRate.Text = Convert.ToString(rate_per_hour);

            decimal rate_per_othour = get_employee_work_hours_and_rate(EmpID, "rate_per_ot_hour");
           txtORate.Text = Convert.ToString(rate_per_othour);





        }

        private void btnRepairRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = DataGridEmployee.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DataGridEmployee.Rows[selectedrowindex];

            String Eid = Convert.ToString(selectedRow.Cells[0].Value);
          
        
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {



                string query = "DELETE FROM employee WHERE e_code = '" + Eid + "' ";
                Database db = new Database();
                db.openConnection();
                db.getConnection();
                db.sqlQuery(query);    //pass query to sql query method
                db.nonQuery();          //pass the cmd to nonQuery method(for Insert)
                db.getConnection().Close();
                EmployeeGridView();  //reload table
                resetFields();   //clear all fileds
            }

        }

        private void btnRepairClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnRepairUpdate_Click(object sender, EventArgs e)
        {

            bool test = Validte_Data();
            if (test == true)
            {

                int selectedrowindex = DataGridEmployee.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DataGridEmployee.Rows[selectedrowindex];


                String EID = Convert.ToString(selectedRow.Cells[0].Value);

                string gender = "";
                if (rbMale.Checked)
                {
                    gender = "Male";


                }
                else if (rbFemale.Checked)
                {

                    gender = "Female";


                }


                Database db = new Database();
                db.openConnection();
                SqlConnection conn = db.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                string query = "UPDATE employee SET fname = '" + txtFname.Text + "', lname= '" + txtLame.Text + "',b_date = '" + dpBirthday.Text + "',gender = '" + gender + "',add_line_01 = '" + txtAddressLine1.Text + "',add_line_02 = '" + txtAddressline2.Text + "',city = '" + txtCity.Text + "',nic = '" + txtNIC.Text + "',tel_phone = '" + txtTelephone.Text + "',position = '" + cmbPosition.Text + "',card_id = '" + txtCardid.Text + "' WHERE e_code = '" + txtEmpID.Text + "' ";
                db.getConnection();

                db.sqlQuery(query);
                if (db.nonQuery())
                    MyDialog.Show("Success...!", "Status updated");

                else
                    MyDialog.Show("Error...!", "Status not updated");
                update_employee_work_hours_and_rate(txtEmpID.Text, Convert.ToDecimal(txtRate.Text), Convert.ToDecimal(txtORate.Text));

                db.getConnection().Close();
                EmployeeGridView();
                resetFields();
            }
        }
        string imageLocation = "";
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
