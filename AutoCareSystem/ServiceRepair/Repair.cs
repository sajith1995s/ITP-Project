using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Repair
    {
        private String DATE_FORMAT = "yyyy-MM-dd";
        private string r_code;
        private string e_code;
        private string vehicle_id;
        private DateTime repair_date;

        private string p_repairId;
        private string error_code;
        private string status;

        private string type_id;
        private string type_name;
        private string type_desc;
        private string type_charges;

        public string RepairCode
        {
            get { return this.r_code; }
            set { this.r_code = value; }
        }

        public string EmployeeCode
        {
            get { return this.e_code; }
            set { this.e_code = value; }
        }

        public string VehicleId
        {
            get { return this.vehicle_id; }
            set { this.vehicle_id = value; }
        }

        public DateTime RepairDate
        {
            get { return DateTime.Parse(this.repair_date.ToString(DATE_FORMAT)); }
            set { this.repair_date = value; }
        }

        /**
            PROVIDED REPAIR
        **/

        public string ProvidedRepairId
        {
            get { return this.p_repairId; }
            set { this.p_repairId = value; }
        }

        /**
            UPDATE JOB STATUS
        **/

        public string ErrorCode
        {
            get { return this.error_code; }
            set { this.error_code = value; }
        }

        public string JobStatus
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /**
            ADD REPAIR TYPE
        **/

        public string RepairTypeId
        {
            get { return this.type_id; }
            set { this.type_id = value; }
        }

        public string RepairTypeName
        {
            get { return this.type_name; }
            set { this.type_name = value; }
        }

        public string RepairTypeDesc
        {
            get { return this.type_desc; }
            set { this.type_desc = value; }
        }

        public string RepairTypeCharges
        {
            get { return this.type_charges; }
            set { this.type_charges = value; }
        }
    }
}
