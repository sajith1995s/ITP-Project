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
    public partial class add_repair_types : UserControl
    {
        private RepairController rc;

        public add_repair_types()
        {
            InitializeComponent();
            rc = new RepairController();
        }

        private void add_repair_types_Load(object sender, EventArgs e)
        {
            enableButtons(false);
            BindGridView(null);
        }

        private void BindGridView(String skey)
        {
            try
            {
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = rc.getRepairTypeDetails(skey);
                SetGridViewWidth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void SetGridViewWidth()
        {
            bunifuCustomDataGrid1.Columns[0].Width = 50;
            bunifuCustomDataGrid1.Columns[1].Width = 250;
            bunifuCustomDataGrid1.Columns[2].Width = 400;
            bunifuCustomDataGrid1.Columns[3].Width = 80;

        }

        private void btnAddRepairType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxRepairTypeName.Text) || 
                string.IsNullOrWhiteSpace(tbxDesc.Text) || 
                string.IsNullOrWhiteSpace(tbxCharges.Text))
            {
                MyDialog.Show("Error...!", "Please fill all fields");
            }
            else
            {
                if (Validator.IsValidName(tbxRepairTypeName.Text))
                {
                    if (Validator.IsValidCharges(tbxCharges.Text))
                        addNewRepairType();
                    else
                        MyDialog.Show("Error...!", "Invalid charges");
                }
                else
                {
                    MyDialog.Show("Error...!", "Repair Type Name is invalid");
                }
            }
        }

        private void addNewRepairType()
        {
            Repair rp = new Repair();
            rp.RepairTypeName = tbxRepairTypeName.Text;
            rp.RepairTypeDesc = tbxDesc.Text;
            rp.RepairTypeCharges = tbxCharges.Text;

            if (rc.addNewRepairType(rp))
            {
                MyDialog.Show("Success...!", "New Repair Type Added");
                resetFields();
                BindGridView(null);
            }
            else
            {
                MyDialog.Show("Error...!", "Fail to create new repair type");
            }
        }

        private void resetFields()
        {
            try
            {
                bunifuCustomDataGrid1.ClearSelection();
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }
            tbxRepairTypeName.Text = string.Empty;
            tbxDesc.Text = string.Empty;
            tbxCharges.Text = string.Empty;
            enableButtons(false);
        }

        private void enableButtons(bool b)
        {
            btnRemove.Enabled = b;
            btnUpdate.Enabled = b;
            btnAddRepairType.Enabled = !b;

            btnAddRepairType.Cursor = (!b) ? Cursors.Hand : Cursors.Default;
            btnRemove.Cursor = (b) ? Cursors.Hand : Cursors.Default;
            btnUpdate.Cursor = (b) ? Cursors.Hand : Cursors.Default;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            loadTexts(selectedRow);
            enableButtons(true);
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            tbxRepairTypeName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            tbxDesc.Text = Convert.ToString(selectedRow.Cells[2].Value);
            tbxCharges.Text = Convert.ToString(selectedRow.Cells[3].Value);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String id = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                rc.removeRepairType(id);
                BindGridView(null);
                resetFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String id = Convert.ToString(selectedRow.Cells[0].Value);

            if (Validator.IsValidName(tbxRepairTypeName.Text))
            {
                if (Validator.IsValidCharges(tbxCharges.Text))
                {
                    Repair rp = new Repair();
                    rp.RepairTypeId = id;
                    rp.RepairTypeName = tbxRepairTypeName.Text;
                    rp.RepairTypeDesc = tbxDesc.Text;
                    rp.RepairTypeCharges = tbxCharges.Text;

                    if(rc.updateRepairType(rp))
                    {
                        MyDialog.Show("Success...!", "Repair Type Updated");
                        BindGridView(null);
                        resetFields();
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Fail to update repair type");
                    }
                }
                else
                    MyDialog.Show("Error...!", "Invalid charges");
            }
            else
            {
                MyDialog.Show("Error...!", "Repair Type Name is invalid");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }

        private void bunifuMaterialTextbox4_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }
    }
}
