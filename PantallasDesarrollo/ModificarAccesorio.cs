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
*Modulo de Modificar Accesorios
*
*este modulo permite la modificacion de accesorios existentes en el programa
*
*06/12/2107
*/

namespace PantallasDesarrollo
{
    public partial class ModificarAccesorio : Form
    {
        public ModificarAccesorio()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
        }

        //Boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 2;
            form.Show();
            this.Hide();
        }

        //Boton para modificar los datos ingresados en este modulo
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int estado = 16;//estado activo
            if (rdbActivo.Checked == false)
            {
                estado = 17;//estado inactivo
            }

            //validacion para no permitir espacios en blanco 
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string query = "update Accesorios set Descripcion= '" + txtDescripcion.Text + "', estado = " + estado + " where IDAccesorio = " + int.Parse(txtCodigo.Text) + "";
                Mantenimiento.actualizar(query);


                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 2;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }
        
        //Validacion para solo permitir letras en el campo descripcion
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones letra = new validaciones();
            letra.SoloLetras(e);
            letra.espacio(e);
        }
    }
}
