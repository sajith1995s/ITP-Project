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
    public partial class ReportView : MetroFramework.Forms.MetroForm
    {
        private int mIndex;

        public ReportView(int selectedIndex)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.mIndex = selectedIndex;
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            switch (mIndex)
            {
                case 0:
                    loadReport("service_report.rpt");
                    break;
                case 1:
                    loadReport("repair_report.rpt");
                    break;
                case 2:
                    loadReport("provided_repair_list.rpt");
                    break;
                case 3:
                    loadReport("provided_services_list.rpt");
                    break;
            }  
        }

        private void loadReport(string fileName)
        {
            try
            {
                ReportDocument CustomerReport = new ReportDocument();
                string rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ServiceRepair\SevRepReports\", fileName);
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
    }
}
