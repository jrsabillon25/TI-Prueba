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
*Modulo Modificar Modelo
*
*este modulo permite la modificacion de modelos existentes
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class ModificarModelo : Form
    {
        //llenar campos del modulo desde el inicio del programa
        public ModificarModelo()
        {
            InitializeComponent();
            rdbActivo.Checked = true;
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(cmbMarca); 
        }

        //Boton para salir al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 1;
            form.Show();
            this.Hide();
        }

        //Boton para verificar los cambios realizados
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
                string idtype = "select IDmarca from Marca where Descripcion = '" + cmbMarca.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);

                string query = "update Modelo set Descripcion= '" + txtDescripcion.Text + "', Estado = " + estado + ", IDmarca = " + idbd + " where IDmodelo = " + int.Parse(txtCodigo.Text) + "";
                Mantenimiento.actualizar(query);

                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 1;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios vacios!!");
            }
        }
    }
}
