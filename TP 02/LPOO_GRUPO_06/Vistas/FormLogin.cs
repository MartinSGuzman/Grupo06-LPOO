using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;
namespace Vistas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void handle_login(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            
            string password = passwordBox.Text;

            Console.WriteLine("username ingresado: "+username);
            Console.WriteLine("password ingresado: "+password);
            Usuario user = LogicaLogin.handle_login(username, password);

            if( user != null  ){
                FormMain frmMain = new FormMain(user.Rol_id);
                frmMain.Show();
            }else{
                MessageBox.Show("Datos Incorrectos!");
            }
        }
    }
}
