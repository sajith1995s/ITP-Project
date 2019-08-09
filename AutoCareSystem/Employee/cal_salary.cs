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
using CrystalDecisions.CrystalReports.Engine;
using AutoCareSystem.Employee;
using AutoCareSystem.Employee.EmpReports;

namespace AutoCareSystem
{
    public partial class cal_salary : UserControl
    {
        public cal_salary()
        {
            InitializeComponent();

            EmployeeGridView();

            SalaryGridView();
            crystalReportcalarybill.Visible = false;
            btnback.Visible = false;


        }
       
        private void EmployeeGridView()
        {
            try
            {
                Database db = new Database();
                db.openConnection();
                string query = "select e_code AS 'Employee ID',fname AS 'FirstName',nic AS 'NIC',gender AS 'Gender',tel_phone AS 'Telephone' from employee";


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
        private void SalaryGridView()

        {
            try
            {
                Database db = new Database();
                db.openConnection();
                string query = "select sal_id AS 'Salary ID',emp_id AS 'Employee ID',rate_per_hour AS 'Rate',rate_per_ot_hour AS 'OT Rate',work_hour AS 'Work Hours',ot_hour AS 'OT Hours',total_salary AS 'Salary' from emp_salary";

                SqlConnection conn = db.getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                DataGridSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                DataGridSalary.DataSource = bsource;
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


        public Decimal get_employee_work_hours_and_rate(string EID, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee_work_hours_and_rate WHERE 	emp_id ='" + EID + "'";
                Database db = new Database();
                db.openConnection();
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


        private void resetFields()
        {
            txtEid.Text = string.Empty;
            txtename.Text = string.Empty;
            txtORate.Text = string.Empty;
            txtRate.Text = string.Empty;
            SalaryGridView();
            EmployeeGridView();



        }


        private void cal_salary_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            EmployeeGridViewBySearch(txtename.Text);
        }

        private void DataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = DataGridEmployee.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = DataGridEmployee.Rows[selectedrowindex];

            txtename.Text=Convert.ToString(selectedRow.Cells[1].Value);
            txtEid.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtRate.Text = Convert.ToString(get_employee_work_hours_and_rate(txtEid.Text, "rate_per_hour"));
            txtORate.Text = Convert.ToString(get_employee_work_hours_and_rate(txtEid.Text, "rate_per_ot_hour"));

        }

        private void DataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            decimal workHour= get_employee_work_hours_and_rate(txtEid.Text, "work_hour");
            decimal otHour = get_employee_work_hours_and_rate(txtEid.Text, "ot_hour");
            decimal sal = (Convert.ToDecimal((txtRate.Text)) * get_employee_work_hours_and_rate(txtEid.Text, "work_hour")) +( Convert.ToDecimal((txtORate.Text)) *get_employee_work_hours_and_rate(txtEid.Text, "ot_hour"));
            lblTotalSal.Text = Convert.ToString(sal);



            
           
            string sid = CodeGenerator.generateEmployeesalaryID();
             string query = "INSERT INTO emp_salary VALUES('" + sid + "','" + txtEid.Text + "',(select  TOP 1 att_id from emp_attendance where emp_id='" + txtEid.Text + "'),'" + Convert.ToDecimal(txtRate.Text) + "','" + Convert.ToDecimal( txtORate.Text) + "','"+ workHour + "','"+ otHour + "','"+DateTime.Now.ToString("yyyy-MM-dd")+ "','" + sal + "')";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            if (db.nonQuery())
            {
                MyDialog.Show("Success...!", "Salary Calculated");
                SalaryGridView();
               


            }





        }

        private void btnRepairClear_Click(object sender, EventArgs e)
        {
            resetFields();
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            crystalReportcalarybill.Visible = true;
            btnback.Visible = true;

            Database db = new Database();
            db.openConnection();
            SqlConnection conn = db.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employee e,emp_salary es where e.e_code=es.emp_id and es.emp_id='" + txtEid.Text + "'", conn);
            DataSet dst = new DataSet();
            sda.Fill(dst, "emp_salary");
            EmployeeBill cryrpt = new EmployeeBill();
            

            cryrpt.SetDataSource(dst);
            crystalReportcalarybill.ReportSource = cryrpt;
            db.getConnection().Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            crystalReportcalarybill.Visible = false;
            btnback.Visible = false;
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            crystalReportcalarybill.Visible = false;
            btnback.Visible = false;

        }
    }
}
