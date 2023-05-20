using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class LogicaVenta
    {
        public static DataTable list_ventas()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select date as 'Fecha', dni_customer as 'Cliente DNI' from Venta ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            return dt;
        }
       

        public static int save_venta(VentaReal vent)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            string query1 = "INSERT INTO Venta (date, dni_customer) VALUES (@date, @dni); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd1 = new SqlCommand(query1, cnn);
            cmd1.Parameters.AddWithValue("@date", vent.Date);
            cmd1.Parameters.AddWithValue("@dni", vent.Dni_customer);

            int ventaId = Convert.ToInt32(cmd1.ExecuteScalar());
            vent.Id = ventaId;

            cnn.Close();

            return ventaId;
        }
        public static void save_ventaDetalle(Venta vent)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            string query1 = "INSERT INTO VentaDetalle (sale_number, product_number, price, cant, total) VALUES (@sale_number, @product_number, @price, @cant, @total );";
            SqlCommand cmd1 = new SqlCommand(query1, cnn);
            cmd1.Parameters.AddWithValue("@sale_number", vent.Key_sale);
            cmd1.Parameters.AddWithValue("@product_number", vent.Key_product);
            cmd1.Parameters.AddWithValue("@price", vent.Price);
            cmd1.Parameters.AddWithValue("@cant", vent.Cant);
            cmd1.Parameters.AddWithValue("@total", vent.Total);
            cmd1.ExecuteNonQuery();
            cnn.Close();

        }

        public static void put_ventaDetalle(int id, string dni)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            string query1 = "UPDATE Venta SET dni_customer = @dni WHERE id = @id;";
            SqlCommand cmd1 = new SqlCommand(query1, cnn);
            cmd1.Parameters.AddWithValue("@id", id);
            cmd1.Parameters.AddWithValue("@dni", dni);
            cmd1.ExecuteNonQuery();

            cnn.Close();
        }
        public static DataTable list_cart(int id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select sale_number as 'VENTA NRO', product_number as 'PRODUCTO NRO DNI', price as 'PRECIO', cant AS 'CANTIDAD',  total AS 'TOTAL' from VentaDetalle where sale_number like @id ";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            return dt;
        }

        public static DataTable filter_by_customer(string category)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select date as 'Fecha', dni_customer as 'Cliente DNI' from Venta where dni_customer like @category";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@category",category);
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }

        public static DataTable filter_by_product(int id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Venta.date AS 'Fecha', Venta.dni_customer AS 'Cliente DNI' " +
                      "FROM Venta " +
                      "INNER JOIN VentaDetalle ON Venta.id = VentaDetalle.sale_number " +
                      "WHERE VentaDetalle.product_number = @id"; cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }

        public static DataTable filter_byDate(DateTime date1, DateTime date2) {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetSalesDateRange";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@StartDate", date1);
            cmd.Parameters.AddWithValue("@EndDate", date2);
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }   

    }
}
