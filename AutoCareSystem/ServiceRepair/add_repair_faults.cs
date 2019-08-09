using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace AutoCareSystem
{
    public partial class add_repair_faults : UserControl
    {
        private String vehicle_id;
        private RepairController rc;

        public add_repair_faults()
        {
            InitializeComponent();
            rc = new RepairController();
        }

        private void new_add_repair_Load(object sender, EventArgs e)
        {
            setTechnicians();
            lblBrand.Text = String.Empty;
            lblModel.Text = String.Empty;
            enabaleFields(false);
            btnRemove.Enabled = false;
            btnRemove.Cursor = Cursors.Default;
            btnRepairAdd.Enabled = false;
            btnRepairAdd.Cursor = Cursors.Default;
        }

        private void setTechnicians()
        {
            try
            {
                DataTable dt = rc.getEmployeeDetails();
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                foreach (DataRow row in dt.Rows)
                {
                    String id = Convert.ToString(row["e_code"]);
                    String name = Convert.ToString(row["fname"]) + " " + Convert.ToString(row["lname"]);
                    comboSource.Add(id, name);
                }

                cmbTechnician.DataSource = new BindingSource(comboSource, null);
                cmbTechnician.DisplayMember = "Value";
                cmbTechnician.ValueMember = "Key";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void enabaleFields(bool b)
        {
            tbxErrorCode.Enabled = b;
            tbxErrorDesc.Enabled = b;
            tbxRemark.Enabled = b;
            cmbTechnician.Enabled = b;

            btnRepairAdd.Enabled = b;
            btnRepairAdd.Cursor = (b) ? Cursors.Hand : Cursors.Default;
        }

        private void tbxVehicleNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void tbxVehicleNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (Validator.IsValidVehicleNumber(tbxVehicleNumber.Text))
                enabaleFields( ((isFound()) ? true : false) ); 
        }

        private bool isFound()
        {
            DataTable dt = rc.getVehicleDetailsIfExists(tbxVehicleNumber.Text);
            if (dt != null)
            {
                vehicle_id = Convert.ToString(dt.Rows[0]["v_code"]);
                lblBrand.Text = Convert.ToString(dt.Rows[0]["brand"]);
                lblModel.Text = Convert.ToString(dt.Rows[0]["model"]);
                return true;
            }
            else
            {
                vehicle_id = null;
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = tbxErrorCode.Text;
            string desc = tbxErrorDesc.Text;
            string remark = tbxRemark.Text;
            if (tbxErrorCode.Text.Length > 0 && tbxErrorDesc.Text.Length > 0)
            {
                if (Validator.IsValidErrorCode(code))
                {
                    if (!isErrorAlreadyAdded(code))
                    {
                        string[] row = { code, desc, remark };
                        bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        bunifuCustomDataGrid1.Rows.Add(row);
                        lblErrorCount.Text = bunifuCustomDataGrid1.Rows.Count.ToString();
                    }
                    else
                    {
                        MyDialog.Show("Error..!", "Vehicle Error Already Added");
                    }
                }
                else
                {
                    MyDialog.Show("Error..!", "Invalid Error Code");
                }
            }
            else
            {
                MyDialog.Show("Error..!", "Error Code && Description are Required");
            }
        }

        private bool isErrorAlreadyAdded(String code)
        {
            bool found = false;
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
            {
                if (row.Cells[0].Value.Equals(code))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = bunifuCustomDataGrid1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                bunifuCustomDataGrid1.Rows.RemoveAt(bunifuCustomDataGrid1.CurrentCell.RowIndex);
                lblErrorCount.Text = bunifuCustomDataGrid1.Rows.Count.ToString();
            }
            else
            {
                btnRemove.Enabled = false;
                btnRemove.Cursor = Cursors.Default;
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnRemove.Cursor = Cursors.Hand;
        }

        private void btnRepairAdd_Click(object sender, EventArgs e)
        {
            String repair_date = repairDate.Value.ToString("yyyy-MM-dd");
            String r_code = CodeGenerator.generateRepairCode();
            if (Validator.IsValidPastDate(repair_date))
                addNewRepair();
            else
                MyDialog.Show("Error...!", "Invalid repair date");
        }

        private void addNewRepair()
        {
            Repair rp = new Repair();
            rp.EmployeeCode = ((KeyValuePair<string, string>)cmbTechnician.SelectedItem).Key;
            rp.VehicleId = vehicle_id;
            rp.RepairDate = repairDate.Value;

            if (rc.addRepair(rp))
            {
                MyDialog.Show("Success...!", "Repair Registered");
                addVehicleFaults();
                resetFields();
            }
            else
            {
                MyDialog.Show("Error...!", "Repair Not Registered");
            }
        }


        private void addVehicleFaults()
        {
            rc.AddVehicleFaults(bunifuCustomDataGrid1);
        }

        private void resetFields()
        {
            tbxVehicleNumber.Text = String.Empty;
            tbxErrorCode.Text = String.Empty;
            tbxErrorDesc.Text = String.Empty;
            tbxRemark.Text = String.Empty;
            bunifuCustomDataGrid1.DataSource = null;
            bunifuCustomDataGrid1.Rows.Clear();
            lblErrorCount.Text = "0";
            cmbTechnician.SelectedIndex = 0;
            repairDate.Value = DateTime.Today.AddDays(0);
        }

        private void tbxErrorCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void tbxErrorCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (Validator.IsValidErrorCode(tbxErrorCode.Text))
            {
                DataTable dt = rc.getErrorDetailsIfExists(tbxErrorCode.Text);
                if (dt != null)
                {
                    tbxErrorDesc.Text = Convert.ToString(dt.Rows[0]["description"]);
                    tbxRemark.Text = Convert.ToString(dt.Rows[0]["extra_details"]);
                }
            }
            else
            {
                tbxErrorDesc.Text = String.Empty;
                tbxRemark.Text = String.Empty;
            }
        }

        private void cmbTechnician_Click(object sender, EventArgs e)
        {
            setTechnicians();
        }
    }
}
