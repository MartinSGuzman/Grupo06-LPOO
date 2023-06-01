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

        private void save_user(object sender, EventArgs e)
        {
            Cliente client = new Cliente();
            client.Dni = dniBox.Text;
            client.Name = nameBox.Text;
            client.Lastname = lastnameBox.Text;
            client.Os_cuit = os_cuitBox.Text;
            client.Carnet_number = carnet_numberBox.Text;
            client.Address = addressBox.Text;
            Console.WriteLine("OBJETO CLIENT SET CON LOS BOX ADDRESS" + client.Address);
            LogicaCliente.save_customer(client);
            list_customer();
        }

        private void FormGestionClientes_Load(object sender, EventArgs e)
        {
            list_customer();
        }
        private void list_customer() {
            customerDataGrid.DataSource = LogicaCliente.list_customer();
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

      
    }
}
