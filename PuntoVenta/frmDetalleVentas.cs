using CapaEntidad;
using CapaNegocio;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using PuntoVenta.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class frmDetalleVentas : Form
    {
        public frmDetalleVentas()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

      
        InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }

        private void frmDetalleVentas_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.btnLimpiar.Cursor = _customHandCursor;
            this.btnBuscar.Cursor = _customHandCursor;
            this.btnDescargarPDF.Cursor = _customHandCursor;
            this.dgvUserData.Cursor = _customHandCursor;
            this.txtDocumentoVenta.Cursor = _customCaretCursor;

            txtDocumentoCliente.Enabled = false;
            txtFecha.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTipoDocumento.Enabled = false;
            txtUsuario.Enabled = false;
            txtMontoPago.Enabled = false;
            txtMontoCambio.Enabled = false;
            txtTotal.Enabled = false;   

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var modal = new mdVenta())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtDocumentoVenta.Text = modal._Venta.numeroDocumento.ToString();
                }
                else
                {
                    txtDocumentoVenta.Select();
                }
            }
            Venta obj = new CN_Venta().obtenerVenta(txtDocumentoVenta.Text);

            if (obj.idVenta != 0)
            {
                txtDocumentoVenta.Text = obj.numeroDocumento;
                txtDocumentoCliente.Text = obj.documentoCliente;
                txtTipoDocumento.Text = obj.tipoDocumento;
                txtUsuario.Text = obj.objUsuario.nombre;
                txtNombreCliente.Text = obj.nombreCliente;
                txtFecha.Text = obj.fechaRegistro;

                dgvUserData.Rows.Clear();

                foreach (Detalle_Venta dt in obj.objDetalleVenta)
                {
                    dgvUserData.Rows.Add(new object[]
                    {
                        dt.objProducto.nombre, dt.precioVenta, dt.cantidad, dt.subTotal
                    });
                }

                txtTotal.Text = obj.montoTotal.ToString("0.00");
                txtMontoPago.Text = obj.montoPago.ToString("0.00");
                txtMontoCambio.Text = obj.montoCambio.ToString("0.00");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumentoCliente.Text = "";
            txtFecha.Text = "";
            txtNombreCliente.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            dgvUserData.Rows.Clear();
            txtTotal.Text = "";
            txtDocumentoVenta.Text = "";
            txtDocumentoVenta.Select();
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (txtDocumentoVenta.Text != "")
            {
                string texto_html = Properties.Resources.Plantilla_Venta.ToString();
                Negocio objNG = new CN_Negocio().obtenerDatos();

                texto_html = texto_html.Replace("@nombrenegocio", objNG.nombre.ToUpper());
                texto_html = texto_html.Replace("@docnegocio", objNG.rfc);
                texto_html = texto_html.Replace("@direcnegocio", objNG.direccion);

                texto_html = texto_html.Replace("@tipodocumento", txtTipoDocumento.Text);
                texto_html = texto_html.Replace("@numerodocumento", txtDocumentoVenta.Text);

                texto_html = texto_html.Replace("@doccliente", txtDocumentoCliente.Text);
                texto_html = texto_html.Replace("@nombrecliente", txtNombreCliente.Text);
                texto_html = texto_html.Replace("@fecharegistro", txtFecha.Text);
                texto_html = texto_html.Replace("@usuarioregistro", txtUsuario.Text);

                string filas = string.Empty;

                foreach (DataGridViewRow fila in dgvUserData.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + fila.Cells["Producto"].Value.ToString() + "</td>";
                    filas += "<td>" + fila.Cells["precio"].Value.ToString() + "</td>";
                    filas += "<td>" + fila.Cells["cantidad"].Value.ToString() + "</td>";
                    filas += "<td>" + fila.Cells["subTotal"].Value.ToString() + "</td>";
                    filas += "</tr>";
                }

                texto_html = texto_html.Replace("@filas", filas);
                texto_html = texto_html.Replace("@montototal", txtTotal.Text);
                texto_html = texto_html.Replace("@pagocon", txtMontoPago.Text);
                texto_html = texto_html.Replace("@cambio", txtMontoCambio.Text);

                SaveFileDialog archivoGuardado = new SaveFileDialog();
                archivoGuardado.FileName = string.Format("Venta_{0}.pdf", txtDocumentoVenta.Text);
                archivoGuardado.Filter = "PDF Files | *.pdf";

                if (archivoGuardado.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream st = new FileStream(archivoGuardado.FileName, FileMode.Create))
                    {
                        var pgSize = new iTextSharp.text.Rectangle(1000, 1000);

                        iTextSharp.text.Document docGenerado = new iTextSharp.text.Document(pgSize, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(docGenerado, st);

                        docGenerado.Open();

                        bool obtenido = true;

                        byte[] imagen = new CN_Negocio().obtenerLogo(out obtenido);

                        if (obtenido)
                        {
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagen);
                            img.ScaleToFit(60, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(docGenerado.Left, docGenerado.GetTop(51));
                            docGenerado.Add(img);
                        }

                        using (StringReader sr = new StringReader(texto_html))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, docGenerado, sr);

                        }
                        docGenerado.Close();
                        st.Close();
                        MessageBox.Show("Documento PDF generado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Debes ingresar una venta para generar el archivo PDF", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
