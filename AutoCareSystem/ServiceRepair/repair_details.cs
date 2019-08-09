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
    public partial class repair_details : UserControl
    {
        private RepairController rc;

        public repair_details()
        {
            InitializeComponent();
            rc = new RepairController();
        }

        private void new_repair_details_Load(object sender, EventArgs e)
        {
            BindGridView();
            setRepairTypes();
            enableButton(false,0);
            cmbFilter.SelectedIndex = 0;
            btnRemoveRepair.Enabled = false;
            btnRemoveRepair.Cursor = Cursors.Default;
        }

        private void enableButton(bool b, int i)
        {
            if (i==0)
            {
                btnRepairTypeRemove.Enabled = b;
                btnRepairTypeAdd.Enabled = b;
            }
            else if (i == 1)
            {
                btnRepairTypeRemove.Enabled = !b;
                btnRepairTypeAdd.Enabled = b;
            }
            else
            {
                btnRepairTypeRemove.Enabled = b;
                btnRepairTypeAdd.Enabled = !b;
            }

            btnRepairTypeRemove.Cursor = (btnRepairTypeRemove.Enabled) ? Cursors.Hand : Cursors.Default;
            btnRepairTypeAdd.Cursor = (btnRepairTypeAdd.Enabled) ? Cursors.Hand : Cursors.Default;
        }

        private void BindGridView()
        {
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuCustomDataGrid1.DataSource = rc.getRepairDetails();
        }

        private void setRepairTypes()
        {
            DataTable dt = rc.getRepairTypes();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();

            foreach (DataRow row in dt.Rows)
            {
                String id = Convert.ToString(row["rtid"]);
                String name = Convert.ToString(row["name"]);
                comboSource.Add(id, name);
            }

            cmbRepairTypes.DataSource = new BindingSource(comboSource, null);
            cmbRepairTypes.DisplayMember = "Value";
            cmbRepairTypes.ValueMember = "Key";
        }

        private void btnRepairTypeAdd_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            Repair rp = new Repair();
            rp.RepairCode = Convert.ToString(selectedRow.Cells[0].Value);
            rp.ProvidedRepairId = ((KeyValuePair<string, string>)cmbRepairTypes.SelectedItem).Key;

            if (!rc.isProvidedRepairExists(rp))
            {
                if (rc.addProvidedRepair(rp))
                {
                    MyDialog.Show("Success...!", "Repair added");
                    loadSubGridView(Convert.ToString(selectedRow.Cells[0].Value));
                }
            }
            else
            {
                MyDialog.Show("Opps...!", "This Repair Already Exists");
            }
        }

        

        private void loadSubGridView(String id)
        {
            try
            {
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = rc.getProvidedRepairDetails(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enableButton(true, 1);
            btnRemoveRepair.Enabled = true;
            btnRemoveRepair.Cursor = Cursors.Hand;

            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            loadSubGridView(Convert.ToString(selectedRow.Cells[0].Value));
        }

        private void bunifuCustomDataGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enableButton(true, 2);
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            int index = cmbRepairTypes.FindString(Convert.ToString(selectedRow.Cells[0].Value));
            cmbRepairTypes.SelectedIndex = index;
        }

        private void btnRepairTypeRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            String id = Convert.ToString(selectedRow.Cells[0].Value);
            String key = ((KeyValuePair<string, string>)cmbRepairTypes.SelectedItem).Key;

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                rc.removeProvidedRepair(id,key);
                loadSubGridView(id);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.ClearSelection();
            bunifuCustomDataGrid2.DataSource = null;
            cmbFilter.SelectedIndex = 0;
            cmbRepairTypes.SelectedIndex = 0;
            tbxSearchBox.Text = string.Empty;
            btnRemoveRepair.Enabled = false;
            btnRemoveRepair.Cursor = Cursors.Default;
            BindGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (tbxSearchBox.Text.Length > 0)
                if (cmbFilter.SelectedIndex == 0)
                {
                    if (Validator.IsValidVehicleNumber(tbxSearchBox.Text))
                        serachRepairedVehicles(tbxSearchBox.Text, (cmbFilter.SelectedIndex == 0));
                    else
                        MyDialog.Show("Error...!", "Invalid Vehicle Number");
                }
                else
                {
                    if (Validator.IsValidPrimaryCode(tbxSearchBox.Text, "R"))
                        serachRepairedVehicles(tbxSearchBox.Text, (cmbFilter.SelectedIndex == 0));
                    else
                        MyDialog.Show("Error...!", "Invalid Repair Code");
                }
            else
                MyDialog.Show("Opps!", "Search key cannot be empty");
        }

        private void serachRepairedVehicles(string skey, bool b)
        {
            try
            {
                DataTable dt = rc.getRepairedVehicles(skey,b);
                if (dt != null && dt.Rows.Count > 0)
                {
                    bunifuCustomDataGrid2.DataSource = null;
                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bunifuCustomDataGrid1.DataSource = dt;
                }
                else
                {
                    MyDialog.Show("Opps!", "No repairs found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void tbxSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void btnRemoveRepair_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            String id = Convert.ToString(selectedRow.Cells[0].Value);
            String key = ((KeyValuePair<string, string>)cmbRepairTypes.SelectedItem).Key;

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                rc.removeRepair(id);
                BindGridView();
                bunifuCustomDataGrid2.DataSource = null;
            }
        }

        private void repair_details_DoubleClick(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void cmbRepairTypes_Click(object sender, EventArgs e)
        {
            setRepairTypes();
        }

        private void cmbFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            tbxSearchBox.Text = (cmbFilter.SelectedIndex == 0) ? "Vehicle Number" : "Repair Code";
            tbxSearchBox.HintText = (cmbFilter.SelectedIndex == 0) ? "Vehicle Number" : "Repair Code";
        }

        private void tbxSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Search();
            }
        }
    }
}
