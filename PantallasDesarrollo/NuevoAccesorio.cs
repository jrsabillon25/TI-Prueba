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
*modulo de Nuevo Accesorio
*
*
*este modulo permite la incersión de un nuevo accesorio al programa 
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class NuevoAccesorio : Form
    {
        public NuevoAccesorio()
        {
            InitializeComponent();
        }

        //boton para verificar cambios realizados en el modulo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string cadenasql = "insert  into Accesorios values ('" + txtDescripcion.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtDescripcion.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 2;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }
        }

        //Boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 2;
            form.Show();
            this.Hide();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones val = new validaciones();
            val.espacio(e);
        }
    }
}
