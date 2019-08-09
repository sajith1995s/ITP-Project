using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class VehicleController
    {
        Database db;

        public VehicleController()
        {
            db = new Database();
        }

        public DataTable getCustomerDetails()
        {
            string query = "SELECT * FROM customers";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getVehicleDetails(String keyword)
        {
            String query;
            if (string.IsNullOrWhiteSpace(keyword))
                query = "SELECT v.v_code AS ID, c.fname+' '+c.lname AS Customer,v.vehicle_number AS 'Vehicle Number',v.vehicle_type AS Type,v.brand AS Brand,v.model AS Model FROM vehicles v LEFT OUTER JOIN customers c ON v.c_code = c.c_code";
            else
                query = "SELECT v.v_code AS ID, c.fname+' '+c.lname AS Customer,v.vehicle_number AS 'Vehicle Number',v.vehicle_type AS Type,v.brand AS Brand,v.model AS Model FROM vehicles v LEFT OUTER JOIN customers c ON v.c_code = c.c_code WHERE v.vehicle_number LIKE '%" + keyword + "%'";

            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public bool addVehicle(Vehicle data)
        {
            String v_code = CodeGenerator.generateVehicleCode();
            string query = "INSERT INTO vehicles VALUES('" + v_code + "','" + data.CustomerName + "','" + data.VehicleNo + "','" + data.Type + "','" + data.Brand + "','" + data.Model + "','" + DateTime.Now + "')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool updateVehicle(Vehicle data)
        {
            String query = "UPDATE vehicles SET vehicle_number = '" + data.VehicleNo + "', c_code = '" + data.CustomerName + "', vehicle_type = '" + data.Type + "', brand = '" + data.Brand + "', model = '" + data.Model + "' WHERE v_code = '" + data.VehicleCode + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool removeVehicle(String v_code)
        {
            string query = "DELETE FROM vehicles WHERE v_code = '" + v_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }
    }
}
