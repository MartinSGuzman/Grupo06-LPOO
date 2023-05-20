using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClaseBase
{
    public class LogicaCliente
    {
        public static DataTable list_customer() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select dni as 'DNI', name as 'Nombre', lastname as 'Apellido', address as 'Direccion', os_cuit as 'Obra Social CUIT', carnet_number as 'Numero de carnet' from Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }
        public static DataTable list_customerBox() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select name from Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }
        public static void save_customer(Cliente client)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(dni, name, lastname, address, os_cuit, carnet_number) values(@dniBox, @nameBox, @lastnameBox, @addressBox, @os_cuitBox, @carnet_numberBox)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dniBox", client.Dni);
            cmd.Parameters.AddWithValue("@nameBox", client.Name);
            cmd.Parameters.AddWithValue("@lastnameBox", client.Lastname);
            cmd.Parameters.AddWithValue("@addressBox", client.Address);
            cmd.Parameters.AddWithValue("@os_cuitBox", client.Os_cuit);
            cmd.Parameters.AddWithValue("@carnet_numberBox", client.Carnet_number);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static Cliente find_customer(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Cliente where id like @id ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@id", "%" + dni + "%");
            Cliente found = new Cliente();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dadapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                found.Dni = row["dni"].ToString();
                found.Address = row["address"].ToString();
                found.Carnet_number = row["carnet_number"].ToString();
                found.Name = row["name"].ToString();
                found.Lastname = row["lastname"].ToString();
                found.Os_cuit = row["os_cuit"].ToString();
            }
            else {
                Console.WriteLine("No encontro chaval");
            }
            return found;
        }

        public static DataTable order_byLastName() {
            SqlConnection cnn = new SqlConnection(ClaseBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select dni as 'DNI', name as 'Nombre', lastname as 'Apellido', address as 'Direccion', os_cuit as 'Obra Social CUIT', carnet_number as 'Numero de carnet' from Cliente order by lastname";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();

            dadapter.Fill(datatable);
            return datatable;
        }

        
    }
}
