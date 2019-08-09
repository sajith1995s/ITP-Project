using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Vehicle
    {
        private string v_code;
        private string cus_name;
        private string phone_no;
        private string vehicle_no;
        private string _type;
        private string _brand;
        private string _model;

        public string VehicleCode
        {
            get { return this.v_code; }
            set { this.v_code = value; }
        }

        public string CustomerName
        {
            get { return this.cus_name; }
            set { this.cus_name = value; }
        }

        public string PhoneNumber
        {
            get { return this.phone_no; }
            set { this.phone_no = value; }
        }

        public string VehicleNo
        {
            get { return this.vehicle_no; }
            set { this.vehicle_no = value; }
        }

        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }
    }
}
