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
    public partial class fm_expenses : fm_f_stats
    {
        Data data = new Data();
        public fm_expenses()
        {
            InitializeComponent();
            DataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FillComboBox();
        }
        public void FillComboBox()
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
        private void btnTable_Click(object sender, EventArgs e)
        {
            DataGrid1.DataSource = null;
            DataGrid1.Rows.Clear();
            DataGrid1.Refresh();
            DataTable table = new DataTable();
            if (periodOfView == "Yearly")
            {
                table = data.GetExpenses(displayMode);
            }
            else // periodOfView = Monthly
            {
                // validate
                if (cmbYear.SelectedIndex != 0)
                    table = data.GetExpenses(displayMode, Convert.ToInt32(cmbYear.SelectedItem));
            }
            DataGrid1.DataSource = table;
            DataGrid1.Visible = true;
            DataGrid1.BringToFront();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            btnTable_Click(sender, e);
            DataGrid1.Sort(DataGrid1.Columns[0], ListSortDirection.Ascending);
            chart1.Series.Clear();
            chart1.BringToFront();
            int x, y;
            string type;
            if (chartType == "Bar")
            {
                if (displayMode == "Separate")
                {
                    chart1.Series.Add("Maintenance");
                    chart1.Series.Add("Inventory");
                    chart1.Series.Add("Employee");
                    chart1.Series.Add("Bills");
                    chart1.Series.Add("Loans");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[1].IsValueShownAsLabel = true;
                    chart1.Series[2].IsValueShownAsLabel = true;
                    chart1.Series[3].IsValueShownAsLabel = true;
                    chart1.Series[4].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[2].Value.ToString());
                        type = DGVR.Cells[1].Value.ToString();
                        chart1.Series[type].Points.AddXY(x, y);
                    }
                }
                else
                {
                    chart1.Series.Add("Expenses");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        chart1.Series["Expenses"].Points.AddXY(x, y);
                    }
                }
               
            }
            else if (chartType == "Line")
            {
                if (displayMode == "Separate")
                {
                    chart1.Series.Add("Maintenance");
                    chart1.Series.Add("Inventory");
                    chart1.Series.Add("Employee");
                    chart1.Series.Add("Bills");
                    chart1.Series.Add("Loans");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    chart1.Series[1].IsValueShownAsLabel = true;
                    chart1.Series[2].IsValueShownAsLabel = true;
                    chart1.Series[3].IsValueShownAsLabel = true;
                    chart1.Series[4].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[2].Value.ToString());
                        type = DGVR.Cells[1].Value.ToString();
                        chart1.Series[type].Points.AddXY(x, y);
                    }
                }
                else
                {
                    chart1.Series.Add("Expenses");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        chart1.Series["Expenses"].Points.AddXY(x, y);
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
                    chart1.Series.Add("Expenses");
                    chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    chart1.Series[0].IsValueShownAsLabel = true;
                    foreach (DataGridViewRow DGVR in DataGrid1.Rows)
                    {
                        x = int.Parse(DGVR.Cells[0].Value.ToString());
                        y = int.Parse(DGVR.Cells[1].Value.ToString());
                        //type = DGVR.Cells[1].Value.ToString();
                        chart1.Series["Expenses"].Points.AddXY(x, y);
                    }
                }
            }
        }
    }
}
