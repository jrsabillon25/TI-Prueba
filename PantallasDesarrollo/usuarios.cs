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
*Modulo de Usuarios
*
*Modulo central de Usuario con la vista de usuarios ya existentes y las opciones para crear nuevos
*y editar los ya existentes 
* 
*03/12/2017 
*/
 

namespace PantallasDesarrollo
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        //Boton para regresar al modulo de menú
        private void btnVolver_Click(object sender, EventArgs e)
        {    
            this.Hide();
        }

        //Boton para movilizarse al modulo de Nuevo Usuario
        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NuevoUsuario frm3 = new NuevoUsuario();
            frm3.Show();
        }

        //Cargar informacion necesaria al datagrid desde la Base de Datos
        private void usuarios_Load(object sender, EventArgs e)
        {
            users us = new users();
            us.cargarUsers(dgvUsuarios);
        }

        //Boton para editar informacion del usuario seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Validacion por si no selecciono un usuario
            if (dgvUsuarios.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            //halar informacion al modulo de Editar Usuario
            else
            {
                EditarUsuario ec = new EditarUsuario();
                ec.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                ec.txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                ec.cmbPuesto.SelectedItem = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                ec.cmbEstado.SelectedItem = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                ec.txteid.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                ec.txtEstado.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                ec.txtPuesto.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();

                this.Hide();
                ec.Show();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, ayudaH2.HelpNamespace);
        }
    }
}
