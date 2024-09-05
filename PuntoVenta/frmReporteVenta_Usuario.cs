using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
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
    public partial class frmReporteVenta_Usuario : Form
    {
        public frmReporteVenta_Usuario()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

       
        InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }

        private void frmReporteVenta_Usuario_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.btnListar.Cursor = _customHandCursor;
            this.btnDescargarExcel.Cursor = _customHandCursor;
            this.dgvData.Cursor = _customHandCursor;
            this.cboBuscar.Cursor = _customHandCursor;
            this.dateFechaInicio.Cursor = _customHandCursor;


            List<Usuario> nombres = new CN_Usuario().listar();
            foreach (Usuario item in nombres)
            {
                cboBuscar.Items.Add(new OpcionCombo() { valor = item.idUsuario, texto = item.nombre });
            }
            cboBuscar.DisplayMember = "texto";
            cboBuscar.ValueMember = "valor";
            cboBuscar.SelectedIndex = 0;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dateFechaInicio.Format = DateTimePickerFormat.Custom;
            dateFechaInicio.CustomFormat = "yyyy/MM/dd";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ReporteVenta> lista = new List<ReporteVenta>();
            string nombre = ((OpcionCombo)cboBuscar.SelectedItem).texto.ToString();

            lista = new CN_Reporte().ventaUsuario(dateFechaInicio.Text.ToString(), Convert.ToInt32(((OpcionCombo)cboBuscar.SelectedItem).valor.ToString()));

            dgvData.Rows.Clear();

            foreach (ReporteVenta report in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    dateFechaInicio.Text.ToString(),
                    nombre,
                    report.montoTotal,
                   
                });
            }


        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debes realizar una busqueda con el botón listar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateFechaInicio.Select();
                return;
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow fila in dgvData.Rows)
                {
                    dt.Rows.Add(new object[]
                    {
                            fila.Cells[0].Value.ToString(),
                            fila.Cells[1].Value.ToString(),
                            fila.Cells[2].Value.ToString(),

                    });

                }

                SaveFileDialog archivoGuardado = new SaveFileDialog();
                archivoGuardado.FileName = string.Format("ReporteVentaUsuario_{0}.xlsx", DateTime.Now.ToString("ddmmyyyyHHmmss"));
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



    }//Termina clase
}
