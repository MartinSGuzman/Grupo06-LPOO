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
        public static void save_venta(Venta vent)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            cnn.Open();

            // Primera consulta
            string query1 = "INSERT INTO Venta (date, dni_customer) VALUES (@date, @dni)";
            SqlCommand cmd1 = new SqlCommand(query1, cnn);
            cmd1.Parameters.AddWithValue("@date", vent.Date);
            cmd1.Parameters.AddWithValue("@dni", vent.Dni_customer);
            cmd1.ExecuteNonQuery();

            // Segunda consulta
            string query2 = "INSERT INTO VentaDetalle (key_sale, key_product, price, total, cant) VALUES (@keysale, @keyproduct, @price, @total, @cant)";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cmd2.Parameters.AddWithValue("@keysale", vent.Key_sale);
            cmd2.Parameters.AddWithValue("@keyproduct", vent.Key_product);
            cmd2.Parameters.AddWithValue("@price", vent.Price);
            cmd2.Parameters.AddWithValue("@total", vent.Total);
            cmd2.Parameters.AddWithValue("@cant", vent.Cant);
            cmd2.ExecuteNonQuery();

            cnn.Close();
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
