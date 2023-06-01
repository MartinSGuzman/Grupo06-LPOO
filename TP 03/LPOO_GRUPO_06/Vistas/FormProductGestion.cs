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
            if(editar == false){
                Console.WriteLine("ENTRA POR GUARDAR");
            Producto pro = new Producto();
            pro.Key_product = keyProductBox.Value.ToString();
            pro.Category = categoriesBox.Text.ToString();
            pro.Price = priceBox.Value;
            pro.Description = DescripcionBox.Text;
            LogicaProducto.save_product(pro);
            editar = false;
            load_products();
            }

            if (editar == true)
            {
                try
                {
                    Console.WriteLine("ENTRA POR EDITAR");
                    LogicaProducto.edit_product(keyProductBox.Text, categoriesBox.Text, priceBox.Text, DescripcionBox.Text, idProduct);
                    editar = false;

                    load_products();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
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
