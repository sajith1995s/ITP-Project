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
    public partial class ReceiptView : MetroFramework.Forms.MetroForm
    {
        private string mCode = null;
        private int mIndex = 0;
        private string mInvDate;
        private string mInvNumber;

        public ReceiptView(string code, int selectedIndex, string invNumber, String invDate)
        {
            InitializeComponent();
            this.mCode = code;
            this.mIndex = selectedIndex;
            this.mInvNumber = invNumber;
            this.mInvDate = invDate;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument CustomerReport = new ReportDocument();
                String fileName = (mIndex == 0) ? "service_receipt.rpt" : "repair_receipt.rpt";
                String rptPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ServiceRepair\SevRepReports\", fileName);
                CustomerReport.Load(rptPath);

                /*ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterDiscreteValue.Value = mCode;
                crParameterFieldDefinitions = CustomerReport.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["code"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);*/
                CustomerReport.SetParameterValue("code", mCode);
                CustomerReport.SetParameterValue("in_code", mInvNumber);
                CustomerReport.SetParameterValue("in_date", mInvDate);

                crystalReportViewer1.ReportSource = CustomerReport;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
