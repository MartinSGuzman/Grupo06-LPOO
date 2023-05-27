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
    public partial class FormMain : Form
    {
        private Usuario user;
        public FormMain()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
            
        }
        public FormMain(Usuario user)
        {
            InitializeComponent();
            this.user = user; 
            if(user.Rol_id == 1 ){
                gestionClientesToolStripMenuItem.Visible = false;
                gestionVentasToolStripMenuItem.Visible = false;
            }
            if (user.Rol_id == 2)
            {
                gestionUsuarioMenuStrip.Visible = false;
                gestionProductosToolStripMenuItem.Visible = false;
            }
            
        }
        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios frmg = new FormGestionUsuarios(user);

            //se dice que su padre es este

            frmg.Show();
        }

        private void formGestion(object sender, EventArgs e)
        {
            FormGestionClientes frmcustomer = new FormGestionClientes();
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
            nameUser.Text = user.User_username.ToString();
        }

        private void gestionProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProductGestion frmprodcs = new FormProductGestion();
            frmprodcs.Show();
        }

        private void gestionVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VentaReal newVenta = new VentaReal();
            //newVenta.Date = DateTime.Now;
            //newVenta.Dni_customer = 44645905.ToString();
            //int ventaId = LogicaVenta.save_venta(newVenta);
            //newVenta.Id = ventaId;
            //
            FormGestionVentas frmventas = new FormGestionVentas();
            frmventas.Show();
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionVentasVer fromv = new FormGestionVentasVer();
            fromv.Show();
        }
    }
}
