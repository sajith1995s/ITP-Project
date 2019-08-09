using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class Receipt : MetroFramework.Forms.MetroForm
    {
        private string order_code = null;
        private string order_date;

        public Receipt(String code, String date)
        {
            InitializeComponent();
            this.order_code = code;
            this.order_date = date;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument CustomerReport = new ReportDocument();

                String fileName = "MyReceipt.rpt";
                String rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Inventory\OrderReports\", fileName);
                CustomerReport.Load(rptPath);
                CustomerReport.SetParameterValue("o_code", order_code);
                crystalReportViewer1.ReportSource = CustomerReport;
                //crystalReportViewer1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
