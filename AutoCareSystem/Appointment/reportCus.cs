using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoCareSystem.Appointment
{
    public partial class reportCus : UserControl
    {
        public reportCus()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String type = comboBox1.Text;
            switch (type)
            {
                case "Select Report Type":
                    break;
                case "Customers":
                    {


                        CustomerRprt myreport = new CustomerRprt();   
                        crystalReportViewer1.ReportSource = myreport;

                        break;
                    }
                case "Appointments":
                    {
                        appRprt myreport = new appRprt();
                        crystalReportViewer1.ReportSource = myreport;

                

                        break;
                    }
                case "Customer & Appointment":
                    {
                        mainReport myreport = new mainReport();
                        crystalReportViewer1.ReportSource = myreport;



                        break;
                    }
            }
        }
    }
}
