using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Category
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
