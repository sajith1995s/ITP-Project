using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Service
    {
        private String DATE_FORMAT = "yyyy-MM-dd";
        private string s_code;
        private string vehicle_code;
        private DateTime service_date;
        private string odo_meter;
        private DateTime next_service_date;

        public string ServiceCode
        {
            get { return this.s_code; }
            set { this.s_code = value; }
        }

        public string VehicleCode
        {
            get { return this.vehicle_code; }
            set { this.vehicle_code = value; }
        }

        public DateTime ServiceDate
        {
            get { return DateTime.Parse(this.service_date.ToString(DATE_FORMAT)); }
            set { this.service_date = value; }
        }

        public string OdoMeter
        {
            get { return this.odo_meter; }
            set { this.odo_meter = value; }
        }

        public DateTime NextServiceDate
        {
            get { return DateTime.Parse(this.next_service_date.ToString(DATE_FORMAT)); }
            set { this.next_service_date = value; }
        }
    }
}
