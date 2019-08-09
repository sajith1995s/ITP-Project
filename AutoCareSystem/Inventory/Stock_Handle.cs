using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCareSystem;
using System.Data.SqlClient;
  
namespace AutoCareSystem
{
    public partial class Stock_Handle : UserControl
    {
       StockController stc;

        public Stock_Handle()
        {
            InitializeComponent();
            stc = new StockController();

        }

        private void Stock_Handle_Load(object sender, EventArgs e)
        {
            setSupplierName();
            BindGridView(null);
            enableButtons(false);
            cmbType.SelectedIndex = 0;
        }

        //public void SetGridViewWidth()
        //{
        //    bunifuCustomDataGrid1.Columns[0].Width = 30;
        //    bunifuCustomDataGrid1.Columns[1].Width = 70;
        //    bunifuCustomDataGrid1.Columns[2].Width = 40;
        //    bunifuCustomDataGrid1.Columns[3].Width = 40;
        //    bunifuCustomDataGrid1.Columns[4].Width = 40;
           
        //}


        private void setSupplierName()
        {
           
            try
            {
                DataTable dt = stc.getSupDetails();
                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                foreach (DataRow row in dt.Rows)
                {
                    String id = Convert.ToString(row["sup_code"]);
                    String name = Convert.ToString(row["full_name"]);
                    comboSource.Add(id, name);
                }

                cmbSup.DataSource = new BindingSource(comboSource, null);
                cmbSup.DisplayMember = "Value";
                cmbSup.ValueMember = "Key";
            }
            catch (Exception e)
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
                DataTable dt = stc.getStockDetails(skey);
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                //SetGridViewWidth();

                bunifuCustomDataGrid1.Columns[4].Visible = false;
                bunifuCustomDataGrid1.Columns[6].Visible = false;
                bunifuCustomDataGrid1.Columns[7].Visible = false;
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


        private void addNewItem()
        {

            string key = ((KeyValuePair<string, string>)cmbSup.SelectedItem).Key;
            string type = cmbType.SelectedItem.ToString();

            Stock st_data = new Stock();
            st_data.SupName = key;
            st_data.Type = type;
            st_data.ItemName = txtName.Text;
            st_data.Brand = txtBrand.Text;
            st_data.Description = txtDescription.Text;
            st_data.Quantity = txtQty.Text;
            st_data.UnitPrice = txtPrice.Text;

            if (stc.addItem(st_data))
            {
                MyDialog.Show("Success...!", "Item Registered");
                resetFields();
                BindGridView(null);
            }
            else
            {
                MyDialog.Show("Error...!", "Item Not Registered");
            }
        }

       

        public void loadTexts(DataGridViewRow selectedRow)
        {

           
            txtName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtBrand.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtPrice.Text = Convert.ToString(selectedRow.Cells[5].Value);
            txtQty.Text = Convert.ToString(selectedRow.Cells[6].Value);
            txtDescription.Text = Convert.ToString(selectedRow.Cells[7].Value);

            int index = cmbSup.FindString(Convert.ToString(selectedRow.Cells[2].Value));
            cmbSup.SelectedIndex = index;
            int index1 = cmbType.FindString(Convert.ToString(selectedRow.Cells[3].Value));
            cmbType.SelectedIndex = index1;


        }

        private void resetFields()
        {
          
            cmbType.ResetText();
            cmbSup.ResetText();
            txtName.Text = string.Empty;
            txtBrand.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtDescription.Text = string.Empty;
            bunifuCustomDataGrid1.ClearSelection();
            enableButtons(false);
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



        

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //BindGridView(tbxSearch.Text);
            BindGridView(((tbxSearch.Text.Length >= 4) ? tbxSearch.Text : null));

        }


        private void btnRemove_Click_1(object sender, EventArgs e)
        {
           
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String item_code = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                stc.removeItem(item_code);
                BindGridView(null);         //reload table
                resetFields();          //reset all input fields
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                 String.IsNullOrWhiteSpace(txtBrand.Text) ||
                 String.IsNullOrWhiteSpace(txtPrice.Text) ||
                 String.IsNullOrWhiteSpace(txtQty.Text) ||
                 String.IsNullOrWhiteSpace(txtDescription.Text))

                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {

                if (Validator.IsValidNumber(txtQty.Text))
                {

                    if (Validator.IsValidPrice(txtPrice.Text))
                    {

                        addNewItem();

                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Invalid Price");
                    }

                }
                else
                {
                    MyDialog.Show("Error...!", "Invalid Quantity");
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            String item_code = Convert.ToString(selectedRow.Cells[0].Value);
            String type = cmbType.SelectedItem.ToString();
            string sup_name = ((KeyValuePair<string, string>)cmbSup.SelectedItem).Key;

            if (String.IsNullOrWhiteSpace(txtName.Text) ||
                String.IsNullOrWhiteSpace(txtBrand.Text) ||
                String.IsNullOrWhiteSpace(txtPrice.Text) ||
                String.IsNullOrWhiteSpace(txtQty.Text) ||
                String.IsNullOrWhiteSpace(txtDescription.Text))


                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {
                if (Validator.IsValidNumber(txtQty.Text))
                {

                    if (Validator.IsValidPrice(txtPrice.Text))
                    {
                            Stock st_data = new Stock();
                            st_data.ItemCode = item_code;
                            st_data.SupName = sup_name;
                            st_data.ItemName = txtName.Text;
                            st_data.Type = type;
                            st_data.Brand = txtBrand.Text;
                            st_data.Description = txtDescription.Text;
                            st_data.Quantity = txtQty.Text;
                            st_data.UnitPrice = txtPrice.Text;

                        if (stc.updateItem(st_data))
                            {
                                BindGridView(null);
                                resetFields();
                                MyDialog.Show("Success...!", "Item updated");
                            }
                            else
                            {
                                MyDialog.Show("Error...!", "Item not updated");
                            }
                        }
                        else
                            MyDialog.Show("Error...!", "Invalid Price");

                }

                else
                    MyDialog.Show("Error...!", "Invalid Quantity");

            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            resetFields();
        }

        private void cmbSup_Click(object sender, EventArgs e)
        {
            setSupplierName();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //if (Validator.IsValidVehicleNumber(tbxSearch.Text))
            //    BindGridView(tbxSearch.Text);
            //else
            //    MyDialog.Show("Error...!", "Invalid Vehicle Number");
        }
    }
}