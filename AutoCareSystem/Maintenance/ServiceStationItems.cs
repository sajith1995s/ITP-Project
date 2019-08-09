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
using Bunifu.Framework.UI;
using AutoCareSystem;
using System.Text.RegularExpressions;

namespace AutoCareSystem
{
    public partial class ServiceStationItems : UserControl
    {
        public ServiceStationItems()
        {
            InitializeComponent();
        }

        private void BindGridView(String skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                     query = "SELECT  e.item_code, e.item_name, e.item_info, e.item_invoice_id, e.item_price, e.item_condition, s.full_name , e.warrenty_exp_date FROM equipments e LEFT OUTER JOIN suppliers s ON e.sup_code = s.sup_code WHERE e.status = 1";
                else    
                     query = "SELECT  e.item_code, e.item_name, e.item_info, e.item_invoice_id, e.item_price, e.item_condition, s.full_name , e.warrenty_exp_date FROM equipments e LEFT OUTER JOIN suppliers s ON e.sup_code = s.sup_code WHERE e.item_name LIKE '%" + skey+"%' AND e.status = 1";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                db.closeConnection();

                bunifuCustomDataGrid1.Columns[1].Visible = false;
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

        private void setSuppliers()
        {
            try
            {
                string query = "SELECT sup_code, full_name  FROM suppliers";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                db.closeConnection();

                Dictionary<string, string> comboSource = new Dictionary<string, string>();

                foreach (DataRow row in dt.Rows)
                {
                    String id = Convert.ToString(row["sup_code"]);
                    String name = Convert.ToString(row["full_name"]);
                    comboSource.Add(id, name);
                }

                combosupname.DataSource = new BindingSource(comboSource, null);
                combosupname.DisplayMember = "Value";
                combosupname.ValueMember = "Key";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            txtcode.Text = Convert.ToString(selectedRow.Cells[0].Value);
            txtname.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtinfo.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txtinvoiceid.Text = Convert.ToString(selectedRow.Cells[3].Value);
            txtprice.Text = Convert.ToString(selectedRow.Cells[4].Value);

            int index1 = combocondition.FindString(Convert.ToString(selectedRow.Cells[5].Value));
            combocondition.SelectedIndex = index1;

            int index2 = combosupname.FindString(Convert.ToString(selectedRow.Cells[6].Value));
            combosupname.SelectedIndex = index2;

            warrentydate.Value = DateTime.Parse(Convert.ToString(selectedRow.Cells[7].Value));
        }

        private void bunifuCustomDataGrid1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            loadTexts(selectedRow);
            btnUpdate.Enabled = true;
            btnRemove.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void ServiceStationItems_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            setSuppliers();
            resetFields();
            txtcode.Enabled = false;
            txtcode.Text = CodeGenerator.generateItemCode();
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
          //  warrentydate.MinDate = DateTime.Now ;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void addNewEquipment()
        {
            string itemid = CodeGenerator.generateItemCode();
            string itemsupid = ((KeyValuePair<string, string>)combosupname.SelectedItem).Key;
            string itemwarexpdate = warrentydate.Value.ToString("yyyy-MM-dd");
            int status = 1;
            string query = "INSERT INTO equipments VALUES('" + itemid + "','" + txtname.Text + "','" + txtinfo.Text + "','" + txtinvoiceid.Text + "','" + txtprice.Text + "','" + combocondition.SelectedItem + "','" + itemsupid + "','" + itemwarexpdate + "','" + status + "')";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            if (db.nonQuery())
            {
                MyDialog.Show("Success...!", "Equipment Registered.");
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
                if(Validator.IsValidFutureDate(warrentydate.Value))
                {
                    if(Validator.IsValidNameWithSpaces(txtname.Text))
                    {
                        if(Validator.IsValidIntNumber(txtinvoiceid.Text) && Validator.IsValidPrice(txtprice.Text))
                        {
                            addNewEquipment();
                            BindGridView(null);
                            resetFields();
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Plese Enter correct invoiceID , Price!");
                        }
                    }else
                    {
                        MyDialog.Show("Error...!", "Plese Enter correct name!");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Plese Enter Future Date!");
                }
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void resetFields()
        {
            txtcode.Text = string.Empty;
            txtcode.Text = CodeGenerator.generateItemCode();
            txtname.Text = string.Empty;
            txtinfo.Text = string.Empty;
            txtinvoiceid.Text = string.Empty;
            txtprice.Text = string.Empty;
            combocondition.SelectedIndex = -1;
            combosupname.SelectedIndex = -1;
            bunifuCustomDataGrid1.ClearSelection();
            warrentydate.Value = DateTime.Now;
            tbxSearch.Text = null;
            BindGridView(null);
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
                if (Validator.IsValidFutureDate(warrentydate.Value))
                {
                    if (Validator.IsValidNameWithSpaces(txtname.Text))
                    {
                        if (Validator.IsValidIntNumber(txtinvoiceid.Text) && Validator.IsValidPrice(txtprice.Text))
                        {
                            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                            String id = Convert.ToString(selectedRow.Cells[0].Value);
                            string name = txtname.Text;
                            string info = txtinfo.Text;
                            int invoiceid = Convert.ToInt32(txtinvoiceid.Text);
                            decimal price = Convert.ToDecimal(txtprice.Text);
                            string exp_date = warrentydate.Value.ToString("yyyy-MM-dd");
                            string query = "UPDATE equipments SET  item_name = '" + name + "', item_info = '" + info + "', item_invoice_id = '" + invoiceid + "', item_price = '" + price + "', warrenty_exp_date = '" + exp_date + "' WHERE item_code = '" + id + "'";
                            Database db = new Database();
                            db.openConnection();
                            db.sqlQuery(query);
                            db.nonQuery();
                            db.closeConnection();
                            BindGridView(null);
                            resetFields();
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Plese Enter correct invoiceID , Price!");
                        }
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Plese Enter correct name!");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Plese Enter Future Date!");
                }
            }
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(((tbxSearch.Text.Length >= 1) ? tbxSearch.Text : null));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String id = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to Remove this item ??",
                                     "Confirm Removed!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "UPDATE equipments SET status = 0 WHERE item_code = '" + id + "'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);     //pass query to sql query method 
                db.nonQuery();          //pass the cmd to nonQuery method(for Insert)
                db.closeConnection();
                BindGridView(null);         //reload table
                resetFields();          //reset all input fields
            }

            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            btnAdd.Enabled = true;
        }

        private bool isEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtinfo.Text) || string.IsNullOrWhiteSpace(txtinvoiceid.Text) || string.IsNullOrWhiteSpace(txtprice.Text) || combocondition.SelectedItem.Equals("") || combosupname.SelectedItem.Equals("") )
            {
                return false;
            }else
            {
                return true;
            }
        }

       
    }

}
