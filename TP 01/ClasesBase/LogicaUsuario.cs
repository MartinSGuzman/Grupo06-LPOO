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
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(usu_NombreUsuario, usu_Contraseña, usu_ApellidoNombre, rol_Codigo) values(@nombreUs,@contra,@apellido,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nombreUs", user.Usu_NombreUsuario1);
            cmd.Parameters.AddWithValue("@contra", user.Usu_Contraseña1);
            cmd.Parameters.AddWithValue("@apellido", user.Usu_ApellidoNombre1);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable exec_list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_usuarios_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable exec_search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_usuarios";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static void exec_eliminar_usuario(int ID)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.pasteleriaConnectionString1);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "eliminar_usuario_sp";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usu_ID", ID);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
  
