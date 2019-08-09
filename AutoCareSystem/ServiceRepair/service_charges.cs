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
    public partial class service_charges : UserControl
    {
        ServiceController sc;

        public service_charges()
        {
            InitializeComponent();
            sc = new ServiceController();
        }

        private void service_charges_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            tbxServiceName.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate.Cursor = Cursors.Default;
        }

        private void BindGridView(String skey)
        {
            try
            {
                DataTable dt = sc.getServiceTypes(skey);
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                if(dt != null && dt.Rows.Count > 0)
                    SetGridViewWidth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        public void SetGridViewWidth()
        {
            bunifuCustomDataGrid1.Columns[0].Width = 30;
            bunifuCustomDataGrid1.Columns[1].Width = 200;
            bunifuCustomDataGrid1.Columns[2].Width = 300;
            bunifuCustomDataGrid1.Columns[3].Width = 80;
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnUpdate.Cursor = Cursors.Hand;
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];

            tbxServiceName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            tbxCharges.Text = Convert.ToString(selectedRow.Cells[3].Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid1.Rows[selectedrowindex];
            string id = Convert.ToString(selectedRow.Cells[0].Value);
            string charges = tbxCharges.Text;
            if (Validator.IsValidCharges(charges))
            {
                if (sc.updateServiceTypeCharges(id, charges))
                {
                    MyDialog.Show("Success...!", "Service Charges updated");
                    BindGridView(null);
                    resetFields();
                }
                else
                {
                    MyDialog.Show("Error...!", "Service Charges not updated");
                }
            }
            else
            {
                MyDialog.Show("Error...!", "Invalid Charges");
            }
        }

        private void resetFields()
        {
            btnUpdate.Enabled = false;
            btnUpdate.Cursor = Cursors.Default;
            tbxServiceName.Text = String.Empty;
            tbxCharges.Text = String.Empty;
            bunifuCustomDataGrid1.ClearSelection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }
    }
}
