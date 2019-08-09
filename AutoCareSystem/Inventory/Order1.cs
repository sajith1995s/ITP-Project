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
    public partial class Order1 : UserControl
    {
        OrderController oc;
        public Order1()
        {
            InitializeComponent();
            oc = new OrderController();
        }

        private void Order1_Load(object sender, EventArgs e)
        {
            initialization();
            BindGridView(null);

            rbReceived.Checked = false;
            rbNotReceived.Checked = false;
            rbReceived.Enabled = false;
            rbNotReceived.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void initialization()
        {
            //code here
        }

        private void BindGridView(String skey)
        {
           
            try
            {
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = oc.getOrderDetails(skey);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

       
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            btnRemove.Cursor = Cursors.Hand;
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            loadOrderedItems(Convert.ToString(selectedRow.Cells[0].Value));
            if (Convert.ToString(selectedRow.Cells[3].Value) == "Received")
            {
                rbReceived.Enabled = false;
                rbNotReceived.Enabled = false;
                rbReceived.Checked = true;
                rbNotReceived.Checked = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                rbReceived.Enabled = true;
                rbNotReceived.Enabled = true;
                rbReceived.Checked = false;
                rbNotReceived.Checked = true;
            }
        }

        private void loadOrderedItems(String order_code)
        {
                       try
            {
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = oc.getOrderItemsDetails(order_code);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String order_code = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                oc.removeOrder(order_code);
                BindGridView(null);         //reload table
                
            }
        }
       
   
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String status = (rbReceived.Checked) ? "Received" : "Not Received";
            String order_code = Convert.ToString(selectedRow.Cells[0].Value);

            if (oc.updateOrderStatus(status, order_code)) { 
                BindGridView(null);
                MyDialog.Show("Success...!", "Order Received Status Updated ");
            }
            else
            {
                MyDialog.Show("Error...!", "Order Status Not Updated");
            }

        }

        private void Order1_DoubleClick(object sender, EventArgs e)
        {
            BindGridView(null);
        }
    }
}
