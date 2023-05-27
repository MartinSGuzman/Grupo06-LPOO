using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Venta
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string key_sale;

        public string Key_sale
        {
            get { return key_sale; }
            set { key_sale = value; }
        }
        private decimal cant;

        public decimal Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        private string key_product;

        public string Key_product
        {
            get { return key_product; }
            set { key_product = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string product_name;

        public string Product_name
        {
            get { return product_name; }
            set { product_name = value; }
        }
    }
}
