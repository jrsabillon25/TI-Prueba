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
using System.Text.RegularExpressions;

/*
*
*Modulo de parametros de administrador
*
*este modulo permite la modificacion o incersion de datos que se requieren 
*en el funcionamiento del programa
*
*06/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class ParametrosAdmon : Form
    {
        public ParametrosAdmon()
        {
            InitializeComponent();
        }

        //rellenar todos los grids y campos del modulo con datos de la BD
        private void ParametrosAdmon_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarIDTypes(dgvTipoId);
            co.cargarMarcas(dgvMarca);
            co.cargarModelo(dgvModelo);
            co.cargarAcc(dgvAccesorio);
            co.cargarTdispo(dgvTipoDispositivo);
            string query = "select ISV from ISV";
            txtIsv.Text = Mantenimiento.lookerSt(query);
        }

        //Boton para ingresar al modulo de nueva marca
        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            AgregarMarca newMarca = new AgregarMarca();
            newMarca.Show();
            this.Hide();
        }

        //Boton para Modificar el ISV     
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string query = "update ISV set ISV = " + txtIsv.Text + " where Id = " +1+ "";
            Mantenimiento.actualizar(query);
        }

        //Boton para ingresar al modulo de modificar el tipo de ID
        private void btnEditarTipoId_Click(object sender, EventArgs e)
        {
            ModificarTipoID form = new ModificarTipoID();

            //Rellenar campos del modulo Modificar Tipo de ID
            form.txtCodigo.Text = dgvTipoId.CurrentRow.Cells[0].Value.ToString();
            form.txtDescripcion.Text = dgvTipoId.CurrentRow.Cells[1].Value.ToString();

            if (dgvTipoId.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                form.rdbActivo.Checked = true;
            }
            else
                form.rdbInactivo.Checked = true;


            form.Show();
            this.Hide();
        }

        //Boton para ingresar al modulo Nuevo Tipo de ID
        private void btnNuevoTipoId_Click(object sender, EventArgs e)
        {
            NuevoTipoID form = new NuevoTipoID();

            form.Show();
            this.Hide();
        }
    
        //Boton para ingresar al modulo de Editar Marcas
        private void btnEditarMarca_Click_1(object sender, EventArgs e)
        {
            if (dgvMarca.RowCount == 0)
            {
                MessageBox.Show("Selecione una linea");
            }
            else
            {
                //Rellenar campos en el modulo de Editar Marca
                EditarMarca edit = new EditarMarca();
                edit.txtCodigo.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
                edit.txtDescripcion.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
                
                if(dgvMarca.CurrentRow.Cells[2].Value.ToString() == "Activo")
                {
                    edit.rdbActivo.Checked = true;
                }
                else
                    edit.rdbInactivo.Checked = true;


                edit.Show();
                this.Hide();
            }
        }

        //Boton para ingresar al modulo de nuevo accesorio
        private void btnNuevoAccesorio_Click(object sender, EventArgs e)
        {
            NuevoAccesorio newAcc = new NuevoAccesorio();
            newAcc.Show();
            this.Hide();
        }

        //Boton para ingresar al modulo de Modificar el tipo de dispositivo
        private void btnEditarAccesorio_Click(object sender, EventArgs e)
        {
            ModificarAccesorio modAcc = new ModificarAccesorio();

            //rellenar los campos necesarios dentro de este modulo
            modAcc.txtCodigo.Text = dgvAccesorio.CurrentRow.Cells[0].Value.ToString();
            modAcc.txtDescripcion.Text = dgvAccesorio.CurrentRow.Cells[1].Value.ToString();
            if (dgvAccesorio.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                modAcc.rdbActivo.Checked = true;
            }
            else
                modAcc.rdbInactivo.Checked = true;
            
            modAcc.Show();
            this.Hide();           
        }

        //Boton para ingresar al modulo Nuevo tipo de Dispositivo
        private void btnNuevoTipoDispositivo_Click(object sender, EventArgs e)
        {
            NuevoTipoDispositivo newTiD = new NuevoTipoDispositivo();
            newTiD.Show();
            this.Hide();
        }

        //Boton para ingresar al modulo Modificar Tipo de Dispositivo
        private void btnEditarTipoDispositivo_Click(object sender, EventArgs e)
        {
            ModificarTipoDispositivo modTipDis = new ModificarTipoDispositivo();

            //Rellenar campos necesarios en este modulo
            modTipDis.txtCodigo.Text = dgvTipoDispositivo.CurrentRow.Cells[0].Value.ToString();
            modTipDis.txtDescripcion.Text = dgvTipoDispositivo.CurrentRow.Cells[1].Value.ToString();

            if (dgvTipoDispositivo.CurrentRow.Cells[2].Value.ToString() == "Activo")
            {
                modTipDis.rdbActivo.Checked = true;
            }
            else
                modTipDis.rdbInactivo.Checked = true;


            modTipDis.Show();
            this.Hide();
        }

        //Boton para ingresar al modulo de Nuevo Modulo
        private void btnNuevoModelo_Click(object sender, EventArgs e)
        {
            NuevoModelo newMol = new NuevoModelo();
            
            newMol.Show();
            this.Hide();
        }

        //Boton para ingresar al modulo de  Editar Modelo
        private void btnEditarModelo_Click(object sender, EventArgs e)
        {
            ModificarModelo modMol = new ModificarModelo();

            //Rellenar Campos necesarios para este modulo
            modMol.txtCodigo.Text = dgvModelo.CurrentRow.Cells[0].Value.ToString();
            modMol.cmbMarca.Text = dgvModelo.CurrentRow.Cells[1].Value.ToString();
            modMol.txtDescripcion.Text = dgvModelo.CurrentRow.Cells[2].Value.ToString();

            if (dgvModelo.CurrentRow.Cells[3].Value.ToString() == "Activo")
            {
                modMol.rdbActivo.Checked = true;
            }
            else
                modMol.rdbInactivo.Checked = true;


            modMol.Show();
            this.Hide();
        }
  
        //Boton para regresar al modulo de menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
