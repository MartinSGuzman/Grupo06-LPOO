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
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Usuarios(rol_id, username, user_username, user_password) values(@rolBox, @userbox, @username_box, @password_box)";
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
        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            return datatable;
        }
        public static DataTable list_users()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select rol_desc as 'Rol', username as 'Nombre Usuario', user_username as 'Usuario' ,user_password as 'Contraseña', Usuarios.user_id, Usuarios.rol_id from Usuarios left join Roles on Usuarios.rol_id = Roles.rol_id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            return datatable;
        }
    }
}
