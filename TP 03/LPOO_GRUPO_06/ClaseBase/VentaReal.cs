using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class VentaReal
    {
        private DateTime date;
        private string dni_customer;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Dni_customer
        {
            get { return dni_customer; }
            set { dni_customer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
      
    }
}
