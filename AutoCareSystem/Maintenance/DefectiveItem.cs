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
    public partial class DefectiveItem : UserControl
    {
        public DefectiveItem()
        {
            InitializeComponent();
        }

        private void BindGridView(String skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                    query = "SELECT  e.item_code, e.item_name, e.item_info, e.item_invoice_id, e.item_price, e.item_condition, s.full_name , e.warrenty_exp_date FROM equipments e LEFT OUTER JOIN suppliers s ON e.sup_code = s.sup_code WHERE e.status = 0";
                else
                    query = "SELECT  e.item_code, e.item_name, e.item_info, e.item_invoice_id, e.item_price, e.item_condition, s.full_name , e.warrenty_exp_date FROM equipments e LEFT OUTER JOIN suppliers s ON e.sup_code = s.sup_code WHERE e.item_name LIKE '%" + skey + "%' AND e.status = 0";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = dt;
                db.closeConnection();

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

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(((tbxSearch.Text.Length >= 1) ? tbxSearch.Text : null));
        }

        private void DefectiveItem_Load(object sender, EventArgs e)
        {
            BindGridView(null);
            bunifuFlatButton1.Enabled = false;
        }

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            BindGridView1(Convert.ToString(selectedRow.Cells[0].Value));
            bunifuFlatButton1.Enabled = true;
            
        }

        private void BindGridView1(string eq_id)
        {
            try
            {
                string query1 = "SELECT er.eq_repair_id, er.info, er.invoice_id, er.amount, er.maintanance_date FROM equipment_repair er WHERE er.item_code = '" + eq_id + "' ";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                db.closeConnection();
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

        

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearch_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            BindGridView(null);
            bunifuCustomDataGrid1.DataSource = null;
            bunifuFlatButton1.Enabled = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int selectedrowindex = bunifuCustomDataGrid2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = bunifuCustomDataGrid2.Rows[selectedrowindex];
            String id = Convert.ToString(selectedRow.Cells[0].Value);
            var confirmResult = MessageBox.Show("Are you sure to Remove this item ??",
                                     "Confirm Removed!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "UPDATE equipments SET status = 1 WHERE item_code = '" + id + "'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);     //pass query to sql query method 
                db.nonQuery();          //pass the cmd to nonQuery method(for Insert)
                db.closeConnection();
                BindGridView(null);         //reload table
                bunifuCustomDataGrid1.DataSource = null;
                bunifuFlatButton1.Enabled = false;

            }
        }
    }
}
