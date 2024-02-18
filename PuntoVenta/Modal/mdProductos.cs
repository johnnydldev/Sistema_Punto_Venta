using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta.Modal
{
    public partial class mdProductos : Form
    {

        public Producto _Producto;
         int filaSeleccionada;
         int columnaSelecionada;
        public mdProductos()
        {
            InitializeComponent();
        }

        private void mdProductos_Load(object sender, EventArgs e)
        {
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

            //Mostrar Los datos de los usuarios en la tabla
            List<Producto> list = new CN_Producto().listar();

            foreach (Producto item in list)
            {
                dgvUserData.Rows.Add(new object[]
            {
                item.idProducto,
                item.codigo,
                item.nombre,
                item.descripcion,
                item.stock,
                item.precioCompra,
                item.precioVenta
            });
            }
        }

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = Convert.ToInt32(dgvUserData.CurrentRow.Index);
            columnaSelecionada = e.ColumnIndex;

            if (filaSeleccionada >= 0 && columnaSelecionada >= 0)
            {
                _Producto = new Producto()
                {
                    idProducto = Convert.ToInt32(dgvUserData.Rows[filaSeleccionada].Cells["idProducto"].Value.ToString()),
                    codigo = dgvUserData.Rows[filaSeleccionada].Cells["codigo"].Value.ToString(),
                    nombre = dgvUserData.Rows[filaSeleccionada].Cells["nombre"].Value.ToString(),
                    descripcion = dgvUserData.Rows[filaSeleccionada].Cells["descripcion"].Value.ToString(),
                    stock = Convert.ToInt32( dgvUserData.Rows[filaSeleccionada].Cells["stock"].Value.ToString()),
                    precioCompra = Convert.ToDecimal( dgvUserData.Rows[filaSeleccionada].Cells["precioCompra"].Value.ToString()),
                    precioVenta = Convert.ToDecimal( dgvUserData.Rows[filaSeleccionada].Cells["precioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

                filaSeleccionada = -1;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow fila in dgvUserData.Rows)
            {
                fila.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            filaSeleccionada = Convert.ToInt32(dgvUserData.CurrentRow.Index);

            if (filaSeleccionada >= 0 )
            {
                _Producto = new Producto()
                {
                    idProducto = Convert.ToInt32(dgvUserData.Rows[filaSeleccionada].Cells["idProducto"].Value.ToString()),
                    codigo = dgvUserData.Rows[filaSeleccionada].Cells["codigo"].Value.ToString(),
                    nombre = dgvUserData.Rows[filaSeleccionada].Cells["nombre"].Value.ToString(),
                    descripcion=  dgvUserData.Rows[filaSeleccionada].Cells["descripcion"].Value.ToString() ,
                    stock = Convert.ToInt32(dgvUserData.Rows[filaSeleccionada].Cells["stock"].Value.ToString()),
                    precioCompra = Convert.ToDecimal(dgvUserData.Rows[filaSeleccionada].Cells["precioCompra"].Value.ToString()),
                    precioVenta = Convert.ToDecimal(dgvUserData.Rows[filaSeleccionada].Cells["precioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
                filaSeleccionada = -1;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
