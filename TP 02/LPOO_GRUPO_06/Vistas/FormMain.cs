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
    }
}
