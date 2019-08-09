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
    class PaymentController
    {
        private Database db;

        public PaymentController()
        {
            db = new Database();
        }

        public DataTable getRepairOrServiceList(String skey, int SelectedIndex)
        {
            try
            {
                String query;
                if (SelectedIndex == 0)
                    query = "SELECT s.s_code AS ID, s.enter_date AS 'Service Date', s.next_date AS 'Next Date' FROM services s LEFT OUTER JOIN vehicles v ON s.v_code = v.v_code WHERE v.vehicle_number = '" + skey + "'";
                else
                    query = "SELECT r.r_code AS ID, e.fname+' '+lname AS Technician, r.repair_date AS 'Repair Date' FROM repairs r LEFT OUTER JOIN vehicles v ON r.v_code = v.v_code LEFT OUTER JOIN employee e ON r.e_code = e.e_code WHERE v.vehicle_number = '" + skey + "'";

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


        public Vehicle getCustomerBasicInfo(String skey)
        {
            try
            {
                String model = String.Empty;
                String full_name = String.Empty;
                String phone_num = String.Empty;
                Vehicle vh = new Vehicle();
                String query = "SELECT v.model, c.fname, c.lname, c.mobile FROM vehicles v LEFT OUTER JOIN customers c ON v.c_code = c.c_code WHERE v.vehicle_number = '" + skey + "'";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        model = Convert.ToString(row["model"]);
                        full_name = Convert.ToString(row["fname"]) + " " + Convert.ToString(row["lname"]);
                        phone_num = Convert.ToString(row["mobile"]);
                    }

                    vh.Model = model;
                    vh.CustomerName = full_name;
                    vh.PhoneNumber = phone_num;
                }
                db.closeConnection();
                return ((vh != null) ? vh : null);
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


        public DataTable getProvidedTasks(String id, bool b)
        {
            try
            {
                string query = null;
                if (b)
                    query = "SELECT st.name,ps.charges FROM provided_services ps LEFT OUTER JOIN service_types st ON ps.stid = st.stid WHERE ps.s_code = '" + id + "'";
                else
                    query = "SELECT rt.name,pr.charges FROM provided_repairs pr LEFT OUTER JOIN repair_types rt ON pr.rtid = rt.rtid WHERE pr.r_code = '" + id + "'";

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



        //Invoice Handle
        public bool addNewInvoicedetails(String type_code, int mIndex, String total)
        {

            string query;
            String in_code = getInvoiceNumber(type_code, mIndex);
            String in_date = getInvoiceDate(type_code, mIndex);

            if (mIndex == 0)
                query = "UPDATE services SET is_issued = 1 WHERE s_code = '" + type_code + "'";
            else
                query = "UPDATE repairs SET is_issued = 1 WHERE r_code = '" + type_code + "'";

            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();

            string query01 = "INSERT INTO invoices VALUES('" + in_code + "','" + type_code + "','" + in_date + "','" + total + "','" + DateTime.Now + "')";
            db.openConnection();
            db.sqlQuery(query01);
            bool b = db.nonQuery();
            db.closeConnection();
            return b;
        }

        public String getInvoiceNumber(String code, int mIndex)
        {
            return (isInvoiceReceived(code, mIndex)) ? getInvoicedetails(code, "in_code") : CodeGenerator.generateInvoiceNumber();
        }

        public String getInvoiceDate(String code, int mIndex)
        {
            return (isInvoiceReceived(code, mIndex)) ? getInvoicedetails(code, "in_date") : DateTime.Now.ToString();
        }

        public bool isInvoiceReceived(String _code, int mIndex)
        {
            string query;

            if (mIndex == 0)
                query = "SELECT is_issued FROM services WHERE s_code = '" + _code + "'";
            else
                query = "SELECT is_issued FROM repairs WHERE r_code = '" + _code + "'";

            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            String status = db.executeQuery("is_issued");
            db.closeConnection();
            return (status.Equals("1"));
        }


        public String getInvoicedetails(String _code, String field_name)
        {
            try
            {
                string query = "SELECT * FROM invoices WHERE type_code = '" + _code + "'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                String value = db.executeQuery(field_name);
                db.closeConnection();
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return null;
            }
        }
    }
}
