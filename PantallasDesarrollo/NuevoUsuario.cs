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

using System.Security.Cryptography;

/*
*Modulo de Añadir Usuarios
* 
*este modulo permite la incersion de nuevos usuarios al programa
* 
*03/12/2017 
*/ 


namespace PantallasDesarrollo
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion para no permitir espacios en blanco
            if (string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(txtTelefono.Text) == true || string.IsNullOrWhiteSpace(cmbPuesto.Text) == true || string.IsNullOrWhiteSpace(txtUsuario.Text) == true || string.IsNullOrWhiteSpace(txtContraseña.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }   
            else
            {
            //copia el texto de las cajas de texto y lo compara en la base de datos para asegurarase de que
            //no existe
            string Query = "select *from USUARIO where USUARIO= '" + txtUsuario.Text + "'";

            contactos cl = new contactos();
            if (cl.Buscar(Query) == true)
            {
                MessageBox.Show("USUARIO ya existe");
            }
            else
            {
                //encripta contraseña
                users us = new users();
                string login_pass = txtContraseña.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", ""); 
                
                //toma la decision lo asigna a administrador o usuario regular para derechos
                if (cmbPuesto.Text == "Administrador")
                {
                    string cadenasql = "insert  into USUARIO values ('" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtUsuario.Text + "', '" + login_pass + "'," + 8 + ", " + 0 + "," + 6 + ");";
                    users.insertarUser(cadenasql);
                }
                else
                {
                    string cadenasql = "insert  into USUARIO values ('" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtUsuario.Text + "', '" + login_pass + "'," + 8 + ", " + 0 + "," + 7 + ");";
                    users.insertarUser(cadenasql);
                }
                
            
                txtNombre.Clear();
                txtTelefono.Clear();
                txtUsuario.Clear();
                cmbPuesto.Text = " ";
                this.Hide();
                usuarios user1 = new usuarios();
                user1.Show();
            }

          }

        }

        //Boton para regresar al modulo de usuarios
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios user1 = new usuarios();
            user1.Show();
        }

        //Solo acepta numeros en telefono y no permite espacios
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);
        }


        //Solo acepta letras en Nombre
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }

        //no permite espacios en usuario
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        //no permite espacios en el campo de contraseñas
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);        
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);
        }

        //llenar combobox de puesto con la informacion de la Base de Datos
        private void NuevoUsuario_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarPst(cmbPuesto); 
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 8;
        }
    }
}
