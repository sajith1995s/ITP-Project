using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AutoCareSystem
{
    public partial class fm_manage_bills : UserControl
    {
        string DATE_FORMAT = "yyyy-MM-dd";
        bool dataPassed = false;
        int id = -1;
        bool rowSelected = false;

        public fm_manage_bills()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbType.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 4;
            RefreshButtonEnabled(dataPassed);

            string query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills;";
            BindGridView(query);
        }

        public void BindGridView(string query)
        {
            try
            {
                bunifuCustomDataGrid1.DataSource = null;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                Database db = new Database();
                DataTable table = new DataTable();
                db.openConnection();
                db.sqlQuery(query);
                table = db.executeQuery();
                db.closeConnection();

                bunifuCustomDataGrid1.DataSource = null;
                bunifuCustomDataGrid1.Rows.Clear();
                bunifuCustomDataGrid1.Refresh();
                bunifuCustomDataGrid1.DataSource = table;
            }
            catch (SqlException ex)
            {
                MyDialog.Show("SQLException", Convert.ToString(ex));
            }
            catch (InvalidOperationException ex)
            {
                MyDialog.Show("InvalidOperationException", Convert.ToString(ex));
            }
            catch (Exception e)
            {
                MyDialog.Show("Exception...!", Convert.ToString(e));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            cmbType.SelectedIndex = 0;
            txtId.Text = string.Empty;
            txtMonthly.Text = string.Empty;
            issueDate.Text = string.Empty;
            dataPassed = false;
            RefreshButtonEnabled(dataPassed);

            rowSelected = false;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex monthlyAmount = new Regex("^[0-9]{1-8},[0-9]{0,2}$");
            if (rowSelected == false)
            {
                if (Validator.IsValidPrice1(txtMonthly.Text))
                {
                    if (Validator.IsValidPastDate(issueDate.Value.ToString(DATE_FORMAT)))
                    {
                        //CodeGenerator CG = new CodeGenerator();
                        string billID = CodeGenerator.generateBillID();
                        string query = "insert into bills (b_id, b_type, b_monthly_amount, b_issue_date) ";
                        query += " values ('" + billID + "', '" + cmbType.SelectedItem.ToString() + "', " + float.Parse(txtMonthly.Text) + ", '" + issueDate.Value.ToShortDateString() + "');";
                        Database db = new Database();
                        db.openConnection();
                        db.sqlQuery(query);
                        if (db.nonQuery())
                        {
                            MyDialog.Show("Successful", "Bill was added successfully");
                            query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills;";
                            BindGridView(query);
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Adding Failed");
                        }
                        db.closeConnection();
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Issue date is in the future");
                    }
                }
                else
                {
                    MyDialog.Show("Error...!", "Invalid monthly amount");
                }
            }
            else
            {
                MyDialog.Show("Error...!", "Clear before adding");
            }

        }

        private bool validateFields() // return true-add, false-abort
        {
            return true;
        }

        private bool IsBillTypeInvalid(string data)
        {
            if (data == "Electricity")
                return false;
            else if (data == "Internet")
                return false;
            else if (data == "Water")
                return false;
            else if (data == "Select Type")
                return true;
            else
                return true;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rowSelected == true)
            {
                string query = "update bills ";
                query += "set b_type = '" + cmbType.SelectedItem.ToString() + "', b_monthly_amount = " + float.Parse(txtMonthly.Text) + ", b_issue_date = '" + issueDate.Value.ToShortDateString() + "' ";
                query += "where b_id = '" + txtId.Text + "'; ";
                Database db = new Database();
                db.sqlQuery(query);
                db.openConnection();
                if (db.nonQuery())
                {
                    MyDialog.Show("Update Successful", "Bill was updated successfully");
                    query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills;";
                    BindGridView(query);
                }
                else
                {
                    MyDialog.Show("Error...!", "Updating bill failed");
                }
                db.closeConnection();
            }
            else
            {
                MyDialog.Show("Error...!", "No Row Selected");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (rowSelected == true)
            {
                try
                {
                    Database db = new Database();
                    db.openConnection();
                    if (MessageBox.Show("Delete?", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        string query;
                        query = "delete from bill_payments where bp_b_id = '" + txtId.Text + "'; ";
                        db.sqlQuery(query);
                        db.nonQuery();

                        query = "DELETE FROM bills WHERE b_id = '" + txtId.Text + "'; ";
                        db.sqlQuery(query);
                        if (db.nonQuery())
                        {
                            MyDialog.Show("Delete Successful", "Bill was deleted successfully");

                            query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills;";

                            BindGridView(query);
                            clearFields();
                        }
                        else
                        {
                            MyDialog.Show("Delete Failed", "Deleting Bill Failed");
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
            else
            {
                MyDialog.Show("Error...!", "Select a row to delete");
            }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();
            string type = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            switch (type)
            {
                case "Electricity":
                    cmbType.SelectedIndex = 1;
                    break;
                case "Internet":
                    cmbType.SelectedIndex = 2;
                    break;
                case "Water":
                    cmbType.SelectedIndex = 3;
                    break;
            }
            txtMonthly.Text = bunifuCustomDataGrid1.CurrentRow.Cells[2].Value.ToString();
            issueDate.Text = (Convert.ToDateTime(bunifuCustomDataGrid1.CurrentRow.Cells[3].Value)).ToShortDateString();

            rowSelected = true;
            btnRemove.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void RefreshButtonEnabled(bool dataPassed)
        {
            btnUpdate.Enabled = dataPassed;
            btnRemove.Enabled = dataPassed;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbFilter.Text;
            string query = "";

            switch (type)
            {
                case "All Types":
                    query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills; ";
                    break;
                default:
                    query = "select b_id as 'Bill ID', b_type as 'Type', b_monthly_amount as 'Monthly Amount', b_issue_date as 'Issue Date' from bills where b_type = '" + type + "'; ";
                    break;
            }
            BindGridView(query);
        }

    }
}
