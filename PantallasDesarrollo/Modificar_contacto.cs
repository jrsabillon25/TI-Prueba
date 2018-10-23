using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Clases;
using System.Data.Sql;

/*
*
*Modulo de Modificacion de Cliente 
*
*Este modulo permitira hacer las modificaciones que el Usuario quiera hacer
*sobre los contactos(empleados) de cada cliente.
*
*02/12/2017
*
*/

    //Diccionario de Datos
/*
*/

namespace PantallasDesarrollo
{
    public partial class Modificar_contacto : Form
    {
     
        public Modificar_contacto()
        {
            InitializeComponent();
        }

        //Boton para finalizar la modificacion de los datos Capturados
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verificar que no existen campos vacios
            if (string.IsNullOrWhiteSpace(txtRtnId.Text) == true || string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(txtApellido.Text) == true || string.IsNullOrWhiteSpace(txtTelefono.Text) == true || string.IsNullOrWhiteSpace(txtRtnIdCliente.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            //En el caso de que no existan enviar los datos
            else
            {
                contactos co = new contactos();
                MessageBox.Show(co.edit((Convert.ToInt32(txtRtnId.Text)), txtNombre.Text, txtApellido.Text, txtTelefono.Text, 1, (Convert.ToInt32(txtRtnIdCliente.Text))));
                this.Hide();
                clientes clifrm = new clientes();
                clifrm.Show();
            }
        }


        //Boton para regresar al modulo de Cliente
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        //Funcion para Buscar al Cliente deseado escribiendo su nombre en el textbox Buscar Cliente
        private void txtBuscarCliente_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string codigo = "%" + txtBuscarCliente.Text + "%";
            string query = "Select CLIENTE.IDCliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[CLIENTE]  Where CLIENTE.IDCliente LIKE '" + codigo + "' OR CLIENTE.[NOMBRE COMPLETO] LIKE '" + codigo + "';";
            contactos.buscarcontactos(dgvModificarContacto, query); 
        }

        //No permite espacios en blanco en el campo Rtn/ID
        private void txtRtnIdCliente_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
