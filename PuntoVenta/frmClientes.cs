using CapaEntidad;
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
    public partial class frmClientes : Form
    {
        GeneradorDocumento objDocumento = new GeneradorDocumento();
        ER_Metodos expresion = new ER_Metodos();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(new CN_Cliente().obtenerId());
            txtId.Enabled = false;
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
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Mostrar Los datos de los clientes en la tabla
            List<Cliente> lista = new CN_Cliente().listar();

            foreach (Cliente item in lista)
            {
                dgvUserData.Rows.Add(new object[]
            {
                "",
                item.idCliente,
                item.documento,
                item.nombre,
                item.correo,
                item.telefono,
                item.estado == true ? 1 : 0,
                item.estado == true ? "Activo" : "Inactivo"
            });
            }
        }//Termina evento load

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
                MessageBox.Show("Telefono no valido, el formato no es correcto.\nSolo se permiten 11 números, entre 0-9", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Select();
                txtTelefono.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }


            if (expresion.validarDocumento(txtDocumento.Text) != true)
            {

                MessageBox.Show("Documento no valido, solo se permiten números, formato incorrecto de caracteres.\n" +
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


            Cliente obj = new Cliente();

            if (validacion == true)
            {
                obj.idCliente = Convert.ToInt32(txtId.Text);
                obj.documento = txtDocumento.Text;
                obj.nombre = txtNombre.Text;
                obj.correo = txtCorreo.Text;
                obj.telefono = txtTelefono.Text;
                obj.estado = estado;


                int clienteGenerado = new CN_Cliente().registrar(obj, out mensaje);


                if (clienteGenerado != 0)
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
                if (Convert.ToInt32(txtId.Text)==1)
                {
                    MessageBox.Show("No puedes eliminar este usuario, es el usuario predeterminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que deseas eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Cliente obj = new Cliente()
                        {
                            idCliente = Convert.ToInt32(txtId.Text)
                        };
                        bool resultado = new CN_Cliente().eliminar(obj, out mensaje);

                        if (resultado)
                        {
                            dgvUserData.Rows.RemoveAt(Convert.ToInt32(lblIndiceTabla.Text));
                            limpiarOpciones();
                            restaurarCampos();
                            btnAgregar.Enabled = true;
                            btnEliminar.Enabled = false;
                            btnActualizar.Enabled = false;
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

            Cliente obj = new Cliente();

            if (validacion == true)
            {
                if (Convert.ToInt32(txtId.Text)==1)
                {
                    MessageBox.Show("No puedes editar el Cliente predeterminado", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    obj.idCliente = Convert.ToInt32(txtId.Text);
                    obj.documento = txtDocumento.Text;
                    obj.nombre = txtNombre.Text;
                    obj.correo = txtCorreo.Text;
                    obj.telefono = txtTelefono.Text;
                    obj.estado = estado;

                    bool resultado = new CN_Cliente().editar(obj, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow fila = dgvUserData.Rows[Convert.ToInt32(lblIndiceTabla.Text)];
                        fila.Cells["idCliente"].Value = txtId.Text;
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
           
        }//Termina método limpiar casillas de información

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).valor.ToString();

            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingresa información valida, el campo no puede estar vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscar.BackColor = System.Drawing.Color.LightBlue;
                txtBuscar.Select();
                return;

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

           
        }//Termina método buscar clientes

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
                    txtId.Text = dgvUserData.Rows[indice].Cells["idCliente"].Value.ToString();
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

        }//Termina evento paa cargar los datos de edición

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
        }//Termina evento para agregar botón editar


    }//Termina clase 
}
