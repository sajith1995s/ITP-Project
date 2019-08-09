using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Supplier
    {

        private string sup_code;
        private string sup_name;
        private string address_1;
        private string address_2;
        private string _phone;
        private string _email;
       

        public string SupplierCode
        {
            get { return this.sup_code; }
            set { this.sup_code = value; }
        }

        public string SupplierName
        {
            get { return this.sup_name; }
            set { this.sup_name = value; }
        }

        public string Address1
        {
            get { return this.address_1; }
            set { this.address_1 = value; }
        }

        public string Address2
        {
            get { return this.address_2; }
            set { this.address_2 = value; }
        }

        public string PhoneNumber
        {
            get { return this._phone; }
            set { this._phone = value; }
        }

        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
      

    }
}
