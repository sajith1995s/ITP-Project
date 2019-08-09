using AutoCareSystem.Employee.EmpReports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem.Employee
{
    public partial class cristalReportview : Form
    {
        public cristalReportview()
        {
            InitializeComponent();
            AttendenceReport1 cryrpt = new AttendenceReport1();

            crystalReportViewerforatt.ReportSource = cryrpt;
        }
    }
}
