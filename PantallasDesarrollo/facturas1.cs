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
*Modulo de Facturas
*
*Este modulo permite la visualizacion de las facturas ya realizadas
*
*03/12/2017
*/

namespace PantallasDesarrollo
{
    public partial class facturas1 : Form
    {
        public facturas1()
        {
            InitializeComponent();
        }

        //boton para regresar al modulo de menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Cargar datos de la Base de Datos al datagrid
        private void facturas_Load(object sender, EventArgs e)
        {
            contactos co = new contactos();
            co.cargarFacturas(dgvFacturas);
        }


        private void btnAyuda2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(btnAyuda2, ayudaH.HelpNamespace);
        }

    }
}
