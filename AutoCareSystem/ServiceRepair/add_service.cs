using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace AutoCareSystem
{
    public partial class add_service : UserControl
    {

        private String DATE_FORMAT = "yyyy-MM-dd";
        ServiceController sc;

        public add_service()
        {
            InitializeComponent();
            sc = new ServiceController();
            initialization();
        }

        private void initialization()
        {
            enableButtons(false);
        }

        private void EnableControls(Control con, bool b)
        {
            foreach (Control c in con.Controls)
            {
                if (c is CheckBox)
                    EnableControls(c, b);  
            }
            if (con is CheckBox)
                con.Enabled = b;
            
        }

        private void tbxVehicleNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (Validator.IsValidVehicleNumber(tbxVehicleNumber.Text))
            {
              enableButtons((sc.isVehicleFound(tbxVehicleNumber.Text)));
            }
            else
            {
                enableButtons(false);
            }
        }

        private void enableButtons(bool b)
        {
            btnAdd.Enabled = b;
            btnAdd.Cursor = (b) ? Cursors.Hand : Cursors.Default;

            serviceDate.Enabled = b;
            nextServiceDate.Enabled = b;
            tbxOdoMeter.Enabled = b;

            EnableControls(groupBox1, b);
            EnableControls(groupBox2, b);
            EnableControls(groupBox3, b);
        }

        private void tbxVehicleNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (e.KeyChar.ToString()).ToUpper().ToCharArray()[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidPastDate(serviceDate.Value.ToString(DATE_FORMAT)))
            {
                if (Validator.IsValidNumber(tbxOdoMeter.Text))
                {
                    if (Validator.IsValidFutureDate(nextServiceDate.Value.ToString(DATE_FORMAT)))

                        addNewService();
                    else
                        MyDialog.Show("Error...!", "Next Service Date is invalid");
                }
                else
                    MyDialog.Show("Error...!", "ODO Meter is invalid");
            }
            else
                MyDialog.Show("Error...!", "Service Date is invalid");

        }

        private void addNewService()
        {
            try
            {
                Service sv = new Service();
                sv.VehicleCode = sc.getVehicleCode(tbxVehicleNumber.Text);
                sv.ServiceDate = serviceDate.Value;
                sv.OdoMeter = tbxOdoMeter.Text;
                sv.NextServiceDate = nextServiceDate.Value;

                if(sc.addService(sv))
                {
                    MyDialog.Show("Success...!", "New Service Registered");
                    addProvidedServices();
                    resetFields();
                }
                else
                {
                    MyDialog.Show("Error...!", "New Service Not Registered");
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void addProvidedServices()
        {
            sc.addProvidedServices(getCheckedList());
        }

        private void resetFields()
        {
            uncheckCheckBox();
            tbxVehicleNumber.Text = String.Empty;
            tbxOdoMeter.Text = String.Empty;
        }

        private void uncheckCheckBox()
        {
            cbxEngineOilTest.Checked = false;
            cbxTransmissionOilTest.Checked = false;
            cbxBreakFluidTest.Checked = false;
            cbxReplaceBreakFluid.Checked = false;
            cbxInverterCoolentTest.Checked = false;
            cbxRadiatorCoolentTest.Checked = false;

            cbxOilFilter.Checked = false;
            cbxAirFilter.Checked = false;
            cbxAcFilter.Checked = false;

            cbxEngineTuneup.Checked = false;
            cbxSparkPlugChange.Checked = false;
            cbxHvBattery.Checked = false;
            cbxHvBatteryCooling.Checked = false;
            cbxBreakService.Checked = false;
            cbxRepalceBreakPad.Checked = false;
            cbxEngineScanning.Checked = false;
            cbxBatteryUsable.Checked = false;
        }

        private List<int> getCheckedList()
        {
            List<int> checkedList = new List<int>();

            if (cbxEngineOilTest.Checked)
                checkedList.Add(1);
                
            if (cbxTransmissionOilTest.Checked)
                checkedList.Add(2);
            
            if (cbxBreakFluidTest.Checked)
                checkedList.Add(3);
            
            if (cbxReplaceBreakFluid.Checked)
                checkedList.Add(4);
           
            if (cbxInverterCoolentTest.Checked)
                checkedList.Add(5);
            
            if (cbxRadiatorCoolentTest.Checked)
                checkedList.Add(6);
            
            if (cbxOilFilter.Checked) //filter
                checkedList.Add(7);
            
            if (cbxAirFilter.Checked)
                checkedList.Add(8);
            
            if (cbxAcFilter.Checked)
                checkedList.Add(9);
            
            if (cbxEngineTuneup.Checked) //other service
                checkedList.Add(10);
            
            if (cbxSparkPlugChange.Checked)
                checkedList.Add(11);
            
            if (cbxHvBattery.Checked)
                checkedList.Add(12);
            
            if (cbxHvBatteryCooling.Checked)
                checkedList.Add(13);
            
            if (cbxBreakService.Checked)
                checkedList.Add(14);
            
            if (cbxRepalceBreakPad.Checked)
                checkedList.Add(15);
            
            if (cbxEngineScanning.Checked)
                checkedList.Add(16);
            
            if (cbxBatteryUsable.Checked)
                checkedList.Add(17);
            

            return checkedList;
        }
    }
}
