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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(validateUser(tbxUsername.Text, tbxPassword.Text))
            {
                this.Hide();
                var form2 = new AutoCareMain();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MyDialog.Show("Error..!","Invalid username or password");
            }
        }


        private bool validateUser(String username, String pwd)
        {
            try
            {
                Database db = new Database();
                String q1 = "SELECT * FROM administrator WHERE ad_username= '" + username + "' AND ad_pwd = '" + pwd + "'";
                db.sqlQuery(q1);
                DataTable dt = db.executeQuery();
                int count = dt.Rows.Count;
                db.getConnection().Close();
                return (count == 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.Message));
                return false;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
