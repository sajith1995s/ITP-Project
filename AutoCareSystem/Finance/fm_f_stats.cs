using System;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class fm_f_stats : UserControl
    {
        protected string chartType = "Bar";
        protected string periodOfView = "Yearly";
        protected string displayMode = "Separate";
        protected int periodYear = 0;

        public fm_f_stats()
        {
            InitializeComponent();
            radBar.Checked = true;
            radYearly.Checked = true;
            radSeparate.Checked = true;
            cmbYear.Items.Insert(0, "Select");
            cmbYear.SelectedIndex = 0;
        }

        private void radYearly_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radYearly.Checked == true)
            {
                periodOfView = "Yearly";
                cmbYear.Enabled = false;
                chart1.Visible = false;
            }
        }

        private void radMonthly_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radMonthly.Checked == true)
            {
                periodOfView = "Monthly";
                cmbYear.Enabled = true;
                chart1.Visible = false;
            }
        }

        private void radBar_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            if (radBar.Checked == true)
            {
                chartType = "Bar";
                chart1.Visible = false;
                radSeparate.Enabled = true;
            }
        }

        private void radLine_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            if (radLine.Checked == true)
            {
                chartType = "Line";
                chart1.Visible = false;
                radSeparate.Enabled = true;
            }
        }

        private void radPie_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            if (radPie.Checked == true)
            {
                chartType = "Pie";
                chart1.Visible = false;
                radSeparate.Enabled = false;
                radSeparate.Checked = false;
                radTotal.Checked = true;
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != 0)
            {
                periodYear = Convert.ToInt32(cmbYear.SelectedItem);
            }
            else
            {
                periodYear = 0;
            }
            chart1.Visible = false;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) // Chart
        {
            if (chart1.Visible == false)
            {
                chart1.Visible = true;
                DataGrid1.Visible = false;
            }
            chart1.Series.Clear();
            chart1.BringToFront();
        }

        private void radSeparate_CheckedChanged(object sender, EventArgs e)
        {
            if (radSeparate.Checked == true)
            {
                displayMode = "Separate";
                chart1.Visible = false;
            }
        }

        private void radTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (radTotal.Checked == true)
            {
                displayMode = "Total";
                chart1.Visible = false;
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            DataGrid1.Visible = true;
            chart1.Visible = false;
        }
    }
}
