using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.IO;

namespace PuntoVenta
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

      
        InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        public Image convertirImagen(byte[] bytesImagen)
        {
            MemoryStream stream = new MemoryStream();
            stream.Write(bytesImagen, 0, bytesImagen.Length);

            Image imagen = new Bitmap(stream);

            return imagen;
        }
        private void frmNegocio_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.btnCargarImagen.Cursor = _customHandCursor;
            this.btnGuardar.Cursor = _customHandCursor;
            this.txtDireccion.Cursor = _customCaretCursor;
            this.txtNombreN.Cursor = _customCaretCursor;
            this.txtRFC.Cursor = _customCaretCursor;
            gbtnOpciones.Cursor = _customCutCursor;


            bool resultado = true;

            byte[] bytesImagen = new CN_Negocio().obtenerLogo(out resultado);

            if (resultado)
            {
                picLogo.Image = convertirImagen(bytesImagen);
            }

            Negocio datos = new CN_Negocio().obtenerDatos();

            txtNombreN.Text = datos.nombre;
            txtRFC.Text = datos.rfc;
            txtDireccion.Text = datos.direccion;

        }//Termina inicializador de datos

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FileName = "Files| *.jpg; *.png; *.jpeg";

            if (fileDialog.ShowDialog()== DialogResult.OK)
            {
                byte[] bytesImagen = File.ReadAllBytes(fileDialog.FileName);
                bool resultado = new CN_Negocio().actualizarLogo(bytesImagen, out mensaje);

                if (resultado)
                {
                    picLogo.Image = convertirImagen(bytesImagen);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }//Termina método cargar imagen

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                nombre = txtNombreN.Text,
                rfc = txtRFC.Text,
                direccion = txtDireccion.Text,
            };

            bool resultado = new CN_Negocio().guardarDatos(obj, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Los cambios fueron guardados :)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Los cambios no fueron guardados :(", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//Termina método de actualización de datos


    }//Termina clase
}
