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
    public partial class VehicleService : UserControl
    {
        public VehicleService()
        {
            InitializeComponent();
        }

        private void BindGridView(String skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                    query = "SELECT rv.rv_id, rv.rv_brand, rv.rv_model, rv.rv_number FROM rental_vehicle rv ";
                else
                    query = "SELECT rv.rv_id, rv.rv_brand, rv.rv_model, rv.rv_number FROM rental_vehicle rv WHERE rv.rv_number LIKE '%" + skey + "%'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = dt;
                db.closeConnection();
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

        private void VehicleService_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            txtvehinumber.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            loadTexts(selectedRow);
            BindGridView1(Convert.ToString(selectedRow.Cells[0].Value));
            setTotal();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            string vehi_id = Convert.ToString(selectedRow.Cells[0].Value);
            txtvehinumber.Text = Convert.ToString(selectedRow.Cells[3].Value);          
        }

        private void BindGridView1(string eq_id)
        {
            try
            {
                string query1 = "SELECT vrs.maintanance_id, vrs.maintanance_type, vrs.info, vrs.invoice_id, vrs.amount, vrs.current_milage, vrs.maintanance_date FROM rental_vehicle_repair_service vrs WHERE vrs.rv_id = '" + eq_id + "' ";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                db.closeConnection();
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

        private void tbxsearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(((tbxsearch.Text.Length >= 1) ? tbxsearch.Text : null));
        }

        private void resetFields()
        {
            txtvehinumber.Text = string.Empty;
            txtcurmilage.Text = string.Empty;
            combotype.SelectedIndex = -1;
            txtinfo.Text = string.Empty;
            txtinvoiceid.Text = string.Empty;
            txtamount.Text = string.Empty;
            maintaindate.Value = DateTime.Now;
            bunifuCustomDataGrid1.DataSource = null;
            bunifuCustomDataGrid2.DataSource = null;
            tbxsearch.Text = null;
            BindGridView(null);
            lblcost.Text = String.Empty;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            loadRentVehiMainDetails(selectedRow);
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        public void loadRentVehiMainDetails(DataGridViewRow selectedRow)
        {
            int index1 = combotype.FindString(Convert.ToString(selectedRow.Cells[1].Value));
            combotype.SelectedIndex = index1;
            txtinfo.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtinvoiceid.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtamount.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtcurmilage.Text = Convert.ToString(selectedRow.Cells[5].Value);
            maintaindate.Value = DateTime.Parse(Convert.ToString(selectedRow.Cells[6].Value));
        }

        private void addNewService()
        {
            String serid = CodeGenerator.generateRentVehicleRRepaiServiceId();
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            string vehiid = Convert.ToString(selectedRow.Cells[0].Value);
            string service_date = maintaindate.Value.ToString("yyyy-MM-dd");
            string query = "INSERT INTO rental_vehicle_repair_service VALUES('" + serid + "','" + vehiid + "','" + combotype.SelectedItem + "','" + txtinfo.Text + "','" + txtinvoiceid.Text + "','" + txtamount.Text + "','" + txtcurmilage.Text + "','" + service_date + "')";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            if (db.nonQuery())
            {
                MyDialog.Show("Success...!", "Renew Details Added.");
            }
            db.closeConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool emptyFields = isEmptyFields();
            if (emptyFields == false)
            {
                MyDialog.Show("Error...!", "Plese fill all fields");
            }
            else
            {
                if(Validator.IsValidIntNumber(txtcurmilage.Text))
                {
                    if(Validator.IsValidIntNumber(txtinvoiceid.Text) && Validator.IsValidPrice(txtamount.Text))
                    {
                        if(Validator.IsValidDescription(txtinfo.Text))
                        {
                            addNewService();
                            resetFields();
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Plese enter correct Service Infomation!");
                        }
                    }else
                    {
                        MyDialog.Show("Error...!", "Plese enter correct InvoiceId , Amount!");
                    }
                }else
                {
                    MyDialog.Show("Error...!", "Plese enter correct milage!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool emptyFields = isEmptyFields();
            if (emptyFields == false)
            {
                MyDialog.Show("Error...!", "Plese fill all fields");
            }
            else
            {
                if (Validator.IsValidIntNumber(txtcurmilage.Text))
                {
                    if (Validator.IsValidIntNumber(txtinvoiceid.Text) && Validator.IsValidPrice(txtamount.Text))
                    {
                        if (Validator.IsValidDescription(txtinfo.Text))
                        {
                            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                            string service_id = Convert.ToString(selectedRow.Cells[0].Value);
                            string maintain_date = maintaindate.Value.ToString("yyyy-MM-dd");
                            string query = "UPDATE rental_vehicle_repair_service SET  maintanance_type = '" + combotype.SelectedItem + "', info = '" + txtinfo.Text + "', invoice_id = '" + txtinvoiceid.Text + "', amount = '" + txtamount.Text + "', current_milage = '" + txtcurmilage.Text + "', maintanance_date = '" + maintain_date + "' WHERE maintanance_id = '" + service_id + "'";
                            Database db = new Database();
                            db.openConnection();
                            db.sqlQuery(query);
                            if (db.nonQuery())
                            {
                                MyDialog.Show("Success...!", "Service Details Updated.");
                                db.closeConnection();
                            }
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Plese enter correct Service Infomation!");
                        }
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Plese enter correct InvoiceId , Amount!");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Plese enter correct milage!");
                }
            }

            combotype.SelectedIndex = -1;
            txtinfo.Text = string.Empty;
            txtinvoiceid.Text = string.Empty;
            txtamount.Text = string.Empty;
            maintaindate.Value = DateTime.Now;

            int selectedrowindex2 = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow2 = bunifuCustomDataGrid2.Rows[selectedrowindex2];
            string vehiid = Convert.ToString(selectedRow2.Cells[0].Value);
            BindGridView1(vehiid);
            resetFields();
        }

        private bool isEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtvehinumber.Text) || string.IsNullOrWhiteSpace(txtcurmilage.Text) || string.IsNullOrWhiteSpace(txtinfo.Text) || string.IsNullOrWhiteSpace(txtinvoiceid.Text) || string.IsNullOrWhiteSpace(txtamount.Text) || combotype.SelectedItem.Equals(""))
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void setTotal()
        {
            int sum = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[4].Value);
            }
            if (sum > 0)
                lblcost.Text = "Rs " + sum.ToString("#.00");
            else
                lblcost.Text = String.Empty;
        }
    }
}
