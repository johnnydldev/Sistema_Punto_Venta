using CapaEntidad;
using CapaNegocio;
using ClosedXML.Excel;
using PuntoVenta.Herramientas;
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
    public partial class frmProductos : Form
    {

        GeneradorDocumento codigoProducto = new GeneradorDocumento();

        ER_Metodos expresion = new ER_Metodos();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(new CN_Producto().obtenerIdProduct());
            txtId.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lblIndiceTabla.Visible = false;

            cboEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cboEstado.DisplayMember = "texto";
            cboEstado.ValueMember = "valor";
            cboEstado.SelectedIndex = 0;

            List<Categoria> listCat = new CN_Categoria().listar();

            foreach (Categoria item in listCat)
            {
                cboCategoria.Items.Add(new OpcionCombo() { valor = item.idCategoria, texto = item.descripcion });
            }
            cboCategoria.DisplayMember = "texto";
            cboCategoria.ValueMember = "valor";
            cboCategoria.SelectedIndex = 0;



            foreach (DataGridViewColumn colums in dgvUserData.Columns)
            {
                if (colums.Visible == true && colums.Name != "btnSeleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo { valor = colums.Name, texto = colums.HeaderText });
                }

            }
            cboBuscar.DisplayMember = "texto";
            cboBuscar.ValueMember = "valor";
            cboBuscar.SelectedIndex = 0;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Mostrar Los datos de los usuarios en la tabla
            List<Producto> list = new CN_Producto().listar();

            foreach (Producto  item in list)
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
        }//inicializador de componentes

        private void limpiarOpciones()
        {
            lblIndiceTabla.Text = "-1";
            txtId.Text = Convert.ToString(new CN_Producto().obtenerIdProduct());
            txtCodigo.Text = "";
            txtCodigo.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            txtPrecioVenta.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            restaurarCampos();
            txtCodigo.Select();

        }

        private bool estadoBandera()
        {
            int valor = 0;
            valor = Convert.ToInt32(((OpcionCombo)cboEstado.SelectedItem).valor);
            bool estadoBandera = false;

            if (valor == 1)
            {
                estadoBandera = true;
            }
            return estadoBandera;
        }

        public bool validarCampos()
        {
            bool respuesta = true;

            if (txtDescripcion.Text == "" || txtDescripcion.Text.Length < 4)
            {
                MessageBox.Show("Descripción no valida, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Select();
                txtDescripcion.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

            if (txtCantidad.Text == "" || expresion.validarNumeros(txtCantidad.Text) != true)
            {
                MessageBox.Show("Cantidad no valida, el formato no es correcto.\nSolo se permiten Números, entre el 0 y 9.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Select();
                txtCantidad.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

            if (txtPrecioVenta.Text  == "" || expresion.validarNumeros(txtPrecioVenta.Text) != true)
            {
                MessageBox.Show("Precio de venta no valido, el formato no es correcto.\nSolo se permiten Números, entre el 0 y 9.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioVenta.Select();
                txtPrecioVenta.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

            if (txtNombre.Text == "" || txtNombre.Text.Length<4)
            {
                MessageBox.Show("Nombre no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Select();
                txtNombre.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }

            if (expresion.validarDocumento(txtCodigo.Text) != true)
            {
                MessageBox.Show("Codigo no valido, el formato no es correcto.\nSolo se permiten números, entre 0-9", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Select();
                txtCodigo.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

           
            return respuesta;
        }//termina Validar campos

        public void restaurarCampos()
        {
            txtBuscar.BackColor = System.Drawing.Color.White;
            txtDescripcion.BackColor = System.Drawing.Color.White;
            txtNombre.BackColor = System.Drawing.Color.White;
            txtCodigo.BackColor = System.Drawing.Color.LightBlue;
            txtPrecioVenta.BackColor = System.Drawing.Color.White;
            txtCantidad.BackColor = System.Drawing.Color.White;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estadoFinal = estadoBandera();

            bool validacion = validarCampos();

            Producto obj = new Producto();

            if (validacion == true)
            {
                obj.idProducto = Convert.ToInt32(txtId.Text.Trim());
                obj.codigo = txtCodigo.Text.Trim();
                obj.nombre = txtNombre.Text.Trim();
                obj.descripcion = txtDescripcion.Text.Trim();
                obj.objCategoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).valor) };
                obj.stock = Convert.ToInt32(txtCantidad.Text.Trim());
                obj.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                obj.estado = estadoFinal;


                int ProductGenerado = new CN_Producto().registrar(obj, out mensaje);


                if (ProductGenerado != 0)
                {
                    dgvUserData.Rows.Add(new object[]
                    {
                    "",
                    txtId.Text,
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    ((OpcionCombo) cboCategoria.SelectedItem).valor.ToString(),
                    ((OpcionCombo) cboCategoria.SelectedItem).texto.ToString(),
                    txtCantidad.Text,
                    "0.0",
                    txtPrecioVenta.Text,
                    ((OpcionCombo) cboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo) cboEstado.SelectedItem).texto.ToString()
                    });
                    limpiarOpciones();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

            

        }//termina método agregar

        private void btnLimpiarCasillas_Click(object sender, EventArgs e)
        {
            limpiarOpciones();
        }//termina método limpiar componentes

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        idProducto = Convert.ToInt32(txtId.Text)
                    };
                    bool resultado = new CN_Producto().eliminar(obj, out mensaje);

                    if (resultado)
                    {
                        dgvUserData.Rows.RemoveAt(Convert.ToInt32(lblIndiceTabla.Text));
                        limpiarOpciones();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }//termina método eliminar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();

            bool validacion = validarCampos();

            Producto obj = new Producto();

            if (validacion == true)
            {
                obj.idProducto = Convert.ToInt32(txtId.Text.Trim());
                obj.codigo = txtCodigo.Text.Trim();
                obj.nombre = txtNombre.Text.Trim();
                obj.descripcion = txtDescripcion.Text.Trim();
                obj.objCategoria = new Categoria() { idCategoria = Convert.ToInt32(((OpcionCombo)cboCategoria.SelectedItem).valor) };
                obj.stock = Convert.ToInt32( txtCantidad.Text.Trim());
                obj.precioVenta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                obj.estado = estado;


                bool resultado = new CN_Producto().editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow fila = dgvUserData.Rows[Convert.ToInt32(lblIndiceTabla.Text)];
                    fila.Cells["idProducto"].Value = txtId.Text;
                    fila.Cells["codigo"].Value = txtCodigo.Text;
                    fila.Cells["nombre"].Value = txtNombre.Text;
                    fila.Cells["descripcion"].Value = txtDescripcion.Text;
                    fila.Cells["idCat"].Value = ((OpcionCombo)cboCategoria.SelectedItem).valor.ToString();
                    fila.Cells["categoria"].Value = ((OpcionCombo)cboCategoria.SelectedItem).texto.ToString();
                    fila.Cells["stock"].Value = txtCantidad.Text;
                    fila.Cells["precioVenta"].Value = txtPrecioVenta.Text;
                    fila.Cells["estadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).valor.ToString();
                    fila.Cells["estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).texto.ToString();
                    limpiarOpciones();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
         


        }//termina método actualizar

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            GeneradorDocumento nuevo = new GeneradorDocumento();

            if (txtCodigo.Text != "")
            {
                txtCodigo.Text = "";
                txtCodigo.Text = nuevo.generadorDocumento();
            }
            else
            {
                txtCodigo.Text = codigoProducto.generadorDocumento();
            }
        }//termina método generar código

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).valor.ToString();

            if (txtBuscar.Text != "")
            {
                if (dgvUserData.Rows.Count > 0)
                {
                    foreach (DataGridViewRow fila in dgvUserData.Rows)
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
            else
            {
                MessageBox.Show("Ingresa información valida, no puede estar vacio el campo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.BackColor = System.Drawing.Color.LightBlue;
                txtBuscar.Select();
                return;
            }



        }//termina método buscar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                fila.Visible = true;
            }
            txtBuscar.Select();
            txtBuscar.BackColor = System.Drawing.Color.LightBlue;
        }//termina método limpiar

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    lblIndiceTabla.Text = indice.ToString();
                    txtId.Text = dgvUserData.Rows[indice].Cells["idProducto"].Value.ToString();
                    txtCodigo.Text = dgvUserData.Rows[indice].Cells["codigo"].Value.ToString();
                    txtNombre.Text = dgvUserData.Rows[indice].Cells["nombre"].Value.ToString();
                    txtDescripcion.Text = dgvUserData.Rows[indice].Cells["descripcion"].Value.ToString();
                    txtCantidad.Text = dgvUserData.Rows[indice].Cells["stock"].Value.ToString();
                    txtPrecioVenta.Text = dgvUserData.Rows[indice].Cells["precioVenta"].Value.ToString();

                    foreach (OpcionCombo item in cboCategoria.Items)
                    {
                        if (Convert.ToInt32(item.valor) == Convert.ToInt32(dgvUserData.Rows[indice].Cells["idCat"].Value))
                        {
                            int indice_combo = cboCategoria.Items.IndexOf(item);
                            cboCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo item in cboEstado.Items)
                    {
                        if (Convert.ToInt32(item.valor) == Convert.ToInt32(dgvUserData.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_combo = cboEstado.Items.IndexOf(item);
                            cboEstado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
            txtCodigo.Enabled = false;
            txtId.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }//termina método para cargar los datos de edición

        private void dgvUserData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.lapiz_.Width;
                var h = Properties.Resources.lapiz_.Height;

                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.lapiz_, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }//Termina método para cagar la imagen del boton editar.

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            if (dgvUserData.Rows.Count < 1)
            {
                MessageBox.Show("!!!!No hay datos que exportar!!!!","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvUserData.Columns)
                {
                   if( columna.HeaderText != "" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    } 
                }

                foreach (DataGridViewRow fila in dgvUserData.Rows)
                {
                    if (fila.Visible)
                    {
                        dt.Rows.Add( new object[]
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
            }//Termina else


        }//termina método para exportar archivo de excel


    }
}
