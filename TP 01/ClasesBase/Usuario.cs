using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int Usu_ID;
        //prueba desde mi pc nico
        public int Usu_ID1
        {
            get { return Usu_ID; }
            set { Usu_ID = value; }
        }
        private string Usu_NombreUsuario;

        public string Usu_NombreUsuario1
        {
            get { return Usu_NombreUsuario; }
            set { Usu_NombreUsuario = value; }
        }
        private string Usu_Contraseña;

        public string Usu_Contraseña1
        {
            get { return Usu_Contraseña; }
            set { Usu_Contraseña = value; }
        }
        private string Usu_ApellidoNombre;

        public string Usu_ApellidoNombre1
        {
            get { return Usu_ApellidoNombre; }
            set { Usu_ApellidoNombre = value; }
        }
        public Usuario(string username, string password)
        {
            Usu_NombreUsuario1 = username;
            Usu_Contraseña1 = password;
        }

        public Usuario()
        {
            // TODO: Complete member initialization
        }


        public object Rol_Codigo { get; set; }
    }
}
