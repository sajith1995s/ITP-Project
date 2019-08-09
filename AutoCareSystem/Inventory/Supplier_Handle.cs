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
    public partial class Supplier_Handle : UserControl
    {
        SupplierController sc;

        public Supplier_Handle()
        {
            InitializeComponent();
            sc = new SupplierController();

        }

        private void Supplier_Handle_Load(object sender, EventArgs e)
        {
            
            BindGridView(null);
            enableButtons(false);
        }

        public void SetGridViewWidth()
        {
            bunifuCustomDataGrid1.Columns[0].Width = 70;
            bunifuCustomDataGrid1.Columns[1].Width = 150;
            bunifuCustomDataGrid1.Columns[2].Width = 70;
            bunifuCustomDataGrid1.Columns[3].Width = 70;
            bunifuCustomDataGrid1.Columns[4].Width = 70;
            bunifuCustomDataGrid1.Columns[5].Width = 150;
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
                DataTable dt = sc.getSupplierDetails(skey);
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


     
        private void addNewSupplier()
        {
         

            Supplier s_data = new Supplier();
            s_data.SupplierName = txtSupName.Text;
            s_data.Address1 = txtAddress1.Text;
            s_data.Address2 = txtAddress2.Text;
            s_data.PhoneNumber = txtphone.Text;
            s_data.Email = txtEmail.Text;

            if (sc.addSupplier(s_data))
            {
                MyDialog.Show("Success...!", "Supplier Registered");
                resetFields();
                BindGridView(null);
            }
            else
            {
                MyDialog.Show("Error...!", "Supplier Not Registered");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSupName.Text) ||
                 String.IsNullOrWhiteSpace(txtAddress1.Text) ||
                 String.IsNullOrWhiteSpace(txtAddress2.Text) ||
                 String.IsNullOrWhiteSpace(txtphone.Text) ||
                 String.IsNullOrWhiteSpace(txtEmail.Text))

                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {
                if (Validator.IsValidName(txtSupName.Text))
                {
                    if (Validator.IsValidEmail(txtEmail.Text))
                    {
                        if (Validator.IsValidPhonenumber(txtphone.Text))
                        {
                            addNewSupplier();
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Invalid Telephone Number");
                        }
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Invalid Email Address");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Invalid Supplier Name");
                }


                
                
            } 
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            txtSupName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtAddress1.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtAddress2.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtphone.Text = Convert.ToString(selectedRow.Cells[4].Value);
            txtEmail.Text = Convert.ToString(selectedRow.Cells[5].Value);
           
            

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
            String sup_code = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sc.removeSupplier(sup_code);
                BindGridView(null);         //reload table
                resetFields();          //reset all input fields
            }
        }


        private void resetFields()
        {
            txtSupName.Text = string.Empty;
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            bunifuCustomDataGrid1.ClearSelection();
            enableButtons(false);
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            String sup_code = Convert.ToString(selectedRow.Cells[0].Value);
           

            if (String.IsNullOrWhiteSpace(txtSupName.Text) ||
                String.IsNullOrWhiteSpace(txtAddress1.Text) ||
                String.IsNullOrWhiteSpace(txtAddress2.Text) ||
                String.IsNullOrWhiteSpace(txtphone.Text) ||
                String.IsNullOrWhiteSpace(txtEmail.Text)
                )

                MyDialog.Show("Error...!", "Please fill all fields");

            else
            {
                if (Validator.IsValidName(txtSupName.Text))
                {
                    if (Validator.IsValidEmail(txtEmail.Text))
                    {
                        if (Validator.IsValidPhonenumber(txtphone.Text))
                        {
                            Supplier s_data = new Supplier();
                            s_data.SupplierCode = sup_code;
                            s_data.SupplierName = txtSupName.Text;
                            s_data.Address1 = txtAddress1.Text;
                            s_data.Address2 = txtAddress2.Text;
                            s_data.PhoneNumber = txtphone.Text;
                            s_data.Email = txtEmail.Text;

                            if (sc.updateSupplier(s_data))
                            {
                                BindGridView(null);
                                resetFields();
                                MyDialog.Show("Success...!", "Supplier updated");
                            }
                            else
                            {
                                MyDialog.Show("Error...!", "Supplier not updated");
                            }
                        }
                        else
                            MyDialog.Show("Error...!", "Invalid Telephone Number");

                    }
                    else
                        MyDialog.Show("Error...!", "Invalid Email Address");
                }
                else
                    MyDialog.Show("Error...!", "Invalid Supplier Name");

            }
        }

       

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
           // BindGridView(((tbxSearch.Text.Length >= 7) ? tbxSearch.Text : null));
            BindGridView(tbxSearch.Text);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (Validator.IsValidName(txtSupName.Text))
                BindGridView(tbxSearch.Text);
            else
                MyDialog.Show("Error...!", "Invalid Supplier Number");
        }
    }
}
