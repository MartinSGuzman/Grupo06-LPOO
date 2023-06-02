﻿using System;
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
    public partial class FormGestionVentasVer : Form
    {
        public FormGestionVentasVer()
        {
            InitializeComponent();
        }

        private void FormGestionVentasVer_Load(object sender, EventArgs e)
        {
            list_ventas();
            lst_products();
            load_customers();
        }
        private void list_ventas()
        {
            dataVenta.DataSource = LogicaVenta.list_ventas();
        }
        private void lst_products()
        {
            productsBox.DisplayMember = "name";
            productsBox.ValueMember = "id";
            productsBox.DataSource = LogicaCliente.list_customerBox();
        }
        //private void load_roles()
        //{
        //    obraSocialBox.DisplayMember = "os_razon";
        //    obraSocialBox.ValueMember = "id";
        //    obraSocialBox.DataSource = LogicaObraSocial.list_obraSocial();
        //}
        //
        private void load_customers()
        {
            clienteBox.DisplayMember = "name";
            clienteBox.ValueMember = "id";
            clienteBox.DataSource = LogicaCliente.list_customerBox();
        
            //filterCustomerBox.DisplayMember = "name";
            //filterCustomerBox.ValueMember = "id";
            //filterCustomerBox.DataSource = LogicaCliente.list_customerBox();
        }
        private void filterByDate(object sender, EventArgs e)
        {
            Console.WriteLine(dateBox1.Value.ToString());
            Console.WriteLine(dateBox2.Value.ToString());
            dataVenta.DataSource = LogicaVenta.filter_byDate(dateBox1.Value, dateBox2.Value);
        }
        private void filterByCustomer(object sender, EventArgs e)
        {
            Console.WriteLine(clienteBox.SelectedIndex);
            int id = (int)((DataRowView)clienteBox.SelectedItem)[clienteBox.ValueMember]; ;
            Console.WriteLine("ID A BUSCAR " + id);
            Cliente client = LogicaCliente.find_customer(id.ToString());
            dataVenta.DataSource = LogicaVenta.filter_by_customer(client.Dni.ToString());

        }

        private void filterByProduct(object sender, EventArgs e)
        {
            list_ventas();
            int id = (int)((DataRowView)productsBox.SelectedItem)[productsBox.ValueMember];
            Cliente client = LogicaCliente.find_customer(id.ToString());
            dataVenta.DataSource = LogicaCliente.filter_byProducts(client.Dni.ToString());

        }

        private void dataVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void handleLimpiar(object sender, EventArgs e)
        {
            list_ventas();
        }


    }
}
