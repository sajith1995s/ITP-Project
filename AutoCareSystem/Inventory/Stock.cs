using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCareSystem
{
    class Stock
    {
        private string item_code;
        private string supplier_name;
        private string _type;
        private string item_name;
        private string _brand;
        private string _description;
        private string _quantity;
        private string unit_price;


        public string ItemCode
        {
            get { return this.item_code; }
            set { this.item_code = value; }
        }

        public string SupName
        {
            get { return this.supplier_name; }
            set { this.supplier_name = value; }
        }

        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        public string ItemName
        {
            get { return this.item_name; }
            set { this.item_name = value; }
        }

        public string Brand
        {
            get { return this._brand; }
            set { this._brand = value; }
        }

        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public string Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        public string UnitPrice
        {
            get { return this.unit_price; }
            set { this.unit_price = value; }
        }
    }
}
