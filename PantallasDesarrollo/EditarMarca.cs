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
*Modulo de Editar Marcas
*
*este modulo permite la edicion de las marcas existentes en el programa
*
*06/12/2017
*
*/

namespace PantallasDesarrollo
{
    public partial class EditarMarca : Form
    {

        public EditarMarca()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
        }

        //Boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.Show();
            this.Hide();
        }

        //Boton para modificar los datos ingresados
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int estado = 16;//estado activo

            if (rdbActivo.Checked == false)
            {
                estado = 17;//estado inactivo
            }

            //validacion para corroborar que no existen campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string query = "update Marca set Descripcion= '" + txtDescripcion.Text + "', Estado = " + estado + " where IDmarca = " + int.Parse(txtCodigo.Text) + "";
                Mantenimiento.actualizar(query);

                ParametrosAdmon form = new ParametrosAdmon();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones val = new validaciones();
            val.espacio(e);
        }

    }
}
