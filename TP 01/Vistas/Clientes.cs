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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            load_Clientes();
        }

        public void load_Clientes()
        {
            dgwClientes.DataSource = LogicaCliente.exec_list_clientes();
        }

        public void btnBuscarCliente_Click(object sender, EventArgs e)
        {
           /* if (txtPattern.Text != "")
            {
                dgwClientes.DataSource = LogicaCliente.exec_search_cliente(txtPattern.Text);
            }
            else
            {
                load_Clientes();
            }

            */
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (txtPattern.Text != "")
            {
                dgwClientes.DataSource = LogicaCliente.exec_search_cliente(txtPattern.Text);
            }
            else
            {
                load_Clientes();
            }
        }
    }
}
