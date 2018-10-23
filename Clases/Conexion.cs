using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*
*
*Modulo de Conexion
*
*Este es un modulo de conexion entre Base de Datos y programa
*OJO no borrar el otro modulo denominado connect porque en el se encuentran variables 
*que se heredan en todo el programa
*
*03/12/2017
*/

namespace Clases
{
    public class Conexion
    {
        //la conexion para cualquier computadora se hizo por medio del localhost
        public static SqlConnection generarConexion()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=IT4;Integrated Security=True");
            return Con;
        }
    }
}
