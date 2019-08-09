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
    class RepairController
    {

        Database db;

        public RepairController()
        {
            db = new Database();
        }

        /**
            ADD REPAIR FAULTS INTERFACE
        **/
        public DataTable getEmployeeDetails()
        {
            //string query = "SELECT * FROM employee WHERE technician_status = 'available'";
            string query = "SELECT * FROM employee";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getVehicleDetailsIfExists(string vehicle_no)
        {
            try
            {
                String query = "SELECT * FROM vehicles WHERE vehicle_number = '" + vehicle_no + "'";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                db.closeConnection();
                return ((dt != null && dt.Rows.Count == 1) ? dt : null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataTable getErrorDetailsIfExists(string error_code)
        {
            try
            {
                String query = "SELECT * FROM error_codes WHERE code = '" + error_code + "'";
                //db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                //db.getConnection().Close();
                return ((dt != null && dt.Rows.Count == 1) ? dt : null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public bool addRepair(Repair data)
        {
            String r_code = CodeGenerator.generateRepairCode();
            string query = "INSERT INTO repairs VALUES('" + r_code + "','" + data.EmployeeCode + "','" + data.VehicleId + "','" + data.RepairDate + "','0')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public void AddVehicleFaults(BunifuCustomDataGrid bunifuCustomDataGrid1)
        {
            String r_code = Database.getLastInsertId("repairs", "r_code");
            db.openConnection();
            foreach (DataGridViewRow row in bunifuCustomDataGrid1.Rows)
            {
                String e_code = Convert.ToString(row.Cells[0].Value);
                String e_desc = Convert.ToString(row.Cells[1].Value);
                String e_remark = Convert.ToString(row.Cells[2].Value);
                DataTable dt = getErrorDetailsIfExists(e_code);

                String exist_id = (dt != null) ? Convert.ToString(dt.Rows[0]["ecid"]) : null;
                String error_id = ((exist_id != null) ? exist_id : addNewErrorCode(e_code, e_desc, e_remark));
                if (!isVehicleErrorExists(r_code, error_id))
                {
                    string query = "INSERT INTO vehicle_errors VALUES('" + r_code + "','" + error_id + "','Pending','" + DateTime.Now + "')";
                    db.sqlQuery(query);
                    db.nonQuery();
                }
            }
            db.closeConnection();
        }

        private bool isVehicleErrorExists(string r_code, string error_id)
        {
            try
            {
                String query = "SELECT * FROM vehicle_errors WHERE r_code = '" + r_code + "' AND ecid = '" + error_id + "'";
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

        private String addNewErrorCode(String e_code, String e_desc, String e_remark)
        {
            String query = "INSERT INTO error_codes VALUES('" + e_code + "','" + e_desc + "','" + e_remark + "','" + DateTime.Now + "')";
            db.sqlQuery(query);
            db.nonQuery();
            return Database.getLastInsertId("error_codes", "ecid"); ;
        }



        /**
            REPAIR DETAILS INTERFACE
        **/
        public DataTable getRepairTypes()
        {
            string query = "SELECT rtid, name FROM repair_types";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return dt;
        }

        public DataTable getRepairDetails()
        {
            try
            {
                string query = "SELECT r.r_code AS Code, e.fname+' '+e.lname AS Employee, v.vehicle_number AS 'Vehicle Number', r.repair_date AS 'Repair Date' FROM repairs r LEFT OUTER JOIN vehicles v ON r.v_code = v.v_code LEFT OUTER JOIN employee e ON r.e_code = e.e_code";
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

        public DataTable getProvidedRepairDetails(String id)
        {
            try
            {
                string query = "SELECT rt.name,pr.charges FROM provided_repairs pr LEFT OUTER JOIN repair_types rt ON pr.rtid = rt.rtid WHERE pr.r_code = '" + id + "'";
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

        public DataTable getRepairedVehicles(string skey, bool b)
        {
            try
            {
                string query;
                if (b)
                    query = "SELECT r.r_code AS Code, e.fname+' '+e.lname AS Employee, v.vehicle_number AS 'Vehicle Number', r.repair_date AS 'Repair Date' FROM repairs r LEFT OUTER JOIN vehicles v ON r.v_code = v.v_code LEFT OUTER JOIN employee e ON r.e_code = e.e_code  WHERE v.vehicle_number = '" + skey + "'";
                else
                    query = "SELECT r.r_code AS Code, e.fname+' '+e.lname AS Employee, v.vehicle_number AS 'Vehicle Number', r.repair_date AS 'Repair Date' FROM repairs r LEFT OUTER JOIN vehicles v ON r.v_code = v.v_code LEFT OUTER JOIN employee e ON r.e_code = e.e_code  WHERE r.r_code = '" + skey + "'";
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

        public bool removeProvidedRepair(String id, String key)
        {
            string query = "DELETE FROM provided_repairs WHERE r_code = '" + id + "' AND rtid = '" + key + "' ";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool isProvidedRepairExists(Repair repair)
        {
            string query = "SELECT * FROM provided_repairs WHERE r_code = '" + repair.RepairCode + "' AND rtid = '" + repair.ProvidedRepairId + "'";
            db.openConnection();
            db.sqlQuery(query);
            DataTable dt = db.executeQuery();
            db.closeConnection();
            return (dt != null && dt.Rows.Count == 1);
        }

        public bool addProvidedRepair(Repair repair)
        {
            String charges = getCharges(repair.ProvidedRepairId);
            string query = "INSERT INTO provided_repairs VALUES('" + repair.RepairCode + "','" + repair.ProvidedRepairId + "','" + charges + "','" + DateTime.Now + "')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        private string getCharges(string key)
        {
            string query = "SELECT charges FROM repair_types WHERE rtid = '" + key + "'";
            db.openConnection();
            db.sqlQuery(query);
            String charges = db.executeQuery("charges");
            db.closeConnection();
            return charges;
        }

        public bool removeRepair(String r_code)
        {
            string query = "DELETE FROM repairs WHERE r_code = '" + r_code + "' ";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }


        /**
            UPDATE JOB STATUS INTERFACE
        **/

        public DataTable getErrorList(string skey, bool b)
        {
            try
            {
                string query;
                if (b)
                    query = "SELECT r.r_code AS 'Repair Code',ec.code AS 'Error Code',ec.description AS Description,ve.status AS Status FROM vehicle_errors ve LEFT OUTER JOIN error_codes ec ON ve.ecid = ec.ecid LEFT OUTER JOIN repairs r ON r.r_code = ve.r_code LEFT OUTER JOIN vehicles v ON v.v_code = r.v_code WHERE v.vehicle_number = '" + skey + "'";
                else
                    query = "SELECT r.r_code AS 'Repair Code',ec.code AS 'Error Code',ec.description AS Description,ve.status AS Status FROM vehicle_errors ve LEFT OUTER JOIN error_codes ec ON ve.ecid = ec.ecid LEFT OUTER JOIN repairs r ON r.r_code = ve.r_code WHERE ve.r_code = '" + skey + "'";

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

        public bool updateJbStatus(Repair rp)
        {
            String ecid = getErrorCodeID(rp.ErrorCode);

            string query = "UPDATE vehicle_errors SET status = '" + rp.JobStatus + "' WHERE r_code = '" + rp.RepairCode + "' AND ecid = '" + ecid + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        private string getErrorCodeID(string error_code)
        {
            string query = "SELECT ecid FROM error_codes  WHERE code = '" + error_code + "'";
            db.openConnection();
            db.sqlQuery(query);
            return db.executeQuery("ecid");
        }


        /**
            ADD REPAIR TYPE INTERFACE
        **/

        public DataTable getRepairTypeDetails(string skey)
        {
            try
            {
                String query;
                if (string.IsNullOrWhiteSpace(skey))
                    query = "SELECT rtid AS ID, name AS Name, description AS Description, charges AS Charges FROM repair_types";
                else
                    query = "SELECT rtid AS ID, name AS Name, description AS Description, charges AS Charges FROM repair_types WHERE name LIKE '%" + skey + "%'";

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

        public bool addNewRepairType(Repair rp)
        {
            string query = "INSERT INTO repair_types VALUES('" + rp.RepairTypeName + "','" + rp.RepairTypeDesc + "','" + rp.RepairTypeCharges + "')";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool removeRepairType(String id)
        {
            string query = "DELETE FROM repair_types WHERE rtid = '" + id + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public bool updateRepairType(Repair rp)
        {
            string query = "UPDATE repair_types SET name = '" + rp.RepairTypeName + "', description = '" + rp.RepairTypeDesc + "', charges = '" + rp.RepairTypeCharges + "' WHERE rtid = '" + rp.RepairTypeId + "'";
            db.openConnection();
            db.sqlQuery(query);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }
    }
}
