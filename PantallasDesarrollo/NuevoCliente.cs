using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace PantallasDesarrollo
{
    public partial class NuevoCliente : Form
    {

        connect cli = new connect();
        Conexion conec = new Conexion();

        public NuevoCliente()
        {
            InitializeComponent();
        }

        //Boton para Regresar al Modulo de Clientes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes clifrm = new clientes();
            clifrm.Show();
        }

        //Boton para aceptar la informacion ingresada y modificada
        private void btnAceptar_Click(object sender, EventArgs e) 
        {          
            //Validar que no existan campos vacios
            if (string.IsNullOrWhiteSpace(txtRtnId.Text) == true || string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(txtDireccion.Text) == true || string.IsNullOrWhiteSpace(cmbTipoId.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                if (txtRtnId.TextLength <= 13)
                {
                    MessageBox.Show("Ingrese una identidad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRtnId.Focus();
                }
                else
                {
                    string Query = "select * from CLIENTE where [RTN/ID]= '" + txtRtnId.Text + "'";
                    contactos cl = new contactos();

                    //Verificar que el RTN o ID ingresado no exista
                    if (cl.Buscar(Query) == true)
                    {
                        MessageBox.Show("Identificación ya existe");
                    }
                    else
                    {
                        //Enviar e ingresar datos Capturados
                        string idtype = "select IDType from IDTypes where Descripcion = '" + cmbTipoId.Text + "'";
                        int idbd = 0;
                        idbd = clients.idtypecheck(idtype);

                        string cadenasql = "insert  into CLIENTE values ('" + txtRtnId.Text + "', '" + txtNombre.Text + "', '" + txtDireccion.Text + "', " + 16 + ", " + idbd + ");";
                        clients.insetarclien(cadenasql);
                        txtDireccion.Clear();
                        txtNombre.Clear();
                        txtRtnId.Clear();
                        cmbTipoId.Text = " ";
                        this.Hide();
                        clientes clifrm = new clientes();
                        clifrm.Show();
                    }

                }

            }

            

        }

        //Funcion que Permite Validar numeros en el Textbox de RTN/ID
        private void txtRtnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
            numero.espacio(e);

            e.Handled = char.IsLetter(e.KeyChar);
        }

        //Funcion que Permite Validar letras en el Textbox de Nombre
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);           
        }

        //Rellenar el Combobox con la informacion requerida
        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarCliente(cmbTipoId);  
        }

    }
}
