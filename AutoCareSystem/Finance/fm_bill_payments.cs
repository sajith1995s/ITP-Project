using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoCareSystem
{
    public partial class fm_bill_payments : UserControl
    {
        bool billSelected = false;
        bool prevPaid = false;
        private string DATE_FORMAT = "yyyy-MM-dd";
        public fm_bill_payments()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string query = "select bp_b_id as 'Bill ID', bp_paid_amount as 'Paid Amount', bp_paid_date as 'Paid Date' from bill_payments";
            BindGridView(query);
            grpboxBillPayments.Enabled = false;
        }

        private void BindGridView(string query)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prevPaid = false;
            string bpquery = "select bp_b_id, bp_paid_amount, bp_paid_date from bill_payments where bp_b_id = '" + txtId.Text+"';";
            string billsquery = "select b_id, b_type, b_monthly_amount, b_issue_date from bills where b_id = '"+txtId.Text+"'; ";
            Database db = new Database();

            db.openConnection();

            db.sqlQuery(billsquery);
            DataTable billstable = new DataTable();
            billstable = db.executeQuery();

            db.sqlQuery(bpquery);
            DataTable bptable = new DataTable();
            bptable = db.executeQuery();

            db.closeConnection();

            if (bptable.Rows.Count == 1)
            {
                prevPaid = true;
            }

            if (billstable.Rows.Count == 1)
            {
                billSelected = true;
                grpboxBillPayments.Enabled = true;
                lblBillID.Text = billstable.Rows[0][0].ToString();
                lblType.Text = billstable.Rows[0][1].ToString();
                lblAmount.Text = billstable.Rows[0][2].ToString();
                lblIssueDate.Text = Convert.ToDateTime(billstable.Rows[0][3]).ToShortDateString();
                if (prevPaid == true)
                {
                    lblPrevPaid.Text = bptable.Rows[0][1].ToString();
                    lblRemAmount.Text = (float.Parse(lblAmount.Text) - float.Parse(lblPrevPaid.Text)).ToString();
                }
                else
                {
                    lblPrevPaid.Text = "0";
                    lblRemAmount.Text = lblAmount.Text;
                }
            }
            else
            {
                billSelected = false;
                grpboxBillPayments.Enabled = false;
                MyDialog.Show("Error...!", "Invalid ID");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            txtPaidAmount.Text = lblRemAmount.Text;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (billSelected == false)
            {
                // Not possible
            }
            else
            {
                string query = "" ;
                float newamount = 9999999999999;
                if (prevPaid == true)
                {
                    if (Validator.IsValidPrice1(txtPaidAmount.Text))
                    {
                        newamount = float.Parse(lblPrevPaid.Text) + float.Parse(txtPaidAmount.Text);
                        if (newamount <= float.Parse(lblAmount.Text))
                        {
                            query = "update bill_payments ";
                            query += "set  bp_paid_amount = " + newamount + ", bp_paid_date = '" + paidDate.Value.ToString(DATE_FORMAT) + "' ";
                            query += "where bp_b_id = '" + lblBillID.Text + "';";
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Paid Amount > Bill Amount");
                        }
                    }
                }
                else
                {
                    if (Validator.IsValidPrice1(txtPaidAmount.Text))
                    {
                        newamount = float.Parse(txtPaidAmount.Text);
                        if (newamount <= float.Parse(lblAmount.Text))
                        {
                            query = "insert into bill_payments (bp_b_id, bp_paid_amount, bp_paid_date) ";
                            query += "values ('" + lblBillID.Text + "', " + newamount + ",'" + paidDate.Value.ToString(DATE_FORMAT) + "')";
                        }
                        else
                        {
                            MyDialog.Show("Error...!", "Paid Amount > Bill Amount");
                        }
                    }
                }
                if(newamount <= float.Parse(lblAmount.Text))
                {
                    Database db = new Database();
                    db.sqlQuery(query);
                    db.openConnection();
                    if (db.nonQuery())
                    {
                        MyDialog.Show("Success", "Payment made successfully");
                        query = "select bp_b_id as 'Bill ID', bp_paid_amount as 'Paid Amount', bp_paid_date as 'Paid Date' from bill_payments";
                        BindGridView(query);
                    }
                    else
                    {
                        MyDialog.Show("Error...!", "Failed to make payment");
                    }
                    db.closeConnection();
                }
                
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            string query = "select bp_b_id as 'Bill ID', bp_paid_amount as 'Paid Amount', bp_paid_date as 'Paid Date' from bill_payments";
            BindGridView(query);
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblBillID.Text = bunifuCustomDataGrid1.CurrentRow.Cells[0].Value.ToString();

            string query = "select b_id, b_type, b_monthly_amount, b_issue_date from bills where b_id = '" + lblBillID.Text + "'; ";
            Database db = new Database();
            db.openConnection();
            db.sqlQuery(query);
            DataTable table = new DataTable();
            table = db.executeQuery();
            db.closeConnection();
            lblType.Text = table.Rows[0][1].ToString();

            lblAmount.Text = table.Rows[0][2].ToString();

            lblIssueDate.Text = Convert.ToDateTime(table.Rows[0][3]).ToShortDateString();

            lblPrevPaid.Text = bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();

            lblRemAmount.Text = (float.Parse(lblAmount.Text) -  float.Parse(lblPrevPaid.Text)).ToString();

            txtPaidAmount.Text = string.Empty;
            billSelected = true;
            prevPaid = true;
            grpboxBillPayments.Enabled = true;
        }
    }
}
