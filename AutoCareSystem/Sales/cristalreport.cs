using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using AutoCareSystem.Sales.SalesReports;

namespace AutoCareSystem.Sales
{
    public partial class cristalreport : Form
    {
        //ReportDocument cryrpt = new ReportDocument();
        public cristalreport()
        {
            InitializeComponent();
            CrystalReport2 cryrpt = new CrystalReport2();

            //cryrpt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
