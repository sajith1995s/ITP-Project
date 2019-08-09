using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem.Common
{
    class Data
    {
        Database db = new Database();

        public Data()
        {

        }

        public DataTable GetIncome(string displayMode)
        {
            

            string query = "";
            if (displayMode == "Separate")
            {
                query =  "select datepart(yyyy, bill_date) as 'Year', 'Rental Service' as 'Section', sum(bill_tot_amount) as 'Total Amount' ";
                query += "from rental_bill_details ";
                query += "group by datepart(yyyy, bill_date) ";
                query += "union ";
                query += "select datepart(yyyy, created_at) as 'Year', 'Sales Outlet' as 'Section', sum(total_price) as 'Total Amount' ";
                query += "from sales ";
                query += "group by DATEPART(yyyy, created_at) ";
                query += "union ";
                query += "select datepart(yyyy, ps.created_at) as 'Year', 'Services' as 'Section', sum(ps.charges) as 'Total Amount' ";
                query += "from provided_services ps, services s ";
                query += "group by datepart(yyyy, ps.created_at) ";
                query += "union ";
                query += "select datepart(yyyy, pr.created_at) as 'Year', 'Repairs' as 'Section', sum(pr.charges) as 'Total Amount' ";
                query += "from provided_repairs pr, repairs r ";
                query += "group by datepart(yyyy, pr.created_at); ";
            }
            else
            {
                query = "select Year, sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select datepart(yyyy, bill_date) as 'Year', 'Rental Service' as 'Section', sum(bill_tot_amount) as 'Total_Amount' ";
                query += "from rental_bill_details ";
                query += "group by datepart(yyyy, bill_date) ";
                query += "union ";
                query += "select datepart(yyyy, created_at) as 'Year', 'Sales Outlet' as 'Section', sum(total_price) as 'Total Amount' ";
                query += "from sales ";
                query += "group by DATEPART(yyyy, created_at) ";
                query += "union ";
                query += "select datepart(yyyy, ps.created_at) as 'Year', 'Services' as 'Section', sum(ps.charges) as 'Total Amount' ";
                query += "from provided_services ps, services s ";
                query += "group by datepart(yyyy, ps.created_at) ";
                query += "union ";
                query += "select datepart(yyyy, pr.created_at) as 'Year', 'Repairs' as 'Section', sum(pr.charges) as 'Total Amount' ";
                query += "from provided_repairs pr, repairs r ";
                query += "group by datepart(yyyy, pr.created_at) ";
                query += ") as subquery ";
                query += "group by Year;";
            }
            
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();
            return table;
        }

        public DataTable GetIncome(string displayMode, int year)
        {
            string query;
            if (displayMode == "Separate")
            {
                query = "select datepart(MM, bill_date) as 'Month', 'Rental Service' as 'Section', sum(bill_tot_amount) as 'Total Amount' ";
                query += "from rental_bill_details ";
                query += "where datepart(yyyy, bill_date) = "+year+" ";
                query += "group by datepart(MM, bill_date) ";
                query += "union ";
                query += "select datepart(MM, created_at) as 'Month', 'Sales Outlet' as 'Section', sum(total_price) as 'Total Amount' ";
                query += "from sales ";
                query += "where datepart(yyyy, created_at) = "+year+" ";
                query += "group by DATEPART(MM, created_at) ";
                query += "union ";
                query += "select datepart(MM, ps.created_at) as 'Month', 'Services' as 'Section', sum(ps.charges) as 'Total Amount' ";
                query += "from provided_services ps, services s ";
                query += "where datepart(yyyy, ps.created_at) = "+year+" ";
                query += "group by datepart(MM, ps.created_at) ";
                query += "union ";
                query += "select datepart(MM, pr.created_at) as 'Year', 'Repairs' as 'Section', sum(pr.charges) as 'Total Amount' ";
                query += "from provided_repairs pr, repairs r ";
                query += "where datepart(yyyy, pr.created_at) = " + year + " ";
                query += "group by datepart(MM, pr.created_at);";
            }
            else // displayMode = Total
            {
                query = "select Month, sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select datepart(MM, bill_date) as 'Month', 'Rental Service' as 'Section', sum(bill_tot_amount) as 'Total_Amount' ";
                query += "from rental_bill_details ";
                query += "where datepart(yyyy, bill_date) = "+year+" ";
                query += "group by datepart(MM, bill_date) ";
                query += "union ";
                query += "select datepart(MM, created_at) as 'Month', 'Sales Outlet' as 'Section', sum(total_price) as 'Total_Amount' ";
                query += "from sales ";
                query += "where datepart(yyyy, created_at) = "+year+" ";
                query += "group by DATEPART(MM, created_at) ";
                query += "union ";
                query += "select datepart(MM, ps.created_at) as 'Month', 'Services' as 'Section', sum(ps.charges) as 'Total_Amount' ";
                query += "from provided_services ps, services s ";
                query += "where datepart(yyyy, ps.created_at) = "+year+" ";
                query += "group by datepart(MM, ps.created_at) ";
                query += "union ";
                query += "select datepart(MM, pr.created_at) as 'Year', 'Repairs' as 'Section', sum(pr.charges) as 'Total_Amount' ";
                query += "from provided_repairs pr, repairs r ";
                query += "where datepart(yyyy, pr.created_at) = "+year+" ";
                query += "group by datepart(MM, pr.created_at) ";
                query += ") as subquery ";
                query += "group by Month; ";
            }
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();
            return table;
        }

        public DataTable GetExpenses(string displayMode)
        {
            string query = "";
            if (displayMode == "Separate")
            {
                // Maintenance
                query = "select Year, 'Maintenance' as 'Section', sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from equipment_repair ";
                query += "group by datepart(yyyy, maintanance_date) ";
                query += "union ";
                query += "select datepart(yyyy, renew_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_renew ";
                query += "group by datepart(yyyy, renew_date) ";
                query += "union ";
                query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_repair_service ";
                query += "group by datepart(yyyy, maintanance_date) ";
                query += ") as subquery ";
                query += "group by Year ";
                query += "union ";
                // Employee
                query += "select datepart(yyyy, sal_date) as 'Year', 'Employee' as 'Section', sum(total_salary) as 'Total Amount' ";
                query += "from emp_salary ";
                query += "group by datepart(yyyy, sal_date) ";
                query += "union ";
                // Inventory
                query += "select datepart(yyyy, o.created_at) as 'Year', 'Inventory' as 'Section', sum(t.Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select order_code, sum(amount) as 'Total_Amount' ";
                query += "from ordered_items ";
                query += "group by order_code) as t, orders o ";
                query += "where o.order_code = t.order_code ";
                query += "group by datepart(yyyy, o.created_at) ";
                query += "union ";
                // Bills
                query += "select datepart(yyyy, bp_paid_date) as 'Year', 'Bills' as 'Section', sum(bp_paid_amount) as 'Total Amount' ";
                query += "from bill_payments ";
                query += "group by datepart(yyyy, bp_paid_date) ";
                query += "union ";
                // Loans
                query += "select datepart(yyyy, lp_payment_date) as 'Year', 'Loans' as 'Section', sum(lp_payment_amount) as 'Total Amount' ";
                query += "from loan_payments ";
                query += "group by datepart(yyyy, lp_payment_date); ";
            }
            else
            {
                query = "select Year, sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select Year, 'Maintenance' as 'Section', sum(Total_Amount) as 'Total_Amount' ";
                query += "from ( ";
                query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from equipment_repair ";
                query += "group by datepart(yyyy, maintanance_date) ";
                query += "union ";
                query += "select datepart(yyyy, renew_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_renew ";
                query += "group by datepart(yyyy, renew_date) ";
                query += "union ";
                query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_repair_service ";
                query += "group by datepart(yyyy, maintanance_date) ";
                query += ") as subquery ";
                query += "group by Year ";
                query += "union ";
                query += "select datepart(yyyy, sal_date) as 'Year', 'Employee' as 'Section', sum(total_salary) as 'Total_Amount' ";
                query += "from emp_salary ";
                query += "group by datepart(yyyy, sal_date) ";
                query += "union ";
                query += "select datepart(yyyy, o.created_at) as 'Year', 'Inventory' as 'Section', sum(t.Total_Amount) as 'Total_Amount' ";
                query += "from ( ";
                query += "select order_code, sum(amount) as 'Total_Amount' ";
                query += "from ordered_items ";
                query += "group by order_code) as t, orders o ";
                query += "where o.order_code = t.order_code ";
                query += "group by datepart(yyyy, o.created_at) ";
                query += "union ";
                query += "select datepart(yyyy, bp_paid_date) as 'Year', 'Bills' as 'Section', sum(bp_paid_amount) as 'Total Amount' ";
                query += "from bill_payments ";
                query += "group by datepart(yyyy, bp_paid_date) ";
                query += "union ";
                query += "select datepart(yyyy, lp_payment_date) as 'Year', 'Loans' as 'Section', sum(lp_payment_amount) as 'Total Amount' ";
                query += "from loan_payments ";
                query += "group by datepart(yyyy, lp_payment_date) ";
                query += ") as subquery ";
                query += "group by Year; ";
            }
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();
            return table;
        }

        public DataTable GetExpenses(string displayMode, int year)
        {
            string query = "";
            if (displayMode == "Separate")
            {
                // Maintenance
                query = "select Month, 'Maintenance' as 'Section', sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select datepart(MM, maintanance_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from equipment_repair ";
                query += "where datepart(yyyy, maintanance_date) = "+year+" ";
                query += "group by datepart(MM, maintanance_date) ";
                query += "union ";
                query += "select datepart(MM, renew_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_renew ";
                query += "where datepart(yyyy, renew_date) = "+year+" ";
                query += "group by datepart(MM, renew_date) ";
                query += "union ";
                query += "select datepart(MM, maintanance_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_repair_service ";
                query += "where datepart(yyyy, maintanance_date) = "+year+" ";
                query += "group by datepart(MM, maintanance_date) ";
                query += ") as subquery ";
                query += "group by Month ";
                query += "union ";
                // Employee
                query += "select datepart(MM, sal_date) as 'Month', 'Employee' as 'Section', sum(total_salary) as 'Total Amount' ";
                query += "from emp_salary ";
                query += "where datepart(yyyy, sal_date) = "+year+" ";
                query += "group by datepart(MM, sal_date) ";
                query += "union ";
                // Inventory
                query += "select datepart(MM, o.created_at) as 'Month', 'Inventory' as 'Section', sum(t.Total_Amount) as 'Total Amount' ";
                query += "from ";
                query += "(select order_code, sum(amount) as 'Total_Amount' ";
                query += "from ordered_items ";
                query += "group by order_code) as t, orders o ";
                query += "where o.order_code = t.order_code and datepart(yyyy, created_at) = "+year+" ";
                query += "group by datepart(MM, o.created_at) ";
                query += "union ";
                // Bills
                query += "select datepart(MM, bp_paid_date) as 'Year', 'Bills' as 'Section', sum(bp_paid_amount) as 'Total Amount' ";
                query += "from bill_payments ";
                query += "where  datepart(yyyy, bp_paid_date) = "+year+" ";
                query += "group by datepart(MM, bp_paid_date) ";
                query += "union ";
                // Loans
                query += "select datepart(MM, lp_payment_date) as 'Year', 'Loans' as 'Section', sum(lp_payment_amount) as 'Total Amount' ";
                query += "from loan_payments ";
                query += "where datepart(yyyy, lp_payment_date) = "+year+" ";
                query += "group by datepart(MM, lp_payment_date); ";
            }
            else
            {
                query = "select Month, sum(Total_Amount) as 'Total Amount' ";
                query += "from ( ";
                query += "select Month, 'Maintenance' as 'Section', sum(Total_Amount) as 'Total_Amount' ";
                query += "from ( ";
                query += "select datepart(MM, maintanance_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from equipment_repair ";
                query += "where datepart(yyyy, maintanance_date) = " + year + " ";
                query += "group by datepart(MM, maintanance_date) ";
                query += "union ";
                query += "select datepart(MM, renew_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_renew ";
                query += "where datepart(yyyy, renew_date) = " + year + " ";
                query += "group by datepart(MM, renew_date) ";
                query += "union ";
                query += "select datepart(MM, maintanance_date) as 'Month', sum(amount) as 'Total_Amount' ";
                query += "from rental_vehicle_repair_service ";
                query += "where datepart(yyyy, maintanance_date) = " + year + " ";
                query += "group by datepart(MM, maintanance_date) ";
                query += ") as subquery ";
                query += "group by Month ";
                query += "union ";
                query += "select datepart(MM, sal_date) as 'Month', 'Employee' as 'Section', sum(total_salary) as 'Total Amount' ";
                query += "from emp_salary ";
                query += "where datepart(yyyy, sal_date) = " + year + " ";
                query += "group by datepart(MM, sal_date) ";
                query += "union ";
                query += "select datepart(MM, o.created_at) as 'Month', 'Inventory' as 'Section', sum(t.Total_Amount) as 'Total Amount' ";
                query += "from ";
                query += "(select order_code, sum(amount) as 'Total_Amount' ";
                query += "from ordered_items ";
                query += "group by order_code) as t, orders o ";
                query += "where o.order_code = t.order_code and datepart(yyyy, created_at) = " + year + " ";
                query += "group by datepart(MM, o.created_at) ";
                query += "union ";
                // Bills
                query += "select datepart(MM, bp_paid_date) as 'Year', 'Bills' as 'Section', sum(bp_paid_amount) as 'Total Amount' ";
                query += "from bill_payments ";
                query += "where  datepart(yyyy, bp_paid_date) = " + year + " ";
                query += "group by datepart(MM, bp_paid_date) ";
                query += "union ";
                // Loans
                query += "select datepart(MM, lp_payment_date) as 'Year', 'Loans' as 'Section', sum(lp_payment_amount) as 'Total Amount' ";
                query += "from loan_payments ";
                query += "where datepart(yyyy, lp_payment_date) = " + year + " ";
                query += "group by datepart(MM, lp_payment_date) ";
                query += ") as subquery ";
                query += "group by Month; ";
            }
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();
            return table;
        }

        public DataTable GetProfit(string displayMode)
        {
            DataTable incomedata = GetIncome(displayMode);
            DataTable expensesdata = GetExpenses(displayMode);

            DataTable table = new DataTable();
            DataColumn dc = new DataColumn("Year", typeof(Int32));
            table.Columns.Add(dc);
            dc = new DataColumn("Income", typeof(float));
            table.Columns.Add(dc);
            dc = new DataColumn("Expenses", typeof(float));
            table.Columns.Add(dc);

            

            DataTable profitdata = new DataTable();

            int[] incomerange = GetIncomeYearRange();
            int[] expensesrange = GetExpensesYearRange();
            int[] range = new int[2];
            if (incomerange[0] < expensesrange[0])
            {
                range[0] = incomerange[0];
            }
            else
            {
                range[0] = expensesrange[0];
            }
            if (incomerange[1] > expensesrange[1])
            {
                range[1] = incomerange[1];
            }
            else
            {
                range[1] = expensesrange[1];
            }
            
            if(displayMode == "Separate")
            {

            }
            else // displayMode = Total
            {
                float incomevalue;
                float expensesvalue;
                for (; range[0] <= range[1]; range[0]++)
                {
                    incomevalue = 0;
                    expensesvalue = 0;
                    foreach (DataRow datarow in incomedata.Rows)
                    {
                        if (Convert.ToInt32(datarow[0]) == range[0])
                        {
                            incomevalue = float.Parse(datarow[1].ToString());
                            break;
                        }
                    }

                    foreach(DataRow datarow in expensesdata.Rows)
                    {
                        if (Convert.ToInt32(datarow[0]) == range[0])
                        {
                            expensesvalue = float.Parse(datarow[1].ToString());
                            break;
                        }
                    }
                    DataRow row = table.NewRow();
                    row[0] = range[0];
                    row[1] = incomevalue;
                    row[2] = expensesvalue;
                    table.Rows.Add(row);
                }
                
                dc = new DataColumn("Year", typeof(int));
                profitdata.Columns.Add(dc);
                dc = new DataColumn("Total Amount", typeof(double));
                profitdata.Columns.Add(dc);

                
                foreach (DataRow tablerow in table.Rows)
                {
                    DataRow profitrow = profitdata.NewRow();
                    profitrow[0] = tablerow[0];
                    profitrow[1] = float.Parse(tablerow[1].ToString()) - float.Parse(tablerow[2].ToString());
                    profitdata.Rows.Add(profitrow);
                }
            }
            
            return profitdata;
        }

        public DataTable GetProfit(string displayMode, int year)
        {
            DataTable incomedata = GetIncome(displayMode, year);
            DataTable expensesdata = GetExpenses(displayMode, year);

            DataTable table = new DataTable();
            DataColumn dc = new DataColumn("Month", typeof(Int32));
            table.Columns.Add(dc);
            dc = new DataColumn("Income", typeof(float));
            table.Columns.Add(dc);
            dc = new DataColumn("Expenses", typeof(float));
            table.Columns.Add(dc);
            
            DataTable profitdata = new DataTable();

            if (displayMode == "Separate")
            {

            }
            else // displayMode = Total
            {
                float incomevalue;
                float expensesvalue;
                int[] range = { 1, 12 };
                for (; range[0] <= range[1]; range[0]++)
                {
                    incomevalue = 0;
                    expensesvalue = 0;
                    foreach (DataRow datarow in incomedata.Rows)
                    {
                        if (Convert.ToInt32(datarow[0]) == range[0])
                        {
                            incomevalue = float.Parse(datarow[1].ToString());
                            break;
                        }
                    }

                    foreach (DataRow datarow in expensesdata.Rows)
                    {
                        if (Convert.ToInt32(datarow[0]) == range[0])
                        {
                            expensesvalue = float.Parse(datarow[1].ToString());
                            break;
                        }
                    }
                    DataRow row = table.NewRow();
                    row[0] = range[0];
                    row[1] = incomevalue;
                    row[2] = expensesvalue;
                    table.Rows.Add(row);
                }

                dc = new DataColumn("Month", typeof(int));
                profitdata.Columns.Add(dc);
                dc = new DataColumn("Total Amount", typeof(double));
                profitdata.Columns.Add(dc);


                foreach (DataRow tablerow in table.Rows)
                {
                    DataRow profitrow = profitdata.NewRow();
                    profitrow[0] = tablerow[0];
                    profitrow[1] = float.Parse(tablerow[1].ToString()) - float.Parse(tablerow[2].ToString());
                    profitdata.Rows.Add(profitrow);
                }
            }
            
            return profitdata;
        }

        public int[] GetIncomeYearRange()
        {
            int[] range = new int[2];

            string query;
            query =  "select min(Year) as 'Min', max(Year) as 'Max' ";
            query += "from ( ";
            query += "select datepart(yyyy, bill_date) as 'Year', 'Rental Service' as 'Section', sum(bill_tot_amount) as 'Total_Amount' ";
            query += "from rental_bill_details ";
            query += "group by datepart(yyyy, bill_date) ";
            query += "union ";
            query += "select datepart(yyyy, created_at) as 'Year', 'Sales Outlet' as 'Section', sum(total_price) as 'Total Amount' ";
            query += "from sales ";
            query += "group by DATEPART(yyyy, created_at) ";
            query += "union ";
            query += "select datepart(yyyy, ps.created_at) as 'Year', 'Services' as 'Section', sum(ps.charges) as 'Total Amount' ";
            query += "from provided_services ps, services s ";
            query += "group by datepart(yyyy, ps.created_at) ";
            query += "union ";
            query += "select datepart(yyyy, pr.created_at) as 'Year', 'Repairs' as 'Section', sum(pr.charges) as 'Total Amount' ";
            query += "from provided_repairs pr, repairs r ";
            query += "group by datepart(yyyy, pr.created_at) ";
            query += ") as subquery; ";
            
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();

            range[0] = Convert.ToInt32(table.Rows[0][0]);
            range[1] = Convert.ToInt32(table.Rows[0][1]);

            return range;
        }

        public int[] GetExpensesYearRange()
        {
            int[] range = new int[2];

            string query;

            query = "select min(Year) as 'Min', max(Year) as 'Max' ";
            query += "from ( ";
            query += "select Year, 'Maintenance' as 'Section', sum(Total_Amount) as 'Total Amount' ";
            query += "from ( ";
            query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
            query += "from equipment_repair ";
            query += "group by datepart(yyyy, maintanance_date) ";
            query += "union ";
            query += "select datepart(yyyy, renew_date) as 'Year', sum(amount) as 'Total_Amount' ";
            query += "from rental_vehicle_renew ";
            query += "group by datepart(yyyy, renew_date) ";
            query += "union ";
            query += "select datepart(yyyy, maintanance_date) as 'Year', sum(amount) as 'Total_Amount' ";
            query += "from rental_vehicle_repair_service ";
            query += "group by datepart(yyyy, maintanance_date) ";
            query += ") as subquery ";
            query += "group by Year ";
            query += "union ";
            query += "select datepart(yyyy, sal_date) as 'Year', 'Employee' as 'Section', sum(total_salary) as 'Total Amount' ";
            query += "from emp_salary ";
            query += "group by datepart(yyyy, sal_date) ";
            query += "union ";
            query += "select datepart(yyyy, o.created_at) as 'Year', 'Inventory' as 'Section', sum(t.Total_Amount) as 'Total Amount' ";
            query += "from ( ";
            query += "select order_code, sum(amount) as 'Total_Amount' ";
            query += "from ordered_items ";
            query += "group by order_code) as t, orders o ";
            query += "where o.order_code = t.order_code ";
            query += "group by datepart(yyyy, o.created_at) ";
            query += "union ";
            // Bills
            query += "select datepart(yyyy, bp_paid_date) as 'Year', 'Bills' as 'Section', sum(bp_paid_amount) as 'Total Amount' ";
            query += "from bill_payments ";
            query += "group by datepart(yyyy, bp_paid_date) ";
            query += "union ";
            // Loans
            query += "select datepart(yyyy, lp_payment_date) as 'Year', 'Loans' as 'Section', sum(lp_payment_amount) as 'Total Amount' ";
            query += "from loan_payments ";
            query += "group by datepart(yyyy, lp_payment_date) ";
            query += ") as subquery; ";
            
            DataTable table = new DataTable();
            db.openConnection();
            db.sqlQuery(query);
            table = db.executeQuery();
            db.closeConnection();

            range[0] = Convert.ToInt32(table.Rows[0][0]);
            range[1] = Convert.ToInt32(table.Rows[0][1]);

            return range;
        }
    }
}
