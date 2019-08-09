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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace AutoCareSystem
{
    public partial class payment_details : UserControl
    {
        private PaymentController pc;

        public payment_details()
        {
            InitializeComponent();
            pc = new PaymentController();
        }

        private void repair_payment_Load(object sender, EventArgs e)
        {
            resetFields();
            cmbFilter.SelectedIndex = 0;
        }

        private void tbxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void BindGridView(String skey)
        {
            try
            {
                DataTable dt = pc.getRepairOrServiceList(skey, cmbFilter.SelectedIndex);
                if (dt != null && dt.Rows.Count > 0)
                {

                    bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bunifuCustomDataGrid1.DataSource = dt;
                    loadCustomerDetails(skey);
                }
                else
                {
                    MyDialog.Show("Error...!", "Vehicle Number Not Available");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void resetFields()
        {
            bunifuCustomDataGrid1.DataSource = null;
            bunifuCustomDataGrid2.DataSource = null;
            lblCharges.Text = String.Empty;
            lblModel.Text = String.Empty;
            lblFullName.Text = String.Empty;
            lblPhoneNo.Text = String.Empty;
            enableButton(false);
        }

        private void enableButton(bool b)
        {
            btnReceipt.Enabled = b;
            btnReceipt.Cursor = (b) ? Cursors.Hand : Cursors.Default;

        }

        private void loadCustomerDetails(String skey)
        {
            try
            {
                Vehicle vh = pc.getCustomerBasicInfo(skey);
                lblModel.Text = vh.Model;
                lblFullName.Text = vh.CustomerName;
                lblPhoneNo.Text = vh.PhoneNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            loadSubGridView(Convert.ToString(selectedRow.Cells[0].Value),(cmbFilter.SelectedIndex==0));
        }

        private void loadSubGridView(String id, bool b)
        {
            try
            {
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DataTable dt = pc.getProvidedTasks(id, b);
                bunifuCustomDataGrid2.DataSource = dt;
                calculateTotal(dt);
                enableButton(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void calculateTotal(DataTable dt)
        {
            int charges = 0;

            foreach (DataRow row in dt.Rows)
                charges = charges + Convert.ToInt32(row["charges"]);
            

            lblCharges.Text = Convert.ToString(charges);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearchBox.Text.Length > 0)
            {
                if (Validator.IsValidVehicleNumber(tbxSearchBox.Text))
                {
                    resetFields();
                    BindGridView(tbxSearchBox.Text);
                }
                else
                {
                    MyDialog.Show("Error...!", "Invalid Vehicle Number");
                }
            }
            else
            {
                MyDialog.Show("Opps!", "Search Box is empty");
            }
        }

        private void tbxSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSearchBox.Text = String.Empty;
            resetFields();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            String code = Convert.ToString(selectedRow.Cells[0].Value);

            if (!pc.isInvoiceReceived(code,cmbFilter.SelectedIndex)) {
                pc.addNewInvoicedetails(code, cmbFilter.SelectedIndex, lblCharges.Text);
            }
            new ReceiptView(code, cmbFilter.SelectedIndex, 
                pc.getInvoiceNumber(code,cmbFilter.SelectedIndex), 
                pc.getInvoiceDate(code, cmbFilter.SelectedIndex)).Show();
        }
    }
}
