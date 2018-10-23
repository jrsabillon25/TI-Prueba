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
using System.Data.SqlClient;

/*
*
*Modulo de Modificar Tipo de ID
*
*este modulo permite modificar los tipos de identidad que se manejan en el programa
*
*06/12/2017
*
*/

namespace PantallasDesarrollo
{
    public partial class ModificarTipoID : Form
    {
        public ModificarTipoID()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
        }

        //Boton para verificar cambios realizados en el modulo actual
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int estado = 16;//estado activo
            if (rdbActivo.Checked == false)
            {
                estado = 17;//estado inactivo
            }
            //Validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string query = "update IDTypes set Descripcion= '" + txtDescripcion.Text + "', ESTADO = "+estado+" where IDType = " + int.Parse(txtCodigo.Text) + "";
                Mantenimiento.actualizar(query);
      
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 3;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }

        //Boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();

            form.tabControl1.SelectedIndex = 3;
            form.Show();
            this.Hide();
        }

        //Validacion para no permitir numeros en el campo descripcion
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
            letra.espacio(e);
        }

    }
}
