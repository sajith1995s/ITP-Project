using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoCareSystem
{
    class CodeGenerator
    {
        private static String NUMBER_FORMAT = "{0:D4}";

        private static String VEHICLE_CODE = "V";
        private static String REPAIR_CODE = "R";
        private static String SERVICE_CODE = "S";
        private static String INVOICE_CODE = "AS";

        private static String TBL_VEHICLE = "vehicles";
        private static String TBL_REPAIR = "repairs";
        private static String TBL_SERVICE = "services";
        private static String TBL_INVOICE = "invoices";

        private static String CLM_VEHICLE = "v_code";
        private static String CLM_REPAIR = "r_code";
        private static String CLM_SERVICE = "s_code";
        private static String CLM_INVOICE = "in_code";


        public static String generateVehicleCode()
        {
            if (isDataExists(TBL_VEHICLE))
            {
                String number = getLastInsertId(TBL_VEHICLE, CLM_VEHICLE).Substring(1);
                return (VEHICLE_CODE + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
            }
            else
            {
                return (VEHICLE_CODE + String.Format(NUMBER_FORMAT, 1));
            }
        }

        public static String generateRepairCode()
        {
            if (isDataExists(TBL_REPAIR))
            {
                String number = getLastInsertId(TBL_REPAIR, CLM_REPAIR).Substring(1);
                return (REPAIR_CODE + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
            }
            else
            {
                return (REPAIR_CODE + String.Format(NUMBER_FORMAT, 1));
            }
        }

        public static String generateServiceCode()
        {
            if (isDataExists(TBL_SERVICE))
            {
                String number = getLastInsertId(TBL_SERVICE, CLM_SERVICE).Substring(1);
                return (SERVICE_CODE + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
            }
            else
            {
                return (SERVICE_CODE + String.Format(NUMBER_FORMAT, 1));
            }
        }

        public static String generateInvoiceNumber()
        {
            if (isDataExists(TBL_INVOICE))
            {
                String number = getLastInsertId(TBL_INVOICE, CLM_INVOICE).Substring(2);
                return (INVOICE_CODE + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
            }
            else
            {
                return (INVOICE_CODE + String.Format(NUMBER_FORMAT, 1));
            }
        }




        //Ishara
        public static String generateSupplierCode()
        {
            String number = getLastInsertId("suppliers", "sup_code").Substring(2);
            return ("SP" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateItemCode()
        {
            String number = getLastInsertId("stocks", "item_code").Substring(1);
            return ("I" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateOrderCode()
        {
            String number = getLastInsertId("orders", "order_code").Substring(2);
            return ("OD" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }


        //Lahiru
        public static string generateEquipmentsCode()
        {
            String number = getLastInsertId("equipments", "item_code").Substring(2);
            return ("EQ" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateItemRepairCode()
        {
            String number = getLastInsertId("equipment_repair", "eq_repair_id").Substring(3);
            return ("EQR" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static string generateRentVehicleRenewId()
        {
            String number = getLastInsertId("rental_vehicle_renew", "renew_id").Substring(3);
            return ("RVR" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static string generateRentVehicleRRepaiServiceId()
        {
            String number = getLastInsertId("rental_vehicle_repair_service", "maintanance_id").Substring(4);
            return ("RVRS" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }


        //Sajith
        public static String generateRentalVehicleCode()
        {
            String number = getLastInsertId("rental_vehicle", "rv_id").Substring(2);
            return ("RV" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateRentalDetailsCode()
        {
            String number = getLastInsertId("rental_details", "rnt_id").Substring(2);
            return ("RD" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateCustomerCode()
        {
            String number = getLastInsertId("customers", "c_code").Substring(1);
            return ("C" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateRentalBillCode()
        {
            String number = getLastInsertId("rental_bill_details", "bill_id").Substring(2);
            return ("RB" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateRentalInvoiceCode()
        {
            String number = getLastInsertId("rental_invoice", "in_id").Substring(2);
            return ("IN" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }


        //Shaleendra

        public String generateReturnItemCode()
        {
            String number = getLastInsertId("return_items", "return_id").Substring(2);
            return ("RI" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateSalesItemCode()
        {
            String number = getLastInsertId("sales_items", "item_id").Substring(2);
            return ("SI" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateSalescode()
        {
            String number = getLastInsertId("sales", "sales_id").Substring(2);
            return ("SA" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateSalescustomercode()
        {
            String number = getLastInsertId("salescustomer", "cus_id").Substring(2);
            return ("SC" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }


        //Sachin
        public static String generateCustomerID()
        {
            String number = getLastInsertId("customers", "c_code").Substring(1);
            return ("C" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateAppointmentID()
        {
            String number = getLastInsertId("appointment", "appointment_id").Substring(1);
            return ("A" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateSlotID()
        {
            String number = getLastInsertId("slots", "slot_id").Substring(1);
            return ("SL" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        //Sameer
        public static String generateLoanID()
        {
            string number = getLastInsertId("loans", "l_id").Substring(2);
            return ("LN" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateInstallmentID()
        {
            string number = getLastInsertId("installments", "ins_id").Substring(2);
            return ("IN" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateBillID()
        {
            string number = getLastInsertId("bills", "b_id").Substring(2);
            return ("BL" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateLoanPaymentID()
        {
            string number = getLastInsertId("loan_payments", "lp_ins_id").Substring(2);
            return ("IN" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        //Buddhi

        public static String generateEmployeeID()
        {
            String number = getLastInsertId("employee", "e_code").Substring(1);
            return ("E" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateEmployeesalaryID()
        {
            String number = getLastInsertId("emp_salary", "sal_id").Substring(2);
            return ("ES" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }

        public static String generateEmployeeAttendeceID()
        {
            String number = getLastInsertId("emp_attendance", "att_id").Substring(2);
            return ("EA" + String.Format(NUMBER_FORMAT, (Convert.ToInt32(number) + 1)));
        }


        public static String getLastInsertId(String tbl_name, String clm_name)
        {
            try
            {
                Database db = new Database();
                String query = "SELECT TOP 1 " + clm_name + " FROM " + tbl_name + " ORDER BY " + clm_name + " DESC";
                db.openConnection();
                db.sqlQuery(query);
                String id = db.executeQuery(clm_name);
                db.closeConnection();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static bool isDataExists(String tbl_name)
        {
            try
            {
                Database db = new Database();
                String query = "SELECT * FROM " + tbl_name + "";
                db.openConnection();
                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                db.closeConnection();
                return (dt != null && dt.Rows.Count > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }
        }
    }
}
