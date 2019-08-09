using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCareSystem
{
    public partial class service_handle : UserControl
    {
        public service_handle()
        {
            InitializeComponent();
            metroTabControl1.SelectedTab = tabPage1;
        }
    }
}
