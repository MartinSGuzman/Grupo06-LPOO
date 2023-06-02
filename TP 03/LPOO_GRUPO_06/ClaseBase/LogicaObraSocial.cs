using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ClaseBase
{
    public class LogicaObraSocial
    {
        public static DataTable list_obraSocial() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT id, os_razon from ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dadapter.Fill(dt);

            return dt;
        }
        public static DataTable list_obraSocials()
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT id as 'ID', os_razon as 'RAZON SOCIAL', os_phone as 'TELEFONO', os_address as 'DIRECCION', os_number as 'Nro' from ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            dadapter.Fill(dt);

            return dt;
        }
        public static void save_obrasocial(ObraSocial newp)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO ObraSocial(os_number, os_razon, os_address, os_phone) values(@os_number, @os_razon, @os_address, @os_phone)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@os_number", newp.Number);
            cmd.Parameters.AddWithValue("@os_address", newp.Address);
            cmd.Parameters.AddWithValue("@os_phone", newp.Phone);
            cmd.Parameters.AddWithValue("@os_razon", newp.Razon);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void edit_obraSocial(string os_number, string os_address, string os_phone, string os_razon, string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE ObraSocial SET os_number = @os_number, os_address = @os_address, os_phone = @os_phone, os_razon = @os_razon WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@os_number", os_number);
            cmd.Parameters.AddWithValue("@os_address", os_address);
            cmd.Parameters.AddWithValue("@os_phone", os_phone);
            cmd.Parameters.AddWithValue("@os_razon", os_razon);
            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
        public static void delete_obraSocial(string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM ObraSocial WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static ObraSocial find_obraSocial(string id)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * from ObraSocial WHERE id like @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", "%" + id + "%");
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            ObraSocial producto = new ObraSocial();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                producto.Id = Convert.ToInt32(row["id"]);
                producto.Razon = row["os_razon"].ToString();
            }
            else {
                Console.WriteLine("NO SE ENCONTRO NINGUNA OBRA SOCIAL");
            }
            return producto;
        }
    }
}
