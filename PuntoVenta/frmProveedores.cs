﻿using CapaEntidad;
using CapaNegocio;
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
    public partial class frmProveedores : Form
    {

        GeneradorDocumento objDocumento = new GeneradorDocumento();
        ER_Metodos expresion = new ER_Metodos();
        public frmProveedores()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

       
        InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.gbtnOpciones.Cursor = _customCutCursor;
            this.btnLimpiar.Cursor = _customHandCursor;
            this.btnAgregar.Cursor = _customHandCursor;
            this.btnActualizar.Cursor = _customHandCursor;
            this.btnEliminar.Cursor = _customHandCursor;
            this.btnGenerarDocumento.Cursor = _customHandCursor;
            this.btnLimpiarCasillas.Cursor = _customHandCursor;
            this.btnBuscar.Cursor = _customHandCursor;
            this.cboBuscar.Cursor = _customHandCursor;
            this.cboEstado.Cursor = _customHandCursor;
            this.dgvUserData.Cursor = _customHandCursor;
            this.txtBuscar.Cursor = _customCaretCursor;
            this.txtCorreo.Cursor = _customCaretCursor;
            this.txtDocumento.Cursor = _customCaretCursor;
            this.txtNombre.Cursor = _customCaretCursor;
            this.txtTelefono.Cursor = _customCaretCursor;


            txtId.Text = Convert.ToString(new CN_Proveedor().obtenerId());
            txtId.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lblIndiceTabla.Visible = false;

            cboEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cboEstado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cboEstado.DisplayMember = "texto";
            cboEstado.ValueMember = "valor";
            cboEstado.SelectedIndex = 0;


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
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Mostrar Los datos de los clientes en la tabla
            List<Proveedor> lista = new CN_Proveedor().listar();

            foreach (Proveedor item in lista)
            {
                dgvUserData.Rows.Add(new object[]
                {
                    "",
                    item.idProveedor,
                    item.documento,
                    item.razonSocial,
                    item.correo,
                    item.telefono,
                    item.estado == true ? 1 : 0,
                    item.estado == true ? "Activo" : "Inactivo"
                });
            }

        }//Termina cargador de datos

        private void limpiarOpciones()
        {
            lblIndiceTabla.Text = "-1";
            txtId.Text = Convert.ToString(new CN_Cliente().obtenerId());
            txtDocumento.Text = "";
            txtDocumento.Enabled = true;
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

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

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            GeneradorDocumento nuevo = new GeneradorDocumento();

            if (txtDocumento.Text != "")
            {
                txtDocumento.Text = "";
                txtDocumento.Text = nuevo.generadorDocumento();
            }
            else
            {
                txtDocumento.Text = objDocumento.generadorDocumento();
            }
        }//Termina método generar documento

        public bool validarCampos()
        {
            bool correoValido = ER_Metodos.IsValidEmail(txtCorreo.Text);
            bool respuesta = true;

            if (correoValido != true)
            {
                MessageBox.Show("Correo Electronico no valido, el formato no es correcto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Select();
                txtCorreo.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

            if (expresion.validarSoloLetras(txtNombre.Text) != true)
            {
                MessageBox.Show("Nombre no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Select();
                txtNombre.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }

            if (expresion.validarTelefono(txtTelefono.Text) != true)
            {
                MessageBox.Show("Telefono no valido, el formato no es correcto.\nSolo se permiten 11 números aleatorios, entre 0-9\n Sin lada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Select();
                txtTelefono.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }


            if (expresion.validarDocumento(txtDocumento.Text) != true)
            {

                MessageBox.Show("Documento no valido, solo se permiten numeros, formato incorrecto de caracteres.\n" +
                    "Recuerde que son 8 números aleatorios entre 0-9.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Select();
                txtDocumento.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }


            return respuesta;
        }//termina Validar campos

        public void restaurarCampos()
        {
            txtBuscar.BackColor = System.Drawing.Color.White;
            txtDocumento.BackColor = System.Drawing.Color.White;
            txtNombre.BackColor = System.Drawing.Color.White;
            txtCorreo.BackColor = System.Drawing.Color.White;
            txtTelefono.BackColor = System.Drawing.Color.White;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();


            bool validacion = validarCampos();


            Proveedor obj = new Proveedor();

            if (validacion == true)
            {

                obj.idProveedor = Convert.ToInt32(txtId.Text);
                obj.documento = txtDocumento.Text;
                obj.razonSocial = txtNombre.Text;
                obj.correo = txtCorreo.Text;
                obj.telefono = txtTelefono.Text;
                obj.estado = estado;


                int ProveedorGenerado = new CN_Proveedor().registrar(obj, out mensaje);


                if (ProveedorGenerado != 0)
                {
                    dgvUserData.Rows.Add(new object[]
                    {
                    "",
                    txtId.Text,
                    txtDocumento.Text,
                    txtNombre.Text,
                    txtCorreo.Text,
                    txtTelefono.Text,
                    ((OpcionCombo) cboEstado.SelectedItem).valor.ToString(),
                    ((OpcionCombo) cboEstado.SelectedItem).texto.ToString()
                    });
                    limpiarOpciones();
                    restaurarCampos();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }//Termina método agregar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (Convert.ToInt32(txtId.Text) == 1)
                {
                    MessageBox.Show("No puedes eliminar este proveedor, es el proveedor predeterminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que deseas eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Proveedor obj = new Proveedor()
                        {
                            idProveedor = Convert.ToInt32(txtId.Text)
                        };
                        bool resultado = new CN_Proveedor().eliminar(obj, out mensaje);

                        if (resultado)
                        {
                            dgvUserData.Rows.RemoveAt(Convert.ToInt32(lblIndiceTabla.Text));
                            limpiarOpciones();
                            restaurarCampos();
                            btnAgregar.Enabled = true;
                            btnEliminar.Enabled = false;
                            btnActualizar.Enabled = false;
                            btnEliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
           

        }//Termina método eliminar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();
            bool validacion = validarCampos();

            Proveedor obj = new Proveedor();

            if (validacion)
            {

                if (Convert.ToInt32(txtId.Text) == 1)
                {
                    MessageBox.Show("No puedes editar el Proveedor predeterminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    obj.idProveedor = Convert.ToInt32(txtId.Text);
                    obj.documento = txtDocumento.Text;
                    obj.razonSocial = txtNombre.Text;
                    obj.correo = txtCorreo.Text;
                    obj.telefono = txtTelefono.Text;
                    obj.estado = estado;

                    bool resultado = new CN_Proveedor().editar(obj, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow fila = dgvUserData.Rows[Convert.ToInt32(lblIndiceTabla.Text)];
                        fila.Cells["idProveedor"].Value = txtId.Text;
                        fila.Cells["documento"].Value = txtDocumento.Text;
                        fila.Cells["nombre"].Value = txtNombre.Text;
                        fila.Cells["correo"].Value = txtCorreo.Text;
                        fila.Cells["telefono"].Value = txtTelefono.Text;
                        fila.Cells["estadoValor"].Value = ((OpcionCombo)cboEstado.SelectedItem).valor.ToString();
                        fila.Cells["estado"].Value = ((OpcionCombo)cboEstado.SelectedItem).texto.ToString();
                        limpiarOpciones();
                        restaurarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }

        }//Termina método actualizar

        private void btnLimpiarCasillas_Click(object sender, EventArgs e)
        {
            limpiarOpciones();
            restaurarCampos();
        }//Termina método limpiar casillas

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).valor.ToString();
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese información para buscar, no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
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

            
        }//Termina método buscar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                fila.Visible = true;
            }
        }//Termina método limpiar buscador

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    lblIndiceTabla.Text = indice.ToString();
                    txtId.Text = dgvUserData.Rows[indice].Cells["idProveedor"].Value.ToString();
                    txtDocumento.Text = dgvUserData.Rows[indice].Cells["documento"].Value.ToString();
                    txtNombre.Text = dgvUserData.Rows[indice].Cells["nombre"].Value.ToString();
                    txtCorreo.Text = dgvUserData.Rows[indice].Cells["correo"].Value.ToString();
                    txtTelefono.Text = dgvUserData.Rows[indice].Cells["telefono"].Value.ToString();



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
            txtDocumento.Enabled = false;
            txtId.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;

        }//Termina evento cargar datos de edición

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
        }//Termina evento cargar botón editar




    }//Termina Clase
}
