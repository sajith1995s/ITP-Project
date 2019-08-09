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
using System.Data.OleDb;

namespace AutoCareSystem
{
    public partial class vehicle_manage : UserControl
    {
        VehicleController vc;

        public vehicle_manage()
        {
            InitializeComponent();
            vc = new VehicleController();
        }

        private void vehicle_manage_Load(object sender, EventArgs e)
        {
            setCustomers();
            BindGridView(null);
            enableButtons(false);
            cmbVehicleType.SelectedIndex = 0;
        }

        public void SetGridViewWidth()
        {
            bunifuCustomDataGrid1.Columns[0].Width = 50;
            bunifuCustomDataGrid1.Columns[1].Width = 200;
            bunifuCustomDataGrid1.Columns[2].Width = 100;
            bunifuCustomDataGrid1.Columns[3].Width = 100;
            bunifuCustomDataGrid1.Columns[4].Width = 100;
            bunifuCustomDataGrid1.Columns[5].Width = 100;
        }

        private void setCustomers()
        {
            try
            {
                DataTable dt = vc.getCustomerDetails();
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                foreach (DataRow row in dt.Rows)
                {
                    String id = Convert.ToString(row["c_code"]);
                    String name = Convert.ToString(row["fname"]) + " " + Convert.ToString(row["lname"]);
                    comboSource.Add(id, name);
                }

                cmbCusName.DataSource = new BindingSource(comboSource, null);
                cmbCusName.DisplayMember = "Value";
                cmbCusName.ValueMember = "Key";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void enableButtons(bool b)
        {
            btnRemove.Enabled = b;
            btnUpdate.Enabled = b;
            btnAdd.Enabled = !b;

            btnAdd.Cursor = (!b) ? Cursors.Hand : Cursors.Default;
            btnRemove.Cursor = (b) ? Cursors.Hand : Cursors.Default;
            btnUpdate.Cursor = (b) ? Cursors.Hand : Cursors.Default;

        }

        private void BindGridView(String skey)
        {
            try
            {
                DataTable dt = vc.getVehicleDetails(skey);
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                SetGridViewWidth();
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

        private void addNewVehicle()
        {
            string key = ((KeyValuePair<string, string>)cmbCusName.SelectedItem).Key;
            String vehicle_type = cmbVehicleType.SelectedItem.ToString();

            Vehicle v_data = new Vehicle();
            v_data.CustomerName = key;
            v_data.VehicleNo = tbxVehicleNo.Text;
            v_data.Type = vehicle_type;
            v_data.Brand = tbxBrand.Text;
            v_data.Model = tbxModel.Text;

            if(vc.addVehicle(v_data))
            {
                MyDialog.Show("Success...!", "Vehicle Registered");
                resetFields();
                BindGridView(null);
            }
            else
            {
                MyDialog.Show("Error...!", "Vehicle Not Registered");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxVehicleNo.Text) ||
                String.IsNullOrWhiteSpace(tbxBrand.Text) ||
                String.IsNullOrWhiteSpace(tbxModel.Text) ||
                String.IsNullOrWhiteSpace(tbxVehicleNo.Text))

                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {
                if (Validator.IsValidName(tbxBrand.Text))
                {
                    if (Validator.IsValidVehicleNumber(tbxVehicleNo.Text))
                    {
                        if (Validator.IsValidName(tbxModel.Text))
                            addNewVehicle();
                        else
                            MyDialog.Show("Error...!", "Invalid Model Name");
                    }
                    else
                        MyDialog.Show("Error...!", "Invalid Vehicle Number");
                }
                else
                {
                    MyDialog.Show("Error...!", "Invalid Brand Name");
                }
            }
            
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            tbxVehicleNo.Text = Convert.ToString(selectedRow.Cells[2].Value);
            tbxBrand.Text = Convert.ToString(selectedRow.Cells[4].Value);
            tbxModel.Text = Convert.ToString(selectedRow.Cells[5].Value);

            int index01 = cmbVehicleType.FindString(Convert.ToString(selectedRow.Cells[3].Value));
            cmbVehicleType.SelectedIndex = index01;

            int index02 = cmbCusName.FindString(Convert.ToString(selectedRow.Cells[1].Value));
            cmbCusName.SelectedIndex = index02;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

                loadTexts(selectedRow);
                enableButtons(true);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
            BindGridView(null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String v_code = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                vc.removeVehicle(v_code);
                BindGridView(null);         //reload table
                resetFields();          //reset all input fields
            }
            
        }

        private void resetFields()
        {
            cmbCusName.ResetText();
            cmbVehicleType.ResetText();
            tbxVehicleNo.Text = String.Empty;
            tbxBrand.Text = String.Empty;
            tbxModel.Text = String.Empty;
            bunifuCustomDataGrid1.ClearSelection();
            enableButtons(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            String v_code = Convert.ToString(selectedRow.Cells[0].Value);
            String vehicle_type = cmbVehicleType.SelectedItem.ToString();
            string cus_name = ((KeyValuePair<string, string>)cmbCusName.SelectedItem).Key;

            if (String.IsNullOrWhiteSpace(tbxVehicleNo.Text) ||
                String.IsNullOrWhiteSpace(tbxBrand.Text) ||
                String.IsNullOrWhiteSpace(tbxModel.Text) ||
                String.IsNullOrWhiteSpace(tbxVehicleNo.Text))

                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {
                if (Validator.IsValidName(tbxBrand.Text))
                {
                    if (Validator.IsValidVehicleNumber(tbxVehicleNo.Text))
                    {
                        if (Validator.IsValidName(tbxModel.Text))
                        {
                            Vehicle v_data = new Vehicle();
                            v_data.VehicleCode = v_code;
                            v_data.CustomerName = cus_name;
                            v_data.VehicleNo = tbxVehicleNo.Text;
                            v_data.Type = vehicle_type;
                            v_data.Brand = tbxBrand.Text;
                            v_data.Model = tbxModel.Text;

                            if (vc.updateVehicle(v_data))
                            {
                                BindGridView(null);
                                resetFields();
                                MyDialog.Show("Success...!", "Vehicle updated");
                            }
                            else
                            {
                                MyDialog.Show("Error...!", "Vehicle not updated");
                            }
                        }
                        else
                            MyDialog.Show("Error...!", "Invalid Model Name");

                    }
                    else
                        MyDialog.Show("Error...!", "Invalid Vehicle Number");
                }
                else
                    MyDialog.Show("Error...!", "Invalid Brand Name");
                
            }   
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView( ((tbxSearch.Text.Length >= 7) ? tbxSearch.Text : null) );
        }

        private void tbxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidVehicleNumber(tbxSearch.Text))
                BindGridView(tbxSearch.Text);
            else
                MyDialog.Show("Error...!", "Invalid Vehicle Number");
        }

        private void cmbCusName_Click(object sender, EventArgs e)
        {
            setCustomers();
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }
    }
}
