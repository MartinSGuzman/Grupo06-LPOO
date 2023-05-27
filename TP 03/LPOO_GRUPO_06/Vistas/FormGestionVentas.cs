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
        private List<Venta> carrito = new List<Venta>();
        //private VentaReal ventareal;

        //public FormGestionVentas(VentaReal venta) {
        //    InitializeComponent();
        //    ventareal = venta;
        //    Console.WriteLine("LO QUE VIENE EN EL CONSTRUCTOR: "+ventareal.Id);
        //    //ventaDataGridView.DataSource = '';
        //}
        private void FormGestionVentas_Load(object sender, EventArgs e)
        {
            load_roles();
            load_customers();
            lst_products();
            list_ventas();
        }

        private void list_ventas() {

            var source = new BindingSource();
            source.DataSource = carrito;
            

            ventaDataGridView.DataSource = source;

            ventaDataGridView.Columns.Clear();
            // Crea las columnas que deseas mostrar

            DataGridViewTextBoxColumn columnaProductKey = new DataGridViewTextBoxColumn();
            columnaProductKey.DataPropertyName = "key_product"; // Nombre de la propiedad en la clase Venta
            columnaProductKey.HeaderText = "Cod.Producto";
            ventaDataGridView.Columns.Add(columnaProductKey);

            DataGridViewTextBoxColumn columnaProducto = new DataGridViewTextBoxColumn();
            columnaProducto.DataPropertyName = "product_name"; // Nombre de la propiedad en la clase Venta
            columnaProducto.HeaderText = "Producto";
            ventaDataGridView.Columns.Add(columnaProducto);


            DataGridViewTextBoxColumn columnaCant = new DataGridViewTextBoxColumn();
            columnaCant.DataPropertyName = "Cant"; // Nombre de la propiedad en la clase Venta
            columnaCant.HeaderText = "Cantidad";
            ventaDataGridView.Columns.Add(columnaCant);

            DataGridViewTextBoxColumn columnaPrice = new DataGridViewTextBoxColumn();
            columnaPrice.DataPropertyName = "Price"; // Nombre de la propiedad en la clase Venta
            columnaPrice.HeaderText = "Precio";
            ventaDataGridView.Columns.Add(columnaPrice);

            DataGridViewTextBoxColumn columnaPriceTotal = new DataGridViewTextBoxColumn();
            columnaPriceTotal.DataPropertyName = "total"; // Nombre de la propiedad en la clase Venta
            columnaPriceTotal.HeaderText = "Total";
            ventaDataGridView.Columns.Add(columnaPriceTotal);

            // Agrega más columnas si es necesario

            // Actualiza el control DataGridView
            ventaDataGridView.Refresh();
        }
        private void add_cart(object sender, EventArgs e)
        {
            int seleccionado = productsBox.SelectedIndex + 1;

            Console.Write("se selecciono" + seleccionado);
            Producto data = LogicaProducto.find_product(seleccionado.ToString());


           
            //se setea los datos del cliente y la fecha
            clienteBox.Enabled = false;
            obraSocialBox.Enabled = false;
            dateBox.Enabled = false;


            //SE GUARDA LA VENTA DETALLE
            Venta ventaDetalle = new Venta();
            ventaDetalle.Cant = cantBox.Value;
            ventaDetalle.Key_product = data.Key_product.ToString();
            ventaDetalle.Price = data.Price;
            ventaDetalle.Total = data.Price * cantBox.Value;
            ventaDetalle.Product_name = productsBox.Text.ToString();
            //LogicaVenta.save_ventaDetalle(ventaDetalle);
            Console.WriteLine("se guarda venta detalle");
            total += ventaDetalle.Total;
            totalLabel.Text = total.ToString();
            carrito.Add(ventaDetalle);
            list_ventas();
            sellButton.Enabled = true;
            cancelarButton.Enabled = true;
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

        

        private void handle_sell(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int id = clienteBox.SelectedIndex + 1;
            Cliente client = LogicaCliente.find_customer(id.ToString());
            //LogicaVenta.put_ventaDetalle(ventareal.Id, client.Dni.ToString());
            VentaReal newVenta = new VentaReal();
            newVenta.Date = DateTime.Now;
            newVenta.Dni_customer = client.Dni;
            int ventaId = LogicaVenta.save_venta(newVenta);
            newVenta.Id = ventaId;
            foreach (Venta detalle in carrito)
            {
                detalle.Key_sale = ventaId.ToString();
                LogicaVenta.save_ventaDetalle(detalle);// Asigna el ID de la venta a cada venta detalle
            }
            this.Close();
            
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

        private void ventaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancellSell(object sender, EventArgs e)
        {
            this.Close();
        }

      

        
    }
}
