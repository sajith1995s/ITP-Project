using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class MyPrompt : MetroFramework.Forms.MetroForm
    {
        public MyPrompt()
        {
            InitializeComponent();
        }

        public static void Dispaly()
        {
            new MyPrompt().ShowDialog();
        }

        private void BindGridView()
        {
            try
            {
                Database db = new Database();
                string query = "SELECT TOP 7 item_code AS Code, type AS Type, name AS Name, brand AS Brand, quantity AS Quantity FROM stocks WHERE quantity < 5";

                db.sqlQuery(query);
                DataTable dt = db.executeQuery();
                bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bunifuCustomDataGrid1.DataSource = dt;
                db.getConnection().Close();
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

        private void MyPrompt_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        private void btnIgnore_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemindLater_Click(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer(60000); //60000 for 1 minute
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
            this.Hide();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            new MyPrompt().ShowDialog();
            this.Close();
        }

    }
}
