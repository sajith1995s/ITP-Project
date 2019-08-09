using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;

namespace AutoCareSystem
{
    public partial class Report1 : UserControl
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            rbBarChart.Checked = true;
            rbLineChart.Checked = false;
            rbPieChart.Checked = false;
            cmbRType.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            if (rbBarChart.Checked)
            {
                LoadChart("BarChart");
            }
            else if (rbPieChart.Checked)
            {
                LoadChart("PieChart");
            }
            else if (rbLineChart.Checked)
            {
                LoadChart("LineChart");
            }
        }

        private void LoadChart(String seriesName)
        {
            try
            {
                chart1.Series.Clear();
                Series series = new Series();
                series.Name = seriesName;
                series.IsVisibleInLegend = false;

                switch (seriesName)
                {
                    case "BarChart":
                        series.ChartType = SeriesChartType.Column;
                        break;
                    case "PieChart":
                        series.ChartType = SeriesChartType.Pie;
                        break;
                    case "LineChart":
                        series.ChartType = SeriesChartType.Line;
                        break;
                }

                chart1.Series.Add(series);

                Database db = new Database();
                string query = "SELECT o.order_code AS code, SUM(oi.quantity*oi.amount) AS total from orders o LEFT OUTER JOIN ordered_items oi ON o.order_code = oi.order_code WHERE o.created_at BETWEEN'" + Convert.ToDateTime(dpStartdate.Text) + "' AND '" + Convert.ToDateTime(dpEndDate.Text) + "' GROUP BY o.order_code";
                db.openConnection();
                db.sqlQuery(query);
                SqlDataReader reader = db.getData();
                while (reader.Read())
                {
                    chart1.Series[seriesName].Points.AddXY(reader["code"].ToString(), reader["total"].ToString());
                }
                db.closeConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {  
            new ReportDisplay(cmbRType.SelectedIndex).Show();
        }
       
    }

 }
    

