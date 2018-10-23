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
 * Interfaz central de login
 * 
 * Interfaz que permite el ingreso hacia el programa
 *
 * 02/12/2017  
 */


namespace PantallasDesarrollo
{
    public partial class Login : Form
    {
        int cont = 0;

        public Login()
        {
            InitializeComponent();
        }

        public string login_usuario;


        private void EntrarButton(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) == true || string.IsNullOrWhiteSpace(txtContraseña.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                users u = new users();
                string login_pass = txtContraseña.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");
                login_usuario = txtContraseña.Text;
                u.Usuario = this.txtUsuario.Text;
                u.Contraseña = login_pass;



                if (u.Buscar() == true)
                {
             
                    string adm;
                    string est;
                    string idus;

                    string query = "update USUARIO set INTENTOS = " + 0 + " where USUARIO = '"+txtUsuario.Text+"'";
                    Mantenimiento.actNomsg(query);

                    adm = prueba.Text;
                    est = estado.Text;
                    idus = id.Text;



                    //Verificar que el usuario que ingresa as Administrador
                    prueba.Text = Mantenimiento.consulta(txtUsuario.Text).ToString();
                    MenuPrincipal forma2 = new MenuPrincipal();
                    CambiarContraseña forma3 = new CambiarContraseña();
                    var txt6 = forma2.Controls["txtUsuario"];
                    var txt7 = forma3.Controls["textBox1"];
                 
                    txt6.Text = prueba.Text.ToString();

                    //Verificar el estado del usuario
                    estado.Text = Mantenimiento.Estado(txtUsuario.Text).ToString();

                    //Copia el Id del Usuario
                    id.Text = Mantenimiento.userid(txtUsuario.Text).ToString();
                    txt7.Text = id.Text.ToString();


                    adm = prueba.Text;
                    est = estado.Text;
                    idus = id.Text;

                    /*Case para ver cuales son las opciones que se pueden 
                    tomar despues de que el usuario ingreso sus datos para ingresar al sistema
                    */
                    if (true)
                    {
                        switch (est)
                        {
                            case "Activo":
                                forma2.Show();
                                this.Hide();
                                break;
                            case "Inactivo":
                                MessageBox.Show(u.mensaje, "Usuario Inactivo");
                                break;
                            case "Bloqueado":
                                MessageBox.Show(u.mensaje, "Usuario Bloqueado");
                                break;
                            case "NuevoUser":
                                forma3.Show();
                                this.Hide();
                                break;
                            case "CambiarClave":
                                forma3.Show();
                                this.Hide();
                                break;

                            default:
                                break;
                        }

                    }
                 
                }
                else
                {                   
                    //Verificar cantidad de intentos que tiene el usuario que intenta Entrar
                    if (u.BuscarUser() == true)
                    {
                        string query = "select INTENTOS FROM USUARIO where USUARIO = '" + txtUsuario.Text + "'";
                        cont = Mantenimiento.looker(query);
                        cont++;
                        intents.Text = cont.ToString();
                        
                        //Si tiene mas de 3 intentos mostrar: "Usuario Bloqueado"
                        if (cont >= 3)
                        {
                            MessageBox.Show(u.mensaje, "Usuario Bloqueado");
                            string query1 = "update USUARIO set INTENTOS = " + 3 + ", ESTADO = " + 7 + " where USUARIO = '" + txtUsuario.Text + "'";
                            Mantenimiento.actNomsg(query1);
                        }
                        //en caso contrario Ingresar
                        else
                        {
                          id.Text = Mantenimiento.userid(txtUsuario.Text).ToString();
                          int idus = Convert.ToInt32(id.Text);                    
                          MessageBox.Show(u.editIntentos(cont, idus));
                        }
                    }       
                    
                    //Limpiar los textbox para que al cerrar sesion no queden con información          
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }           
            }
            
        }

        //Boton para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {        
            Environment.Exit(0);
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar para que solo ingrese numeros
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

            e.Handled = char.IsWhiteSpace(e.KeyChar);
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
