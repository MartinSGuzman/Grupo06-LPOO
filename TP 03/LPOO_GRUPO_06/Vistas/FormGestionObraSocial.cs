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
            if (razonBox.Text != "" && numberBox.Text != "") {
                saveButton.Enabled = true;
            }
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
                ObraSocial newc = new ObraSocial();
                newc.Razon = razonBox.Text.ToString();
                newc.Number = numberBox.Text.ToString();
                newc.Phone = phoneBox.Text.ToString();
                newc.Address = addressBox.Text.ToString();
                LogicaObraSocial.save_obrasocial(newc);
                editar = false;
                list_obras();
            }

            if (editar == true)
            {
                try
                {
                    Console.WriteLine("ENTRA POR EDITAR");
                    LogicaObraSocial.edit_obraSocial(numberBox.Text, addressBox.Text, phoneBox.Text, razonBox.Text, idObra);
                    list_obras();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
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