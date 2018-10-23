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
*Modulo de Modificar Dispositivo
*
*Este Modulo permite la modificacion de Dispositivos previamente añadidos
*
*02/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class ModificarDispositivo : Form
    {
        public ModificarDispositivo()
        {
            InitializeComponent();


            SqlDataReader Lect;

            //Generar una conexion para rellenar el combobox de estado
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select [Descripcion] from [dbo].[Estados/Entidad]  where [IDEntidad] = 2 ", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cmbEstado.Items.Add(Lect["Descripcion"].ToString());
                }

                Cone.Close();
            }

            
            SqlDataReader Lect1;
            //Generar conexion para rellenar el combobox de empleados
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select NOM_EMPLEADO from USUARIO", Cone);

                Lect1 = comando.ExecuteReader();

                while (Lect1.Read())
                {
                    cmbEmpleado.Items.Add(Lect1["NOM_EMPLEADO"].ToString());
                }

                Cone.Close();
            }

        }

        //Boton para aceptar cambios realizados para su posterior modificacion 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion para no permitir campos vacios 
            if (string.IsNullOrWhiteSpace(cmbEstado.Text) == true || string.IsNullOrWhiteSpace(cmbDiagnostico.Text) == true || string.IsNullOrWhiteSpace(cmbEmpleado.Text) == true)
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                //enviar datos capturados a sus respectivas clases
                string idtype = "SELECT IDCol FROM [Estados/Entidad] WHERE IDEntidad = 2 and Descripcion = '" + cmbEstado.Text + "'";
                int idbd = 0;
                idbd = clients.idtypecheck(idtype);

                string idtype1 = "select ID_EMPLEADO from USUARIO where NOM_EMPLEADO = '" + cmbEmpleado.Text + "'";
                int idbd1 = 0;
                idbd1 = clients.idtypecheck(idtype1);

                string idclien = "select IDCliente from CLIENTE where [NOMBRE COMPLETO] = '" + txtCliente.Text + "'";
                int idbd2 = 0;
                idbd2 = clients.idtypecheck(idclien);

                string rtn = "select [RTN/ID] from CLIENTE where [NOMBRE COMPLETO] = '" + txtCliente.Text + "'";
                int rtn1 = 0;
                rtn1 = clients.idtypecheck(rtn);

                //Seleccionar el impuesto actual desde la Base de Datos 
                string isv;
                string query1 = "select ISV from ISV";
                isv = Mantenimiento.lookerSt(query1);

                //Validar los escenarios para el combobox de estados
                if (cmbEstado.Text == "Reparado")
                {
                    string query = "update DISPOSITIVO set DIAGNOSTICO= '" + cmbDiagnostico.Text + "', Estado = " + idbd + ", Tecnico = " + idbd1 + ", fecharRetiro = '" + txtFecha.Text + "', Monto = " + txtMonto.Text + ", [Cod Fac] = " + txtCodigoFactura.Text + " where IdDispositivos = " + int.Parse(txtIdDispositivo.Text) + "";
                    Mantenimiento.actualizar(query);

                    string cadenasql = "insert  into FACTURA values (" + txtCodigoFactura.Text + ", " + idbd2 + ", " + isv + ", '" + txtFecha.Text + "' , " + idbd1 + ", " + 10 + ");";
                    Mantenimiento.actualizar(cadenasql);

                    ImprimirFactura frm3 = new ImprimirFactura();

                    frm3.numfac.Text = txtCodigoFactura.Text;
                    frm3.fecha.Text = txtFecha.Text;
                    frm3.rtn.Text = rtn1.ToString();
                    frm3.desc.Text = cmbDiagnostico.Text;
                    frm3.monto.Text = txtMonto.Text;
                    frm3.isv.Text = isv.ToString();
                    frm3.nom.Text = txtCliente.Text;

                    frm3.Show();
                }
                else
                {
                    string query = "update DISPOSITIVO set DIAGNOSTICO= '" + cmbDiagnostico.Text + "', Estado = " + idbd + ", Tecnico = " + idbd1 + ", fecharRetiro = '" + txtFecha.Text + "' where IdDispositivos = " + int.Parse(txtIdDispositivo.Text) + "";
                    Mantenimiento.actualizar(query);
                }
                dispositivos frm4 = new dispositivos();

                //regresar al modulo de Dispositivos
                frm4.Show();
                this.Close();
            }
                    
        }

        //Funcion para rellenar campos en el modulo de Modificar dispositivo en el arranque de la interfaz
        private void ModificarDispositivo_Load(object sender, EventArgs e)
        {
            txtMonto.Text = "0";
            txtCodigoFactura.Text = "0";
            
            //Establecer el campo fecha
            txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            Mantenimiento man = new Mantenimiento();
            int cod;
            
            //Establecer codigo del dispositivo
            cod = int.Parse(txtIdDispositivo.Text);
            
            //Cargar datagrid de Accesorios
            man.cargarAccesorioMod(dgvMostrarItem, cod);
        }

        //Boton para regresar al modulo de Dispositivos
        private void btnVolver_Click(object sender, EventArgs e)
        {
            dispositivos frm3 = new dispositivos();
            frm3.Show();
            this.Close();
        }

        //Escenarios para el combobox de estado
        private void cmbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            //Habilitar controles en caso de que el estado sea Reparado
            if (cmbEstado.Text == "Reparado")
            {
                txtMonto.Enabled = true;
                txtCodigoFactura.Enabled = true;
            }
            //En caso contrario deshabilitarlos
            else
            {
                txtMonto.Enabled = false;
                txtCodigoFactura.Enabled = false;
            }

        }

        //Validacion solo numeros para el campo de codigo de factura 
        private void codfac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

        //validacion de solo numeros para el campo de monto
        private void monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones numero = new validaciones();
            numero.SoloNumeros(e);
        }

    }
}
