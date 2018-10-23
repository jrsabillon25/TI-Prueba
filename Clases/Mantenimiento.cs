using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;

/*
*
*Clase que elabora todos los mantenimientos dentro del programa
*
*
*07/12/2017
*/

namespace Clases
{
    public class Mantenimiento
    {


        //funcion establecida para llenar los combobox con los puestos
        public void llenarPuesto(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                SqlCommand comando = new SqlCommand("select DESC_PUESTO from PUESTO", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["DESC_PUESTO"].ToString());
                }

            }

        }


        //funcion para asignar un nuevo tipo de Identificacion
        public static int codigoIDTypes()
        {
            int resultado;
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand("select top 1 IDType +1 from IDTypes order by IDType desc", cnn);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cnn.Close();
            }

            return resultado;
        }


        //funcion para actualizar las modificaciones
        public static void actualizar(string query)
        { 
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);

                comando.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Modificacion realizada!");
            }
        }


        //funcion para actualizar las modificaciones 
        public static void actNomsg(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);

                comando.ExecuteNonQuery();
                cnn.Close();
            }
        }

        /*----------------Creacion general-----------------------------------*/

            //Funcion para insertar datos a la BD por medio de un query
        public static void insertar(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                comando.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Ingresado!");
            }
        }
        /*---------------------------------------------------*/

        /*----------------Buscar general-----------------------------------*/

            //funcion general para buscar desde cualquier modulo por medio de un query
        public static int looker(string query)
        {
            int look = 0;

            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                look = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cnn.Close();
            }

            return look;
        }

        public static string lookerSt(string query)
        {
            string look;

            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                look = comando.ExecuteScalar().ToString();
                cnn.Close();
            }

            return look;
        }
        /*---------------------------------------------------*/

            //funcion que permite hacer consultas recibiendo como parametro el Usuario
        public static string consulta(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select b.NOM_PUESTO from USUARIO as a inner join PUESTO as b on a.ID_Puesto = b.ID_PUESTO where a.USUARIO=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);
                

                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        //funcion que nos permite visualizar los estados recibiendo como parametro el usuario
        public static string Estado(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select b.Descripcion from USUARIO as a inner join [Estados/Entidad] as b on a.ESTADO = b.IDCol where a.USUARIO=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);      

                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        //funcion que nos permite visualizar el ID del usuario recibiendo como parametro el usuario
        public static string userid(string user)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                string resultado;

                SqlCommand comando = new SqlCommand("select a.ID_EMPLEADO  from USUARIO as a where a.USUARIO=@var1", Cone);
                comando.Parameters.AddWithValue("@var1", user);
                

                Cone.Open();
                resultado = comando.ExecuteScalar().ToString();
                Cone.Close();

                return resultado;
            }
        }

        //funcion para llenar los combobox de puesto
        public void llenarPst(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select DESC_PUESTO from PUESTO", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["DESC_PUESTO"].ToString());
                }
                Cone.Close();
            }
        }

        //funcion que nos permite llenar los combobox de tipos de ID para clientes
        public void llenarCliente(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select Descripcion from IDTypes", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();
            }
        }

        //funcion que nos permite llenar los combobox de marcas
        public void llenarMarca(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select Descripcion from Marca", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();
            }
        }

        //funcion que nos permite llenar los combobox con los tipos de dispositivos
        public void llenarTipoDis(ComboBox cb)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select Descripcion from TipoDispositivo", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();
            }
        }

        //funcion que nos permite llenar combobox en el modulo de modelo dependiendo del ID de marca
        public void llenarModelo(ComboBox cb, int Marca)
        {
            cb.Items.Clear();
            
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("select Descripcion from Modelo where IDmarca = "+Marca+"", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect["Descripcion"].ToString());
                }
                Cone.Close();
            }
        }

        //funcion que nos permite llenar los grids en el modulo de accesorio
        public void cargarAccesorio(DataGridView dgv)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                try
                {
                    da = new SqlDataAdapter("Select Descripcion, IDAccesorio from Accesorios ", Cone);
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

        //funcion que nos permite buscar dispositivos
        public static void buscarDevice(DataGridView dgv, string query)
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

        //funcion que nos permite llenar el grid de accesorios por medio del codigo de dispositivo
        public void cargarAccesorioMod(DataGridView dgv, int cod)
        {
            using (SqlConnection Cone = Conexion.generarConexion())
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                try
                {
                    da = new SqlDataAdapter("select b.Descripcion as Acc from [Dispositivo/Accesorio] as a inner join Accesorios as b on a.IdAccesorio = b.IDAccesorio inner join DISPOSITIVO as c on a.idDispositivo = c.IdDispositivos where c.IdDispositivos = "+cod+"", Cone);
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

        //funcion que nos permite buscar el RTN de un cliente
        public bool BuscarRTN(string nombre)
        {
            string sql = @"SELECT COUNT(*) FROM CLIENTE WHERE [RTN/ID] = @nombre";

            using (SqlConnection Cone = new SqlConnection("connection string"))
            {
                Cone.Open();

                SqlCommand cmd = new SqlCommand(sql, Cone);
                cmd.Parameters.AddWithValue("@nombre", nombre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count == 0;

            }
        }
        
    }
}
