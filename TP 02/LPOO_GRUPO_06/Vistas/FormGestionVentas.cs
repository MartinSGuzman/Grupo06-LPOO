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
        private VentaReal ventareal;

        public FormGestionVentas(VentaReal venta) {
            InitializeComponent();
            ventareal = venta;
            Console.WriteLine("LO QUE VIENE EN EL CONSTRUCTOR: "+ventareal.Id);
            //ventaDataGridView.DataSource = '';
        }
        private void FormGestionVentas_Load(object sender, EventArgs e)
        {
            load_roles();
            load_customers();
            lst_products();
            Console.WriteLine("LO QUE VIENE EN EL CONSTRUCTOR: " + ventareal.Id);
            //list_ventas();
        }

        private void list_ventas() {
            ventaDataGridView.DataSource = LogicaVenta.list_cart(ventareal.Id);
        }
        private void lst_products() {
            productsBox.DisplayMember = "description";
            productsBox.ValueMember = "id";
            productsBox.DataSource = LogicaProducto.list_productsBox();
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

            //filterCustomerBox.DisplayMember = "name";
            //filterCustomerBox.ValueMember = "id";
            //filterCustomerBox.DataSource = LogicaCliente.list_customerBox();
        }

        private void handle_selectedProduct(object sender, EventArgs e)
        {
            Console.Write("se selecciono" + productsBox.SelectedIndex.ToString());
            int seleccionado = productsBox.SelectedIndex + 1;
            Producto data = LogicaProducto.find_product(seleccionado.ToString());
            Console.Write("Este es el resulltado" + data.ToString());
            if (data != null) 
            {   
                codigoBox.Text = data.Key_product;
                priceLabel.Text = data.Price.ToString();
            }
            else {
                Console.WriteLine("NO SE ENCONTRO");
            }
        }
        private decimal total = 0;

        private void add_cart(object sender, EventArgs e)
        {
            int seleccionado = productsBox.SelectedIndex + 1;
            
            Console.Write("se selecciono" + seleccionado);
            Producto data = LogicaProducto.find_product(seleccionado.ToString());

            total += data.Price;

            totalLabel.Text = total.ToString();
            Console.WriteLine("TOTAL: " + total);
            //se setea los datos del cliente y la fecha
            clienteBox.Enabled = false;
            obraSocialBox.Enabled = false;
            dateBox.Enabled = false;


            //SE GUARDA LA VENTA DETALLE
            Venta ventaDetalle = new Venta();
            ventaDetalle.Cant = cantBox.Value;
            ventaDetalle.Key_product = seleccionado;
            ventaDetalle.Key_sale = ventareal.Id;
            ventaDetalle.Price = data.Price;
            ventaDetalle.Total = data.Price * cantBox.Value;
            LogicaVenta.save_ventaDetalle(ventaDetalle);
            Console.WriteLine("se guarda venta detalle");
            list_ventas();
            
        }

        private void handle_sell(object sender, EventArgs e)
        {
            Random rnd = new Random();
            VentaReal vent = new VentaReal();

            int id = clienteBox.SelectedIndex + 1;
            Cliente client = LogicaCliente.find_customer(id.ToString());
            //vent.Dni_customer = client.Dni;
            LogicaVenta.put_ventaDetalle(ventareal.Id, client.Dni.ToString());
            //LogicaVenta.save_venta(vent);
        }

        //private void filterByCustomer(object sender, EventArgs e)
        //{
        //   Console.WriteLine(filterCustomerBox.SelectedIndex);
        //   int id = filterCustomerBox.SelectedIndex + 1;
        //   Cliente client = LogicaCliente.find_customer(id.ToString());
        //   ventaDataGridView.DataSource = LogicaVenta.filter_by_customer(client.Dni.ToString()); 
        //
        //}
        //
        //private void filterByDate(object sender, EventArgs e)
        //{
        //    Console.WriteLine(dateBox1.Value.ToString());
        //    Console.WriteLine(dateBox2.Value.ToString());
        //    ventaDataGridView.DataSource = LogicaVenta.filter_byDate(dateBox1.Value, dateBox2.Value);
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

      

        
    }
}
