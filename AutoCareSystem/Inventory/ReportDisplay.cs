using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class ReportDisplay : MetroFramework.Forms.MetroForm
    {
        private int rType;
        public ReportDisplay(int selectedIndex)
        {

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.rType = selectedIndex;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            try
            {
                //ReportDocument CustomerReport = new ReportDocument();
                //string fileName = "OrderReport.rpt";
                //string rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Reportss\", fileName);
                //CustomerReport.Load(rptPath);
                //crystalReportViewer1.ReportSource = CustomerReport;

                ////my_report myReport = new my_report();
                ////crystalReportViewer1.ReportSource = myReport;

                switch (rType)
                {
                    case 0:
                        loadReport("StockItems.rpt");
                        break;
                    case 1:
                        loadReport("OutOfStockItemsReport.rpt");
                        break;
                    case 2:
                        loadReport("OrderReport.rpt");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //this.Close();
            }

        }

        private void loadReport(string fileName)
        {
            try
            {
                ReportDocument CustomerReport = new ReportDocument();
                string rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Inventory\OrderReports\", fileName);
                CustomerReport.Load(rptPath);
                crystalReportViewer1.ReportSource = CustomerReport;

                /*service_report myReport = new service_report();
                crystalReportViewer1.ReportSource = myReport;*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
