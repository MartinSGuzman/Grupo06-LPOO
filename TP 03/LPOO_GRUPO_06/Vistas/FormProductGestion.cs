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
        private string idProduct = null;
        private Boolean editar = false;
        public FormProductGestion()
        {
            InitializeComponent();
        }

        private void FormProductGestion_Load(object sender, EventArgs e)
        {
            productsData.Enabled = false;
            load_products();
            //categoryFilterBox.Text = "";
            load_categories();
            productsData.ClearSelection();
            editar = false;
            productsData.Enabled = false;
        }


        private void load_products() {
            productsData.DataSource = LogicaProducto.list_products();
        }

        private void load_categories() {
            categoriesBox.DisplayMember = "category_desc";
            categoriesBox.ValueMember = "id";
            categoriesBox.DataSource = LogicaCategoria.list_categories();
            
            //categoryFilterBox.DisplayMember = "category";
            //categoryFilterBox.ValueMember = "id";
            //categoryFilterBox.DataSource = LogicaProducto.list_categories();
        }

        //private void filter_byCategory(object sender, EventArgs e)
        //{
        //    productsData.DataSource = LogicaProducto.filter_byCateory(categoryFilterBox.Text.ToString());
        //}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //categoryFilterBox.Text = "";
            //productsData.DataSource = LogicaProducto.list_products();
        }

        private void handleSaveProduct(object sender, EventArgs e)
        {
             productsData.ClearSelection();

    if (editar == false)
    {
        string key_product = keyProductBox.Value.ToString();
        string category = categoriesBox.Text;
        decimal price = priceBox.Value;
        string description = DescripcionBox.Text;

        if (keyProductBox.Value.ToString() == "0" && category == "" && priceBox.Value.ToString() == "0" && description == "")
        {
            MessageBox.Show("COMPLETA TODOS LOS CAMPOS", "ERROR AL GUARDAR PRODUCTO", MessageBoxButtons.OKCancel);
        }
        else
        {
            string message = string.Format("Clave: {0}\nCategoría: {1}\nPrecio: {2}\nDescripción: {3}", key_product, category, price, description);

            DialogResult result = MessageBox.Show(message, "Confirmar Guardar", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Producto newProduct = new Producto();
                newProduct.Key_product = key_product;
                newProduct.Category = category;
                newProduct.Price = price;
                newProduct.Description = description;
                LogicaProducto.save_product(newProduct);

                editar = false;
                load_products();
            }
        }
    }
    else if (editar == true)
    {
        string key_product = keyProductBox.Value.ToString();
        string category = categoriesBox.Text;
        decimal price = priceBox.Value;
        string description = DescripcionBox.Text;

        string message = string.Format("Clave: {0}\nCategoría: {1}\nPrecio: {2}\nDescripción: {3}", key_product, category, price, description);

            DialogResult result = MessageBox.Show(message, "Confirmar EDICION", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            { 
        Console.WriteLine("ENTRA POR EDITAR");
        LogicaProducto.edit_product(keyProductBox.Text, categoriesBox.Text, priceBox.Text, DescripcionBox.Text, idProduct);
        load_products();
            }

    }

    productsData.ClearSelection();
    categoriesBox.Text = "";
    priceBox.Value = 0;
    DescripcionBox.Text = "";
    keyProductBox.Value = 0;
        }
       
        private void deleteProduct(object sender, EventArgs e)
        {
            if (productsData.CurrentRow != null )
            {
                Console.WriteLine("TRUEEEEE REMOVE");
                idProduct = productsData.CurrentRow.Cells["ID"].Value.ToString();
                LogicaProducto.deleteProduct(idProduct);
                load_products();
            }
            else
            {
                MessageBox.Show("SLECICONE UN Producto!");
            }
        }

        private void productsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void productsData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (productsData.CurrentRow != null && editar == true)
            {
                editar = true;
                idProduct = productsData.CurrentRow.Cells["ID"].Value.ToString();
                Console.WriteLine("ID DEL PRODUCTO: " + idProduct);
                keyProductBox.Text = productsData.CurrentRow.Cells["COD PRODUCTO"].Value.ToString();
                categoriesBox.Text = productsData.CurrentRow.Cells["categoria"].Value.ToString();
                DescripcionBox.Text = productsData.CurrentRow.Cells["Descripcion"].Value.ToString();
                priceBox.Text = productsData.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void handleSaveProduct()
        {
        
        }

        private void handleEditVisible(object sender, EventArgs e)
        {
            productsData.Enabled = true;
            handleRemove.Visible = true;
            editar = true;
            handleCancell.Visible = true;
        }

        private void handleRemoveVisible(object sender, EventArgs e)
        {
            handleRemove.Visible = false;
            handleCancell.Visible = false;
            productsData.Enabled = false;
            categoriesBox.Text = "";
            DescripcionBox.Text = "";
            priceBox.Value = 0;
        }


    }
}
