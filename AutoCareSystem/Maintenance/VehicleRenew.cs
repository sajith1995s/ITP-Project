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
    public partial class VehicleRenew : UserControl
    {
        public VehicleRenew()
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

        private void VehicleRenew_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            txtvehinum.Enabled = false;
            txtvehimodel.Enabled = false;
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
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            //string vehi_id = Convert.ToString(selectedRow.Cells[0].Value);
            txtvehinum.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtvehimodel.Text = Convert.ToString(selectedRow.Cells[2].Value);
        }

        private void BindGridView1(string id)
        {
            try
            {
                string query1 = "SELECT vrr.renew_id, vrr.renew_type, vrr.invoice_id, vrr.amount, vrr.renew_date FROM rental_vehicle_renew vrr WHERE vrr.rv_id = '" + id + "' ";
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

        private void bunifuMaterialTextbox9_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(((tbxsearch.Text.Length >= 1) ? tbxsearch.Text : null));
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            loadRentVehiRenewDetails(selectedRow);
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        public void loadRentVehiRenewDetails(DataGridViewRow selectedRow)
        {
            int index1 = comboinfo.FindString(Convert.ToString(selectedRow.Cells[1].Value));
            comboinfo.SelectedIndex = index1;
            txtinvoiceid.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtamount.Text = Convert.ToString(selectedRow.Cells[3].Value);
            renewdate.Value = DateTime.Parse(Convert.ToString(selectedRow.Cells[4].Value));
        }

        private void resetFields()
        {
            txtvehinum.Text = string.Empty;
            txtvehimodel.Text = string.Empty;
            comboinfo.SelectedIndex = -1;
            txtinvoiceid.Text = string.Empty;
            txtamount.Text = string.Empty;
            renewdate.Value = DateTime.Now;
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

        private void addNewRenew()
        {
            String renewid = CodeGenerator.generateRentVehicleRenewId();
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            string vehicleid = Convert.ToString(selectedRow.Cells[0].Value);
            string vehirenewdate = renewdate.Value.ToString("yyyy-MM-dd");
            string query = "INSERT INTO rental_vehicle_renew VALUES('" + renewid + "','" + vehicleid + "','" + comboinfo.SelectedItem + "','" + txtinvoiceid.Text + "','" + txtamount.Text + "','" + vehirenewdate + "')";
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
                if(Validator.IsValidBeforeOrTodayDate(renewdate.Value))
                {
                    if(Validator.IsValidPrice(txtamount.Text) && Validator.IsValidIntNumber(txtinvoiceid.Text))
                    {
                        addNewRenew();
                        resetFields();
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Plese Enter correct invoiceID , Price!");
                    }
                }else
                {
                    MyDialog.Show("Error...!", "Plese Enter Correct Date!");
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
                if (Validator.IsValidBeforeOrTodayDate(renewdate.Value))
                {
                    if (Validator.IsValidPrice(txtamount.Text) && Validator.IsValidIntNumber(txtinvoiceid.Text))
                    {
                        int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                        string renew_id = Convert.ToString(selectedRow.Cells[0].Value);
                        string maintain_date = renewdate.Value.ToString("yyyy-MM-dd");
                        string query = "UPDATE rental_vehicle_renew SET  renew_type = '" + comboinfo.SelectedItem + "', invoice_id = '" + txtinvoiceid.Text + "', amount = '" + txtamount.Text + "', renew_date = '" + maintain_date + "' WHERE renew_id = '" + renew_id + "'";
                        Database db = new Database();
                        db.openConnection();
                        db.sqlQuery(query);
                        if (db.nonQuery())
                        {
                            MyDialog.Show("Success...!", "Renew Details Updated.");
                            db.closeConnection();
                        }
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Plese Enter correct invoiceID , Price!");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Plese Enter Correct Date!");
                }
            }

            comboinfo.SelectedIndex = -1;
            txtinvoiceid.Text = string.Empty;
            txtamount.Text = string.Empty;
            renewdate.Value = DateTime.Now;

            int selectedrowindex2 = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow2 = bunifuCustomDataGrid2.Rows[selectedrowindex2];
            string eqid = Convert.ToString(selectedRow2.Cells[0].Value);
            BindGridView1(eqid);
            resetFields();
        }

        private bool isEmptyFields()
        {
            if(string.IsNullOrWhiteSpace(txtvehinum.Text) || string.IsNullOrWhiteSpace(txtvehimodel.Text) || string.IsNullOrWhiteSpace(txtinvoiceid.Text) || string.IsNullOrWhiteSpace(txtamount.Text) || comboinfo.SelectedItem.Equals(""))
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setTotal()
        {
            int sum = 0;
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(bunifuCustomDataGrid1.Rows[i].Cells[3].Value);
            }
            if (sum > 0)
                lblcost.Text = "Rs " + sum.ToString("#.00");
            else
                lblcost.Text = String.Empty;
        }
    }
}
