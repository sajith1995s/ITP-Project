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
    public partial class rv_subfubctions : MetroFramework.Forms.MetroForm
    {
        public rv_subfubctions()
        {
            InitializeComponent();

        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            rs_Rental_Detail_new1.BringToFront();
        }
        
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            rs_Manage_Customers1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            rs_Rental_Vehicle1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            rs_issue_the_invoice1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            rs_billing_details1.BringToFront();
        }


        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
             rs_reports1.BringToFront();
        }
    }
}
