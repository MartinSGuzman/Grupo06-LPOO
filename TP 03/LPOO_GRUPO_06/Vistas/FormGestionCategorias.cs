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
    public partial class FormGestionCategorias : Form
    {
        private Boolean editar = false;
        private string idCategory = null;
        public FormGestionCategorias()
        {
            InitializeComponent();
        }

        private void FormGestionCategorias_Load(object sender, EventArgs e)
        {
            list_categories();
            categoryData.Enabled = false;
            categoryData.ClearSelection();
        }
       
        public void list_categories() {
            categoryData.DataSource = LogicaCategoria.list_categories();
        }
        private void handleSave(object sender, EventArgs e)
        {
            categoryData.ClearSelection();
            if (editar == false) {
                Category newc = new Category();
                newc.Description = descriptionBox.Text.ToString();
                LogicaCategoria.save_category(newc);
                editar = false;
                list_categories();
            }

            if (editar == true)
            {
                try
                {
                    Console.WriteLine("ENTRA POR EDITAR");
                    LogicaCategoria.edit_category(descriptionBox.Text, idCategory);
                    list_categories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
                }
            }
            categoryData.ClearSelection();
            descriptionBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void handleEditVisible(object sender, EventArgs e)
        {
            categoryData.Enabled = true;
            removeButton.Visible = true;
            cancellButton.Visible = true;
            editar = true;
        }

       

        private void handleCancell(object sender, EventArgs e)
        {
            editar = false;
            removeButton.Visible = false;
            cancellButton.Visible = false;
            categoryData.ClearSelection();
            descriptionBox.Text = "";
        }

        private void categoryData_CellContentClick(object sender, EventArgs e)
        {
            Console.WriteLine("EDITA ESTE");
            Console.WriteLine(editar);
            if (categoryData.CurrentRow != null && editar == true)
            {
                editar = true;
                idCategory = categoryData.CurrentRow.Cells["id_category"].Value.ToString();
                Console.WriteLine("ID DEL PRODUCTO: " + idCategory);
                descriptionBox.Text = categoryData.CurrentRow.Cells["category_desc"].Value.ToString();
            }
        }

        private void handleRemoveC(object sender, EventArgs e)
        {
            if (categoryData.CurrentRow != null)
            {
                Console.WriteLine("TRUEEEEE REMOVE");
                idCategory = categoryData.CurrentRow.Cells["id_category"].Value.ToString();
                LogicaCategoria.delete_category(idCategory);
                list_categories();
            }
            else
            {
                MessageBox.Show("SLECICONE UNA CATEGORIA!");
            }
        }

        
    }
}
