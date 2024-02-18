using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta.Modal
{
    public partial class mdRespuesta : Form
    {
        string cambio;
        public mdRespuesta(string cadena)
        {
            cambio = cadena;
            InitializeComponent();
         
        }

        private void mdRespuesta_Load(object sender, EventArgs e)
        {

            label2.Text = cambio;
            btnSalir.Select();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
