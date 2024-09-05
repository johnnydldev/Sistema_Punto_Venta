using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using PuntoVenta.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class frmUsuarios : Form
    {
       GeneradorDocumento objDocumento = new GeneradorDocumento();

        ER_Metodos expresion = new ER_Metodos();
        public frmUsuarios()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

       
        InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
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
            this.btnGenerarDocumento.Cursor = _customHandCursor;
            this.btnActualizar.Cursor = _customHandCursor;
            this.btnAgregar.Cursor = _customHandCursor;
            this.btnEliminar.Cursor = _customHandCursor;
            this.dgvUserData.Cursor = _customHandCursor;
            this.cboBuscar.Cursor = _customHandCursor;
            this.cbxEstado.Cursor = _customHandCursor;
            this.cbxRol.Cursor = _customHandCursor;
            this.txtDocumento.Cursor = _customCaretCursor;
            this.txtNombre.Cursor = _customCaretCursor;
            this.txtApodo.Cursor = _customCaretCursor;
            this.txtCorreo.Cursor = _customCaretCursor;
            this.txtConfirmarContraseña.Cursor = _customCaretCursor;
            this.txtContraseña.Cursor = _customCaretCursor;
            this.txtBuscar.Cursor = _customCaretCursor;

            txtId.Text = Convert.ToString(new CN_Usuario().obtenerId());
            txtId.Visible = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            lblIndiceTabla.Visible = false;

            cbxEstado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cbxEstado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cbxEstado.DisplayMember = "texto";
            cbxEstado.ValueMember = "valor";
            cbxEstado.SelectedIndex = 0;

            List<Rol> listRol = new CN_Rol().listar();
            
            foreach (Rol item in listRol) {
                cbxRol.Items.Add(new OpcionCombo() { valor = item.idRol, texto = item.descripcion });
            }
            cbxRol.DisplayMember = "texto";
            cbxRol.ValueMember = "valor";
            cbxRol.SelectedIndex = 0;
            cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;



            foreach  (DataGridViewColumn colums in dgvUserData.Columns)
            {
                if (colums.Visible==true && colums.Name != "btnSeleccionar")
                {
                    cboBuscar.Items.Add(new OpcionCombo { valor = colums.Name, texto = colums.HeaderText });
                }

            }
            cboBuscar.DisplayMember = "texto";
            cboBuscar.ValueMember = "valor";
            cboBuscar.SelectedIndex = 0;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Mostrar Los datos de los usuarios en la tabla
            cargarTabla();


        }//termina evento load

        private void cargarTabla()
        {
            //Mostrar Los datos de los usuarios en la tabla
            List<Usuario> listUsuario = new CN_Usuario().listar();

            foreach (Usuario item in listUsuario)
            {
                dgvUserData.Rows.Add(new object[]
            {
                "",
                item.idUsuario,
                item.documento,
                item.apodo,
                item.nombre,
                item.correo,
                item.clave,
                item.objRol.idRol,
                item.objRol.descripcion,
                item.estado == true ? 1 : 0,
                item.estado == true ? "Activo" : "Inactivo"
            });
            }
        }//Termina cagar tabla
        private void limpiarOpciones()
        {
            lblIndiceTabla.Text = "-1";
            txtId.Text = Convert.ToString(new CN_Usuario().obtenerId());
            txtDocumento.Text = "";
            txtDocumento.Enabled = true;
            txtApodo.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
            cbxRol.SelectedIndex = 0;
            cbxEstado.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

        }//Termina metodo limpiar opciones
        private void restaurarComponentes()
        {
            txtApodo.BackColor = System.Drawing.Color.White;
            txtDocumento.BackColor = System.Drawing.Color.White;
            txtNombre.BackColor = System.Drawing.Color.White;
            txtConfirmarContraseña.BackColor = System.Drawing.Color.White;
            txtContraseña.BackColor = System.Drawing.Color.White;
            txtCorreo.BackColor = System.Drawing.Color.White;
            txtBuscar.BackColor = System.Drawing.Color.White;
        }//termina restaurar componentes
        private bool estadoBandera()
        {
            int valor = 0;
            valor = Convert.ToInt32(((OpcionCombo)cbxEstado.SelectedItem).valor);
            bool estadoBandera = false;

            if (valor == 1)
            {
                estadoBandera = true;
            }
            else if(valor == 0)
            {
                estadoBandera = false;
            }
            else
            {
                MessageBox.Show("Valores enviados, verifique los datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return estadoBandera;
        }//termina estado bandera
        
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

            if (expresion.validarSoloLetras(txtApodo.Text) != true)
            {
                MessageBox.Show("Apodo no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApodo.Select();
                txtApodo.BackColor = System.Drawing.Color.MistyRose;
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
            bool res = txtContraseña.Text.Equals(txtConfirmarContraseña.Text);

            if (txtContraseña.Text == "") {
                MessageBox.Show("Debe ingresar una contraseña, no puede ser vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Select();
                txtContraseña.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }
            else
            {
                if (!res)
                {
                    MessageBox.Show("La contraseña no coincide", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmarContraseña.Select();
                    txtConfirmarContraseña.BackColor = System.Drawing.Color.MistyRose;
                    respuesta = false;
                }
            }
           

            return respuesta;
        }//termina Validar campos
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            bool estado = estadoBandera();
            int rolValor = Convert.ToInt32(((OpcionCombo)cbxRol.SelectedItem).valor);
           
            if(rolValor != 1 || rolValor != 0)
            {
                MessageBox.Show("Rol no valido", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Usuario objUsuario = new Usuario();

            bool validacion = validarCampos();

            if (validacion == true)
            {
                
                objUsuario.idUsuario = Convert.ToInt32(txtId.Text);
                objUsuario.documento = txtDocumento.Text;
                objUsuario.apodo = txtApodo.Text;
                objUsuario.nombre = txtNombre.Text;
                objUsuario.correo = txtCorreo.Text;
                objUsuario.clave = txtContraseña.Text;
                objUsuario.objRol = new Rol() { idRol = rolValor };
                objUsuario.estado = estado;

                int usuarioGenerado = new CN_Usuario().registrar(objUsuario, out mensaje);


                if (usuarioGenerado != 0)
                {
                    limpiarOpciones();
                    restaurarComponentes();
                    dgvUserData.Rows.Clear();
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

       

        }//Termina Método Agregar

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }//Termina Método 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (Convert.ToInt32(txtId.Text) == 1)
                {
                    MessageBox.Show("No puedes eliminar el usuario predeterminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarOpciones();
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Estas seguro que deseas eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;
                        Usuario objUsuario = new Usuario()
                        {
                            idUsuario = Convert.ToInt32(txtId.Text)
                        };
                        bool resultado = new CN_Usuario().eliminar(objUsuario, out mensaje);

                        if (resultado)
                        {
                            limpiarOpciones();
                            btnAgregar.Enabled = true;
                            btnEliminar.Enabled = false;
                            btnActualizar.Enabled = false;

                            dgvUserData.Rows.Clear();
                            cargarTabla();
                        
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
           
        }//Termina Método Eliminar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();

            bool validacion = validarCampos();

            Usuario objUsuario = new Usuario();

            if (validacion)
            {
                objUsuario.idUsuario = Convert.ToInt32(txtId.Text);
                objUsuario.documento = txtDocumento.Text;
                objUsuario.apodo = txtApodo.Text;
                objUsuario.nombre = txtNombre.Text;
                objUsuario.correo = txtCorreo.Text;
                objUsuario.clave = txtContraseña.Text;
                objUsuario.objRol = new Rol() { idRol = Convert.ToInt32(((OpcionCombo)cbxRol.SelectedItem).valor) };
                objUsuario.estado = estado;

                bool resultado = new CN_Usuario().editar(objUsuario, out mensaje);

                if (resultado)
                {
                   limpiarOpciones();
                   restaurarComponentes();

                    dgvUserData.Rows.Clear();
                    cargarTabla();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }

        }//Termina metodo actualizar

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
            
        }

        private void dgvUserData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex <0)
                return;
            

            if (e.ColumnIndex == 0) 
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.lapiz_.Width;
                var h = Properties.Resources.lapiz_.Height;

                var x  = e.CellBounds.Left + (e.CellBounds.Width - w ) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.lapiz_, new Rectangle(x,y, w, h));
                e.Handled = true;
            }

        }

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    lblIndiceTabla.Text = indice.ToString();
                    txtId.Text = dgvUserData.Rows[indice].Cells["idUsuario"].Value.ToString();
                    txtDocumento.Text = dgvUserData.Rows[indice].Cells["documento"].Value.ToString();
                    txtApodo.Text = dgvUserData.Rows[indice].Cells["apodo"].Value.ToString();
                    txtNombre.Text = dgvUserData.Rows[indice].Cells["nombre"].Value.ToString();
                    txtCorreo.Text = dgvUserData.Rows[indice].Cells["correo"].Value.ToString();
                    txtContraseña.Text = dgvUserData.Rows[indice].Cells["contrasenia"].Value.ToString();
                    txtConfirmarContraseña.Text = dgvUserData.Rows[indice].Cells["contrasenia"].Value.ToString();

                    foreach (OpcionCombo item in cbxRol.Items)
                    {
                        if(Convert.ToInt32(item.valor) == Convert.ToInt32(dgvUserData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cbxRol.Items.IndexOf(item);
                            cbxRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo item in cbxEstado.Items)
                    {
                        if (Convert.ToInt32(item.valor) == Convert.ToInt32(dgvUserData.Rows[indice].Cells["estadoValor"].Value))
                        {
                            int indice_combo = cbxEstado.Items.IndexOf(item);
                            cbxEstado.SelectedIndex = indice_combo;
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
        }//termina Evento CEll Content dgvUserData

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("El buscador no debe estar vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Select();
                txtBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            else
            {
                string columnaFiltro = ((OpcionCombo)cboBuscar.SelectedItem).valor.ToString();


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
            
            
        }//termina Metodo Buscar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                fila.Visible=true;
            }

        }
    }
}
