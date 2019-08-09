using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCareSystem.Common;

namespace AutoCareSystem.Financial_Statistics
{
    public partial class fm_profit : fm_f_stats
    {
        Data data = new Data();
        public fm_profit()
        {
            InitializeComponent();
            DataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FillComboBox();
            radTotal.Checked = true;
            radSeparate.Enabled = false;
        }

        public void FillComboBox()
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

        private void btnTable_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = null;
            DataGrid1.Rows.Clear();
            DataGrid1.Refresh();
            DataTable table = new DataTable();
            if (periodOfView == "Yearly")
            {
                table = data.GetProfit(displayMode);
            }
            else // periodOfView = Monthly
            {
                if (cmbYear.SelectedIndex != 0)
                    table = data.GetProfit(displayMode, Convert.ToInt32(cmbYear.SelectedItem));
            }
            DataGrid1.DataSource = table;
            DataGrid1.Visible = true;
            DataGrid1.BringToFront();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            btnTable_Click(sender, e);
            try {
                DataGrid1.Sort(DataGrid1.Columns[0], ListSortDirection.Ascending);
            } 
            catch(Exception exception)
            {
                // No Records in the DataGrid
            }
            
            chart1.Series.Clear();
            chart1.BringToFront();
            int x, y;
            string type;
            if (chartType == "Bar")
            {
                if (displayMode == "Separate")
                {

                }
                else
                {
                    chart1.Series.Add("Profit");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        chart1.Series["Profit"].Points.AddXY(x, y);
                    }
                }

            }
            else if (chartType == "Line")
            {
                if (displayMode == "Separate")
                {

                }
                else
                {
                    chart1.Series.Add("Profit");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        chart1.Series["Profit"].Points.AddXY(x, y);
                    }
                }
            }
            else
            {
                if (displayMode == "Separate") // Cannot display data in a pie chart
                {

                }
                else
                {
                    chart1.Series.Add("Profit");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        //type = DGVR.Cells[1].Value.ToString();
                        chart1.Series["Profit"].Points.AddXY(x, y);
                    }
                }
            }
        }

        private void radLine_CheckedChanged(object sender, EventArgs e)
        {
            radSeparate.Enabled = false;
        }

        private void radBar_CheckedChanged(object sender, EventArgs e)
        {
            radSeparate.Enabled = false;
        }
    }
}
