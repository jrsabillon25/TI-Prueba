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
*Modulo de nuevo tipo de dispositivo
*
*modulo que permite la insercion de un nuevo tipo de dispositivo
*
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class NuevoTipoDispositivo : Form
    {
        public NuevoTipoDispositivo()
        {
            InitializeComponent();
        }

        //Boton para aceptar modificaciones realizadas en este modulo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string cadenasql = "insert  into TipoDispositivo values ('" + txtDescripcion.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtDescripcion.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 5;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }
        }

        //boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 5;
            form.Show();
            this.Hide();
        }

        //validacion para solo permitir letras en el campo descripcion
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
    }
}
