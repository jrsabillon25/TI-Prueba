using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Clases;

/*
*modulo de clientes
*
*interfaz que nos permite visualizar clientes existentes
*
*02/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class clientes : Form 
    {
        clients cli = new clients(); 

        public clientes()
        {
            InitializeComponent();
        }

        //Botón para regresar al menú principal
        private void btnVolver_Click(object sender, EventArgs e)
        {         
            this.Hide();
        }

        //Botón para abrir la pestaña para ingresar un nuevo cliente
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente frm3 = new NuevoCliente();
            this.Hide();
            frm3.Show();
        }

        //cargar informacion correspondiente de clientes y contactos a los datagrids de esta pestaña
        private void clientes_Load(object sender, EventArgs e)
        {
            cli.cargarCliente(DgvClientes);
            contactos co = new contactos();
            co.cargarContacto(dgvContactos);
        }

        //Boton para agregar un nuevo dispositivo
        private void btnNuevoDispositivo_Click(object sender, EventArgs e)
        {

            if (DgvClientes.RowCount == 1)
            {
                MessageBox.Show("Sleccione un cliente");
                editarCliente ec = new editarCliente();
            }
            else
            {
                NuevoDispositivo ec = new NuevoDispositivo();
                ec.txtIdCliente.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
                ec.txtCliente.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
                this.Hide();
                ec.Show();
            }
        }

        //Boton para editar el cliente seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (DgvClientes.RowCount == 1)
            {
                //mensaje de error en caso de que no seleccione ningun cliente en el Datagrid
                MessageBox.Show("Seleccione un cliente");
                editarCliente ec = new editarCliente(); 
            }
            else
            {
                //halar informacion necesaria a la pestaña de Editar cliente
                editarCliente ec = new editarCliente();
                ec.txtIdCliente.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
                ec.txtRtnId.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
                ec.txtNombre.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
                ec.txtDireccion.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();
                ec.txtestatus.Text = DgvClientes.CurrentRow.Cells[4].Value.ToString();
                ec.txtetype.Text = DgvClientes.CurrentRow.Cells[5].Value.ToString();
                
                this.Hide();
                ec.Show();
            }           
        }

        /*
        para el filtro de busqueda de cliente, al escribir se ira buscando en la BD  
        hasta encontrar el nombre acertado.(Se busca por NOMBRE DE CLIENTE).
        */
        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from CLIENTE where [NOMBRE COMPLETO] like ('" + txtBuscarCliente.Text + "%') ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvClientes.DataSource = dt;

                cnn.Close();
            }
        }

        //Boton para Editar el Contacto seleccionado
        private void btnEditarContacto_Click_1(object sender, EventArgs e)
        {
            //en el caso de no seleccionar una fila del datagrid mostrara error
            if (DgvClientes.RowCount == 1)
            {
                MessageBox.Show("Selecione un Contacto");
            }
            else
            {
                //halar informacion necesaria al modulo de contacto para modificr posteriormente
                Modificar_contacto mo = new Modificar_contacto();
                mo.txtRtnId.Text = dgvContactos.CurrentRow.Cells[0].Value.ToString();
                mo.txtNombre.Text = dgvContactos.CurrentRow.Cells[1].Value.ToString();
                mo.txtApellido.Text = dgvContactos.CurrentRow.Cells[2].Value.ToString();
                mo.txtTelefono.Text = dgvContactos.CurrentRow.Cells[3].Value.ToString();
                mo.txtRtnIdCliente.Text = dgvContactos.CurrentRow.Cells[4].Value.ToString();

                this.Hide();
                mo.Show();
            }
        }

        //boton para abrir el modulo de NuevoContacto
        private void btnNuevoContacto_Click(object sender, EventArgs e)
        {
            NuevoContacto frm3 = new NuevoContacto();
            this.Hide();
            frm3.Show();
        }

        //Buscar por medio del textbox de RTN en la seccion de Contacto
        private void txtBuscarRtn_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Contactos.Rtn, Contactos.Nombre, Contactos.Apellido, Contactos.Telefono , Contactos.Idcliente, CLIENTE.[NOMBRE COMPLETO] from [dbo].[Contactos] inner join [dbo].[CLIENTE] on Contactos.Idcliente=CLIENTE.IDCliente where Rtn like ('" + txtBuscarRtn.Text + "%') ";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dgvContactos.DataSource = dt;
                cnn.Close();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda, Ayuda.HelpNamespace);
        }
    }
}
