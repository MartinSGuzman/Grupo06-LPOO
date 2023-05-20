using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void SaveUser_Click (object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)cmbRol_Id.SelectedValue;
            oUser.Usu_ApellidoNombre1 = txtUsu_ApellidoNombre1.Text;
            oUser.Usu_NombreUsuario1 = txtUsuario.Text;
            oUser.Usu_Contraseña1 = txtContraseña.Text;

            LogicaUsuario.insert_Usuario(oUser);

            load_usuarios();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();

            load_usuarios();
        }

        private void load_combo_roles()
        {
            cmbRol_Id.DisplayMember = "rol_Descrip";
            cmbRol_Id.ValueMember = "rol_id";
            cmbRol_Id.DataSource = LogicaUsuario.list_roles();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = LogicaUsuario.list_usuarios();
        }

       private void btnSearch_Click(object sender, EventArgs e)
         {
            if(txtPattern.Text != "")
            {
            dgwUsuarios.DataSource = LogicaUsuario.search_usuarios(txtPattern.Text);
            }
            else{
            load_usuarios();
            }
        

    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dgwUsuarios_CurrentCellChanged (object sender, EventArgs e)
        {
        
            if(dgwUsuarios.CurrentRow != null){
                cmbRol_Id.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol_id"].Value.ToString();
                txtUsu_ApellidoNombre1.Text = dgwUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
            }

        }
}
