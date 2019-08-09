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
    public partial class EmployeeSubFunc : MetroFramework.Forms.MetroForm
    {
        public EmployeeSubFunc()
        {
            InitializeComponent();
           // vehicle_register1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            employee_registration1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            employee_details1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            record_attendance1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            attendanceDetails1.BringToFront();
         
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            cal_salary1.BringToFront();
        }
    }
}
