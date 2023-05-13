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
        public static Usuario handle_login(string username, string password) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            string query = "SELECT * FROM Usuarios WHERE user_username = @nombreUsuario AND user_password = @contraseña";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nombreUsuario", username);
            cmd.Parameters.AddWithValue("@contraseña", password);
            Usuario found = new Usuario();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                found.Rol_id = (int)row["rol_id"];
                found.User = row["username"].ToString();
                found.User_username = row["user_username"].ToString();
                found.User_password = row["user_password"].ToString();
                return found;
            }
            else
            {
                Console.WriteLine("No encontro chaval");
                return null;

            }
        }
    }
}
