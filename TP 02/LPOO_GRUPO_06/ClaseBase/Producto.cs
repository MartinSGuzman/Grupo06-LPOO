using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Producto
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string key_product;

        public string Key_product
        {
            get { return key_product; }
            set { key_product = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }           
}
