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
*Modulo de Agregar Marca
*
*este modulo permite agregar nuevas marcas al programa
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }

        //Boton para regresar al modulo de Parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.Show();
            this.Hide();
        }

        //Boton para verificar la marca que se esta agregando
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion que no permite espacios en blanco
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string cadenasql = "insert  into Marca values ('" + txtDescripcion.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtDescripcion.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }
        }

        //Validacion para solo permitir letras y ningun espacio
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
            letra.espacio(e);
            
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
