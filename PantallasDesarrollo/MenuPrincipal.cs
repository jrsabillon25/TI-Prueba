using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PantallasDesarrollo;

/*
 * Interfaz del menú principal
 * 
 *Este modulo permite la navegacion entre los diferentes modulos del programa
 *
 * 02/12/2017 
 */


namespace PantallasDesarrollo
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Boton para abrir el menú de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            clientes frm3 = new clientes();
            frm3.Show();
        }

        //Boton para abrir el menú de Dispositivos
        private void btnDispositivos_Click(object sender, EventArgs e)
        {
            dispositivos frm2 = new dispositivos();    
            frm2.Show();
        }

        //Boton para abrir el menú de Facturas
        private void btnFacturas_Click(object sender, EventArgs e)
        {
            facturas1 frm1 = new facturas1();
            frm1.Show();
        }

        //Boton para cerrar Sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();     
        }

        //Boton para abrir el menú de Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            usuarios frm = new usuarios();
            frm.Show();
        }

        //Boton para abrir los parametros de la empresa
        private void btnParametros_Click(object sender, EventArgs e)
        {
            ParametrosAdmon frm = new ParametrosAdmon();
            frm.Show(); 
        }

        //Boton para salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Salir del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
        }

        /*
        enviar al textbox oculto el tipo de usuario que ingreso al sistema
        ya sea usuario normal o administrador para habilitar o no los 
        botones adicionales.
        */
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string adm;

            adm = txtUsuario.Text;


            if (adm == "Admin")
            {
                btnUsuarios.Visible = true;
                btnParametros.Visible = true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
