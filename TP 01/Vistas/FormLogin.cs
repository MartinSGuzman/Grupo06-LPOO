using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

using System.Data;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string Usuario = usrName.Text;
            string PassIngresada = passLogin.Text;

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString);

            cnn.Open();
         
            string query = "SELECT COUNT(*) FROM Usuario WHERE usr_username = @nombreUsuario AND usr_password = @contraseña";
            
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Parameters.AddWithValue("@nombreUsuario", Usuario);
            cmd.Parameters.AddWithValue("@contraseña", PassIngresada);

            int count = (int)cmd.ExecuteScalar();

            if (count != 0)
            {
                Main main = new Main();
                main.Show();
            }
            else 
            {
                MessageBox.Show("Error usuario o contra invalido");
            }
        }

     

  
    }
}
