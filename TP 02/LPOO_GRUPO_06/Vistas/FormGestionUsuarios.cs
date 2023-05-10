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
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            list_user();
            list_roles();
        }

        private void list_user() {
            datagridusers.DataSource = LogicaUsuario.list_users();
        }
        private void list_roles() {
            rolBox.DisplayMember = "rol_desc";
            rolBox.ValueMember = "rol_id";
            rolBox.DataSource = LogicaUsuario.list_roles();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void handleSaveUser(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rol_id = (int)rolBox.SelectedValue;
            user.User = userbox.Text;
            user.User_username = username_box.Text;
            user.User_password = password_box.Text;
            LogicaUsuario.save_user(user);
            list_user();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
