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
    public partial class FormProductGestion : Form
    {
        public FormProductGestion()
        {
            InitializeComponent();
        }

        private void save_product(object sender, EventArgs e)
        {
            load_productss();
        }

        private void FormProductGestion_Load(object sender, EventArgs e)
        {
            categoryFilterBox.Text = "";
            load_productss();
            load_categories();
        }

        private void load_productss() {
            productsData.DataSource = LogicaProducto.list_products();
        }

        private void load_categories() {
            categoriesBox.DisplayMember = "category";
            categoriesBox.ValueMember = "id";
            categoriesBox.DataSource = LogicaProducto.list_categories();

            categoryFilterBox.DisplayMember = "category";
            categoryFilterBox.ValueMember = "id";
            categoryFilterBox.DataSource = LogicaProducto.list_categories();
        }

        private void filter_byCategory(object sender, EventArgs e)
        {
            Console.WriteLine(categoryFilterBox.Text);
            productsData.DataSource = LogicaProducto.filter_byCateory(categoryFilterBox.Text.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            categoryFilterBox.Text = "";
            load_productss();
            //productsData.DataSource = LogicaProducto.list_products();
        }

        private void handleSaveProduct() {
            Producto pro = new Producto();
            pro.Key_product = keyProductBox.Value.ToString();
            pro.Category = categoriesBox.Text.ToString();
            pro.Price = priceBox.Value;
            pro.Description = DescripcionBox.Text;
            LogicaProducto.save_product(pro);
        }


    }
}
