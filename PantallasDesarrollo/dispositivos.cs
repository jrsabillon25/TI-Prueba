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
*Modulo de Dispositivos
*
*este modulo permite la edición de dispositivos ya existentes 
*
*02/12/2017
*/


namespace PantallasDesarrollo
{
    public partial class dispositivos : Form
    {
        public dispositivos()
        {
            InitializeComponent();
        }

        //Boton para regresar al modulo de Menú
        private void btnVolver_Click(object sender, EventArgs e)
        {            
            this.Hide();   
        }

        //Boton para modificar el dispositivo seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarDispositivo frm3 = new ModificarDispositivo();
            
            //Validar el caso en el que no se seleccione un contacto
            if (dgvDispositivos.RowCount == 1)
            {
                MessageBox.Show("Selecione un Contacto");
            }
            else
            {
                //halar informacion del datagrid hacia el modulo de Modificar Dispositivo
                frm3.txtIdDispositivo.Text = dgvDispositivos.CurrentRow.Cells[0].Value.ToString();
                frm3.txtRegistro.Text = dgvDispositivos.CurrentRow.Cells[1].Value.ToString();
                frm3.txtMarca.Text = dgvDispositivos.CurrentRow.Cells[2].Value.ToString();
                frm3.txtModelo.Text = dgvDispositivos.CurrentRow.Cells[3].Value.ToString();
                frm3.txtCliente.Text = dgvDispositivos.CurrentRow.Cells[4].Value.ToString();
                frm3.cmbDiagnostico.Text = dgvDispositivos.CurrentRow.Cells[6].Value.ToString();
                
                this.Hide();
                frm3.Show();
            }
            
        }
        
        //Cargar al datagrid la informacion de la Base de Datos 
        private void dispositivos_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarDispo(dgvDispositivos);
        }

        //Funcion de busqueda por medio del textbox Buscar
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string codigo = "%" + txtBuscar.Text + "%";
            string query = "select a.IdDispositivos, a.NumRegistro, c.Descripcion as Marca, b.Descripcion as Modelo, d.[NOMBRE COMPLETO], f.Descripcion as Estado, a.DIAGNOSTICO, a.fechaIngreso from DISPOSITIVO as a inner join Modelo as b on a.IDMODELO = b.IDmodelo inner join Marca as c on b.IDmarca = c.IDmarca inner join CLIENTE as d on a.IDCliente = d.IDCliente inner join [Estados/Entidad] as f on f.IDCol = a.Estado Where a.NumRegistro LIKE '" + codigo + "' OR a.DESCRIPCION LIKE '" + codigo + "' OR c.Descripcion LIKE '" + codigo + "';";
            Mantenimiento.buscarDevice(dgvDispositivos, query); 
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
