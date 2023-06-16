using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClaseBase;
using System.Data.SqlClient;
using System.Data;
namespace ClaseBase
{
    public class LogicaCategoria
    {
        public static DataTable list_categories()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Category";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dadapter.Fill(dt);
            return dt;
        }
        public static void save_category(Category newp)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Category(category_desc) values(@categoriesBox)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@categoriesBox", newp.Description);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void edit_category(string categoriesBox, string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Category SET category_desc = @categoriesBox WHERE id_category = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@categoriesBox", categoriesBox);
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void delete_category(string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString2);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Category WHERE id_category = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
