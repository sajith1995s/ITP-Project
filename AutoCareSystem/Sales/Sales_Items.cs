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
using Microsoft.VisualBasic;

namespace AutoCareSystem
{
    
  
    public partial class Sales_Items : UserControl
    {
        
        private static Sales_Items _instance;
        public static Sales_Items Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sales_Items();
                return _instance;
            }
        }
        public Sales_Items()

            
        {
            InitializeComponent();
            lodeGridViewforcustomer();
            lodeGridViewforStrok();
           
           


        }

        String ItemID1 = "00000";



        private void lodeGridViewforcustomer()
        {
            try
            {
                Database db = new Database();
                string query = "select cus_id AS 'CustomerID',cus_name AS 'CustomerName',cus_address AS 'CustomerAddress',cus_telephone AS 'CustomerTelephone' from salescustomer ";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                CustomerDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                CustomerDataGrid.DataSource = dt;
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
            txtAddress.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txt_serch.Text = string.Empty;
            txtName.Text = string.Empty;
            txtItemID.Text = string.Empty;
            txttelephone.Text = string.Empty;
            txtQuty.Text = string.Empty;
            txtsearch.Text = string.Empty;


        }




        private void resetFields1()
        {
       
            txtDiscount.Text = string.Empty;
            txtItemID.Text = string.Empty;
            txtQuty.Text = string.Empty;



        }

        void updateStocks(string stockid, float quantity)
        {

            string query = "UPDATE stocks SET quantity='" + quantity + "'  WHERE item_code = '" + stockid + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.getConnection().Close();
            lodeGridViewforStrok();
           




        }



        private void lodeGridViewforcustomerbySearch(string searchkey)
        {
            try
            {
                Database db = new Database();
                string query = "select cus_id AS 'CustomerID',cus_name AS 'CustomerName',cus_address AS 'CustomerAddress',cus_telephone AS 'CustomerTelephone' from salescustomer where cus_name like '%"+ searchkey + "%'";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                CustomerDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                CustomerDataGrid.DataSource = dt;
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





        private void lodeGridViewforStrok()
        {
            try
            {
                Database db = new Database();
                string query = "select item_code AS'Itemcode', name AS 'Name',description AS 'Description',type AS 'Type',quantity AS 'Quntity',unit_price AS 'Unite Price' from stocks ";
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

        private void lodeGridViewforStrokbySearch(string searchkey)
        {
            try
            {
                Database db = new Database();
                string query = "select item_code AS'Itemcode', name AS 'Name',description AS 'Description',type AS 'Type',quantity AS 'Quntity',unit_price AS 'Unite Price' from stocks where name like '%" + searchkey + "%'" ;
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
        private void lodesalesItem(string ID,string SID,string SalesID, string Description,string Quntity,string Discount,string price,string rtcnt)
        {

            SalesdataGrid.ColumnCount = 8;
            SalesdataGrid.Columns[0].Name = "ItemID";
            SalesdataGrid.Columns[1].Name = "StockID";
            SalesdataGrid.Columns[2].Name = "SalesID";
            SalesdataGrid.Columns[3].Name = "Discription";
            SalesdataGrid.Columns[4].Name = "Quntity";
            SalesdataGrid.Columns[5].Name = "Discount";
            SalesdataGrid.Columns[6].Name = "Price";
            SalesdataGrid.Columns[7].Name = "returncount";

            string[] RowValue = new string[] { ID, SID,SalesID, Description, Quntity, Discount, price, rtcnt};
            SalesdataGrid.Rows.Add(RowValue);
            
            


            }







        private string getQuntity(string StockID)
        {
            string quantity = "0";
            string query = "SELECT quantity FROM stocks WHERE item_code = '" + StockID + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
          
            DataTable dt = db.executeQuery();

            foreach (DataRow row in dt.Rows)
            {
                quantity = Convert.ToString(row["quantity"]);
            }
            return quantity;
        }




        private string getCusID(string Cusname)
        {
            string cus_id = "0";
            string query = "SELECT cus_id FROM salescustomer WHERE cus_name = '" + Cusname + "'";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            //db.getData();
            DataTable dt = db.executeQuery();

            foreach (DataRow row in dt.Rows)
            {
                cus_id = Convert.ToString(row["cus_id"]);
            }
            return cus_id;
        }

        private string getString(string x)
        {
            return x;
                
                
                
        }



        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtAddress.Text)&&string.IsNullOrWhiteSpace(txttelephone.Text))
            {
                MyDialog.Show("Error...!", "Please fill Personal details");
            }

            else
            {



                if (txtName.Enabled)
                {
                    String Cus_id = CodeGenerator.generateSalescustomercode();

                    string query = "INSERT INTO salescustomer VALUES('" + Cus_id + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtAddress.Text + "')";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query);

                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success...!", "Customer added");

                    }
                    else
                        MyDialog.Show("Error...!", "Customer not added");


                    string SalesID = CodeGenerator.generateSalescode();

                    string query1 = "INSERT INTO sales VALUES('" + SalesID + "','" + Cus_id + "','" + totalLabel.Text + "','" + DateTime.Now + "')";

                    db.sqlQuery(query1);

                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success...!", "Sales added");

                    }
                    else
                        MyDialog.Show("Error...!", "Sales not added");



                }

                else
                {
                    String CusID = getCusID(txtName.Text);


                    string SalesID = CodeGenerator.generateSalescode();

                    string query1 = "INSERT INTO sales VALUES('" + SalesID + "','" + CusID + "','" + totalLabel.Text + "','" + DateTime.Now + "')";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query1);

                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success...!", "Sales added");

                    }
                    else
                        MyDialog.Show("Error...!", "Sales notadded");


                }
                
                for (int i = 0; i < SalesdataGrid.Rows.Count; i++)
                {
                    string SIid = SalesdataGrid.Rows[i].Cells[0].Value.ToString();
                    string Stockid = SalesdataGrid.Rows[i].Cells[1].Value.ToString();
                    string Salesid = SalesdataGrid.Rows[i].Cells[2].Value.ToString();
                 
                    string Description = SalesdataGrid.Rows[i].Cells[3].Value.ToString();
                
                   float Quntity = float.Parse(SalesdataGrid.Rows[i].Cells[4].Value.ToString());
                    float Discount = float.Parse(SalesdataGrid.Rows[i].Cells[5].Value.ToString());
                   float price = float.Parse(SalesdataGrid.Rows[i].Cells[6].Value.ToString());
                    int rncount = Convert.ToInt32(SalesdataGrid.Rows[i].Cells[7].Value.ToString());


                    Database db = new Database();

                    db.openConnection();
                    string query = "INSERT INTO sales_items(item_id,stock_id,sales_id,description,quantity,discount,price,return_cnt) VALUES('" + SIid + "','" + Stockid + "','"+Salesid+"','" + Description + "','" + Quntity + "','" + Discount + "','" + price + "','" + rncount + "')";
             
                   
                    db.sqlQuery(query);

                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success...!", "Sale Item added");

                    }
                    else
                        MyDialog.Show("Error...!", "Sale Item not added");







                }



                new Sales_Bill().Show();
                totalLabel.Text = "0.0";

            }
            }
        

        private void CustomerDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedrowindex = CustomerDataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = CustomerDataGrid.Rows[selectedrowindex];

            txtName.Text = Convert.ToString(selectedRow.Cells[1].Value);
            txtAddress.Text = Convert.ToString(selectedRow.Cells[2].Value);
            txttelephone.Text = Convert.ToString(selectedRow.Cells[3].Value);

            txtName.Enabled = false;      
            txtAddress.Enabled = false;
            txttelephone.Enabled = false;


        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lodeGridViewforcustomerbySearch(txtsearch.Text);
        }

        private void ItemsdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = ItemsdataGrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = ItemsdataGrid.Rows[selectedrowindex];

            txtItemID.Text = Convert.ToString(selectedRow.Cells[0].Value);
             


        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lodeGridViewforStrokbySearch(txt_serch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemID.Text) || string.IsNullOrWhiteSpace(txtQuty.Text) || string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MyDialog.Show("Error...!", "All Fields should be filled");
            }
            else
            {
                int selectedrowindex = ItemsdataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = ItemsdataGrid.Rows[selectedrowindex];

                string ItemID = Convert.ToString(selectedRow.Cells[0].Value);
                string description = Convert.ToString(selectedRow.Cells[2].Value);
                string unitPrice = Convert.ToString(selectedRow.Cells[5].Value);
                string Quntity = Convert.ToString(selectedRow.Cells[4].Value);
                float QuntityF = float.Parse(Quntity);
                float unitprice1 = float.Parse(unitPrice);
                float fQuntity = float.Parse(txtQuty.Text);
                float TOt = unitprice1 * fQuntity;
                float Discount = float.Parse(txtDiscount.Text);
                if (fQuntity > QuntityF)
                {

                    MyDialog.Show("Error...!", "Invalid Quantity");
                    resetFields1();

                }

                else if (Discount>=TOt)
                {
                    MyDialog.Show("Error...!", "Invalid Discount Amount");
                    resetFields1();
                }
                else

                {





                    float total = float.Parse(totalLabel.Text);
                    total = total + unitprice1 * float.Parse(txtQuty.Text) - float.Parse(txtDiscount.Text);
                    totalLabel.Text = Convert.ToString(total);
                    string SalsItemID = CodeGenerator.generateSalesItemCode();
                    string SalsID = CodeGenerator.generateSalescode();


                    if (SalesdataGrid.Rows.Count == 0)
                    {




                        QuntityF = QuntityF - float.Parse(txtQuty.Text);
                        updateStocks(ItemID, QuntityF);
                        lodesalesItem(SalsItemID, ItemID, SalsID, description, txtQuty.Text, txtDiscount.Text, unitPrice, "0");

                        int selectedrowindex1 = SalesdataGrid.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow1 = SalesdataGrid.Rows[selectedrowindex1];
                        ItemID1 = Convert.ToString(selectedRow1.Cells[0].Value);

                        resetFields1();



                    }
                    else
                    {

                    


                        int selectedrowindex1 = SalesdataGrid.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow1 = SalesdataGrid.Rows[selectedrowindex1];
                        ItemID1 = Convert.ToString(selectedRow1.Cells[0].Value);
                       String  XItemID1 = Convert.ToString(selectedRow1.Cells[1].Value);
                        String sDescount = Convert.ToString(selectedRow1.Cells[5].Value);
                        String Squntity = Convert.ToString(selectedRow1.Cells[4].Value);

                        float SFQuntity = float.Parse(Squntity);
                        float SFDescount = float.Parse(sDescount);

                        float RealQuntity = SFQuntity + float.Parse(txtQuty.Text);
                        float RealDescount = SFDescount + float.Parse(txtDiscount.Text);

                        float QuntityF1 = float.Parse(Quntity);
                        QuntityF1 = QuntityF1 - float.Parse(txtQuty.Text);

                        if (ItemID == XItemID1)
                        {
                            selectedRow1.Cells[4].Value = Convert.ToString(RealQuntity);
                            selectedRow1.Cells[5].Value = Convert.ToString(RealDescount);
                            updateStocks(ItemID, QuntityF1);





                        }
                        else
                        {

                            String NUMBER_FORMAT = "{0:D4}";
                            string SalsItemID1 = ItemID1.Substring(2);
                            string SalesItemid = ("SI" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(SalsItemID1) + 1)));
                            updateStocks(ItemID, QuntityF1);
                            lodesalesItem(SalesItemid, ItemID, SalsID, description, txtQuty.Text, txtDiscount.Text, unitPrice, "0");

                            resetFields1();

                        }
                    }

                    SalesdataGrid.Sort(SalesdataGrid.Columns["ItemID"], ListSortDirection.Descending);
                    SalesdataGrid.Rows[0].Selected = true;
                }
            }

           

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

  
                int selectedrowindex = SalesdataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = SalesdataGrid.Rows[selectedrowindex];


                string ItemID = Convert.ToString(selectedRow.Cells[1].Value);
                string Quntity = Convert.ToString(selectedRow.Cells[4].Value);
                float discount = float.Parse(Convert.ToString(selectedRow.Cells[5].Value));
                float unitprice1 = float.Parse(Convert.ToString(selectedRow.Cells[6].Value));

                float QuntityF = float.Parse(getQuntity(ItemID));



                float total = float.Parse(totalLabel.Text);
                total = total - ((unitprice1 * float.Parse(Quntity) - discount));
                totalLabel.Text = Convert.ToString(total);


                float quntity = float.Parse(Quntity);
                QuntityF = QuntityF + quntity;

                SalesdataGrid.Rows.RemoveAt(selectedrowindex);
                updateStocks(ItemID, QuntityF);

            resetFields1();


            
        }

        private void txtQuty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsLetter(e.KeyChar);
            int selectedrowindex = ItemsdataGrid.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = ItemsdataGrid.Rows[selectedrowindex];

            string Quntity = Convert.ToString(selectedRow.Cells[4].Value);
          
          

        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsLetter(e.KeyChar);
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsLetter(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar);
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar);
        }

        private void txt_serch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || char.IsNumber(e.KeyChar);
        }

        private void btnClearReturn_Click(object sender, EventArgs e)
        {
            resetFields();
            lodeGridViewforcustomer();
            lodeGridViewforStrok();
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txttelephone.Enabled = true;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
