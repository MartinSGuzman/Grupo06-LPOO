using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class LogicaUsuario
    {
        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

        public static void insert_Usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(Usu_ID, Usu_NombreUsuario1, Usu_Contraseña1, Usu_ApellidoNombre1, Rol_Codigo1) values(@id,@nombreUs,@contra,@apellido,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", user.Usu_ID1);
            cmd.Parameters.AddWithValue("@nombreUs", user.Usu_NombreUsuario1);
            cmd.Parameters.AddWithValue("@contra", user.Usu_Contraseña1);
            cmd.Parameters.AddWithValue("@apellido", user.Usu_ApellidoNombre1);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " rol_descrip as 'Rol', ";
            cmd.CommandText += " usr_apellido as 'Apellido', usr_nombre as 'Nombre', ";
            cmd.CommandText += " usr_username as 'Usuario', usr_password as 'Contraseña', ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_id=U.rol_id)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usr_apellido LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
          
        
        
       



         }
        }
    }
}
