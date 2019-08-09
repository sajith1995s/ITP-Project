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
    public partial class invoice_details : UserControl
    {
        public invoice_details()
        {
            InitializeComponent();
        }

        private void BindGridView(String keyword)
        {



            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT in_code AS 'Invoice No', type_code AS 'Type Code',in_date AS 'Invoice Date',in_total AS 'Total' FROM invoices";
            else
                query = "SELECT in_code AS 'Invoice No', type_code AS 'Type Code',in_date AS 'Invoice Date',in_total AS 'Total' FROM invoices WHERE type_code LIKE '%" + keyword + "%'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bunifuCustomDataGrid1.DataSource = dt;
            db.closeConnection();
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            BindGridView(tbxSearch.Text);
        }

        private void invoice_details_Load(object sender, EventArgs e)
        {
            BindGridView(null);
        }

        private void invoice_details_DoubleClick(object sender, EventArgs e)
        {
            BindGridView(null);
        }
    }
}
