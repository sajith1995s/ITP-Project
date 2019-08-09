using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoCareSystem
{
    class ServiceController
    {
        Database db;

        public ServiceController()
        {
            db = new Database();
        }

        public string getVehicleCode(string key)
        {
            string query = "SELECT v_code FROM vehicles WHERE vehicle_number = '" + key + "'";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            String code = db.executeQuery("v_code");
            db.closeConnection();
            return code;
        }

        public bool isVehicleFound(String vehicle_no)
        {
            try
            {
                String query = "SELECT COUNT(*) AS vcount FROM vehicles WHERE vehicle_number = '" + vehicle_no + "'";
                db.openConnection();
                db.sqlQuery(query);
                String vcount = db.executeQuery("vcount");
                db.closeConnection();
                return vcount.Equals("1");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }
        }

        public bool addService(Service data)
        {
            String s_code = CodeGenerator.generateServiceCode();
            string query = "INSERT INTO services VALUES('" + s_code + "','" + data.VehicleCode + "','" + data.ServiceDate + "','" + data.OdoMeter + "','" + data.NextServiceDate + "','0')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public void addProvidedServices(List<int> checkedList)
        {
            String s_code = getLastInsertServiceId();

            db.openConnection();
            foreach (int typeId in checkedList)
            {
                String charges = getServiceCharge(typeId);
                //System.Console.WriteLine(typeId + " | " + charges);
                string query = "INSERT INTO provided_services VALUES('" + s_code + "','" + typeId + "','" + charges + "','" + DateTime.Now + "')";
                db.sqlQuery(query);
                db.nonQuery();
            }
            db.closeConnection();
        }

        private String getLastInsertServiceId()
        {
            String query = "SELECT TOP 1 s_code FROM services ORDER BY s_code DESC";
            db.openConnection();
            db.sqlQuery(query);
            String s_code = db.executeQuery("s_code");
            db.closeConnection();
            return s_code;
        }

        private String getServiceCharge(int stid)
        {
            try
            {
                String query = "SELECT charges FROM service_types WHERE stid = '" + stid + "'";
                db.sqlQuery(query);
                String charges = String.Format("{0:C0}", db.executeQuery("charges"));
                return charges;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        /**
            SERVICE DETAILS INTERFACE
        **/

        public DataTable getServicesDetails(String skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                    query = "SELECT s.s_code AS ID, v.vehicle_number AS 'Vehicle Number', s.odo_meter AS 'ODO Meter', s.enter_date AS 'Service Date', s.next_date AS 'Next Date' FROM services s LEFT OUTER JOIN vehicles v ON s.v_code = v.v_code";
                else
                    query = "SELECT s.s_code AS ID, v.vehicle_number AS 'Vehicle Number', s.odo_meter AS 'ODO Meter', s.enter_date AS 'Service Date', s.next_date AS 'Next Date' FROM services s LEFT OUTER JOIN vehicles v ON s.v_code = v.v_code WHERE v.vehicle_number LIKE '%" + skey + "%'";

                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                db.closeConnection();
                return ((dt != null) ? dt : null);
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


        public DataTable getProvidedServicesDetails(String s_code)
        {
            try
            {
                string query = "SELECT st.name,ps.charges FROM provided_services ps LEFT OUTER JOIN service_types st ON ps.stid = st.stid WHERE ps.s_code = '" + s_code + "'";
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

        public bool removeService(String s_code)
        {
            string query = "DELETE FROM services WHERE s_code = '" + s_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        /**
            UPDATE SERVICE FORM INTERFACE
        **/

        public DataTable getBasicDetails(String s_code)
        {
            try
            {
                String query = "SELECT v.vehicle_number,s.enter_date,s.odo_meter,s.next_date FROM services s LEFT OUTER JOIN vehicles v ON s.v_code = v.v_code WHERE s.s_code = '" + s_code + "'";
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

        public DataTable getProvidedServices(String s_code)
        {
            try
            {
                String query = "SELECT stid FROM provided_services WHERE s_code = '" + s_code + "'";
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

        public bool updateBasicServiceDetails(Service sv)
        {
            String query = "UPDATE services SET v_code = '" + sv.VehicleCode + "', enter_date = '" + sv.ServiceDate + "', odo_meter = '" + sv.OdoMeter + "', next_date = '" + sv.NextServiceDate + "' WHERE s_code = '" + sv.ServiceCode + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool removeAndUpdateProvidedServices(String s_code, List<int> checkedList)
        {
            String query01 = "DELETE FROM provided_services WHERE s_code = '" + s_code + "'";
            db.openConnection();
            db.sqlQuery(query01);
            bool b = db.nonQuery();

            foreach (int typeId in checkedList)
            {
                String charges = getServiceCharge(typeId);
                string query02 = "INSERT INTO provided_services VALUES('" + s_code + "','" + typeId + "','" + charges + "','" + DateTime.Now + "')";
                db.sqlQuery(query02);
                db.nonQuery();
            }

            db.closeConnection();
            return b;
        }

        /**
            SERVICE CHARGES INTERFACE
        **/

        public DataTable getServiceTypes(String skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                    query = "SELECT stid AS ID, name AS Name,description AS Description, charges AS Charges FROM service_types";
                else
                    query = "SELECT stid AS ID, name AS Name,description AS Description, charges AS Charges FROM service_types WHERE name LIKE '%" + skey + "%'";

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

        public bool updateServiceTypeCharges(String id, String charges)
        {
            string query = "UPDATE service_types SET charges = '" + charges + "' WHERE stid = '" + id + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }
    }
}
