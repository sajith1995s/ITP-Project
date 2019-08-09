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
    public partial class service_details : UserControl
    {
        ServiceController sc;

        public service_details()
        {
            InitializeComponent();
            sc = new ServiceController();

        }

        private void service_details_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnRemove.Cursor = Cursors.Default;
            BindGridView(null);
        }

        private void BindGridView(String skey)
        {
            try
            {
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = sc.getServicesDetails(skey);
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
            lblVehicleNo.Text = Convert.ToString(selectedRow.Cells[1].Value);
            loadProvidedServices(Convert.ToString(selectedRow.Cells[0].Value));
        }

        private void loadProvidedServices(String s_code)
        {
            try
            {
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = sc.getProvidedServicesDetails(s_code);
                lblTotalServices.Text = bunifuCustomDataGrid2.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
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
                sc.removeService(id);
                BindGridView(null);
                bunifuCustomDataGrid2.DataSource = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Validator.IsValidVehicleNumber(tbxSearch.Text))
                BindGridView(tbxSearch.Text);
            else
                MyDialog.Show("Error...!", "Invalid Vehicle Number");
        }

        private void bunifuMaterialTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(tbxSearch.Text);
            bunifuCustomDataGrid2.DataSource = null;
            lblTotalServices.Text = "0";
            lblVehicleNo.Text = String.Empty;
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void service_details_DoubleClick(object sender, EventArgs e)
        {
            BindGridView(null);
        }
    }
}
