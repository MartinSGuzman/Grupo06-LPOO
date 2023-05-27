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
    public partial class FormProductGestion : Form
    {
        private string idProduct = null;
        private Boolean editar = false;
        public FormProductGestion()
        {
            InitializeComponent();
        }

        private void FormProductGestion_Load(object sender, EventArgs e)
        {
            load_products();
            categoryFilterBox.Text = "";
            load_categories();
        }

        private void load_products() {
            productsData.DataSource = LogicaProducto.list_products();
        }

        private void load_categories() {
            //categoriesBox.DisplayMember = "category";
            //categoriesBox.ValueMember = "id";
            //categoriesBox.DataSource = LogicaProducto.list_categories();
            //
            //categoryFilterBox.DisplayMember = "category";
            //categoryFilterBox.ValueMember = "id";
            //categoryFilterBox.DataSource = LogicaProducto.list_categories();
        }

        private void filter_byCategory(object sender, EventArgs e)
        {
            productsData.DataSource = LogicaProducto.filter_byCateory(categoryFilterBox.Text.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            categoryFilterBox.Text = "";
            //productsData.DataSource = LogicaProducto.list_products();
        }

        private void handleSaveProduct(object sender, EventArgs e)
        {
            Producto pro = new Producto();
            pro.Key_product = keyProductBox.Value.ToString();
            pro.Category = categoriesBox.Text.ToString();
            pro.Price = priceBox.Value;
            pro.Description = DescripcionBox.Text;
            LogicaProducto.save_product(pro);

            if (editar == true)
            {
                try
                {
                    LogicaProducto.edit_product(keyProductBox.Text, categoriesBox.Text, priceBox.Text, DescripcionBox.Text, idProduct);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
                }
            }
        }

        private void deleteProduct(object sender, EventArgs e)
        {
            if (productsData.CurrentRow != null)
            {
                Console.WriteLine("TRUEEEEE REMOVE");
                idProduct = productsData.CurrentRow.Cells["ID"].Value.ToString();
                LogicaProducto.deleteProduct(idProduct);
            }
            else
            {
                MessageBox.Show("SLECICONE UN USUARIO!");
            }
        }

        private void productsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void productsData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (productsData.CurrentRow != null)
            {
                editar = true;
                idProduct = productsData.CurrentRow.Cells["ID"].Value.ToString();
                keyProductBox.Text = productsData.CurrentRow.Cells["COD PRODUCTO"].Value.ToString();
                categoriesBox.Text = productsData.CurrentRow.Cells["categoria"].Value.ToString();
                DescripcionBox.Text = productsData.CurrentRow.Cells["Descripcion"].Value.ToString();
                priceBox.Text = productsData.CurrentRow.Cells["Precio"].Value.ToString();
               
            }
        }

        private void handleSaveProduct()
        {
        
        }


    }
}