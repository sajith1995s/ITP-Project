using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AutoCareSystem
{
    public partial class Employee_registration : UserControl
    {
        public Employee_registration()
        {
            InitializeComponent();
            CodeGenerator cd = new CodeGenerator();
            string EmpID = CodeGenerator.generateEmployeeID();
            txtEID.Text = EmpID;
        }


        public void resetFields() {
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtEID.Text = string.Empty;
            dpDOB.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cmbPosition.SelectedIndex = 0;
            txtCID.Text = string.Empty;
            txtRate.Text= string.Empty;
            txtORate.Text = string.Empty;
            //   txtHoli.Text = string.Empty;


        }
        public void resetFieldsforInsert()
        {
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            dpDOB.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cmbPosition.SelectedIndex = 0;
            txtCID.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtORate.Text = string.Empty;
            // txtHoli.Text = string.Empty;


        }

        void insert_to_employee_work_hours_and_rate(string EID,decimal rate_per_hour,decimal rate_per_othour,int cardID)
        {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            SqlCommand cmd = conn.CreateCommand();
            string query = "INSERT INTO employee_work_hours_and_rate VALUES('" + EID + "',0,0,'" + rate_per_hour + "','" + rate_per_othour + "','" + cardID + "')";
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            resetFields();
            CodeGenerator cd = new CodeGenerator();
            string EmpID = CodeGenerator.generateEmployeeID();
            txtEID.Text = EmpID;


            
        }

    private bool Validte_Data()
        {
            Regex validate_email = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            Regex Validate_alpha_numaric = new Regex("^[0-9a-zA-Z #,-]+$");
            Regex validate_phone_num = new Regex("^[0-9]{10}$");
            Regex validate_nic = new Regex("^[0-9]{9}[V,v]$");
            Regex validate_alphabatic = new Regex("^[a-zA-Z]+$");
            Regex validate_RFID = new Regex("^[0-9]{10}$");
         //   Regex validate_Aceptedholyday = new Regex("^[0-9]+$");

            if (!validate_alphabatic.IsMatch(txtFName.Text))
            {
                MyDialog.Show("Error...!", "First Name Is Not Correct");
            }
            else
            {
                if (!validate_alphabatic.IsMatch(txtLName.Text))
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
                        if (!validate_phone_num.IsMatch(txtPhone.Text))
                        {
                            MyDialog.Show("Error...!", "Mobile Number Is Not Valid");
                           
                        }
                        else
                        {
                            if (!Validate_alpha_numaric.IsMatch(txtAddress1.Text))
                            {
                                MyDialog.Show("Error...!", "Address Line 1 is Not correct");
                               
                            }
                            else
                            {
                                if (!Validate_alpha_numaric.IsMatch(txtAddress2.Text))
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
                                            if (!validate_RFID.IsMatch(txtCID.Text))
                                            {
                                                MyDialog.Show("Error...!", "CardID is Not correct");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Employee_registration_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRepairAdd_Click(object sender, EventArgs e)
        {
            bool test = Validte_Data();
            if (test == true)
            {
                

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
                SqlConnection conn = db.getConnection();
                SqlCommand cmd = conn.CreateCommand();
                string query = "INSERT INTO employee ( e_code,fname, lname, b_date, gender, add_line_01, add_line_02, city, nic, tel_phone, position,card_id) VALUES('" + txtEID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + dpDOB.Text + "','" + gender + "','" + txtAddress1.Text + "','" + txtAddress2.Text + "','" + txtCity.Text + "','" + txtNIC.Text + "','" + txtPhone.Text + "','" + cmbPosition.Text + "','" +Convert.ToInt32( txtCID.Text) + "')";

                db.openConnection();
                db.sqlQuery(query);
                if (db.nonQuery())
                {
                    MyDialog.Show("Success...!", "Employee Registered");
                    insert_to_employee_work_hours_and_rate(txtEID.Text, Convert.ToDecimal(txtRate.Text), Convert.ToDecimal(txtORate.Text), Convert.ToInt32(txtCID.Text));

                }
                else
                {
                    MyDialog.Show("Error...!", "Employee not Registered");
                    resetFields();
                }

            }
           
        }

        private void btnRepairClear_Click(object sender, EventArgs e)
        {
            resetFields();
            CodeGenerator cd = new CodeGenerator();
            string EmpID = CodeGenerator.generateEmployeeID();
            txtEID.Text = EmpID;


        }

        private void txtFName_OnValueChanged(object sender, EventArgs e)
        {

        }
        string imageLocation = "";
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
