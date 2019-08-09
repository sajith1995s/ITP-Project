using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class fm_loan_payments : UserControl
    {
        bool loanSelected = false;
        public fm_loan_payments()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            groupBox2.Enabled = false;
            string query = "select lp_ins_id as 'Installment ID', lp_l_id as 'Loan ID', lp_payment_date as 'Date', lp_payment_amount as 'Amount' from loan_payments";
            BindGridView(query);

        }

        private void BindGridView(string query)
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = null;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                Database db = new Database();

                db.sqlQuery(query);
                DataTable DT = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = DT;

            }
            catch (Exception exception)
            {
                MyDialog.Show("Exception...!", exception.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAndUpdate(txtId.Text);

        }
        private void SearchAndUpdate(string id)
        {
            string query = "select lp_ins_id as 'Installment ID', lp_l_id as 'Loan ID', lp_payment_date as 'Date', lp_payment_amount as 'Amount' ";
            query += "from loan_payments ";
            query += "where lp_l_id = '" + id + "' ; ";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            DataTable loan_payments = db.executeQuery();

            query = "select l_id as 'Loan ID', l_lender_name as 'Lender Name', l_start_date as 'Start Date', l_period as 'Period', l_amount as 'Amount', l_rate as 'Rate' ";
            query += "from loans ";
            query += "where l_id = '" + id + "'; ";
            db.sqlQuery(query);
            DataTable loans = db.executeQuery();

            query = "select * from installments where ins_l_id = '" + id + "'; ";

            db.sqlQuery(query);
            DataTable installments = db.executeQuery();
            db.closeConnection();
            if (loans.Rows.Count >= 1)
            {
                lblPeriod.Text = loans.Rows[0][3].ToString();
            }

            if (installments.Rows.Count >= 1)
            {
                lblMonthlyAmount.Text = installments.Rows[0][2].ToString();
            }

            if (loans.Rows.Count == 1)
            {
                bunifuCustomDataGrid1.DataSource = null;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                bunifuCustomDataGrid1.DataSource = loan_payments;
                loanSelected = true;
                groupBox2.Enabled = true;
                lblID.Text = id;
                if (loan_payments.Rows.Count == 0)
                {
                    query = "select min(ins_year) as 'Start Year' from installments where ins_l_id = '" + lblID.Text + "';";
                    db.openConnection();
                    db.sqlQuery(query);
                    DataTable temp_table = db.executeQuery();
                    lblYear.Text = temp_table.Rows[0][0].ToString();
                    query = "select min(ins_month) as 'Start Month' from installments where ins_l_id = '" + lblID.Text + "' and ins_year = " + Convert.ToInt32(lblYear.Text) + "; ";
                    db.sqlQuery(query);
                    temp_table = db.executeQuery();
                    lblMonth.Text = temp_table.Rows[0][0].ToString();
                }
                else
                {
                    query = "select max(ins.ins_year) as 'Max Year', max(ins.ins_month) as 'Max Month' ";
                    query += "from installments ins, loan_payments lp ";
                    query += "where ins.ins_id = lp.lp_ins_id and ins.ins_l_id = '" + id + "' and ins_year = ( ";
                    query += "select max(ins.ins_year) as 'Max Year' ";
                    query += "from installments ins, loan_payments lp ";
                    query += "where ins.ins_id = lp.lp_ins_id and ins.ins_l_id = '" + id + "'); ";

                    db.sqlQuery(query);
                    db.openConnection();
                    DataTable table = db.executeQuery();
                    db.closeConnection();

                    if (table.Rows.Count >= 1)
                    {
                        int year = Convert.ToInt32(table.Rows[0][0]);
                        int month = Convert.ToInt32(table.Rows[0][1]);

                        month++;
                        if (month > 12)
                        {
                            year++;
                            month = 1;
                        }

                        lblYear.Text = year.ToString();
                        lblMonth.Text = month.ToString();
                    }

                }
            }
            else
            {
                MyDialog.Show("Error...!", "Invalid Loan ID");
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            string query = "select lp_ins_id as 'Installment ID', lp_l_id as 'Loan ID', lp_payment_date as 'Date', lp_payment_amount as 'Amount' from loan_payments";
            BindGridView(query);
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();

            groupBox2.Enabled = false;
            string query = "select max(ins_year) as 'End Year', max(ins_month) as 'End Month' ";
            query += "from installments ";
            query += "where ins_l_id = '" + lblID.Text + "' and ins_year = ( ";
            query += "      select max(ins_year) as 'End Date' ";
            query += "      from installments ";
            query += "      where ins_l_id = '" + lblID.Text + "'); ";
            db.sqlQuery(query);
            DataTable end_table = db.executeQuery();
            int endYear = Convert.ToInt32(end_table.Rows[0][0]);
            int endMonth = Convert.ToInt32(end_table.Rows[0][1]);
            int CurrentYear = Convert.ToInt32(lblYear.Text);
            int CurrentMonth = Convert.ToInt32(lblMonth.Text);

            if (CurrentYear < endYear)
            {
                query = "select ins_id from installments ";
                query += "where ins_l_id = '" + lblID.Text + "' and ins_year = " + int.Parse(lblYear.Text) + " and ins_month = " + int.Parse(lblMonth.Text) + "; ";

                db.sqlQuery(query);

                DataTable temp_table = db.executeQuery();
                string ins_id = temp_table.Rows[0][0].ToString();
                query = "insert into loan_payments (lp_ins_id, lp_l_id, lp_payment_date, lp_payment_amount) ";
                query += "values ('" + ins_id + "', '" + lblID.Text + "', '" + Convert.ToDateTime(paymentDate.Value).ToShortDateString() + "', " + float.Parse(lblMonthlyAmount.Text) + "); ";
                db.sqlQuery(query);
                if (db.nonQuery())
                {
                    MyDialog.Show("Success", "Made Payment");
                }
                else
                {
                    MyDialog.Show("Error...!", "Failed to make payment");
                }
            }
            else if (CurrentYear == endYear)
            {
                if (CurrentMonth <= endMonth)
                {
                    query = "select ins_id from installments ";
                    query += "where ins_l_id = '" + lblID.Text + "' and ins_year = " + int.Parse(lblYear.Text) + " and ins_month = " + int.Parse(lblMonth.Text) + "; ";

                    db.sqlQuery(query);

                    DataTable temp_table = db.executeQuery();
                    string ins_id = temp_table.Rows[0][0].ToString();
                    query = "insert into loan_payments (lp_ins_id, lp_l_id, lp_payment_date, lp_payment_amount) ";
                    query += "values ('" + ins_id + "', '" + lblID.Text + "', '" + Convert.ToDateTime(paymentDate.Value).ToShortDateString() + "', " + float.Parse(lblMonthlyAmount.Text) + "); ";
                    db.sqlQuery(query);
                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success", "Made Payment");
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Failed to make payment");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "All payments have been made");
                }
            }
            else
            {
                MyDialog.Show("Error...!", "All payments have been made");
            }

            SearchAndUpdate(lblID.Text);
            groupBox2.Enabled = true;

            query = "select lp_ins_id as 'Installment ID', lp_l_id as 'Loan ID', lp_payment_date as 'Date', lp_payment_amount as 'Amount' ";
            query += "from loan_payments ";
            query += "where lp_l_id = '" + lblID.Text + "' ; "; ;
            BindGridView(query);
            db.closeConnection();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.openConnection();
            // Getting year and month of the first installment of the Lender ID in Label
            string query = "select min(ins_year) as 'Start Year', min(ins_month) as 'Start Month' ";
            query += "from installments ";
            query += "where ins_l_id = '" + lblID.Text + "' and ins_year = ( ";
            query += "      select min(ins_year) as 'Start Year' ";
            query += "      from installments ";
            query += "      where ins_l_id = '" + lblID.Text + "'); ";
            db.sqlQuery(query);
            DataTable end_table = db.executeQuery();
            db.closeConnection();
            int startYear = Convert.ToInt32(end_table.Rows[0][0]);
            int startMonth = Convert.ToInt32(end_table.Rows[0][1]);
            int CurrentYear = Convert.ToInt32(lblYear.Text);
            int CurrentMonth = Convert.ToInt32(lblMonth.Text);
            CurrentMonth--;
            if (CurrentMonth == 0)
            {
                CurrentYear--;
                CurrentMonth = 12;
            }

            if (CurrentYear > startYear)
            {
                GetInstallmentIDAndDeletePayment(CurrentYear, CurrentMonth);
            }
            else if (CurrentYear == startYear)
            {
                if (CurrentMonth >= startMonth)
                {
                    GetInstallmentIDAndDeletePayment(CurrentYear, CurrentMonth);
                }
                else
                {
                    MyDialog.Show("Error...!", "No Payments exist for this Loan");
                }
            }
            else
            {
                MyDialog.Show("Error...!", "No Payments exist for this Loan");
            }



        }


        private void GetInstallmentIDAndDeletePayment(int CurrentYear, int CurrentMonth)
        {
            Database db = new Database();
            db.openConnection();
            // Get Installment ID of the last loan payment
            string query = "select ins_id from installments ";
            query += "where ins_l_id = '" + lblID.Text + "' and ins_year = " + CurrentYear + " and ins_month = " + CurrentMonth + "; ";

            db.sqlQuery(query);
            DataTable temp_table = db.executeQuery();
            string ins_id = "";

            ins_id = temp_table.Rows[0][0].ToString();

            query = "delete from loan_payments ";
            query += "where lp_ins_id = '" + ins_id + "'; ";
            db.sqlQuery(query);
            if (db.nonQuery())
            {
                MyDialog.Show("Success", "Last Payment Deleted");
                query = "select lp_ins_id as 'Installment ID', lp_l_id as 'Loan ID', lp_payment_date as 'Date', lp_payment_amount as 'Amount' ";
                query += "from loan_payments ";
                query += "where lp_l_id = '" + lblID.Text + "' ; "; ;
                BindGridView(query);
                SearchAndUpdate(lblID.Text);
            }
            else
            {
                MyDialog.Show("Error...!", "Deleting Failed");
            }
            db.closeConnection();
        }
    }
}
