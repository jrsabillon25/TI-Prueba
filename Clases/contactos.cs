using System;
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
*
*Clase de contactos en donde se lleva a cabo todas las operaciones dentro 
*del modulo de contactos
*
*07/12/2017
*/


namespace Clases
{
   public class contactos:connect
    {
       public static bool resul = false;

        //funcion que nos permitira insertar un nuevo contacto recibiendo el query con el codigo
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

        //funcion que nos permitira insertar un nuevo contacto recibiendo el query con el codigo
        public static void insetarCon(string query)
       {
           using (SqlConnection cnn = Conexion.generarConexion())
           {
               cnn.Open();
               SqlCommand comando = new SqlCommand(query, cnn);
               comando.ExecuteNonQuery();
               cnn.Close();
               MessageBox.Show("Contacto ingresado!");
           }
       }

        //seleccionar el siguiente ID del contacto que hay que ingresar
       public static int codigoCont()
       {
           int resultado;
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();
               SqlCommand comando = new SqlCommand("select top 1 [Idcontacto] +1 from [dbo].[Contactos] order by [Idcontacto] desc", cone);

               resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
               cone.Close();

           }

           return resultado;

       }

        //funcion necesaria para buscar contactos en la BD
       public static void buscarcontactos(DataGridView dgv, string query)
       {
           using (SqlConnection cone = Conexion.generarConexion())
           {
               cone.Open();

               DataSet dt = new DataSet();
               SqlDataAdapter da = new SqlDataAdapter(query, cone);

               da.Fill(dt, "IT3");
               dgv.DataSource = dt;
               dgv.DataMember = "IT3";
               cone.Close();

           }
       }

        //dentro del modulo de editar contacto se encuentra un grid de busqueda
        //esta funcion permite el llenado de este grid
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

        //funcion requerida para actualizar informacion 
        //no se encuentra en uso pero puede ser utilizada
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

        //funcion que se utiliza dentro del modulo editar cliente
        //recibe como parametros el RTN, NOMBRE, APELLIDO, TELEFONO, ESTADO, IDCLIENTE
       public string edit(int rtn, string name, string ape, string tel, int t, int cli)
       {
           string salida = "Se actualizaron los datos";
           try
           {
               cnn.Open();
               
               comandosql = new SqlCommand("Update Contactos set Rtn= " + rtn + ", Nombre= '" + name + "', Apellido= '" + ape + "', Telefono = '" + tel + "', Estado = " + 16 + "  , Idcliente = " + cli + " where Rtn = " + rtn + " ", cnn);
               comandosql.ExecuteNonQuery();
               cnn.Close();
           }
           catch (Exception ex)
           {
               salida = "No se actualizo: " + ex.ToString();
           }
           return salida;
       }


        //cargar informacion al grid de contactos
       public void cargarContacto(DataGridView dgv)
       {
     
           try
           {
               da = new SqlDataAdapter("Select Contactos.Rtn , Contactos.Nombre 'Nombre de Contacto', Contactos.Apellido 'Apellido de Contacto', Contactos.Telefono 'Telefono de contacto' , Contactos.Idcliente 'Identificación de contacto', CLIENTE.[NOMBRE COMPLETO] 'Nombre de Cliente' from [dbo].[Contactos] inner join [dbo].[CLIENTE] on Contactos.Idcliente=CLIENTE.IDCliente", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


       /*-----------!Grids externos-------------*/

       //cargar tipos de identificacion en el modulo parametros de administrador
       public void cargarIDTypes(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IDType, a.Descripcion, b.Descripcion as Estado from IDTypes as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


        //cargar marcas en el modulo parametros de administrador
        public void cargarMarcas(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IDmarca, a.Descripcion, b.Descripcion as Estado from Marca as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


        //cargar modelos en el modulo parametros de administrador
        public void cargarModelo(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IDmodelo, b.Descripcion as Marca, a.Descripcion as Modelo, c.Descripcion from Modelo as a inner join Marca as b on a.IDmarca = b.IDmarca inner join [Estados/Entidad] as c on a.Estado = c.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


        //cargar accesorios en el modulo parametros de administrador
        public void cargarAcc(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IDAccesorio, a.Descripcion, b.Descripcion as Estado from Accesorios as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


        //cargar tipos de dispositivos en el modulo parametros de administrador
        public void cargarTdispo(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IDTipoDispositivo, a.Descripcion, b.Descripcion as Estado from TipoDispositivo as a inner join [Estados/Entidad] as b on a.Estado = b.IDCol", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }


        //cargar dispositivos en el modulo parametros de administrador
        public void cargarDispo(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select a.IdDispositivos, a.NumRegistro, c.Descripcion as Marca, b.Descripcion as Modelo, d.[NOMBRE COMPLETO], f.Descripcion as Estado, a.DIAGNOSTICO, a.fechaIngreso from DISPOSITIVO as a inner join Modelo as b on a.IDMODELO = b.IDmodelo inner join Marca as c on b.IDmarca = c.IDmarca inner join CLIENTE as d on a.IDCliente = d.IDCliente inner join [Estados/Entidad] as f on f.IDCol = a.Estado ", cnn);
               dt = new DataTable();
               da.Fill(dt);
               dgv.DataSource = dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
           }
       }

        /*-----------Grids externos!-------------*/

        //funcion para cargar facturas registradas en la base de datos
       public void cargarFacturas(DataGridView dgv)
       {
           try
           {
               da = new SqlDataAdapter("select * from FACTURA", cnn);
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
