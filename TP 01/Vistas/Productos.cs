using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            Producto oP = new Producto();
            oP.Prod_Categoria = categoriaProducto.Text;
            oP.Prod_Codigo = codigoProducto.Text;
            oUser.Usu_NombreUsuario1 = txtUsuario.Text;
            oUser.Usu_Contraseña1 = txtContraseña.Text;

            LogicaUsuario.insert_Usuario(oUser);

            load_usuarios();
        }
    }
}
