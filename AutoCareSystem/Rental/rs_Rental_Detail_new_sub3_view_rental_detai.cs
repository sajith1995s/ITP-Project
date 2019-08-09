using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class rs_Rental_Detail_new_sub3_view_rental_detai : UserControl
    {
        public rs_Rental_Detail_new_sub3_view_rental_detai()
        {
            InitializeComponent();
            loadData();


            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void loadData()
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "SELECT * FROM rental_details";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;

             db.closeConnection();


            for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Visible = false;
            }

            bunifuCustomDataGrid1.Columns[0].Visible = true;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "Rent ID";
            bunifuCustomDataGrid1.Columns[1].Visible = true;
            bunifuCustomDataGrid1.Columns[1].HeaderText = "Customer ID";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Vehicle ID";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "Rent Date";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "Return Date";
            bunifuCustomDataGrid1.Columns[5].Visible = true;
            bunifuCustomDataGrid1.Columns[5].HeaderText = "Minimum Deposit";
            bunifuCustomDataGrid1.Columns[6].Visible = true;
            bunifuCustomDataGrid1.Columns[6].HeaderText = "Current Millage";

            


        }

        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select * from rental_details where rnt_id like '%" + txt_search.Text + "%'";
                db.sqlQuery(q1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = dt;

                 db.closeConnection();

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void rs_Rental_Detail_new_sub3_view_rental_detai_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }

        private void rs_Rental_Detail_new_sub3_view_rental_detai_TabIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }
    }
}
