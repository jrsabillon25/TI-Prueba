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

namespace PantallasDesarrollo
{
    public partial class NuevoModelo : Form
    {
        public NuevoModelo()
        {
            InitializeComponent();
        }

        //cargar datos necesarios a los controles del modulo
        private void NuevoModelo_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(cmbMarca);
            cmbMarca.SelectedIndex = 0;
        }

        //boton para regresar al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ParametrosAdmon form = new ParametrosAdmon();
            form.tabControl1.SelectedIndex = 1;
            form.Show();
            this.Hide();
        }

        //Boton para verificar los datos modificados
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == false)
            {
                string idtype = "select IDmarca from Marca where Descripcion = '" + cmbMarca.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);
                
                string cadenasql = "insert  into Modelo values ("+idbd+",'" + txtDescripcion.Text + "'," + 16 + ");";
                Mantenimiento.insertar(cadenasql);
                txtDescripcion.Clear();
                ParametrosAdmon form = new ParametrosAdmon();
                form.tabControl1.SelectedIndex = 1;
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones val = new validaciones();
            val.espacio(e);
        }
    }
}
