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
    public partial class slots : UserControl
    {
        public slots()
        {
            InitializeComponent();
            cmbSlot.SelectedIndex = 0;
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
                string query1 = "UPDATE slots SET slot_status = 'available' WHERE (end_date<'" + today + "') and (end_time<='" + timeNow + "')";
                string query2 = "UPDATE slots SET slot_status = 'unavailable' WHERE (end_date>'" + today + "') and (end_time>='" + timeNow + "')";
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
            
                String query = "select * from slots";
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
            bunifuCustomDataGrid1.Columns[1].HeaderText = "Slot_Type";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Status";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "End_Date";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "End_Time";
        

        }

        private void cmbSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmbSlot.SelectedIndex==0)
            {
                BindGridView();
            }
            else if(cmbSlot.SelectedIndex==1)
            {
                try
                {
                    String query = "select * from slots where (slot_status='available')";
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
           else if(cmbSlot.SelectedIndex==2)
            {
                try
                {
                    String query = "select * from slots where (slot_status='unavailable')";
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

        private void btnAssign_Click(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker_start.Format = DateTimePickerFormat.Custom;
            datePicker_start.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            datePicker_start.Format = DateTimePickerFormat.Custom;
            datePicker_start.CustomFormat = "dd-MM-yyyy";
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            datePicker_start.Format = DateTimePickerFormat.Custom;
            datePicker_start.CustomFormat = "hh:mm";
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            datePicker_start.Format = DateTimePickerFormat.Custom;
            datePicker_start.CustomFormat = "hh:mm";
        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_assign_Click_1(object sender, EventArgs e)
        {
            String end_date = datePicker_end.Value.ToString("yyyy-MM-dd");
            String end_time = TimePicker_end.Value.ToString("HH:mm");

            String slot_id = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();  
            string status = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            if (status=="available")
            {
                if ((datePicker_start.Value.Date <= datePicker_end.Value.Date))
                {
                    try
                    {
                        Database db = new Database();
                        db.openConnection();
                        string query = "UPDATE slots SET slot_status ='" + "unavailable" + "',end_date='" + end_date + "',end_time='" + end_time + "'where slot_id='"+slot_id+"'";

                        db.sqlQuery(query);
                        db.nonQuery();
                        db.getConnection().Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                }else if(datePicker_start.Value.Date > datePicker_end.Value.Date)
                {
                    MyDialog.Show("Date error", "Start date should be less than End date");
                }
            }
            else if (status == "unavailable")
            {
                MyDialog.Show("Slot already assigned", "Please select a slot which is not assigned");
                
            }
            BindGridView();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_assign.Enabled = true;
            btn_assign.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
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

        private void bunifuCustomDataGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
