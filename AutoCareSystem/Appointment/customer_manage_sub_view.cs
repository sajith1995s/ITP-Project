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
    public partial class customer_manage_sub_view : UserControl
    {
        public customer_manage_sub_view()
        {
            InitializeComponent();

            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.ReadOnly = true;
            bunifuCustomDataGrid1.RowHeadersVisible = false;
            bunifuCustomDataGrid1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loadData();
        }
        public void loadData()
        {
            Database db = new Database();
            db.openConnection();

            String q1 = "SELECT * FROM customers";
            db.sqlQuery(q1);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.DataSource = dt;
            db.getConnection().Close();

            for (int i = 0; i < bunifuCustomDataGrid1.Columns.Count; i++)
            {
                bunifuCustomDataGrid1.Columns[i].Visible = false;
            }

            bunifuCustomDataGrid1.Columns[0].Visible = true;
            bunifuCustomDataGrid1.Columns[0].HeaderText = "ID";
            bunifuCustomDataGrid1.Columns[1].Visible = true;
            bunifuCustomDataGrid1.Columns[1].HeaderText = "First Name";
            bunifuCustomDataGrid1.Columns[2].Visible = true;
            bunifuCustomDataGrid1.Columns[2].HeaderText = "Last Name";
            bunifuCustomDataGrid1.Columns[3].Visible = true;
            bunifuCustomDataGrid1.Columns[3].HeaderText = "NIC";
            bunifuCustomDataGrid1.Columns[4].Visible = true;
            bunifuCustomDataGrid1.Columns[4].HeaderText = "Mobile";
            bunifuCustomDataGrid1.Columns[5].Visible = true;
            bunifuCustomDataGrid1.Columns[5].HeaderText = "Add. Line1";
            bunifuCustomDataGrid1.Columns[6].Visible = true;
            bunifuCustomDataGrid1.Columns[6].HeaderText = "Add. Line2";
            bunifuCustomDataGrid1.Columns[7].Visible = true;
            bunifuCustomDataGrid1.Columns[7].HeaderText = "City";
            bunifuCustomDataGrid1.Columns[8].Visible = true;
            bunifuCustomDataGrid1.Columns[8].HeaderText = "E-Mail";

            txt_search.Text = string.Empty;
        }
             private void search()
        {

            try
            {
                Database db = new Database();
                db.openConnection();

                String q1 = "select* from customers where fname like '%" + txt_search.Text + "%'";

                db.sqlQuery(q1);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = dt;
                db.getConnection().Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void txt_serch_KeyDown(object sender, KeyEventArgs e)
        {
            search();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

