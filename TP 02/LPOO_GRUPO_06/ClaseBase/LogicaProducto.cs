using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class LogicaProducto
    {
        public static DataTable list_products() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select description from Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dadapter.Fill(dt);
            return dt;
        }
        public static Producto find_product(string id) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from Producto WHERE id like @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", "%" + id + "%");
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            Producto producto = new Producto();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                producto.Id = Convert.ToInt32(row["id"]);
                producto.Description = row["description"].ToString();
                producto.Price = Convert.ToInt32(row["price"]);
                producto.Category = row["category"].ToString();
                producto.Key_product = row["key_product"].ToString();
            }
            return producto;
        }
    }
}
