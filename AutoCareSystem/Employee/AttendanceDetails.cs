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
using AutoCareSystem.Employee;

namespace AutoCareSystem
{
    public partial class AttendanceDetails : UserControl
    {
        public AttendanceDetails()
        {
            InitializeComponent();
            AttendanceGridView();
        }










        private void AttendanceGridView()
        {
            try
            {
               Database db = new Database();
               string query = "select ew.emp_id AS 'EmpolyeeID',E.fname+e.lname as 'Employee name',ew.work_hour  AS 'work hour',ew.ot_hour AS 'OT hour' from employee_work_hours_and_rate ew,employee e  where ew.emp_id=e.e_code";


               SqlConnection conn = db.getConnection();
               SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
               DataTable table = new DataTable();
               adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
               datagridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

               datagridAttendance.DataSource = bsource;
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





        private void AttendanceGridViewbySearch(string searchkey)
        {
            try
            {
                Database db = new Database();
                string query = "select ea.emp_id AS 'EmpolyeeID',E.fname+e.lname as 'Employee name',ec.work_hour  AS 'work hour',ec.ot_hour AS 'OT hour' from emp_attendance ea,emp_salary ec,employee e  where ea.att_id=ec.att_id and ea.emp_id=e.e_code and e.fname like '%" + searchkey + "%'";


                SqlConnection conn = db.getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bsource = new BindingSource();
                bsource.DataSource = table;
                datagridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                datagridAttendance.DataSource = bsource;
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








        public String getNeedeStringvalues(String EmployeeId, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee WHERE e_code='" + EmployeeId + "'";
                Database db = new Database();
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


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void datagridAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = datagridAttendance.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datagridAttendance.Rows[selectedrowindex];

            string EmpID = Convert.ToString(selectedRow.Cells[0].Value);

            lblID.Text = EmpID;

           String fname= getNeedeStringvalues(EmpID, "fname");
            string lname = getNeedeStringvalues(EmpID, "lname");

            lblName.Text = fname + lname;
            lblBdate.Text = getNeedeStringvalues(EmpID, "b_date");
            lblGender.Text = getNeedeStringvalues(EmpID, "gender");

            string add1= getNeedeStringvalues(EmpID, "add_line_01");
            string add2 = getNeedeStringvalues(EmpID, "add_line_02");

            lblAddress.Text = add1 + add2;
            lblNIC.Text= getNeedeStringvalues(EmpID, "nic");
            lblPosition.Text= getNeedeStringvalues(EmpID, "position");
            lblTelephone.Text= getNeedeStringvalues(EmpID, "tel_phone");
            lblCardID.Text = getNeedeStringvalues(EmpID, "card_id");

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            AttendanceGridViewbySearch(txtsearch.Text);
        }

        private void btnRepairClear_Click(object sender, EventArgs e)
        {
            new cristalReportview().Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AttendanceGridView();
        }
    }
}
