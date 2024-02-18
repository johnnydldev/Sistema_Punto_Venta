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
    public partial class frmCategoria : Form
    {
        ER_Metodos expresion = new ER_Metodos();
        public frmCategoria()
        {
            InitializeComponent();
        }

        public bool validarCampos()
        {
            bool respuesta = true;

            

            if (expresion.validarSoloLetras(txtDescripcion.Text) != true)
            {
                MessageBox.Show("Nombre no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcion.Select();
                txtDescripcion.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }


            return respuesta;
        }//termina Validar campos

        public void restaurarCampos()
        {
            txtBuscar.BackColor = System.Drawing.Color.White;
            txtDescripcion.BackColor = System.Drawing.Color.White;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();

            bool validacion = validarCampos();

            Categoria objCat = new Categoria();

            if (validacion == true)
            {
                objCat.idCategoria = Convert.ToInt32(txtId.Text);
                objCat.descripcion = txtDescripcion.Text;
                objCat.estado = estado;


                int CatGenerada = new CN_Categoria().registrar(objCat, out mensaje);


                if (CatGenerada != 0)
                {
                    dgvUserData.Rows.Add(new object[]
                    {
                    "",
                    txtId.Text,
                    txtDescripcion.Text,
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


        }//Termina Método Agregar

        private void btnLimpiarCasillas_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            cboEstado.SelectedIndex = 0;
            restaurarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Estas seguro que deseas eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                   Categoria objCat = new Categoria()
                    {
                        idCategoria = Convert.ToInt32(txtId.Text)
                    };
                    bool resultado = new CN_Categoria().eliminar(objCat, out mensaje);

                    if (resultado)
                    {
                        dgvUserData.Rows.RemoveAt(Convert.ToInt32(lblIndiceTabla.Text));
                        limpiarOpciones();
                        restaurarCampos();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }//Termina método eliminar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool estado = estadoBandera();

            bool validacion = validarCampos();
            Categoria objCat = new Categoria();

            if (validacion)
            {
                objCat.idCategoria = Convert.ToInt32(txtId.Text);
                objCat.descripcion = txtDescripcion.Text;
                objCat.estado = estado;


                bool CatGenerada = new CN_Categoria().editar(objCat, out mensaje);


                if (CatGenerada)
                {
                    DataGridViewRow fila = dgvUserData.Rows[Convert.ToInt32(lblIndiceTabla.Text)];
                    fila.Cells["idCategoria"].Value = txtId.Text;
                    fila.Cells["descripcion"].Value = txtDescripcion.Text;
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
         


        }//termina método actualizar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingresa un dato en la casilla, No se puede buscar un dato vacio.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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
        }//Termina método buscar

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                fila.Visible = true;
            }
        }//Termina método limpiar

        private void limpiarOpciones()
        {
            lblIndiceTabla.Text = "-1";
            txtId.Text = Convert.ToString(new CN_Categoria().obtenerIdCategoria());
            txtDescripcion.Text = "";
            txtDescripcion.Enabled = true;
            cboEstado.SelectedIndex = 0;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;

        }//Termna método para limpiar datos

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
        }//Termina metodo para capturar el estado de la categoria

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(new CN_Categoria().obtenerIdCategoria());
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

            //Mostrar Los datos de la categoria en la tabla
            List<Categoria> listCat = new CN_Categoria().listar();

            foreach (Categoria item in listCat)
            {
                dgvUserData.Rows.Add(new object[]
            {
                "",
                item.idCategoria,
                item.descripcion,
                item.estado == true ? 1 : 0,
                item.estado == true ? "Activo" : "Inactivo"
            });
            }
        }//Inicializador de componentes del frm

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    lblIndiceTabla.Text = indice.ToString();
                    txtId.Text = dgvUserData.Rows[indice].Cells["idCategoria"].Value.ToString();
                    txtDescripcion.Text = dgvUserData.Rows[indice].Cells["descripcion"].Value.ToString();

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
            txtId.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

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
        }
    }
}
