using CapaEntidad;
using CapaNegocio;
using PuntoVenta.Herramientas;
using PuntoVenta.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
//using JR.Utils.GUI.Forms;

namespace PuntoVenta
{
    public partial class frmVentas : Form
    {
        public int filaSeleccion;
        public int filaSeleccionada;

        private Usuario usuario;

        public Respuesta _mensaje;

        ER_Metodos expresion = new ER_Metodos();
        public frmVentas(Usuario objUsuario = null)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

       
        usuario = objUsuario;
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.btnAgregar.Cursor = _customHandCursor;
            this.btnEditar.Cursor = _customHandCursor;
            this.btnEliminar_2.Cursor = _customHandCursor;
            this.btnRegistrar.Cursor = _customHandCursor;
            this.btnBuscarProducto.Cursor = _customHandCursor;
            this.btnBuscarCliente.Cursor = _customHandCursor;
            this.cboTipoDocumento.Cursor = _customHandCursor;
            this.txtCantidad.Cursor = _customCaretCursor;
            this.txtCambio.Cursor = _customCaretCursor;
            this.txtNombreProducto.Cursor = _customCaretCursor;
            this.txtPago.Cursor = _customCaretCursor;
            this.txtPrecioVenta.Cursor = _customCaretCursor;
            this.txtTotalPagar.Cursor = _customCaretCursor;
            this.txtCodigoProducto.Cursor = _customCaretCursor;
            this.txtStock.Cursor = _customCaretCursor;
            this.dgvUserData.Cursor = _customHandCursor;

            cboTipoDocumento.Items.Add(new OpcionCombo() { valor = "Recibo", texto = "Recibo" });
            cboTipoDocumento.Items.Add(new OpcionCombo() { valor = "Factura", texto = "Factura" });
            cboTipoDocumento.DisplayMember = "texto";
            cboTipoDocumento.ValueMember = "valor";
            cboTipoDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProducto.Text = "0";
            txtIdProducto.Visible = false;
            txtIdProducto.Enabled = false;
            txtIdCliente.Enabled = false;
            txtIdCliente.Visible = false;
            txtCantidad.Text = "1"; 
            txtTotalPagar.Text = "";
            txtCambio.Text = "0";
            txtPago.Text = "0";
            txtTotalPagar.BackColor = System.Drawing.Color.LimeGreen;
            txtTotalPagar.Enabled = false;
            txtIdCliente.Text = "1";
            txtDocumentoCliente.Text = "00000000";
            txtNombreCliente.Text = "desconocido";
            txtCodigoProducto.Select();
            txtFecha.Enabled = false;
            txtDocumentoCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtStock.Enabled = false;
            txtNombreProducto.BackColor = System.Drawing.Color.White;
            txtPrecioVenta.BackColor = System.Drawing.Color.White;
            txtFecha.BackColor = System.Drawing.Color.White;

        }//Termina load

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var resultado = modal.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtIdCliente.Text = modal._Cliente.idCliente.ToString();
                    txtDocumentoCliente.Text = modal._Cliente.documento;
                    txtNombreCliente.Text = modal._Cliente.nombre;
                    txtCodigoProducto.Select();
                }
                else
                {
                    txtDocumentoCliente.Select();
                }
            }
        }//Termina buscar Cliente
        public bool validarCampos()
        {
            bool respuesta = true;
            string patron = @"[0-9]+$";

            if (expresion.validarPrecio(txtPrecioVenta.Text) != true)
            {
                respuesta = false;
                MessageBox.Show("Precio de venta no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                  "Recuerde que son números del 0-9, un punto o no, y dos o tres dígitos decimales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioVenta.BackColor = System.Drawing.Color.MistyRose;
            }


            if (expresion.validarCodigoProducto(txtCodigoProducto.Text) != true)
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

            if (Regex.IsMatch(txtCantidad.Text, patron) != true)
            {
                respuesta = false;
                MessageBox.Show("Cantidad no valida, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                  "Recuerde que son números del 0-9.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.BackColor = System.Drawing.Color.MistyRose;
            }


            return respuesta;
        }
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
                    txtPrecioVenta.Text = modal._Producto.precioVenta.ToString();
                    txtStock.Text = modal._Producto.stock.ToString();
                    txtPrecioVenta.Select();

                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }//termina método Buscar Producto

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
                    txtPrecioVenta.Text = obj.precioVenta.ToString();
                    txtPrecioVenta.BackColor = System.Drawing.Color.AliceBlue;
                    txtStock.Text = obj.stock.ToString();
                    txtPrecioVenta.Select();

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

            bool respuesta = validarCampos();

            if (respuesta == true)
            {
                if (Convert.ToInt32(txtIdProducto.Text) == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
                {
                    MessageBox.Show("Precio de compra - Formato de moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioVenta.BackColor = System.Drawing.Color.MistyRose;
                    txtPrecioVenta.Select();
                    return;
                }

                if (Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(txtStock.Text) )
                {
                    MessageBox.Show("Cantidad no valida, la cantidad de venta no puede ser mayor a la existencia de productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.BackColor = System.Drawing.Color.MistyRose;
                    txtCantidad.Select();
                    return;
                }

               
                        dgvUserData.Rows.Add(new object[]
                        {
                            txtIdProducto.Text,
                            txtCodigoProducto.Text,
                            txtNombreProducto.Text,
                            txtPrecioVenta.Text,
                            txtCantidad.Text,
                            (Convert.ToInt32(txtCantidad.Text) * Convert.ToDecimal(txtPrecioVenta.Text)).ToString("0.00"),
                            txtStock.Text,
                        });

                        limpiarComponentes();
                        calcularTotal();
                        txtCodigoProducto.Select();
                    
                
            }
        }//termina Agregar

        public void limpiarComponentes()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtCodigoProducto.BackColor = System.Drawing.Color.White;
            txtNombreProducto.Text = "";
            txtNombreProducto.BackColor = System.Drawing.Color.White;
            txtCantidad.Text = "1";
            txtCantidad.BackColor = System.Drawing.Color.White;
            txtPrecioVenta.Text = "";
            txtPrecioVenta.BackColor = System.Drawing.Color.White;
            txtPrecioVenta.Text = "";
            txtStock.Text = "0";
        }
        public void limpiarTodo()
        {
            limpiarComponentes();
            txtDocumentoCliente.Text = "00000000";
            txtNombreCliente.Text = "desconocido";
            txtIdCliente.Text = "1";
            dgvUserData.Rows.Clear();
            calcularTotal();
            txtCodigoProducto.Select();
            txtCodigoProducto.BackColor = System.Drawing.Color.LightBlue;
        }//

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
        }//termina calcular total

        private void btnEliminar_2_Click(object sender, EventArgs e)
        {
            filaSeleccion = Convert.ToInt32(dgvUserData.SelectedRows.Count);
            

            if (filaSeleccion > 0)
            {
                
                if (filaSeleccionada >= 0)
                {
                  
                        dgvUserData.Rows.RemoveAt(filaSeleccionada);
                        calcularTotal();
                        calcularCambio();
                    
                   
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
                        txtPrecioVenta.Text = dgvUserData.Rows[filaSeleccionada].Cells["precioVenta"].Value.ToString();
                        txtCantidad.Text = dgvUserData.Rows[filaSeleccionada].Cells["cantidad"].Value.ToString();
                        txtStock.Text = dgvUserData.Rows[filaSeleccionada].Cells["existencia"].Value.ToString();
                        dgvUserData.Rows.RemoveAt(filaSeleccionada);
                        calcularTotal();
                        calcularCambio();
                    
                   
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

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = Convert.ToInt32(dgvUserData.CurrentCell.RowIndex);
        }

        private void dgvUserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = Convert.ToInt32(dgvUserData.CurrentCell.RowIndex);
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPago.Text.Trim().Length == 0 && e.KeyChar.ToString()== ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString()== ".")
                    {
                        e.Handled= false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularCambio()
        {
            if (txtTotalPagar.Text.Trim() == "")
            {
                MessageBox.Show("No hay productos en la venta.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal pago;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if (txtPago.Text.Trim() == "")
            {
                txtPago.Text = "0";
            }


            if (decimal.TryParse(txtPago.Text.Trim(), out pago))
            {
                if (pago < total)
                {
                    txtPago.Text = "0.00";
                    MessageBox.Show("Debe ingresar un monto de pago valido, no puede ser vacio ni menor al monto total de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    decimal cambio = pago - total;
                  
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }

        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
                btnRegistrar_Click(sender, e);
            }
        }

      

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(dgvUserData.Rows.Count < 1)
            {
                MessageBox.Show("Debes Ingresar productos a la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataTable dtVenta = new DataTable();

            dtVenta.Columns.Add("idProducto", typeof(int));
            dtVenta.Columns.Add("precioVenta", typeof(decimal));
            dtVenta.Columns.Add("cantidad", typeof(int));
            dtVenta.Columns.Add("subTotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                dtVenta.Rows.Add(new object[]
                {
                  Convert.ToInt32(fila.Cells["idProducto"].Value.ToString()),
                  fila.Cells["precioVenta"].Value.ToString(),
                  fila.Cells["cantidad"].Value.ToString(),
                  fila.Cells["subTotal"].Value.ToString()

                });
            }

           

            if (Convert.ToDecimal(txtPago.Text) < Convert.ToDecimal(txtTotalPagar.Text))
            {
                MessageBox.Show("La cantidad de pago no puede ser menor al total a pagar, ingresa una cantidad valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtPago.Select();
                txtPago.BackColor = System.Drawing.Color.LightBlue;
                return;
            }
            else
            {
                int idCorrelativo = new CN_Venta().obtenerCorrelativo();
                string numeroDocumento = string.Format("{0:00000}", idCorrelativo);
                calcularCambio();

                Venta objVenta = new Venta();
                objVenta.objUsuario = new Usuario() { idUsuario = usuario.idUsuario };
                objVenta.tipoDocumento = ((OpcionCombo)cboTipoDocumento.SelectedItem).texto;
                objVenta.numeroDocumento = numeroDocumento;
                objVenta.documentoCliente = txtDocumentoCliente.Text;
                objVenta.nombreCliente = txtNombreCliente.Text;
                objVenta.montoPago = Convert.ToDecimal(txtPago.Text);
                objVenta.montoCambio = Convert.ToDecimal(txtCambio.Text);
                objVenta.montoTotal = Convert.ToDecimal(txtTotalPagar.Text);

                string mensaje = string.Empty;

                bool respuesta = new CN_Venta().registrarVenta(objVenta, dtVenta, out mensaje);

                if (respuesta)
                {
                    //MessageBox.Show("Su cambio es: " + txtCambio.Text, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // myMessageBox("Su cambio es: " + txtCambio.Text);
                    

                    mdRespuesta nuevo = new mdRespuesta(txtCambio.Text);
                    nuevo.Show();

                    /*
                    var resultado = MessageBox.Show("Número de venta Generado: " + numeroDocumento + "¿Deseas copiar al portapapeles?\n\n",
                        "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        Clipboard.SetText(numeroDocumento);
                    }*/

                    limpiarTodo();
                    txtCambio.Text = "0";
                    txtPago.Text = "";
                    txtPago.BackColor = System.Drawing.Color.White;

                }
                else
                {
                  
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
                }
            }
            
        }

        private void txtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
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
                btnAgregar_Click(sender, e);
            }
        }
    }//Termina clase
}//namespace
