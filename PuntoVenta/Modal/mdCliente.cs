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
    public partial class mdCliente : Form
    {
        public Cliente _Cliente;
        int filaSeleccionada;
        int columnaSelecionada;
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
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
            List<Cliente> list = new CN_Cliente().listar();

            foreach (Cliente item in list)
            {
                dgvUserData.Rows.Add(new object[]
            {
                item.idCliente,
                item.documento,
                item.nombre
            });
            }
        }//termina load

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = Convert.ToInt32(dgvUserData.CurrentRow.Index);
            columnaSelecionada = e.ColumnIndex;

            if (filaSeleccionada >= 0 && columnaSelecionada >= 0)
            {
                _Cliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(dgvUserData.Rows[filaSeleccionada].Cells["idCliente"].Value.ToString()),
                    documento = dgvUserData.Rows[filaSeleccionada].Cells["documento"].Value.ToString(),
                    nombre = dgvUserData.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString(),
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

            if (filaSeleccionada >= 0)
            {
                _Cliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(dgvUserData.Rows[filaSeleccionada].Cells["idCliente"].Value.ToString()),
                    documento = dgvUserData.Rows[filaSeleccionada].Cells["documento"].Value.ToString(),
                    nombre = dgvUserData.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString(),
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
