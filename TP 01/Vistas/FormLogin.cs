using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;


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

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            cnn.Open();
         
            string query = "SELECT COUNT(*) FROM Usuario WHERE usu_NombreUsuario = @nombreUsuario AND usu_Contraseña = @contraseña";
            
            SqlCommand cmd = new SqlCommand(query, cnn);

            cmd.Parameters.AddWithValue("@nombreUsuario", Usuario);
            cmd.Parameters.AddWithValue("@contraseña", PassIngresada);

            int count = (int)cmd.ExecuteScalar();

            if (count != 0)
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                
            }
            else 
            {
                MessageBox.Show("Error usuario o contra invalido");
            }
        }

        private void usrName_TextChanged(object sender, EventArgs e)
        {

        }


     

  
    }
}
