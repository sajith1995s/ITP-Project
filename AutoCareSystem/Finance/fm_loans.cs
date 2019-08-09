using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class fm_loans : UserControl
    {
        bool dataPassed = false;
        string id = "";
        string operation = "default";
        string validation = "true";
        string insertstatus = "not validated";

        public fm_loans()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RefreshButtonEnabled(dataPassed);

            string query = "select l_id as 'Loan ID', l_lender_name as 'Lender Name', l_start_date as 'Start Date', l_period as 'Period', l_amount as 'Amount', l_rate as 'Rate' from loans";
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
                db.openConnection();
                db.sqlQuery(query);
                DataTable DT = db.executeQuery();
                bunifuCustomDataGrid1.DataSource = DT;
                db.closeConnection();
            }
            catch (Exception exception)
            {
                MyDialog.Show("Exception...!", exception.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                InsertLoan();
            }
            else
            {
                MyDialog.Show("Error!", "Invalid Data");
            }
        }

        private void InsertLoan()
        {
            string loanId = CodeGenerator.generateLoanID();
            int period = Convert.ToInt32(txtPeriod.Text);
            float amount = float.Parse(txtAmount.Text);
            float rate = float.Parse(txtRate.Text);
            string query = "INSERT INTO loans (l_id, l_lender_name, l_start_date, l_period, l_amount, l_rate) VALUES ( ";
            query += "'" + loanId + "', '" + txtName.Text + "', '" + dateStart.Value.ToString("yyyy-MM-dd") + "', " + period + ", " + amount + ", " + rate + ") ";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            if (db.nonQuery())
            {
                MyDialog.Show("Success...!", "Loan Added");
                DateTime dt = dateStart.Value;
                float monthlyAmount = GetMonthlyAmount(amount, rate, period);
                CreateInstallmentRecords(loanId, monthlyAmount, period, dt.Year, dt.Month);
                query = "select l_id as 'Loan ID', l_lender_name as 'Lender Name', l_start_date as 'Start Date', l_period as 'Period', l_amount as 'Amount', l_rate as 'Rate' from loans";
                BindGridView(query);
            }
            else
            {
                MyDialog.Show("Failed...!", "Loan Not Added");
            }
            db.closeConnection();

        }

        private float GetMonthlyAmount(float amount, float rate, int period)
        {
            float total;
            float monthlyAmount;
            total = ((float)1 + (rate / (float)100)) * amount;
            monthlyAmount = total / (float)period;
            return monthlyAmount;
        }

        private void CreateInstallmentRecords(string loan_id, float amount, int period, int year, int month)
        {
            string installment_id;
            string query = "";
            bool temp_error = false;
            int m, y;
            DateTime dt = Convert.ToDateTime(month + "/01" + "/" + year);
            //MessageBox.Show(dt.ToString());
            for (int count = 1; count <= period; count++)
            {
                installment_id = CodeGenerator.generateInstallmentID();
                dt = dt.AddMonths(1);
                month = dt.Month;
                year = dt.Year;
                query = "INSERT INTO installments (ins_id, ins_l_id, ins_amount, ins_year, ins_month) VALUES ('" + installment_id + "', '" + loan_id + "', " + amount + ", " + year + ", " + month + ");";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                if (!db.nonQuery())
                {
                    temp_error = true;
                }
                db.closeConnection();
            }

            if (temp_error == true)
            {
                MyDialog.Show("Success...!", "Error Adding Installments");
            }
            else
            {
                MyDialog.Show("Success...!", "Installments Added");
            }

        }

        private bool ValidateFields()
        {
            string errors = "Fields: ";
            bool status = true;
            if (!Validator.IsValidNameWithSpaces(txtName.Text))
            {
                status = false;
                errors += "Name ";
            }
            if (!Validator.isValidPeriod(txtPeriod.Text))
            {
                status = false;
                errors += "Period ";
            }
            if (!Validator.IsValidPrice1(txtAmount.Text))
            {
                status = false;
                errors += "Amount ";
            }
            if (!Validator.isValidRate(txtRate.Text))
            {
                status = false;
                errors += "Rate ";
            }
            if (status == false)
            {
                validation = "bypass";
                MyDialog.Show("Invalid Data", errors);
            }
            else
            {
                validation = "true";
            }
            
            return status;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            operation = "clear";
            validation = "bypass";
        }

        private void clearFields()
        {
            txtName.Text = string.Empty; ;
            txtPeriod.Text = string.Empty; ;
            txtAmount.Text = string.Empty; ;
            txtRate.Text = string.Empty; ;
            dateStart.Text = string.Empty;
            dateEnd.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtMonthly.Text = string.Empty;
            RefreshButtonEnabled(false);
        }

        private void RefreshButtonEnabled(bool dataPassed)
        {
            btnUpdate.Enabled = dataPassed;
            btnRemove.Enabled = dataPassed;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Updating a loan will delete all its payment records", "Confirm Update", MessageBoxButtons.OKCancel) == DialogResult.OK) && (ValidateFields()))
            {
                try
                {
                    string query = "update loans set l_lender_name = '"+txtName.Text+"', l_start_date = '"+dateStart.Value.ToShortDateString()+"', l_period = "+Convert.ToInt32(txtPeriod.Text)+", l_amount = "+float.Parse(txtAmount.Text)+", l_rate = "+float.Parse(txtRate.Text)+" ";
                    query += "where l_id = '"+id+"'; ";
                    Database db = new Database();
                    db.openConnection();
                    db.sqlQuery(query);
                    if (db.nonQuery())
                    {
                        MyDialog.Show("Update Successful", "Loan was successfully Updated");
                        clearFields();
                        query = "select l_id as 'Loan ID', l_lender_name as 'Lender Name', l_start_date as 'Start Date', l_period as 'Period', l_amount as 'Amount', l_rate as 'Rate' from loans";
                        BindGridView(query);
                        DeleteLoanPayments(id);
                    }
                    else
                    {
                        MyDialog.Show("Update Failed", "Updating Loan Failed");
                    }
                    db.closeConnection();
                }
                catch (Exception exc)
                {
                    MyDialog.Show("Exception...!", exc.ToString());
                }

            }
            else
            {
                MyDialog.Show("Error...!", "Input Error");

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteLoanPayments(id);
                DeleteInstallmentRecords(id);
                string query = "DELETE FROM loans WHERE l_id = '" + id + "'";
                Database db = new Database();
                db.openConnection();
                db.sqlQuery(query);
                
                if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (db.nonQuery())
                    {
                        MyDialog.Show("Delete Successful", "Loan was deleted successfully");
                        clearFields();
                        query = "select l_id as 'Loan ID', l_lender_name as 'Lender Name', l_start_date as 'Start Date', l_period as 'Period', l_amount as 'Amount', l_rate as 'Rate' from loans";
                        BindGridView(query);
                    }
                    else
                    {
                        MyDialog.Show("Delete Failed", "Deleting Loan Failed");
                    }
                }
                else
                {
                    MyDialog.Show("Delete Cancelled", "Delete Cancelled");
                }
                db.closeConnection();
            }
            catch (Exception exc)
            {
                MyDialog.Show("Exception...!", exc.ToString());
            }
        }

        private void DeleteInstallmentRecords(string l_id)
        {
            string query = "delete from installments where ins_l_id = '"+l_id+"'; ";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.closeConnection();
        }

        private void DeleteLoanPayments(string l_id)
        {
            string query = "delete from loan_payments where lp_l_id = '"+l_id+"';";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            db.nonQuery();
            db.closeConnection();
        }

        private bool IsFieldsEmpty()
        {
            bool status = false;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                status = true;
            }
            if (string.IsNullOrWhiteSpace(txtPeriod.Text))
            {
                status = true;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                status = true;
            }
            if (string.IsNullOrWhiteSpace(txtRate.Text))
            {
                status = true;
            }
            return status;
        }
        private void refreshValues(object sender, EventArgs e)
        {
            if (!IsFieldsEmpty())
            {
                double amount = 0, rate = 0, period = 0;
                if (ValidateFields())
                {
                    try
                    {
                        amount = Convert.ToDouble(txtAmount.Text);
                        rate = Convert.ToDouble(txtRate.Text);
                        try
                        {
                            period = Convert.ToDouble(txtPeriod.Text);
                            rate = rate * (period / 12.00);
                            rate = (rate + 100.00) / 100.00;

                            double total = amount * rate;
                            txtTotal.Text = Convert.ToString(total);

                            double monthly = total / period;
                            txtMonthly.Text = Convert.ToString(monthly);
                            int periodInt = Convert.ToInt32(txtPeriod.Text);
                            DateTime DT = dateStart.Value;
                            DT = DT.AddMonths(periodInt);
                            dateEnd.Text = DT.ToShortDateString();
                        }
                        catch (System.FormatException exc)
                        {
                            MyDialog.Show("Error...!", "Invalid Data Format");
                        }
                    }
                    catch (Exception exc)
                    {
                        MyDialog.Show("Exception...!", exc.ToString());
                    }
                }
            }
        }

        private void CellClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            operation = "default";
            validation = "true";
            dataPassed = false;
            RefreshButtonEnabled(dataPassed);

            id = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();

            dateStart.Text = (Convert.ToDateTime(bunifuCustomDataGrid1.CurrentRow.Cells[2].Value)).ToShortDateString();

            txtPeriod.Text = bunifuCustomDataGrid1.CurrentRow.Cells[3].Value.ToString();

            txtAmount.Text = bunifuCustomDataGrid1.CurrentRow.Cells[4].Value.ToString();

            txtRate.Text = bunifuCustomDataGrid1.CurrentRow.Cells[5].Value.ToString();
            dataPassed = true;
            RefreshButtonEnabled(dataPassed);
            refreshValues(sender, e);
        }

        private string getOriginalID(string fakeID)
        {
            string conID = fakeID;
            string[] parts = conID.Split('N');
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            return parts[1];
        }

        private void txtRate_Click(object sender, EventArgs e)
        {
            validation = "true";
        }
    }
}
