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
    public partial class assign_technicain : UserControl
    {
        public assign_technicain()
        {
            InitializeComponent();
            cmbTech.SelectedIndex = 0;
            updateStatus();
            btn_assign.Enabled = false;
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datePicker_end.Format = DateTimePickerFormat.Custom;
            datePicker_end.CustomFormat = "dd-MM-yyyy";
            datePicker_start.Format = DateTimePickerFormat.Custom;
            datePicker_start.CustomFormat = "dd-MM-yyyy";
            TimePicker_end.Format = DateTimePickerFormat.Custom;
            TimePicker_end.CustomFormat = "HH:mm";
        }
        public void updateStatus()
        {
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
            {

                String today = DateTime.Now.ToString("yyyy-MM-dd");
                String timeNow = DateTime.Now.ToString("HH:mm");
                string query1 = "UPDATE employee SET technician_status = 'available' WHERE (end_date<'" + today + "') and (end_time<='" + timeNow + "')";
                string query2 = "UPDATE employee SET technician_status = 'unavailable' WHERE (end_date>'" + today + "') and (end_time>='" + timeNow + "')";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query1);
                db.sqlQuery(query2);
                db.nonQuery();
                db.getConnection().Close();
            }
            BindGridView();


        }
        private void BindGridView()
        {

            String query = "select e_code,fname,lname,end_date,end_time,technician_status  from employee";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
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
            bunifuCustomDataGrid1.Columns[1].HeaderText = "fname";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "lname";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "End_date";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "End_Time";
            bunifuCustomDataGrid1.Columns[5].Visible = true;
            bunifuCustomDataGrid1.Columns[5].HeaderText = "Status";
        }
        private void assign_technicain_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datePicker_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            if (status == "unavailable")
            {
                btn_assign.Enabled = false;
            }
            else
            {
                btn_assign.Enabled = true;
                btn_assign.Visible = true;
            }
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            String end_date = datePicker_end.Value.ToString("yyyy-MM-dd");
            String end_time = TimePicker_end.Value.ToString("HH:mm");

            String tech_id = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            string status = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            if (status.Equals("available"))
            {
               
                {
                    try
                {
                    Database db = new Database();
                    db.openConnection();


                        string query = "UPDATE employee SET technician_status ='" + "unavailable" + "',end_date='" + end_date + "',end_time='" + end_time + "'where e_code = '"+tech_id+"'";

                    db.sqlQuery(query);
                    db.nonQuery();
                    db.getConnection().Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            }
          
            else if (status == "unavailable")
            {
                MyDialog.Show("Technician already assigned","Please select a technician who is not assigned");
            }
            BindGridView();
        }

        private void cmbTech_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTech.SelectedIndex == 0)
            {
                BindGridView();
            }
            else if (cmbTech.SelectedIndex == 1)
            {
                try
                {
                    String query = "select e_code,fname,lname,end_date,end_time,technician_status from employee where (technician_status='available')";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query);
                    DataTable dt = db.executeQuery();
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bunifuCustomDataGrid1.DataSource = dt;
                    db.getConnection().Close();
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
            else if (cmbTech.SelectedIndex == 2)
            {
                try
                {
                    String query = "select e_code,fname,lname,end_date,end_time,technician_status from employee where (technician_status='unavailable')";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query);
                    DataTable dt = db.executeQuery();
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bunifuCustomDataGrid1.DataSource = dt;
                    db.getConnection().Close();
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
        }
    }
}
