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
    public partial class Order2 : UserControl
    {
        OrderController oc;

        private string item_name;

        public Order2()
        {
            InitializeComponent();
            oc = new OrderController();
        }



        private void BindGridView(String skey)
        {
            try
            {
                DataTable dt = oc.getOutOfStockDetails(skey);
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void loadTexts(DataGridViewRow selectedRow)
        {
            tbxCode.Text = Convert.ToString(selectedRow.Cells[0].Value);
            lblName.Text = Convert.ToString(selectedRow.Cells[1].Value);
        }

        private void Order2_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            setSupplierName();

            enableFields(false);
            btnPrint.Enabled = false;
            btnPrint.Cursor = Cursors.Default;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

                loadTexts(selectedRow);
                enableFields(true);

            }
        }

        private void enableFields(bool b)
        {
            btnAdd.Enabled = b;
            btnAdd.Cursor = (b) ? Cursors.Hand : Cursors.Default;

            tbxQty.Enabled = b;
            tbxPrice.Enabled = b;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (tbxQty.Text.Length > 0 && tbxPrice.Text.Length > 0)
            {
                if (Validator.IsValidNumber(tbxQty.Text))
                {
                    if (Validator.IsValidPrice(tbxPrice.Text))
                    {

                        string code = tbxCode.Text;
                        if (!checkItemExists(code)) {
                            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
                            string name = (item_name != null) ? item_name : Convert.ToString(selectedRow.Cells[2].Value);
                            string qty = tbxQty.Text;
                            string price = tbxPrice.Text;
                            string[] row = { code, name, qty, price };
                            bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            bunifuCustomDataGrid2.Rows.Add(row);
                            item_name = null;
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Item Already Exists");
                        }
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
            else
            {
                MyDialog.Show("Error..!", "Price  && Quantity Required");
            }


        }

        private void setSupplierName()
        {
            try
            {
                try
                {
                    DataTable dt = oc.getSupDetails();
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

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = bunifuCustomDataGrid2.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                bunifuCustomDataGrid2.Rows.RemoveAt(bunifuCustomDataGrid2.CurrentCell.RowIndex);
            }
            else
            {
                changeSubButtons();
            }
        }

        private void tbxCode_KeyUp(object sender, KeyEventArgs e)
        {
            checkForItemCode(tbxCode.Text);
        }

        private void checkForItemCode(String skey)
        {
            try
            {
                DataTable dt = oc.getItemCode(skey);
                if (dt != null && dt.Rows.Count == 1)
                {
                    item_name = Convert.ToString(dt.Rows[0]["name"]);
                    lblName.Text = item_name;
                    enableFields(true);
                }
                else
                {
                    item_name = null;
                    lblName.Text = String.Empty;
                    enableFields(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void calculateTotal()
        {
            double charges = 0;
            foreach (DataGridViewRow row in bunifuCustomDataGrid2.Rows)
            {
                charges = charges + (Convert.ToInt32(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value));
            }

            lblTotalAmount.Text = charges.ToString("0.######");
        }


        private void bunifuCustomDataGrid2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            changeSubButtons();
            calculateTotal();
        }

        private void changeSubButtons()
        {
            btnPrint.Enabled = (bunifuCustomDataGrid2.Rows.Count > 0);
            btnPrint.Cursor = ((bunifuCustomDataGrid2.Rows.Count > 0) ? Cursors.Hand : Cursors.Default);
            btnRemove.Enabled = (bunifuCustomDataGrid2.Rows.Count > 0);
            btnRemove.Cursor = ((bunifuCustomDataGrid2.Rows.Count > 0) ? Cursors.Hand : Cursors.Default);
        }     


        private void cmbSup_Click(object sender, EventArgs e)
        {
            setSupplierName();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            string sup_code = ((KeyValuePair<string, string>)cmbSup.SelectedItem).Key;
            String order_date = orderDate.Value.ToString("yyyy-MM-dd");
            String order_code = CodeGenerator.generateOrderCode();
            if (Validator.IsValidPastDate(order_date))
            {
                Order odr = new Order();
                odr.OrderCode = order_code;
                odr.SuppCode = sup_code;
                odr.OrderDate = orderDate.Value;
                if (oc.addNewOrder(odr))
                {
                    MyDialog.Show("Success...!", "Order Registered");
                    oc.AddOrderItems(bunifuCustomDataGrid2);
                    resetFields();
                    new Receipt(order_code,order_date).Show();
                }
                else
                {
                    MyDialog.Show("Error...!", "Order Not Registered");
                }
            }
            else
            {
                MyDialog.Show("Error...!", "Invalid Order date");
            }
        }

        private void resetFields()
        {
            tbxCode.Text = String.Empty;
            tbxQty.Text = String.Empty;
            tbxPrice.Text = String.Empty;
            lblName.Text = String.Empty;
            bunifuCustomDataGrid2.DataSource = null;
            bunifuCustomDataGrid2.Rows.Clear();
            lblTotalAmount.Text = "0000";
            cmbSup.SelectedIndex = 0;
            orderDate.Value = DateTime.Today.AddDays(0);
        }

        private bool checkItemExists(String o_code)
        {
            bool found = false;
            foreach (DataGridViewRow row in bunifuCustomDataGrid2.Rows)
            {
                if (row.Cells[0].Value.Equals(o_code))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }
    }
    
}

    