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
        private Usuario user;
        private string idUser = null;
        private Boolean editar = false;
        public FormGestionUsuarios()
        {
            InitializeComponent();
        }
        public FormGestionUsuarios(Usuario usuario)
        {
            InitializeComponent();
            this.user = usuario;
            Console.WriteLine(user.User_username);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            list_user();
            list_roles();
            username.Text = user.User_username.ToString();
            datagridusers.Enabled = false;
            datagridusers.ClearSelection();
            editar = false;
            Console.WriteLine("ROL ELELCCIONADO: ", rolBox.SelectedValue);
        }

        private void list_user() {
            datagridusers.DataSource = LogicaUsuario.list_users(user.User_username.ToString());
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
            if(editar == false){
            Console.WriteLine("ROL pasa por acaaa: ", rolBox.SelectedValue);
            Usuario user = new Usuario();
            user.Rol_id = (int)rolBox.SelectedValue;
            user.User = userbox.Text;
            user.User_username = username_box.Text;
            user.User_password = password_box.Text;
            LogicaUsuario.save_user(user);
            editar = false;
            list_user();

            }

            if (editar == true) {
                Console.WriteLine("ROLBOX NATES DE ENTRAR AL EDITAR TRY: " + rolBox.SelectedIndex);
                int rol = rolBox.SelectedIndex + 1;
                try {
                    LogicaUsuario.edit_user(userbox.Text, password_box.Text, username_box.Text, rol.ToString(), idUser);
                    datagridusers.ClearSelection();
                    editar = false;
                    list_user();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede editar estos datos: " + ex.Message);
                }
            }
            userbox.Text = "";
            password_box.Text = "";
            username_box.Text = "";
            datagridusers.ClearSelection();
        }
        
        private void datagridusers_CellContentClick(object sender, EventArgs e)
        {
            if (datagridusers.CurrentRow != null && editar == true)
            {
                editar = true;
                Console.WriteLine("seleccionado");
                Console.WriteLine("ROL??: "+datagridusers.CurrentRow.Cells["Rol"].Value.ToString());
                rolBox.Text = datagridusers.CurrentRow.Cells["Rol"].Value.ToString();
                userbox.Text = datagridusers.CurrentRow.Cells["Nombre Usuario"].Value.ToString();
                username_box.Text = datagridusers.CurrentRow.Cells["Usuario"].Value.ToString();
                password_box.Text = datagridusers.CurrentRow.Cells["Contraseña"].Value.ToString();
                idUser = datagridusers.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void removeUser(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            if (datagridusers.CurrentRow != null)
            {
                idUser = datagridusers.CurrentRow.Cells["ID"].Value.ToString();
                LogicaUsuario.deleteUser(idUser);
                list_user();
            }
            else {
                MessageBox.Show("SLECICONE UN USUARIO!");
            }
        }

        private void handleEditVisible(object sender, EventArgs e)
        {
            datagridusers.Enabled = true;
            EditButton.Visible = true;
            editar = true;
            borraruser.Visible = true;

        }

        private void handleEditCancell(object sender, EventArgs e)
        {
            EditButton.Visible = false;
            datagridusers.Enabled = false;
            datagridusers.ClearSelection();
            editar = false;
            userbox.Text = "";
            borraruser.Visible = false;
            password_box.Text = "";
            username_box.Text = "";
        }

       
    }
}
