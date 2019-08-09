using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    class OrderController
    {
        Database db;

        public OrderController()
        {
            db = new Database();
        }

        public DataTable getOrderDetails(String keyword)
        {

            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT o.order_code  AS 'Order Code' ,s.full_name AS 'Supplier Name', o.order_date AS 'Order Date', o.status AS 'Status ' FROM orders o LEFT OUTER JOIN suppliers s ON s.sup_code  = o.sup_code";
            else
                query = "SELECT o.order_code  AS 'Order Code' ,s.full_name AS 'Supplier Name', o.order_date AS 'Order Date', o.status  AS 'Status ' FROM orders o LEFT OUTER JOIN suppliers s ON s.sup_code  = o.sup_code  WHERE  o.order_code LIKE '%" + keyword + "%'";

            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getOrderItemsDetails(String order_code)
        {
            try
            {
                string query = "SELECT st.item_code AS 'Item Code', st.name AS 'Item Name', oi.quantity AS Quantity , oi.amount AS 'Amount(Rs.)' FROM ordered_items oi LEFT OUTER JOIN stocks st ON oi.item_code  = st.item_code  WHERE oi.order_code = '" + order_code + "'";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                db.closeConnection();
                return ((dt != null && dt.Rows.Count > 0) ? dt : null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return null;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return null;
            }


        }
        public bool removeOrder(String order_code)
        {
            string query = "DELETE FROM orders WHERE order_code = '" + order_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool updateOrderStatus(String status, String order_code)
        {
            bool isUpdated = false;
            String query01 = "UPDATE orders SET status = '" + status + "' WHERE order_code = '" + order_code + "'";
            db.openConnection();
            db.sqlQuery(query01);
            if (db.nonQuery())
            {
                isUpdated = true;
                String query02 = "SELECT * FROM ordered_items WHERE order_code = '" + order_code + "'";
                db.sqlQuery(query02);
                DataTable dt = db.executeQuery();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        String item_code = Convert.ToString(row["item_code"]);
                        int quantity = Convert.ToInt32(row["quantity"]);
                        int new_quantity = quantity + getCurrentQty(item_code);
                        String query03 = "UPDATE stocks SET quantity = '" + new_quantity + "' WHERE item_code = '" + item_code + "'";
                        db.sqlQuery(query03);
                        db.nonQuery();

                        /*int balanced_count = checkForReturn(item_code, Convert.ToInt32(quantity));
                        if (balanced_count != 0)
                        {
                            int new_quantity = balanced_count + getCurrentQty(item_code);
                            String query03 = "UPDATE stocks SET quantity = '" + new_quantity + "' WHERE item_code = '" + item_code + "'";
                            db.sqlQuery(query03);
                            db.nonQuery();
                        }*/
                    }

                }
                db.closeConnection();
            }
            return isUpdated;
        }

        private int getCurrentQty(string item_code)
        {
            String query = "SELECT quantity FROM stocks WHERE item_code = '" + item_code + "'";
            db.sqlQuery(query);
            return Convert.ToInt32(db.executeQuery("quantity"));
        }

        /*private int checkForReturn(string item_code, int quantity)
            {
                String new_count = "0";
                int return_value = 0;
                String query = "SELECT quantity FROM return_items WHERE stock_id = '" + item_code + "'";
                Database db = new Database();
                db.getConnection().Open();
                db.sqlQuery(query);
                int return_count = Convert.ToInt32(db.executeQuery("quantity"));
                if (return_count < quantity)
                {
                    new_count = "0";
                    return_value = (quantity - return_count);
                }
                else
                {
                    new_count = Convert.ToString(return_count - quantity);
                    return_value = 0;
                }
                String query01 = "UPDATE return_items SET quantity = '" + new_count + "' WHERE stock_id = '" + item_code + "'";
                db.sqlQuery(query01);
                db.nonQuery();
                db.getConnection().Close();
                return return_value;
            }*/






        //order2
        public DataTable getOutOfStockDetails(String keyword)
        {
            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT TOP 12 item_code AS 'Item Code',type AS 'Type' ,name AS 'Name',brand AS 'Brand',quantity AS 'Quantity' FROM stocks WHERE quantity < 3";
            else
                query = "SELECT TOP 12 item_code AS 'Item Code',type AS 'Type' ,name AS 'Name',brand AS 'Brand',quantity AS 'Quantity' FROM stocks WHERE quantity < 3 AND item_code LIKE '%" + keyword + "%'";

            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getSupDetails()
        {
            string query = "SELECT * FROM suppliers";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getItemCode(String skey)
        {
            String query = "SELECT * FROM stocks WHERE item_code = '" + skey + "'";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public bool addSupplier(Supplier data)
        {
            String sup_code = CodeGenerator.generateSupplierCode();
            string query = "INSERT INTO suppliers VALUES('" + sup_code + "','" + data.SupplierName + "','" + data.Address1 + "','" + data.Address2 + "','" + data.PhoneNumber + "','" + data.Email + "','" + DateTime.Now + "')";

            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public void AddOrderItems(BunifuCustomDataGrid bunifuCustomDataGrid1)
        {
            String order_code = Database.getLastInsertId("orders", "order_code");
            db.openConnection();
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
            {
                String item_code = Convert.ToString(row.Cells[0].Value);
                String i_qty = Convert.ToString(row.Cells[2].Value);
                String i_amout = Convert.ToString(row.Cells[3].Value);
                String total = Convert.ToString( Convert.ToInt32(i_qty) * Convert.ToDouble(i_amout));
                if (!isOrderItemExists(order_code, item_code))
                {
                    String query = "INSERT INTO ordered_items VALUES('" + order_code + "','" + item_code + "','" + i_qty + "','" + i_amout + "','" + total + "')";
                    db.sqlQuery(query);
                    db.nonQuery();
                }
            }
            db.closeConnection();

        }

        public bool addNewOrder(Order odr)
        {
            string query = "INSERT INTO orders VALUES('" + odr.OrderCode + "','" + odr.SuppCode + "','" + odr.OrderDate + "','Not Received','" + DateTime.Now + "')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }
            


        private bool isOrderItemExists(string order_code, string item_code)
        {
            try
            {
                String query = "SELECT * FROM ordered_items WHERE order_code = '" + order_code + "' AND item_code = '" + item_code + "'";
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                return (dt != null && dt.Rows.Count == 1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

    }
    }