using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string Cli_DNI;

        public string Cli_DNI1
        {
            get { return Cli_DNI; }
            set { Cli_DNI = value; }
        }
        private string Cli_Apellido;

        public string Cli_Apellido1
        {
            get { return Cli_Apellido; }
            set { Cli_Apellido = value; }
        }
        private string Cli_Nombre;

        public string Cli_Nombre1
        {
            get { return Cli_Nombre; }
            set { Cli_Nombre = value; }
        }
        private string Cli_Direccion;

        public string Cli_Direccion1
        {
            get { return Cli_Direccion; }
            set { Cli_Direccion = value; }
        }
        private string OS_CUIT;

        public string OS_CUIT1
        {
            get { return OS_CUIT; }
            set { OS_CUIT = value; }
        }
        private string Cli_NroCarnet;

        public string Cli_NroCarnet1
        {
            get { return Cli_NroCarnet; }
            set { Cli_NroCarnet = value; }
        }
    }
}
