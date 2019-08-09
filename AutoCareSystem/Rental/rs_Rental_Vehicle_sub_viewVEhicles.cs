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
    public partial class rs_Rental_Vehicle_sub_viewVEhicles : UserControl
    {
        public rs_Rental_Vehicle_sub_viewVEhicles()
        {
            InitializeComponent();

            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;


            loadData();
        }


        public void loadData()
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "SELECT * FROM rental_vehicle";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;

             db.closeConnection();
            
                        for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
                        {
                            bunifuCustomDataGrid1.Columns[i].Visible = false;
                        }

                        bunifuCustomDataGrid1.Columns[0].Visible = true;
                        bunifuCustomDataGrid1.Columns[0].HeaderText = "Vehicle ID";
                        bunifuCustomDataGrid1.Columns[1].Visible = true;
                        bunifuCustomDataGrid1.Columns[1].HeaderText = "Brand";
                        bunifuCustomDataGrid1.Columns[2].Visible = true;
                        bunifuCustomDataGrid1.Columns[2].HeaderText = "Vehicle Model";
                        bunifuCustomDataGrid1.Columns[4].Visible = true;
                        bunifuCustomDataGrid1.Columns[4].HeaderText = "Fual Type";
                        bunifuCustomDataGrid1.Columns[5].Visible = true;
                        bunifuCustomDataGrid1.Columns[5].HeaderText = "Millage";
                        bunifuCustomDataGrid1.Columns[6].Visible = true;
                        bunifuCustomDataGrid1.Columns[6].HeaderText = "Status";
                        bunifuCustomDataGrid1.Columns[7].Visible = true;
                        bunifuCustomDataGrid1.Columns[7].HeaderText = "KM Per Day";
                        bunifuCustomDataGrid1.Columns[8].Visible = true;
                        bunifuCustomDataGrid1.Columns[8].HeaderText = "Rate";
                        bunifuCustomDataGrid1.Columns[9].Visible = true;
                        bunifuCustomDataGrid1.Columns[9].HeaderText = "Number";
                        bunifuCustomDataGrid1.Columns[11].Visible = true;
                        bunifuCustomDataGrid1.Columns[11].HeaderText = "Catagory";
            
        }
        private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select* from rental_vehicle where rv_brand like '%" + txt_serch.Text + "%'";
                db.sqlQuery(q1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = dt;

                 db.closeConnection();

                bunifuCustomDataGrid1.Sort(bunifuCustomDataGrid1.Columns["rv_status"], ListSortDirection.Ascending);


            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rs_Rental_Vehicle_sub_viewVEhicles_Paint(object sender, PaintEventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_serch_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void rs_Rental_Vehicle_sub_viewVEhicles_TabIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
