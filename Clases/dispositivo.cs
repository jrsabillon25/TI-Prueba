﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;

/*
*clase complementaria al modulo de dispositivos para realizar las operaciones
*necesarias
*
*07/12/2017
*/

    //clase sin referencias por los momentos

namespace Clases
{
   public class dispositivo:connect
    {
        public static bool resul = false;

        //funcion que permite insertar nuevos dispositivos
        public static void insetar(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                comando.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Dispositivo ingresado!");
            }
        }

        //permite seleccionar el siguiente dispositivo a ingresar en la BD
        public static int codigo()
        {
            int resultado;
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand("select top 1 IdDispositivos +1 from [dbo].[DISPOSITIVO] order by [IdDispositivos] desc", cone);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cone.Close();
            }

            return resultado;

        }

        //Buscar dispositivos para llenar el grid 
        public static void buscardispo(DataGridView dgv, string query)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();

                DataSet dt = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, cone);

                da.Fill(dt, "IT4");
                dgv.DataSource = dt;
                dgv.DataMember = "IT4";
                cone.Close();

            }
        }

        //Buscar informacion dependiendo del query recibido para ser mostrada en el grid
        public bool Buscar(string sql)
        {

            using (SqlConnection cone = Conexion.generarConexion())
            {
                bool resultado = false;
                cone.Open();
                SqlCommand comando = new SqlCommand(sql, cone);

                SqlDataReader reg = (null);
                reg = comando.ExecuteReader();

                if (reg.Read())
                {
                    resultado = true;
                }

                cone.Close();
                resul = resultado;
                return resultado;
            }


        }

        //funcion para modificar el dato seleccionado de un grid
        public static void actualizar(string query)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Modificacion realizada!");
            }
        }

        //funcion para modificar los datos en el modulo de editar dispositivo
        //recibe los siguientes parametros: RTN, NOMBRE, APELLIDO, TELEFONO, ESTADO, IDCLIENTE
        public string edit(int rtn, string name, string ape, string tel, int t, int cli)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cnn.Open();
                comandosql = new SqlCommand("Update DISPOSITIVO set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + 16 + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
                comandosql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
            }
            return salida;
        }


        //cargar informacion al grid dentro de dispositivos
        public void cargarContacto(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select DISPOSITIVO.IdDispositivos, DISPOSITIVO.IDMODELO, DISPOSITIVO.DESCRIPCION, DISPOSITIVO.DIAGNOSTICO , DISPOSITIVO.IDCliente, DISPOSITIVO.[Cod Fac], DISPOSITIVO.Monto, DISPOSITIVO.fechaIngreso, DISPOSITIVO.fecharRetiro, DISPOSITIVO.Tecnico, DISPOSITIVO.Estado, DISPOSITIVO.NumRegistro, DISPOSITIVO.TipoDispositivo, DISPOSITIVO.SSMA_TimeStamp on Contactos.Idcliente=CLIENTE.IDCliente", cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        } 

    }
}
