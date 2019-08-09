using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Order
    {
        private String DATE_FORMAT = "yyyy-MM-dd";
        private string order_code;
        private string supplier_code;
        private DateTime order_date;
        private string _status;
        private string i_code;
        private string _qty;
        private string _amount;
        private string _total;

        public string OrderCode
        {
            get { return this.order_code; }
            set { this.order_code = value; }
        }

        public string SuppCode
        {
            get { return this.supplier_code; }
            set { this.supplier_code = value; }
        }

        public DateTime OrderDate
        {
            get { return DateTime.Parse(this.order_date.ToString(DATE_FORMAT)); }
            set { this.order_date = value; }
        }

        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        public string ICode
        {
            get { return this.i_code; }
            set { this.i_code = value; }
        }

        public string Qty
        {
            get { return this._qty; }
            set { this._qty = value; }
        }

        public string Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        public string Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

    }
}
