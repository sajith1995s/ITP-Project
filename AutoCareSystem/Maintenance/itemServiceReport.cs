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

namespace AutoCareSystem
{
    public partial class itemServiceReport : UserControl
    {
        public itemServiceReport()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           // StationItemRepairReportEditor myReport = new StationItemRepairReportEditor();
           // crystalReportViewer1.ReportSource = myReport;
            ReportDocument CustomerReport = new ReportDocument();
            string fileName = "StationItemRepairReportEditor.rpt";
            String rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Maintenance\ItemReports\", fileName);
             CustomerReport.Load(rptPath);
            crystalReportViewer1.ReportSource = CustomerReport;
        }
    }
}
