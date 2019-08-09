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
    public partial class ReturnItems : UserControl
    {
        private static ReturnItems _instance;
        public static ReturnItems Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReturnItems();
                return _instance;
            }
        }



        public ReturnItems()
        {
            InitializeComponent();
            lodeGridViewforsales();
            lodeGridViewforreturn();
            enableButtons(false);
        }








        private void lodeGridViewforsales()
        {
            try
            {
                Database db = new Database();
                string query = "SELECT s.sales_id AS 'SALESID', sc.cus_name AS 'Customer',  si.item_id AS 'ItemID',si.stock_id AS StorkID,si.return_cnt AS'ReturnCount',si.quantity AS 'Quantity',st.unit_price AS 'UnitPrice',s.total_price AS 'Total Price' FROM sales s,sales_items si,stocks st,salescustomer sc where s.sales_id = si.sales_id and s.cus_id = sc.cus_id and si.stock_id = st.item_code ";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                ItemsdataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ItemsdataGrid.DataSource = dt;
                db.getConnection().Close();
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


        private void resetFields()
        {
            ResonRichTextBox.Text = string.Empty;
            Quantitytxt.Text= string.Empty;
            txt_serch.Text= string.Empty;


        }

        private void lodeGridViewforsalesbySearch(string searchkey)
        {
            try
            {
                Database db = new Database();
                string query = "SELECT s.sales_id AS 'SALESID', sc.cus_name AS 'Customer',  si.item_id AS 'ItemID',si.stock_id AS StorkID,si.return_cnt AS'ReturnCount',si.quantity AS 'Quantity',st.unit_price AS 'UnitPrice',s.total_price AS 'Total Price' FROM sales s,sales_items si,stocks st,salescustomer sc where s.sales_id = si.sales_id and s.cus_id = sc.cus_id and si.stock_id = st.item_code and s.sales_id='" + searchkey + "'";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                ItemsdataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ItemsdataGrid.DataSource = dt;
                db.getConnection().Close();
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


        private void lodeGridViewforreturn()
        {
            try
            {
                Database db = new Database();
                string query = "SELECT  r.return_id AS 'RETURNID', r.sales_id AS 'SALESID',si.item_id AS 'ItemID',si.stock_id AS 'StorkID',sc.cus_name AS 'Customer', r.reason AS 'Reson',  r.quantity AS 'Quantity'    FROM sales s,return_items r,sales_items si,salescustomer sc WHERE s.sales_id = r.sales_id and s.sales_id=si.sales_id and s.cus_id =sc. cus_id ";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                ReturnDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ReturnDataGrid.DataSource = dt;
                db.getConnection().Close();
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

        void updateSalesItem(string itemid,int returncnt)
        {
            
            string query = "UPDATE sales_items SET return_cnt='" + returncnt + "' WHERE item_id = '" + itemid+ "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.getConnection().Close();
            lodeGridViewforsales();
            resetFields();




        }

        void updateSales(string Salesid, float total)
        {

            string query = "UPDATE sales SET total_price='" + total + "' WHERE sales_id = '" + Salesid + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.getConnection().Close();
            lodeGridViewforsales();
            resetFields();

        }
        private void enableButtons(bool b)
        {
            btnAddReturn.Enabled = !b;
           // btnUpdateReturn.Enabled = b;
            btnRemoveReturn.Enabled = b;

        }


        private string gettotalprice(string salesID)
        { 
            string total_price = "0";
            string query = "SELECT total_price FROM sales WHERE sales_id = '" + salesID + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            //db.getData();
            DataTable dt = db.executeQuery();

            foreach (DataRow row in dt.Rows)
            {
                total_price = Convert.ToString(row["total_price"]);
            }
            return total_price;
        }


        private string getunitprice(string ItemID)
        {
            string unit_price = "0";
            string query = "SELECT price FROM sales_items WHERE item_id = '" + ItemID + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            //db.getData();
            DataTable dt = db.executeQuery();

            foreach (DataRow row in dt.Rows)
            {
                unit_price = Convert.ToString(row["price"]);
            }
            return unit_price;
        }
        private string getreturncount(string ItemID)
        {
            string return_cnt = "0";
            string query = "SELECT return_cnt FROM sales_items WHERE item_id = '" + ItemID + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            //db.getData();
            DataTable dt = db.executeQuery();

            foreach (DataRow row in dt.Rows)
            {
                return_cnt = Convert.ToString(row["return_cnt"]);
            }
            return return_cnt;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

      

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_serch.Text))
            {

                MyDialog.Show("Error...!", "Please enter the Receipt Number");

            }
            else
            {
                string search;
                search = Convert.ToString(txt_serch.Text);
                lodeGridViewforsalesbySearch(search);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ResonRichTextBox.Text)&& string.IsNullOrWhiteSpace(Quantitytxt.Text))
            {
                MyDialog.Show("Error...!", "Please fill Reason and Quantity fields");
            }
            else
            {
                int selectedrowindex = ItemsdataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ItemsdataGrid.Rows[selectedrowindex];

                string salsid = Convert.ToString(selectedRow.Cells[0].Value);
                string itemid = Convert.ToString(selectedRow.Cells[2].Value);
                string storkid = Convert.ToString(selectedRow.Cells[3].Value);

                float unitPrice = float.Parse(Convert.ToString(selectedRow.Cells[6].Value));
                int returncont = Convert.ToInt32(Convert.ToString(selectedRow.Cells[4].Value));

                float total = float.Parse(Convert.ToString(selectedRow.Cells[7].Value));
                returncont = returncont + (Convert.ToInt32(Quantitytxt.Text));
                total = total - (unitPrice * Convert.ToInt32(Quantitytxt.Text));

                String Reson = ResonRichTextBox.Text;
                CodeGenerator cd = new CodeGenerator();
                string ReturnID =cd.generateReturnItemCode();
                float Quantity = float.Parse(Quantitytxt.Text);
                string query = "INSERT INTO return_items VALUES('" + ReturnID + "','" + salsid + "','"+ storkid + "','" + Reson + "','" + DateTime.Now + "','" + Quantity + "')";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                // updateSales(returncont, itemid, total);
                updateSalesItem(itemid, returncont);
                updateSales(salsid, total);
                if (db.nonQuery())
                {
                    MyDialog.Show("Success...!", "Return Item added :)");
                    lodeGridViewforreturn();
                }
                else
                    MyDialog.Show("Error...!", "Return Item not added :)");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetFields();
            lodeGridViewforsales();
            lodeGridViewforreturn();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedrowindex = ReturnDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = ReturnDataGrid.Rows[selectedrowindex];

            String id = Convert.ToString(selectedRow.Cells[0].Value);
            String sid = Convert.ToString(selectedRow.Cells[1].Value);
            String itemid = Convert.ToString(selectedRow.Cells[2].Value);
            int Quentity = Convert.ToInt32(Convert.ToString(selectedRow.Cells[6].Value));
            
          
            float total = float.Parse(gettotalprice(sid));
            float unitprice = float.Parse(getunitprice(itemid));
            int returncount = Convert.ToInt32(getreturncount(itemid));
          
            returncount = returncount - Quentity;
            total = total + (unitprice * Quentity);
           


            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                         "Confirm Delete!!",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {



                string query = "DELETE FROM return_items WHERE return_id = '" + id + "' ";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);    //pass query to sql query method
                                       //updateSales(returncount, itemid, total);
                updateSalesItem(itemid, returncount);
                updateSales(sid, total);
                db.nonQuery();          //pass the cmd to nonQuery method(for Insert)
                db.getConnection().Close();
                lodeGridViewforreturn();       //reload table
            }

        }

        private void ReturnDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enableButtons(true);
        }

        private void ItemsdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            enableButtons(false);
        }

        private void btnUpdateReturn_Click(object sender, EventArgs e)
        {

        }
    }
    }

