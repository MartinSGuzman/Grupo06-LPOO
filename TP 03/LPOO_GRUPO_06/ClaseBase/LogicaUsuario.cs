using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class LogicaUsuario
    {

        public static void save_user(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Usuarios(rol_id, fullname, user_username, user_password) values(@rolBox, @userbox, @username_box, @password_box)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rolBox", user.Rol_id);
            cmd.Parameters.AddWithValue("@userbox", user.User);
            cmd.Parameters.AddWithValue("@username_box", user.User_username);
            cmd.Parameters.AddWithValue("@password_box", user.User_password);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void edit_user(string user, string password, string username, string rol, string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Usuarios SET rol_id = @rol, fullname = @userbox, user_username = @username, user_password = @password WHERE user_id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", rol);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@userbox", user);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            return datatable;
        }
        public static DataTable list_users(string user)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT user_id AS 'ID', rol_desc AS 'Rol', fullname AS 'Nombre Usuario', user_username AS 'Usuario', user_password AS 'Contraseña', Usuarios.user_id, Usuarios.rol_id FROM Usuarios LEFT JOIN Roles ON Usuarios.rol_id = Roles.rol_id WHERE user_username <> @userParam AND Usuarios.rol_id <> 3";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@userParam", user);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            return datatable;
        }
        public static void deleteUser(string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuarios WHERE user_id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
       
    }
}
