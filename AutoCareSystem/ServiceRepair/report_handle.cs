using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;

namespace AutoCareSystem
{
    public partial class report_handle : UserControl
    {
        public report_handle()
        {
            InitializeComponent();
        }    

        private void report_handle_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new ReportView(cmbReportType.SelectedIndex).Show();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            switch (cmbReportType.SelectedIndex)
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
                crystalReportViewer1.Refresh();
                crystalReportViewer1.Zoom(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
