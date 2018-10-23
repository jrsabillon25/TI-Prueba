﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using  System.Data;
using System.Data.Sql;

/*
*
*Modulo de Conexion 
*
*Este modulo permite la conexion entre programa y BD(SQL)
*este modulo contiene variables que se heredan en todo el programa
*
*02/12/2017
*/

namespace Clases
{
    public class connect
    {
        //Variables que se heredaran en el ciclo del programa
        public string cadenaconexion;
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;

        //la conexion para cualquier computadora se hizo por medio del localhost
        public connect()
        {
            this.cadenaconexion = (@"Data Source=localhost\SQLEXPRESS;Initial Catalog=IT4;Integrated Security=True");
            this.cnn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }
    }
}
