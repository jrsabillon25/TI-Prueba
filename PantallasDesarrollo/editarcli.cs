using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

/*
*
*
*Modulo de Editar Cliente
*
*Este modulo permitira extraer informacion de un cliente en especifico 
*para poder modificarla.
*
*02/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class editarCliente : Form 
    {
        clients cli = new clients();
        

        public editarCliente()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
        }

        //Boton para agregar la informacion modificada
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text) == true || string.IsNullOrWhiteSpace(txtRtnId.Text) == true || string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(txtDireccion.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string idtype = "select IDType from IDTypes where Descripcion = '" + cmbTipoId.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);


                if (rdbActivo.Checked == true)
                {
                    MessageBox.Show(cli.edit((Convert.ToInt32(txtIdCliente.Text)), (Convert.ToInt32(txtRtnId.Text)), txtNombre.Text, txtDireccion.Text, 16,idbd));
                }

                if (rdbInactivo.Checked == true)
                {
                    MessageBox.Show(cli.edit((Convert.ToInt32(txtIdCliente.Text)), (Convert.ToInt32(txtRtnId.Text)), txtNombre.Text, txtDireccion.Text, 17,idbd));
                }

                //Regresar al modulo anterior
                this.Hide();
                clientes clifrm = new clientes();
                clifrm.Show();
            }
        }

        //Boton para regresar al modulo anterior
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        //No permitir espacios en el campo de Identificacion 
        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        //Funcion para cargar informacion necesaria al modulo de EditarCliente
        private void editarcli_Load(object sender, EventArgs e)
        {
            connect cli = new connect();
            Conexion conec = new Conexion();

            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCliente(cmbTipoId);
            cmbTipoId.SelectedItem = txtetype.Text;
        }

        //Validacion que permite el ingreso solo de letras en el textbox de nombre
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        //Boton para aceptar la informacion ingresada y regresar al modulo anterior
        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que espacios quedaron vacios antes de continuar
            if (txtIdCliente.Text == null)
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtRtnId.Text == null)
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtNombre.Text == null)
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

            if (txtDireccion.Text == null)
            {
                btnAceptar.Enabled = false;
                MessageBox.Show("No se pueden actualizar campos vacios");
            }

        }

        //Validar que no queden espacios en el textbox de RTN/ID
        private void txtRtnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
