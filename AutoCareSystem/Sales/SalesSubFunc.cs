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
    public partial class SalesSubFunc : MetroFramework.Forms.MetroForm
    {
        public SalesSubFunc()
        {
            InitializeComponent();
            sales_Items2.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
            sales_Items2.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            
            returnItems1.BringToFront();
        }

        public void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
           
            sales_report1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
        }

        private void sales_Items1_Load(object sender, EventArgs e)
        {

        }

        private void SalesSubFunc_Load(object sender, EventArgs e)
        {
            updatesalesitems1.BringToFront();
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            salesitemupdate1.BringToFront();
        }
    }
}
