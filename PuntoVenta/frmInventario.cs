using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        
        InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.btnGenerarExcel.Cursor = _customHandCursor;
            this.dgvUserData.Cursor = _customHandCursor;

            List<Producto> list = new CN_Producto().listar();

            foreach (Producto item in list)
            {
                dgvUserData.Rows.Add(new object[]
            {
                "",
                item.idProducto,
                item.codigo,
                item.nombre,
                item.descripcion,
                item.objCategoria.idCategoria,
                item.objCategoria.descripcion,
                item.stock,
                item.precioCompra,
                item.precioVenta,
                item.estado == true ? 1 : 0,
                item.estado == true ? "Activo" : "Inactivo"
            });
            }
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            foreach (DataGridViewColumn columna in dgvUserData.Columns)
            {
                if (columna.HeaderText != "" && columna.Visible)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }
            }

            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                if (fila.Visible)
                {
                    dt.Rows.Add(new object[]
                    {
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString(),
                            fila.Cells[6].Value.ToString(),
                            fila.Cells[7].Value.ToString(),
                            fila.Cells[8].Value.ToString(),
                            fila.Cells[9].Value.ToString(),
                            fila.Cells[11].Value.ToString(),

                    });
                }

            }

            SaveFileDialog archivoGuardado = new SaveFileDialog();
            archivoGuardado.FileName = string.Format("ReporteProductos_{0}.xlsx", DateTime.Now.ToString("ddmmyyyyHHmmss"));
            archivoGuardado.Filter = "Excel Files | *.xlsx";


            if (archivoGuardado.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XLWorkbook libro = new XLWorkbook();
                    var hoja = libro.Worksheets.Add(dt, "Informe");

                    hoja.ColumnsUsed().AdjustToContents();

                    libro.SaveAs(archivoGuardado.FileName);

                    MessageBox.Show("Reporte generado :)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :(", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
