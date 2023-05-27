using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Cliente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private string os_cuit;

        public string Os_cuit
        {
            get { return os_cuit; }
            set { os_cuit = value; }
        }
        private string carnet_number;

        public string Carnet_number
        {
            get { return carnet_number; }
            set { carnet_number = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
