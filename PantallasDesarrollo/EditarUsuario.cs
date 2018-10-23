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

using System.Data.SqlClient;

/*
*Modulo de Editar Usuario
* 
*Este modulo permite la edicion del usuario seleccionado en el modulo
*de Usuarios
* 
*03/12/2017 
*/


namespace PantallasDesarrollo
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
           
            Mantenimiento llenar = new Mantenimiento();
            
            llenar.llenarPst(cmbPuesto);

            users us = new users();

            //busca y llena el estado del usuario que se selecciono
            SqlDataReader Lect;
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select [Descripcion] from [dbo].[Estados/Entidad]  where [IDEntidad] = 1 ", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cmbEstado.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();

            }

            //copia a las cajas de texto los datos del usuario que se selecciono
            cmbPuesto.SelectedItem = txtPuesto.Text;
            cmbEstado.SelectedItem = txtEstado.Text;


        }

        //Guarda la informacion actualizada del usuario
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            users us = new users();
            Conexion cone = new Conexion();
            
            //Validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) == true || string.IsNullOrWhiteSpace(cmbPuesto.Text) == true || string.IsNullOrWhiteSpace(txtUsuario.Text) == true || string.IsNullOrWhiteSpace(txtContraseña.Text) == true || string.IsNullOrWhiteSpace(cmbEstado.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {

                //encriptacion de la contraseña con el metodo md5
                string login_pass = txtContraseña.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

               //va comparando de acuerdo al nuevo estado que se coloque lo insertara en la Base de Datos
                if (cmbEstado.Text == "Activo")
                {
                    if (cmbPuesto.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 5, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 5, 7));
                }


                if (cmbEstado.Text == "Inactivo")
                {
                    if (cmbPuesto.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 6, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 6, 7));
                }

                if (cmbEstado.Text == "Bloqueado")
                {
                    if (cmbPuesto.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 7, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 7, 7));
                }

                if (cmbEstado.Text == "NuevoUser")
                {
                    if (cmbPuesto.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 8, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 8, 7));
                }

                if (cmbEstado.Text == "CambiarClave")
                {
                    if (cmbPuesto.Text == "Administrador")
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 9, 6));
                    else
                        MessageBox.Show(us.edit((Convert.ToInt32(txteid.Text)), txtNombre.Text, txtUsuario.Text, login_pass, 9, 7));
                }

                //regresar al modulo de Usuarios
                this.Hide();
                usuarios user1 = new usuarios();
                user1.Show();

            }
        }

        //Boton para regresar al modulo de Usuarios 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            usuarios user1 = new usuarios();
            user1.Show();
        }

        //Validar ambos textbox de contraseña y usuario para no permitir espacios en blanco
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
