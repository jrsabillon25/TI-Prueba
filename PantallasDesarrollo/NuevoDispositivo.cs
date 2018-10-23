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

namespace PantallasDesarrollo
{
    public partial class NuevoDispositivo : Form
    {
        public NuevoDispositivo()
        {
            InitializeComponent();
        }

        //Cargar contenido necesario al modulo para trabajar 
        private void NuevoDispositivo_Load(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();
            llenar.llenarMarca(cmbMarca);
            llenar.llenarTipoDis(cmbTipoDispositivo);

            Mantenimiento man = new Mantenimiento();
            man.cargarAccesorio(dgvMostrarItem);

            dgvMostrarItem.Columns["Descripcion"].ReadOnly = true;
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            string idtype = "select top 1 IdDispositivos + 1 from DISPOSITIVO order by IdDispositivos desc";
            int idbd = 0;
            idbd = clients.idtypecheck(idtype);

            txtIdDispositivo.Text = idbd.ToString();
        }

        //Boton para Guardar las modificaciones realizadas 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion para no permitir campos vacios
            if (string.IsNullOrWhiteSpace(txtRegistro.Text) == true || string.IsNullOrWhiteSpace(txtDescripcion.Text) == true || string.IsNullOrWhiteSpace(txtDiagnostico.Text) == true || string.IsNullOrEmpty(cmbMarca.Text) || string.IsNullOrEmpty(cmbModelo.Text) || string.IsNullOrEmpty(cmbTipoDispositivo.Text))
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                string Query = "select * from DISPOSITIVO where NumRegistro = " + txtRegistro.Text + "";
                contactos cl = new contactos();

                //Verificar que el N° de registro no existe
                if (cl.Buscar(Query) == true)
                {
                    MessageBox.Show("Registro ya existe");
                }
                else
                {
                    string idtype = "select IDModelo from Modelo where Descripcion = '" + cmbModelo.Text + "'";
                    int idbd = 0;
                    idbd = clients.idtypecheck(idtype);

                    string idtype1 = "select IDTipoDispositivo from TipoDispositivo where Descripcion = '" + cmbTipoDispositivo.Text + "'";
                    int idbd1 = 0;
                    idbd1 = clients.idtypecheck(idtype1);

                    modeloTest.Text = idbd.ToString();
                    TipoTest.Text = idbd1.ToString();

                    string cadenasql = "INSERT INTO DISPOSITIVO(IDMODELO, DESCRIPCION, DIAGNOSTICO, IDCliente, fechaIngreso, Estado, NumRegistro, TipoDispositivo) VALUES (" + idbd + ", '" + txtDescripcion.Text + "', '" + txtDiagnostico.Text + "', " + txtIdCliente.Text + ", '" + txtFecha.Text + "', " + 10 + ", " + txtRegistro.Text + ", " + idbd1 + ");";
                    Mantenimiento.insertar(cadenasql);


                    foreach (DataGridViewRow row in dgvMostrarItem.Rows)
                    {
                        string constring = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=IT4;Integrated Security=True";
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value) == true)
                            {
                                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Dispositivo/Accesorio] VALUES(@DispoID, @Acc)", con))
                                {
                                    cmd.Parameters.AddWithValue("@DispoID", txtIdDispositivo.Text);
                                    cmd.Parameters.AddWithValue("@Acc", row.Cells[2].Value);

                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }


                            }



                        }
                    }

                    this.Hide();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes cliente = new clientes();

            cliente.Show();
        }

        
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Mantenimiento llenar = new Mantenimiento();

            string idtype = "select IDmarca from Marca where Descripcion = '" + cmbMarca.Text + "'";
            int idbd = 0;
            idbd = clients.idtypecheck(idtype);

            llenar.llenarModelo(cmbModelo, idbd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMostrarItem.Rows)
            {
                string constring = @"Data Source=(localdb)\MyInstance;Initial Catalog=IT4;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO [Dispositivo/Accesorio] VALUES(@DispoID, @Acc)", con))
                    {
                        cmd.Parameters.AddWithValue("@DispoID", txtIdDispositivo.Text);
                        cmd.Parameters.AddWithValue("@Acc", row.Cells[2].Value);
                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    
                    
                    }

                    
                    
                }
            }
            MessageBox.Show("Records inserted.");
        }

        private void registro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);

            validaciones vali = new validaciones();
            vali.ParaLoginSinEspacios(e);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
