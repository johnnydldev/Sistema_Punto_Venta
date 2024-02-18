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
    public partial class frmReporteCompra : Form
    {
        public frmReporteCompra()
        {
            InitializeComponent();
        }

        private void frmReporteCompra_Load(object sender, EventArgs e)
        {
            foreach  (DataGridViewColumn columna in dgvData.Columns)
            {
                cboBuscar.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });
            }
            cboBuscar.DisplayMember = "texto";
            cboBuscar.ValueMember = "valor";
            cboBuscar.SelectedIndex = 0;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dateFechaInicio.Format = DateTimePickerFormat.Custom;
            dateFechaInicio.CustomFormat = "yyyy/MM/dd";

            dateFechaFinal.Format = DateTimePickerFormat.Custom;
            dateFechaFinal.CustomFormat = "yyyy/MM/dd";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().obtenerCompras(dateFechaInicio.Text.ToString(), dateFechaFinal.Text.ToString());

            dgvData.Rows.Clear();

            foreach (ReporteCompra report in lista)
            {
                dgvData.Rows.Add(new object[]
                {
                    report.fechaRegistro,
                    report.tipoDocumento,
                    report.numeroDocumento,
                    report.montoTotal,
                    report.nombreUsuario,
                    report.documentoProveedor,
                    report.razonSocial,
                    report.codProducto,
                    report.nombreProducto,
                    report.categoria,
                    report.precioCompra,
                    report.precioVenta,
                    report.cantidad,
                    report.subTotal,
                });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).valor.ToString();

            if (txtBuscar.Text == "")
            {
               
                MessageBox.Show("El campo de busqueda esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtBuscar.Select();
            }
            else
            {
                if (dgvData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow fila in dgvData.Rows)
                    {
                        if (fila.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        {
                            fila.Visible = true;
                        }
                        else
                        {
                            fila.Visible = false;
                        }
                    }
                }
            }

           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                fila.Visible = true;
            }
        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debes realizar una busqueda con el boton listar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
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
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString(),
                            fila.Cells[5].Value.ToString(),
                            fila.Cells[6].Value.ToString(),
                            fila.Cells[7].Value.ToString(),
                            fila.Cells[8].Value.ToString(),
                            fila.Cells[9].Value.ToString(),
                            fila.Cells[10].Value.ToString(),
                            fila.Cells[11].Value.ToString(),
                            fila.Cells[12].Value.ToString(),
                            fila.Cells[13].Value.ToString(),

                        });
                    
                }

                SaveFileDialog archivoGuardado = new SaveFileDialog();
                archivoGuardado.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddmmyyyyHHmmss"));
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
