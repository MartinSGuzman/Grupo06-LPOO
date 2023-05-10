using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class LogicaLogin
    {
        public static int handle_login(string username, string password) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            string query = "SELECT COUNT(*) FROM Usuarios WHERE user_username = @nombreUsuario AND user_password = @contraseña";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nombreUsuario", username);
            cmd.Parameters.AddWithValue("@contraseña", password);
            int count = (int)cmd.ExecuteScalar();
            Console.WriteLine("COUNT:" + count);

            if (count != 0)
            {
                Console.WriteLine("SE ENCONTRO!!!!!!");
                return 1;
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRO");
                return 0;
            }
            cnn.Close();

        }
    }
}
