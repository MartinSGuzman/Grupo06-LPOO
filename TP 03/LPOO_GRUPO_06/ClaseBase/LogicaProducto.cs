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
        public static void save_product(Producto newp) { 
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Producto(key_product, category, description, price) values(@keyProductBox, @categoriesBox, @descripcionBox, @priceBox)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@keyProductBox", newp.Key_product);
            cmd.Parameters.AddWithValue("@categoriesBox", newp.Category);
            cmd.Parameters.AddWithValue("@descripcionBox", newp.Description);
            cmd.Parameters.AddWithValue("@priceBox", newp.Price);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        
        public static DataTable list_productsBox() {
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

        
        public static void edit_product(string keyProductBox, string categoriesBox, string priceBox, string DescripcionBox, string id) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Producto SET key_product = @keyProductBox, category = @categoriesBox, description = @descripcionBox, price = @priceBox WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@keyProductBox", keyProductBox);
            cmd.Parameters.AddWithValue("@categoriesBox", categoriesBox);
            cmd.Parameters.AddWithValue("@descripcionBox", DescripcionBox);
            cmd.Parameters.AddWithValue("@priceBox", priceBox);
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static DataTable list_products()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select id as 'ID', key_product as 'COD PRODUCTO', description as 'Descripcion', category as 'categoria', price as 'Precio' from Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            dadapter.Fill(dt);
            return dt;
        }
        public static DataTable filter_byCateory(string category)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select key_product as 'COD PRODUCTO', description as 'Descripcion', category as 'categoria', price as 'Precio' from Producto where category like @category";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@category",category);

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
        public static void deleteProduct(string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Producto WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
