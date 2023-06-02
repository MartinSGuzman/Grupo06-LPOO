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
    public partial class FormGestionObraSocial : Form
    {
        private string idObra = null;
        private Boolean editar = false;
        public FormGestionObraSocial()
        {
            InitializeComponent();
        }
        private void FormGestionObraSocial_Load(object sender, EventArgs e)
        {
            list_obras();
            obrasocialdata.Enabled = false;
            
        }

        private void list_obras() {
            obrasocialdata.DataSource = LogicaObraSocial.list_obraSocials();
        }

        private void obrasocialdata_CurrentCellChanged(object sender, EventArgs e)
        {
            if (obrasocialdata.CurrentRow != null && editar == true)
            {
                editar = true;
                idObra = obrasocialdata.CurrentRow.Cells["ID"].Value.ToString();
                Console.WriteLine("ID DEL PRODUCTO: " + idObra);
                razonBox.Text = obrasocialdata.CurrentRow.Cells["RAZON SOCIAL"].Value.ToString();
                addressBox.Text = obrasocialdata.CurrentRow.Cells["TELEFONO"].Value.ToString();
                numberBox.Text = obrasocialdata.CurrentRow.Cells["Nro"].Value.ToString();
                phoneBox.Text = obrasocialdata.CurrentRow.Cells["TELEFONO"].Value.ToString();
            }
        }

        private void handleVisibleEdit(object sender, EventArgs e)
        {
            removeButton.Visible = true;
            cancelButton.Visible = true;
            editar = true;
            obrasocialdata.Enabled = true;
        }

        private void handleCancell(object sender, EventArgs e)
        {
            editar = false;
            removeButton.Visible = false;
            cancelButton.Visible = false;
            obrasocialdata.Enabled = false;
            razonBox.Text = "";
            addressBox.Text = "";
            phoneBox.Text = "";
            numberBox.Text = "";
        }

        private void handleRemoveO(object sender, EventArgs e)
        {

            if (obrasocialdata.CurrentRow != null)
            {
                Console.WriteLine("TRUEEEEE REMOVE");
                idObra = obrasocialdata.CurrentRow.Cells["ID"].Value.ToString();
                LogicaObraSocial.delete_obraSocial(idObra);
                list_obras();
                razonBox.Text = "";
                addressBox.Text = "";
                phoneBox.Text = "";
                numberBox.Text = "";
            }
            else
            {
                MessageBox.Show("SLECICONE UNA CATEGORIA!");
            }
        }

        private void handleSave(object sender, EventArgs e)
        {
            obrasocialdata.ClearSelection();

            if (editar == false)
            {
                string razon = razonBox.Text;
                string number = numberBox.Text;
                string phone = phoneBox.Text;
                string address = addressBox.Text;

                if (razon == "" && number == "" && phone == "" && address == "")
                {
                    MessageBox.Show("COMPLETA TODOS LOS CAMPOS", "ERROR AL GUARDAR OBRA SOCIAL", MessageBoxButtons.OKCancel);
                }
                else
                {
                    string message = string.Format("Razón: {0}\nNúmero: {1}\nTeléfono: {2}\nDirección: {3}", razon, number, phone, address);

                    DialogResult result = MessageBox.Show(message, "Confirmar Guardar", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        ObraSocial newObraSocial = new ObraSocial();
                        newObraSocial.Razon = razon;
                        newObraSocial.Number = number;
                        newObraSocial.Phone = phone;
                        newObraSocial.Address = address;
                        LogicaObraSocial.save_obrasocial(newObraSocial);

                        editar = false;
                        list_obras();
                    }
                }
            }
            else if (editar == true)
            {
                string razon = razonBox.Text;
                string number = numberBox.Text;
                string phone = phoneBox.Text;
                string address = addressBox.Text;

                string message = string.Format("Razón: {0}\nNúmero: {1}\nTeléfono: {2}\nDirección: {3}", razon, number, phone, address);

                DialogResult result = MessageBox.Show(message, "Confirmar Edición", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        Console.WriteLine("ENTRA POR EDITAR");
                        LogicaObraSocial.edit_obraSocial(number, address, phone, razon, idObra);
                        list_obras();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede editar estos datos: " + ex.Message);
                    }
                }
            }

            obrasocialdata.ClearSelection();
            razonBox.Text = "";
            phoneBox.Text = "";
            numberBox.Text = "";
            addressBox.Text = "";
        }

       
    }
}
