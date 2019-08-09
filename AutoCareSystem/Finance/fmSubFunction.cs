using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class fmSubFunction : MetroFramework.Forms.MetroForm
    {
        public fmSubFunction()
        {
            InitializeComponent();
        }

        private void SubFunc_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) // Side Tab : Expenses
        {
            fm_expenses1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) // Side Tab : Income
        {
            fm_income1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bills1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e) // Side Tab : Loans
        {
            loans1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e) // Side Tab : Profit/Loss
        {
            fm_profit1.BringToFront();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            reports1.BringToFront();
        }
    }
}
