using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class SupplierController
    {
        Database db;

        public SupplierController()
        {
            db = new Database();
        }
        public DataTable getSupplierDetails(String keyword)
        {
            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT sup_code  AS ID, full_name AS Name, address_1 AS 'Address 1' , address_2 AS 'Address 2', phone AS 'Phone Number' ,email AS Email FROM Suppliers";
            else
                query = "SELECT sup_code  AS ID, full_name AS Name, address_1 AS 'Address 1' , address_2 AS 'Address 2', phone AS 'Phone Number' ,email AS Email FROM Suppliers WHERE full_name LIKE '%" + keyword + "%'";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }
        public bool addSupplier(Supplier data)
        {
            String sup_code = CodeGenerator.generateSupplierCode();
            string query ="INSERT INTO suppliers VALUES('" + sup_code + "','" + data.SupplierName + "','" + data.Address1 + "','" + data.Address2 + "','" + data.PhoneNumber + "','" + data.Email + "','" + DateTime.Now + "')";

            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool updateSupplier(Supplier data)
        {
          
            String query = "UPDATE suppliers SET full_name   = '" + data.SupplierName + "',  address_1  = '" + data.Address1 + "', address_2  = '" + data.Address2 + "', phone  = '" + data.PhoneNumber + "', email = '" + data.Email + "' WHERE sup_code  = '" + data.SupplierCode + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool removeSupplier(String sup_code)
        {
            string query = "DELETE FROM suppliers WHERE sup_code = '" + sup_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }
    }
}
