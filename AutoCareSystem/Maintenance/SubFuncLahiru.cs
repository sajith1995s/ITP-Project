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
    public partial class SubFuncLahiru : MetroFramework.Forms.MetroForm
    {
        public SubFuncLahiru()
        {
            InitializeComponent();
            rentVehicleMaintanance1.BringToFront();
        }

        private void SubFunc_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            rentVehicleMaintanance1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            serviceStationItems1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            itemMaintanance1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            defectiveItem1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            reports_usercon1.BringToFront();
        }
    }
}
