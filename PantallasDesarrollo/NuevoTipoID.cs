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
*Modulo de Nuevo Tipo de ID
*
*modulo que permite la incersion de nuevos tipos de ID para el programa
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class NuevoTipoID : Form
    {
        public NuevoTipoID()
        {
            InitializeComponent();
        }

        //Boton para salir al modulo de parametros
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult = System.Windows.Forms.DialogResult.OK;
            ParametrosAdmon form = new ParametrosAdmon();

            form.tabControl1.SelectedIndex = 3;
            form.Show();
            this.Hide();
        }

        //Boton para verificar cambios realizados en este modulo
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion que no permite campos vacios
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) == true)
            {
                MessageBox.Show("No se permiten espacios en blanco");
                txtDescripcion.Clear();
            }
            else
            {
                try
                {
                    string Query = "select *from IDTypes where Descripcion= '" + txtDescripcion.Text + "'";

                    contactos cl = new contactos();
                    if (cl.Buscar(Query) == true)
                    {
                        MessageBox.Show("IDType ya existe");
                    }
                    else
                    {
                        string cadenasql = "insert  into IDTypes  values ('" + txtDescripcion.Text + "', "+16+")";
                        contactos.insertar(cadenasql);

                        txtDescripcion.Clear();
                        txtCodigo.Text = Mantenimiento.codigoIDTypes().ToString();
                        ParametrosAdmon form = new ParametrosAdmon();

                        form.tabControl1.SelectedIndex = 3;
                        form.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //cargar codigo al campo correspondiente
        private void NuevoTipoID_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Mantenimiento.codigoIDTypes().ToString();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones val = new validaciones();
            val.espacio(e);
        }
    }
}
