using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class SubFunc : MetroFramework.Forms.MetroForm
    {
        public SubFunc()
        {
            InitializeComponent();
            vehicle_register1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            vehicle_register1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            service_handle1.BringToFront();
        }

        public void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            repair_handle1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            payment_handle1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            report_handle1.BringToFront();
        }
    }
}
