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
    public partial class View_Stocks : UserControl
    {
        StockController stc;
        public View_Stocks()
        {
            InitializeComponent();
            stc = new StockController();

        }

        private void BindGridView(String skey)
        {
            try
            {
                DataTable dt = stc.getStockDetails(skey);
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
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
            BindGridView(tbxSearch.Text);
        }

        private void View_Stocks_Load(object sender, EventArgs e)
        {
            BindGridView(null);
        }

        private void bunifuCustomDataGrid1_Click(object sender, EventArgs e)
        {
            //BindGridView(null);
        }

        private void View_Stocks_DoubleClick(object sender, EventArgs e)
        {
            BindGridView(null);
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGridView(null);
        }
    }
}
