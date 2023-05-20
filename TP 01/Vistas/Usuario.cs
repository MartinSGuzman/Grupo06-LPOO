using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usr_Id;
        private int usr_Emal;

        public int Usr_Emal
        {
            get { return usr_Emal; }
            set { usr_Emal = value; }
        }
        private int usr_Nombre;

        public int Usr_Nombre
        {
            get { return usr_Nombre; }
            set { usr_Nombre = value; }
        }
        private int usr_Apellido;

        public int Usr_Apellido
        {
            get { return usr_Apellido; }
            set { usr_Apellido = value; }
        }
        private int usr_Password;

        public int Usr_Password
        {
            get { return usr_Password; }
            set { usr_Password = value; }
        }
        private int usr_UserName;

        public int Usr_UserName
        {
            get { return usr_UserName; }
            set { usr_UserName = value; }
        }
        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
    }
}
