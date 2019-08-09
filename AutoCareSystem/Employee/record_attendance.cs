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

namespace AutoCareSystem
{
    public partial class record_attendance : UserControl
    {
        public record_attendance()
        {
            InitializeComponent();

            lblMessage.Visible = false;
            lblEname.Visible = false;
            lblTime.Visible = false;
            lblMode.Visible=false;
        }

        private void resetFields()
        {
            txtrecordATT.Text = string.Empty;
            

        }

        public String get_employee_Details(String cardID, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee WHERE card_id ='" + cardID + "' ";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                String NeedSTRING = Convert.ToString(db.executeQuery(clm_name));
                db.getConnection().Close();
                return NeedSTRING;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public String get_emp_attendance_Details(int cardID,String Date, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM emp_attendance WHERE card_id ='" + cardID + "'  and attendance_date='" + Date + "'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                String NeedSTRING = Convert.ToString(db.executeQuery(clm_name));
                db.getConnection().Close();
                return NeedSTRING;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Decimal get_employee_work_hours_and_rate(int CardId, String clm_name)
        {
            try
            {
                String query = "SELECT  " + clm_name + " FROM employee_work_hours_and_rate WHERE card_id ='" + CardId + "'";
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

      

      

        private void timer_tick(object sender, EventArgs e)
        {
            bunifuCustomLabel4.Text = System.DateTime.Now.ToString("hh:mm:ss");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void record_attendance_Load(object sender, EventArgs e)
        {
            bunifuCustomLabel3.Text = DateTime.Now.ToString("yyy-MM-dd");
            bunifuCustomLabel4.Text = System.DateTime.Now.ToString("hh:mm:ss");
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(this.timer_tick);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void tbxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblEname.Visible = true;
            lblTime.Visible = true;
            lblMode.Visible = true;

            if (txtrecordATT.Text.Length == 10)
            {
                int cardid = Convert.ToInt32(txtrecordATT.Text);

               

                String EID = get_employee_Details(txtrecordATT.Text, "e_code");
                String Ename = get_employee_Details(txtrecordATT.Text, "fname");

                String date1 = DateTime.Now.ToString("dd-MM-yyyy");
                String time1 = DateTime.Now.ToString("HH:mm:ss tt");
      
                lblEname.Text = Ename;
                lblTime.Text = time1;

                String EmpAtt=CodeGenerator.generateEmployeeAttendeceID();

                // DateTime.Now
                String date2 = DateTime.Now.ToString("dd-MM-yyyy");
                
                String DATE= get_emp_attendance_Details(cardid, date2, "attendance_date");

                if (String.Compare(date1, DATE) == 0)
                {


                   String departureTime = get_emp_attendance_Details(cardid, date2, "departure_time");

                    if (String.Compare(departureTime,"00:00:00")==0)
                    {
                        String time2 = DateTime.Now.ToString("HH:mm:ss tt");
                      
                        Database db = new Database();
                        db.openConnection();
                        SqlConnection conn = db.getConnection();
                        SqlCommand cmd = conn.CreateCommand();
                        string query = "Update emp_attendance SET departure_time = '" + time2 + "' WHERE card_id = '" + cardid + "' and attendance_date='" + date2 + "'";

                        
                        db.sqlQuery(query);
                        db.nonQuery();
                   

                       db.getConnection().Close();
                        resetFields();
                        lblMode.Text = "OUT";
                        lblMessage.Visible = true;
                        lblMessage.Text = ("THANK YOU FOR YOUR SERVICE  " + Ename);

                        string arrivaltime = get_emp_attendance_Details(cardid, date2, "arrival_time");

                        var dateTime = Convert.ToDateTime(time2);
                        String t = "17:00:00";
                        var dateTime1 = Convert.ToDateTime(t);
                        var dateTime3 = Convert.ToDateTime(arrivaltime);

                        if (dateTime < dateTime1)
                        {

                            TimeSpan work_hour = dateTime.Subtract(dateTime3);
                            TimeSpan ot_hour = dateTime1.Subtract(dateTime3);
                           

                            decimal DWork_hour = Convert.ToDecimal(work_hour.TotalHours.ToString("#.00"));

                            
                            decimal SWork_hour =get_employee_work_hours_and_rate(cardid, "work_hour");
                           
                            decimal RealWork_hour = SWork_hour + DWork_hour;




                            Database db1 = new Database();
                            SqlConnection conn1 = db1.getConnection();
                            SqlCommand cmd1 = conn.CreateCommand();
                            string query1 = "Update employee_work_hours_and_rate SET work_hour = '" + RealWork_hour + "' WHERE card_id = '" + cardid + "' ";
                            db1.openConnection();
                            db1.sqlQuery(query1);
                            db1.nonQuery();
                            db1.getConnection().Close();




                        }
                        else
                        {
                            TimeSpan work_hour = dateTime1.Subtract(dateTime3);
                            TimeSpan ot_hour = dateTime.Subtract(dateTime1);
                            decimal DWork_hour = Convert.ToDecimal(work_hour.TotalHours.ToString("#.00"));


                            decimal SWork_hour = get_employee_work_hours_and_rate(cardid, "work_hour");

                            decimal RealWork_hour = SWork_hour + DWork_hour;



                            decimal Dot_hour = Convert.ToDecimal(ot_hour.TotalHours.ToString("#.00"));
                            decimal Sot_hour = get_employee_work_hours_and_rate(cardid, "ot_hour");
                            decimal Realot_hour = Sot_hour + Dot_hour;

                            Database db1 = new Database();
                            SqlConnection conn1 = db1.getConnection();
                            SqlCommand cmd1 = conn.CreateCommand();
                            string query1 = "Update employee_work_hours_and_rate SET work_hour = '" + RealWork_hour + "',ot_hour='" + Realot_hour + "' WHERE card_id = '" + cardid + "' ";
                            db1.openConnection();
                            db1.sqlQuery(query1);
                            db1.nonQuery();
                           db1.getConnection().Close();



                        }





                    }
                    else
                    {

                        MyDialog.Show("Error...!", "You have already leaved");
                        resetFields();
                    }



                }
               
                
                else
                {
                    string query1 = "INSERT INTO emp_attendance VALUES('" + EmpAtt + "','" + EID + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "','" + DateTime.Now.ToString("HH:mm:ss tt") + "','00:00:00','" + cardid + "')";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query1);
                    db.nonQuery();

                    resetFields();
                    lblMode.Text = "IN";
                    lblMessage.Visible = true;
                    lblMessage.Text = ("WELCOME "+Ename);
                }
            }




        }
    }
}
