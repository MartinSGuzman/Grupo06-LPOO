using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClaseBase
{
    public class Usuario
    {
        private int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        private string user_username;

        public string User_username
        {
            get { return user_username; }
            set { user_username = value; }
        }
        private string user_password;

        public string User_password
        {
            get { return user_password; }
            set { user_password = value; }
        }
        private int rol_id;

        public int Rol_id
        {
            get { return rol_id; }
            set { rol_id = value; }
        }
        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
    }
}
