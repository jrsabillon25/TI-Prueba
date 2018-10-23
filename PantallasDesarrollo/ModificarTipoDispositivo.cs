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
*Modulo de modificar dispositivos
*
*
*esta interfaz permite la modificacion de los dispositivos existentes
*
*06/12/2017
*/
namespace PantallasDesarrollo
{
    public partial class ModificarTipoDispositivo : Form
    {
        public ModificarTipoDispositivo()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
        }

        //boton para regresa al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 5;
            form.Show();
            this.Hide();
        }

        //boton para verificar cambios realizados en este modulo
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int estado = 16;//estado activo
            if (rdbActivo.Checked == false)
            {
                estado = 17;//estado inactivo
            }
            //validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string query = "update TipoDispositivo set Descripcion= '" + txtDescripcion.Text + "', Estado = " + estado + " where IDTipoDispositivo = " + int.Parse(txtCodigo.Text) + "";
                Mantenimiento.actualizar(query);
                
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 5;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        //validacion para solo permitir letras en el campo descripcion
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
        }
    }
}
