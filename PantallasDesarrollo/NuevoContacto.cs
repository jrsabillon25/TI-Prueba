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
using System.Data.SqlClient;

/*
*
*Modulo de Nuevo Contacto 
*
*Este modulo permite el ingreso de un contacto para dicho cliente
*
*02/12/2017
*/

//Diccionario de datos

/*
    Clifrm = instancia de cliente
    Query = busqueda hacia la Base de Datos
    cadenasql = busqueda hacia la Base de Datos
    numero, vali, letra = instancias a validaciones
    codigo = almacen de datos (textbox Buscar Cliente) para buscar en la Base de Datos
*/

namespace PantallasDesarrollo
{
    public partial class NuevoContacto : Form
    {    
        public NuevoContacto()
        {
            InitializeComponent();
        }

        //Boton para volver al modulo de Cliente
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        //Boton para verificar los cambios realizados dentro de este modulo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            if (string.IsNullOrWhiteSpace(txtRtnId.Text) == true || string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(txtApellido.Text) == true || string.IsNullOrWhiteSpace(txtTelefono.Text) == true || string.IsNullOrWhiteSpace(txtRtnIdCliente.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string Query = "select *from Contactos where Rtn= '" + txtRtnId.Text + "'";

                contactos cl = new contactos();
                if (cl.Buscar(Query) == true)
                {
                    MessageBox.Show("Rtn ya existe");
                }
                else
                {
                    string cadenasql = "insert  into Contactos  values ('" + txtNombre.Text + "', '" + txtApellido.Text + "','" + txtTelefono.Text + "', " + 16 + ", '" + txtRtnIdCliente.Text + "', '" + txtRtnId.Text + "', "+1+")";
                    contactos.insetarCon(cadenasql);

                    txtRtnId.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtBuscarCliente.Clear();
                    txtRtnIdCliente.Clear();
                    txtTelefono.Clear();

                    this.Hide();

                    clientes clifrm = new clientes();
                    clifrm.Show();
                }

             }

         }     

        //Funcion para validar textbox Rtn/ID
        private void txtRtnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion para que admita solo numeros
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            //Validacion para que no permita espacios
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);
        }

        //Validar Apellido para que acepte solo letras
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        //Validar nombre para que solo acepte letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
        
        //Validacion para que el campo RTN/ID cliente solo acepta numeros
        private void txtRtnIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
            numero.espacio(e);
        }

        //Funcion para buscar en el datagrid por medio del campo Buscar Cliente (busqueda por nombre de cliente).
        private void txtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            string codigo = "%" + txtBuscarCliente.Text + "%";
            string query = "Select CLIENTE.IDCliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[CLIENTE]  Where CLIENTE.IDCliente LIKE '" + codigo + "' OR CLIENTE.[NOMBRE COMPLETO] LIKE '" + codigo + "';";
            contactos.buscarcontactos(dgvNuevoContacto, query); 
        }
        
    }
}
