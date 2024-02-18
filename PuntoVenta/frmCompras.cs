using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
using PuntoVenta.Herramientas;
using PuntoVenta.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class frmCompras : Form
    {

        static int filaSeleccion;
        static int filaSeleccionada;

        private Usuario usuario; 

        ER_Metodos expresion = new ER_Metodos();
        
        public frmCompras(Usuario objUsuario = null)
        {
            usuario = objUsuario;

            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.Items.Add(new OpcionCombo() { valor = "Boleta", texto = "Boleta" });
            cboTipoDocumento.Items.Add(new OpcionCombo() { valor = "Factura", texto = "Factura" });
            cboTipoDocumento.DisplayMember = "texto";
            cboTipoDocumento.ValueMember = "valor";
            cboTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProveedor.Text = "1";
            txtIdProducto.Text = "0";
            txtDocumento.Text = "00000000";
            txtRazonSocial.Text = "desconocido";
            txtIdProducto.Visible = false;
            txtIdProducto.Enabled = false;
            txtIdProveedor.Enabled = false;
            txtIdProveedor.Visible = false;
            txtCantidad.Text = "1";
            txtPorcentaje.Text = "10";
            txtTotalPagar.Text = "0";
            txtTotalPagar.BackColor = System.Drawing.Color.LimeGreen;
            txtTotalPagar.Enabled = false;
            txtDocumento.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtFecha.Enabled = false;
            txtCodigoProducto.Select();


        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal._Proveedor.idProveedor.ToString();
                    txtDocumento.Text = modal._Proveedor.documento;
                    txtRazonSocial.Text = modal._Proveedor.razonSocial;
                }
                else
                {
                    txtDocumento.Select();
                }
            }
        }//termina cargar datos de proveedor

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProductos())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.idProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.codigo;
                    txtNombreProducto.Text = modal._Producto.nombre;
                    txtPrecioCompra.Select();

                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }//Termina cargar datos de producto

        public bool validarCampos()
        {
            bool respuesta = true;
            string patron = @"[0-9]+$";

            if (expresion.validarPrecio(txtPrecioCompra.Text)!=true)
            {
                respuesta = false;
                MessageBox.Show("Precio de compra no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                  "Recuerde que son números del 0-9, un punto o no, y dos o tres dígitos decimales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCompra.BackColor = System.Drawing.Color.MistyRose;
            }
            

            if (expresion.validarCodigoProducto(txtCodigoProducto.Text) != true && (txtCodigoProducto.Text.Length <8 || txtCodigoProducto.Text.Length >13))
            {
                respuesta = false;
                MessageBox.Show("Codigo no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                  "Recuerde que son números del 0-9, un punto o no, y dos o tres dígitos decimales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoProducto.BackColor = System.Drawing.Color.MistyRose;
            }

            if (txtNombreProducto.Text == "")
            {
                respuesta = false;
                MessageBox.Show("Nombre no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreProducto.BackColor = System.Drawing.Color.MistyRose;
            }

            if (Regex.IsMatch(txtCantidad.Text,patron) != true)
            {
                respuesta = false;
                MessageBox.Show("Cantidad no valida, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                  "Recuerde que son números del 0-9.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.BackColor = System.Drawing.Color.MistyRose;
            }


            return respuesta;
        }
        private void calcularPrecioVenta()
        {
            decimal precioC, porcentaje, preciofinal;
            
               

                if (expresion.validarPrecio(txtPrecioCompra.Text) != true) { 
                    MessageBox.Show("Precio de compra no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                      "Recuerde que son números del 0-9, un punto o no, y dos o tres dígitos decimales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioCompra.BackColor = System.Drawing.Color.MistyRose;
                }
                else if (txtPorcentaje.Text == "")
                {
                        MessageBox.Show("Debes ingresar un porcentaje valido \nNo puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrecioVenta.BackColor = System.Drawing.Color.AliceBlue;
                        txtPorcentaje.Select();
                }
                else
                {
                    precioC = Convert.ToDecimal(txtPrecioCompra.Text);
                    porcentaje = Convert.ToDecimal(txtPorcentaje.Text);

                    preciofinal = precioC + ((precioC * porcentaje) / 100);

                    txtPrecioVenta.Text = Convert.ToString(preciofinal);

                    if (expresion.validarPrecio(txtPrecioVenta.Text) != true)
                    {
                        MessageBox.Show("Precio de venta no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                          "Recuerde que son números del 0-9, un punto o no, y dos o tres dígitos decimales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPrecioVenta.BackColor = System.Drawing.Color.MistyRose;
                    }
                 }
            
            
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            calcularPrecioVenta();
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto obj = new CN_Producto().listar().Where(p => p.codigo == txtCodigoProducto.Text && p.estado == true).FirstOrDefault();

                if (obj != null)
                {
                    txtCodigoProducto.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = obj.idProducto.ToString();
                    txtNombreProducto.Text = obj.nombre;
                    txtPrecioCompra.BackColor = System.Drawing.Color.AliceBlue;
                    txtPrecioCompra.Select();

                }
                else
                {
                    MessageBox.Show("!!!El producto buscado no existe o esta inactivo!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodigoProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtNombreProducto.Text = "";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false;

            bool respuesta = validarCampos();

            if (respuesta == true)
            {
                if (Convert.ToInt32(txtIdProducto.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
                {
                    MessageBox.Show("Precio de compra - Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioCompra.BackColor = System.Drawing.Color.MistyRose;
                    txtPrecioCompra.Select();
                    return;
                }
                if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("Precio de venta - Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioVenta.BackColor = System.Drawing.Color.MistyRose;
                    txtPrecioVenta.Select();
                    return;
                }

                foreach (DataGridViewRow fila in dgvUserData.Rows)
                {
                    if (fila.Cells["idProducto"].Value.ToString() == txtIdProducto.Text)
                    {
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {
                    dgvUserData.Rows.Add(new object[]
                    {
                    txtIdProducto.Text,
                    txtCodigoProducto.Text,
                    txtNombreProducto.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtCantidad.Text,
                    (Convert.ToInt32(txtCantidad.Text) * precioCompra).ToString("0.00"),
                    });

                    limpiarComponentes();
                    calcularTotal();
                }
            }

        }//termina método agregar a la tabla


        public void limpiarComponentes()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtCodigoProducto.BackColor = System.Drawing.Color.LightBlue;
            txtNombreProducto.Text = "";
            txtNombreProducto.BackColor = System.Drawing.Color.White;
            txtCantidad.Text = "1";
            txtPrecioCompra.Text = "";
            txtPrecioCompra.BackColor = System.Drawing.Color.White;
            txtPrecioVenta.Text = "";
            txtPorcentaje.Text = "10";
            txtPorcentaje.BackColor = System.Drawing.Color.White;
            txtIdProveedor.BackColor = System.Drawing.Color.White;
            txtCodigoProducto.Select();
        }//Termina método limpiar campos
         //

        public void limpiarTodo()
        {
            limpiarComponentes();
            txtIdProveedor.BackColor = System.Drawing.Color.White;
            txtIdProveedor.Text = "1";
            txtDocumento.Text = "00000000";
            txtRazonSocial.Text = "desconocido";
            txtRazonSocial.BackColor = System.Drawing.Color.White;
            dgvUserData.Rows.Clear();
            calcularTotal();
        }

        public void calcularTotal()
        {
            decimal total = 0;
            if (dgvUserData.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvUserData.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["subTotal"].Value.ToString());
                }

            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void dgvUserData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            

            
        }

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccion = e.RowIndex;
          
        }

        private void btnEliminar_2_Click(object sender, EventArgs e)
        {
            filaSeleccion = Convert.ToInt32(dgvUserData.SelectedRows.Count);


            if (filaSeleccion > 0)
            {

                if (filaSeleccionada >= 0)
                {
                    dgvUserData.Rows.RemoveAt(filaSeleccionada);
                    calcularTotal();
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//termina método eliminar de la tabla

        private void btnEditar_Click(object sender, EventArgs e)
        {
            filaSeleccion = Convert.ToInt32(dgvUserData.SelectedRows.Count);

            if (filaSeleccion > 0)
            {
                if (filaSeleccionada >= 0)
                {
                    txtIdProducto.Text = dgvUserData.Rows[filaSeleccionada].Cells["idProducto"].Value.ToString();
                    txtCodigoProducto.Text = dgvUserData.Rows[filaSeleccionada].Cells["codigo"].Value.ToString();
                    txtNombreProducto.Text = dgvUserData.Rows[filaSeleccionada].Cells["Producto"].Value.ToString();
                    txtPrecioCompra.Text = dgvUserData.Rows[filaSeleccionada].Cells["PrecioCompra"].Value.ToString();
                    txtPrecioVenta.Text = dgvUserData.Rows[filaSeleccionada].Cells["precioVenta"].Value.ToString();
                    txtCantidad.Text = dgvUserData.Rows[filaSeleccionada].Cells["cantidad"].Value.ToString();
                    txtPorcentaje.Text = "10";

                    dgvUserData.Rows.RemoveAt(filaSeleccionada);
                    calcularTotal();

                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            DataTable dt_Compra = new DataTable();

            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Debe ingresar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvUserData.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
              

                dt_Compra.Columns.Add("idProducto", typeof(int));
                dt_Compra.Columns.Add("precioCompra", typeof(decimal));
                dt_Compra.Columns.Add("precioVenta", typeof(decimal));
                dt_Compra.Columns.Add("cantidad", typeof(int));
                dt_Compra.Columns.Add("montoTotal", typeof(decimal));

                foreach (DataGridViewRow fila in dgvUserData.Rows)
                {
                    dt_Compra.Rows.Add(new object[]
                    {
                  Convert.ToInt32(fila.Cells["idProducto"].Value.ToString()),
                  fila.Cells["PrecioCompra"].Value.ToString(),
                  fila.Cells["precioVenta"].Value.ToString(),
                  fila.Cells["cantidad"].Value.ToString(),
                  fila.Cells["subTotal"].Value.ToString()

                    });
                }

                int idCorrelativo = new CN_Compra().obtenerCorrelativo();
                string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

                Compra objCompra = new Compra()
                {
                    objUsuario = new Usuario() { idUsuario = usuario.idUsuario },
                    objProveedor = new Proveedor() { idProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                    tipoDocumento = ((OpcionCombo)cboTipoDocumento.SelectedItem).texto,
                    numDocumento = numeroDocumento,
                    montoTotal = Convert.ToDecimal(txtTotalPagar.Text)
                };

                string mensaje = string.Empty;

                bool respuesta = new CN_Compra().registrarCompra(objCompra, dt_Compra, out mensaje);

                if (respuesta)
                {
                    var resultado = MessageBox.Show("Número de compra Generado: " + numeroDocumento + "¿Deseas copiar al portapapeles?\n\n",
                        "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        Clipboard.SetText(numeroDocumento);


                    }
                    
                    limpiarTodo();

                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            

            dt_Compra = null;
            txtCodigoProducto.Select();
            txtCodigoProducto.BackColor = System.Drawing.Color.LightBlue;
        }

        private void txtPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCantidad.Select();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPrecioVenta.Select();
            }
        }

        private void txtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnAgregar_Click(sender, e);
            }
        }
    }//Termina clase
}
