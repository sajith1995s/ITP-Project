using AutoCareSystem.Common;
using AutoCareSystem.Finance;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class fm_reports : UserControl
    {
        Data data = new Data();
        private string view, displayMode, dataType;
        int year;

        public fm_reports()
        {
            InitializeComponent();

            radIncome.Checked = true;
            radYearly.Checked = true;
            radSeparate.Checked = true;
        }

        private void radIncome_CheckedChanged(object sender, EventArgs e)
        {
            if(radIncome.Checked == true)
            {
                dataType = "Income";
                groupBox4.Enabled = true;
                cmbYear.Items.Clear();
                cmbYear.Items.Add("Select");
                cmbYear.SelectedIndex = 0;
                IncomeFillComboBox();
            }
        }

        public void IncomeFillComboBox()
        {
            DataTable table = new DataTable();
            int[] range = data.GetIncomeYearRange();
            int min = range[0];
            int max = range[1];
            int index = 1;
            for (; min <= max; min++)
            {
                cmbYear.Items.Insert(index, min);
                index++;
            }
        }

        private void radExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if(radExpenses.Checked == true)
            {
                dataType = "Expenses";
                groupBox4.Enabled = true;
                cmbYear.Items.Clear();
                cmbYear.Items.Add("Select");
                cmbYear.SelectedIndex = 0;
                ExpensesFillComboBox();
            }
        }

        public void ExpensesFillComboBox()
        {
            DataTable table = new DataTable();
            int[] range = data.GetExpensesYearRange();
            int min = range[0];
            int max = range[1];
            int index = 1;
            for (; min <= max; min++)
            {
                cmbYear.Items.Insert(index, min);
                index++;
            }
        }

        private void radProfit_CheckedChanged(object sender, EventArgs e)
        {
            if(radProfit.Checked == true)
            {
                dataType = "Profit";
                groupBox4.Enabled = false;
                radSeparate.Checked = false;
                radTotal.Checked = true;
                cmbYear.Items.Clear();
                cmbYear.Items.Add("Select");
                cmbYear.SelectedIndex = 0;
                ProfitFillComboBox();
            }
        }

        public void ProfitFillComboBox()
        {
            int[] incomerange = data.GetIncomeYearRange();
            int[] expensesrange = data.GetExpensesYearRange();
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
            int min = range[0];
            int max = range[1];
            int index = 1;
            for (; min <= max; min++)
            {
                cmbYear.Items.Insert(index, min);
                index++;
            }
        }

        private void radYearly_CheckedChanged(object sender, EventArgs e)
        {
            if(radYearly.Checked == true)
            {
                view = "Yearly";
                groupBox3.Enabled = false;
            }
        }

        private void radMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if(radMonthly.Checked == true)
            {
                view = "Monthly";
                groupBox3.Enabled = true;
            }
        }

        private void radSeparate_CheckedChanged(object sender, EventArgs e)
        {
            if(radSeparate.Checked == true)
            {
                displayMode = "Separate";
            }
        }

        private void radTotal_CheckedChanged(object sender, EventArgs e)
        {
            if(radTotal.Checked == true)
            {
                displayMode = "Total";
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbYear.SelectedIndex != 0)
            {
                year = Convert.ToInt32(cmbYear.SelectedItem);
            }
        }

        

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Data data = new Data();
            Reports_Data_Set ds = new Reports_Data_Set();
            DataTable table = new DataTable();
            if(dataType == "Income")
            {
                if(view == "Yearly")
                {
                    table = data.GetIncome(displayMode);
                    ds.Tables[dataType+"_"+view + "_" + displayMode].Merge(table);
                    if (displayMode == "Separate")
                    {
                        rp_income_yearly_separate myReport = new rp_income_yearly_separate();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                    else
                    {
                        rp_income_yearly_total myReport = new rp_income_yearly_total();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                }
                else if (view == "Monthly" && cmbYear.SelectedIndex != 0)
                {
                    table = data.GetIncome(displayMode, year);
                    ds.Tables[dataType + "_" + view + "_" + displayMode].Merge(table);
                    if (displayMode == "Separate")
                    {
                        rp_income_monthly_separate myReport = new rp_income_monthly_separate();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                    else
                    {
                        rp_income_monthly_total myReport = new rp_income_monthly_total();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                }
            }
            else if (dataType == "Expenses")
            {
                if (view == "Yearly")
                {
                    table = data.GetExpenses(displayMode);
                    ds.Tables[dataType + "_" + view + "_" + displayMode].Merge(table);
                    if (displayMode == "Separate")
                    {
                        rp_expenses_yearly_separate myReport = new rp_expenses_yearly_separate();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                    else
                    {
                        rp_expenses_yearly_total myReport = new rp_expenses_yearly_total();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                }
                else if (view == "Monthly" && cmbYear.SelectedIndex != 0)
                {
                    table = data.GetExpenses(displayMode, year);
                    ds.Tables[dataType + "_" + view + "_" + displayMode].Merge(table);
                    if (displayMode == "Separate")
                    {
                        rp_expenses_monthly_separate myReport = new rp_expenses_monthly_separate();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                    else
                    {
                        rp_expenses_monthly_total myReport = new rp_expenses_monthly_total();
                        myReport.SetDataSource(ds);
                        crystalReportViewer1.ReportSource = myReport;
                    }
                }
            }
            else // dataType = Profit
            {
                if (view == "Yearly")
                {
                    table = data.GetProfit(displayMode);
                    ds.Tables[dataType + "_" + view + "_" + displayMode].Merge(table);
                    rp_profit_yearly_total myReport = new rp_profit_yearly_total();
                    myReport.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = myReport;
                }
                else if (view == "Monthly" && cmbYear.SelectedIndex != 0)
                {
                    table = data.GetProfit(displayMode, year);
                    ds.Tables[dataType + "_" + view + "_" + displayMode].Merge(table);
                    rp_profit_monthly_total myReport = new rp_profit_monthly_total();
                    myReport.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = myReport;
                }
            }
        }
        
    }
}
