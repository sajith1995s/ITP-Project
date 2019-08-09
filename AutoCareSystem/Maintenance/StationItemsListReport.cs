using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using AutoCareSystem.Maintenance.ItemReports;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace AutoCareSystem
{
    public partial class StationItemsListReport : UserControl
    {
        public StationItemsListReport()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReportDocument CustomerReport = new ReportDocument();
            string fileName = "StationItemListReportEditor.rpt";
            String rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Maintenance\ItemReports\", fileName);
            CustomerReport.Load(rptPath);
            crystalReportViewer1.ReportSource = CustomerReport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
        }
    }
}
