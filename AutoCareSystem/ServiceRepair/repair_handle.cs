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
    public partial class repair_handle : UserControl
    {
        public repair_handle()
        {
            InitializeComponent();
            metroTabControl1.SelectedTab = metroTabPage2;
        }
    }
}
