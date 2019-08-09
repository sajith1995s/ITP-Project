using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCareSystem;
using System.Data.SqlClient;

namespace AutoCareSystem
{
    public partial class Notification : UserControl
    {
        StockController stc;
        public Notification()
        {
            InitializeComponent();
            stc = new StockController();
        }
       
        private void BindGridView(String skey)
        {
          
            try
            {
                DataTable dt = stc.getOutOfStockDetails(skey);
                bunifuCustomDataGrid2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid2.DataSource = dt;
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }


        private void Notification_Load(object sender, EventArgs e)
        {
            BindGridView(null);

        }

        private void SetRowsColor()
        {
            try
            {
                for (int i = 0; i < bunifuCustomDataGrid2.Rows.Count; i++)
                {
                    int val = Int32.Parse(bunifuCustomDataGrid2.Rows[i].Cells[4].Value.ToString());

                    if (val == 0)
                    {
                        timer1.Start();
                        bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
                    }
                    else if (val >= 1 && val <= 2)
                    {
                        bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(127, 255, 212);
                    }
                    else if (val >= 3 && val <= 5)
                    {
                        bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 205);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("RowsColor:" + ex);
            }
        }

        private void bunifuCustomDataGrid2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetRowsColor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bunifuCustomDataGrid2.Rows.Count; i++)
            {
                int val = Int32.Parse(bunifuCustomDataGrid2.Rows[i].Cells[4].Value.ToString());

                if (val == 0)
                {
                    if (bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor == Color.FromArgb(255, 182, 193))
                    {
                        bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                    }
                    else if (bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor == Color.FromArgb(255, 255, 255))
                    {
                        bunifuCustomDataGrid2.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 182, 193);
                    }


                }
            }
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
         
            BindGridView(tbxSearch.Text);
        }

        private void Notification_DoubleClick(object sender, EventArgs e)
        {
            BindGridView(null);
        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindGridView(null);
        }
    }
}