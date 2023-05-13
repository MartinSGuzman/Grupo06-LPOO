using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            //se agrega que es un contenedor
            this.IsMdiContainer = true;
            InitializeComponent();
            
        }
        public FormMain(int rol)
        {
            InitializeComponent();
            if(rol == 1 ){
                gestionClientesToolStripMenuItem.Visible = false;
            }
        }
        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios frmg = new FormGestionUsuarios();

            //se dice que su padre es este
            frmg.MdiParent = this;

            frmg.Show();
        }

        private void formGestion(object sender, EventArgs e)
        {
            FormGestionClientes frmcustomer = new FormGestionClientes();
            frmcustomer.MdiParent = this;
            frmcustomer.Show();
        }

        private void handle_singout(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
