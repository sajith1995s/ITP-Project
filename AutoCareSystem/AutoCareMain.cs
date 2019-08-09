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
    public partial class AutoCareMain : MetroFramework.Forms.MetroForm
    {
        public AutoCareMain()
        {
            InitializeComponent();
            form_load();
        }

        private void form_load()
        {
            bunifuCustomLabel3.Text = DateTime.Now.ToString("yyy-MM-dd");
            bunifuCustomLabel4.Text = System.DateTime.Now.ToString("hh:mm:ss");
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(this.timer_tick);
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            bunifuCustomLabel4.Text = System.DateTime.Now.ToString("hh:mm:ss");
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            new SubFunc().Show();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            new Appointment_main().Show();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            new SubFuncLahiru().Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            new rv_subfubctions().Show();
        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            new fmSubFunction().Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            new SubFuncIshara().Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            new EmployeeSubFunc().Show();
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            new SalesSubFunc().Show();
        }
    }
}
