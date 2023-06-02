using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;
namespace Vistas
{
    public partial class FormGestionClientes : Form
    {
        public FormGestionClientes()
        {
            InitializeComponent();
        }
        private Boolean editar = false;
        private string idCustomer = null;

        private void save_user(object sender, EventArgs e)
        {
            customerDataGrid.ClearSelection();
            if (editar == false)
            {
                Cliente client = new Cliente();
                client.Dni = dniBox.Text;
                client.Name = nameBox.Text;
                client.Lastname = lastnameBox.Text;
                client.Os_cuit = os_cuitBox.Text;
                client.Carnet_number = carnet_numberBox.Text;
                client.Address = addressBox.Text;
                client.Os_id = (int)((DataRowView)osBox.SelectedItem)[osBox.ValueMember];
                Console.WriteLine("OBJETO CLIENT SET CON LOS BOX ADDRESS" + client.Address);
                LogicaCliente.save_customer(client);
                list_customer();
            }
            if (editar == true)
            {
                try
                {
                    int os = (int)((DataRowView)osBox.SelectedItem)[osBox.ValueMember];
                    LogicaCliente.edit_customer(dniBox.Text,nameBox.Text, lastnameBox.Text, addressBox.Text, os_cuitBox.Text, carnet_numberBox.Text, os.ToString() , idCustomer);
                    list_customer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
                }
            }
            customerDataGrid.ClearSelection();
            dniBox.Text = "";
            nameBox.Text = "";
            lastnameBox.Text = "";
            addressBox.Text = "";
            os_cuitBox.Text = "";
            carnet_numberBox.Text = "";
        }

        private void handleEditVisible(object sender, EventArgs e)
        {
            editar = true;
            removeBox.Visible = true;
            cancelButton.Visible = true;
            customerDataGrid.Enabled = true;

        }
        private void handleCancell(object sender, EventArgs e)
        {
            editar = false;
            customerDataGrid.Enabled = false;
            removeBox.Visible = false;
            cancelButton.Visible = false;
            customerDataGrid.ClearSelection();
            dniBox.Text = "";
            nameBox.Text = "";
            lastnameBox.Text = "";
            addressBox.Text = "";
            os_cuitBox.Text = "";
            carnet_numberBox.Text = "";

        }
        private void handleRemoveC(object sender, EventArgs e)
        {
            if (customerDataGrid.CurrentRow != null)
            {
                idCustomer = customerDataGrid.CurrentRow.Cells["ID"].Value.ToString();
                LogicaCliente.delete_customer(idCustomer);
                list_customer();
            }
            else
            {
                MessageBox.Show("SLECICONE UNA CATEGORIA!");
            }
        }

        

        private void customerDataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (customerDataGrid.CurrentRow != null && editar == true)
            {
                editar = true;
                idCustomer = customerDataGrid.CurrentRow.Cells["ID"].Value.ToString();
                dniBox.Text = customerDataGrid.CurrentRow.Cells["DNI"].Value.ToString();
                nameBox.Text = customerDataGrid.CurrentRow.Cells["Nombre"].Value.ToString();
                lastnameBox.Text = customerDataGrid.CurrentRow.Cells["Apellido"].Value.ToString();
                addressBox.Text = customerDataGrid.CurrentRow.Cells["Direccion"].Value.ToString();
                os_cuitBox.Text = customerDataGrid.CurrentRow.Cells["Obra Social CUIT"].Value.ToString();
                carnet_numberBox.Text = customerDataGrid.CurrentRow.Cells["Numero de carnet"].Value.ToString();
            }
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {
            list_os();
            list_customer();
            customerDataGrid.Enabled = false;
            customerDataGrid.ClearSelection();
        }
        private void list_customer() {
            customerDataGrid.DataSource = LogicaCliente.list_customer();
        }

        private void list_os() {
            osBox.DisplayMember = "os_razon";
            osBox.ValueMember = "id";
            osBox.DataSource = LogicaObraSocial.list_obraSocial();
        }

        private void orderbylastname(object sender, EventArgs e)
        {
            customerDataGrid.DataSource = LogicaCliente.order_byLastName();
            Console.WriteLine("cambia");
            Console.WriteLine(lastnamerBox.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dni_Click(object sender, EventArgs e)
        {

        }

        private void dniBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void os_cuitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {

        }

       


      

      
    }
}
