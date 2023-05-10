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
    public partial class FormGestionVentas : Form
    {
        public FormGestionVentas()
        {
            InitializeComponent();
        }

        private void FormGestionVentas_Load(object sender, EventArgs e)
        {
            load_roles();
            load_customers();
            lst_products();
            list_ventas();
        }

        private void list_ventas() {
            ventaDataGridView.DataSource = LogicaVenta.list_ventas();
        }
        private void lst_products() {
            productsBox.DisplayMember = "description";
            productsBox.ValueMember = "id";
            productsBox.DataSource = LogicaProducto.list_products();
        }
        private void load_roles(){
            obraSocialBox.DisplayMember = "os_razon";
            obraSocialBox.ValueMember = "id";
            obraSocialBox.DataSource = LogicaObraSocial.list_obraSocial();
        }

        private void load_customers() { 
            clienteBox.DisplayMember = "name";
            clienteBox.ValueMember = "id";
            clienteBox.DataSource = LogicaCliente.list_customerBox();
        }

        private void handle_selectedProduct(object sender, EventArgs e)
        {
            Console.Write("se selecciono" + productsBox.SelectedIndex.ToString());
            int seleccionado = productsBox.SelectedIndex + 1;
            Producto data = LogicaProducto.find_product(seleccionado.ToString());
            Console.Write("Este es el resulltado" + data.ToString());
            if (data != null) 
            {   
                priceBox.Value = data.Price;
                codigoBox.Text = data.Key_product;
            }
            else {
                Console.WriteLine("NO SE ENCONTRO");
            }
        }

        private void handle_sell(object sender, EventArgs e)
        {

            Random rnd = new Random();
            Venta vent = new Venta();
            Console.WriteLine(cantBox.Value);
            Console.WriteLine(dateBox.Value);

            vent.Cant = cantBox.Value;
            vent.Date = dateBox.Value;
            int idp = productsBox.SelectedIndex + 1;
            Producto pro = LogicaProducto.find_product(idp.ToString());
            vent.Key_product = pro.Key_product;
            vent.Price = pro.Price;
            vent.Key_sale = rnd.Next(100000, 999999).ToString();
            vent.Total = priceBox.Value * cantBox.Value;
            int id = clienteBox.SelectedIndex + 1;
            Cliente client = LogicaCliente.find_customer(id.ToString());
            vent.Dni_customer = client.Dni;
            Console.WriteLine("DNI DEL CLIENTE " + vent.Dni_customer + "y este es el BOX CLIENT " + clienteBox.SelectedIndex.ToString());
            LogicaVenta.save_venta(vent);
            list_ventas();
        }


    }
}
