

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class StockController
    {
        Database db;

        public StockController()
        {
            db = new Database();
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

        public DataTable getStockDetails(String keyword)
        {
            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT st.item_code AS ID, st.name AS Name, s.full_name AS 'Supplier Name', st.type AS Type , st.brand AS Brand , st.unit_price AS 'Price(Rs.)', st.quantity AS Quantity , st.description AS Description FROM stocks st LEFT OUTER JOIN suppliers s ON st.sup_code  = s.sup_code ";
            else
                query = "SELECT st.item_code AS ID, st.name AS Name, s.full_name AS 'Supplier Name', st.type AS Type , st.brand AS Brand , st.unit_price AS 'Price(Rs.)', st.quantity AS Quantity , st.description AS Description FROM stocks st LEFT OUTER JOIN suppliers s ON st.sup_code  = s.sup_code  WHERE st.item_code LIKE '%" + keyword + "%'";

            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public bool addItem(Stock data)
        {
            String item_code = CodeGenerator.generateItemCode();
            string query = "INSERT INTO stocks VALUES('" + item_code + "','" + data.SupName + "','" + data.Type + "','" + data.ItemName + "','" + data.Brand + "','" + data.Description + "','" + data.Quantity + "','" + data.UnitPrice + "','" + DateTime.Now + "')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool updateItem(Stock data)
        {

            string query = "UPDATE stocks SET name = '" + data.ItemName + "',type = '" + data.Type + "', brand  = '" + data.Brand + "', unit_price  = '" + data.UnitPrice + "', quantity  = '" + data.Quantity + "',description = '" + data.Description + "' WHERE item_code  = '" + data.ItemCode + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool removeItem(String item_code)
        {
            string query = "DELETE FROM stocks WHERE item_code  = '" + item_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        //Notification
        public DataTable getOutOfStockDetails(String keyword)
        {
            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT TOP 12 item_code AS 'Item Code',type AS 'Type' ,name AS 'Name',brand AS 'Brand',quantity AS 'Quantity' FROM stocks WHERE quantity < 5";
            else
                query = "SELECT TOP 12 item_code AS 'Item Code',type AS 'Type' ,name AS 'Name',brand AS 'Brand',quantity AS 'Quantity' FROM stocks WHERE quantity < 5 AND item_code LIKE '%" + keyword + "%'";

            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;



        }
    }
}
