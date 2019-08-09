using AutoCareSystem;
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
    public partial class SubFuncIshara : MetroFramework.Forms.MetroForm
    {
        public SubFuncIshara()
        {
            
            InitializeComponent();
            
        }

        private void SubFunc_Load(object sender, EventArgs e)
        {
            supplier_Handle1.BringToFront();
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                OnTimedEvent();
                timer.Dispose();
            }, null, 5000, System.Threading.Timeout.Infinite);
        }

        private void OnTimedEvent()
        {
            MyPrompt.Dispaly();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            supplier_Handle1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            stock_Manage1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            order_Handle1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            notification1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            report11.BringToFront();
        }

        private void reports1_Load(object sender, EventArgs e)
        {

        }
    }
}
