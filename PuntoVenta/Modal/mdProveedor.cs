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
    public partial class mdProveedor : Form
    {

        public Proveedor _Proveedor { get; set; }
        int iFila, columnaSelecionada;
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn colums in dgvUserData.Columns)
            {
                if (colums.Visible == true )
                {
                    cboBuscar.Items.Add(new OpcionCombo { valor = colums.Name, texto = colums.HeaderText });
                }

            }
            cboBuscar.DisplayMember = "texto";
            cboBuscar.ValueMember = "valor";
            cboBuscar.SelectedIndex = 0;
            cboBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            List<Proveedor> lista = new CN_Proveedor().listar();

            foreach (Proveedor item in lista)
            {
                dgvUserData.Rows.Add(new object[]
                {
                    item.idProveedor,
                    item.documento,
                    item.razonSocial,
                });
            }

        }//Termina cargador de datos

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             iFila  = Convert.ToInt32(dgvUserData.CurrentRow.Index);
            columnaSelecionada = e.ColumnIndex;

            if (iFila >= 0 && columnaSelecionada >0)
            {
                _Proveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32(dgvUserData.Rows[iFila].Cells["idProveedor"].Value.ToString()),
                    documento = dgvUserData.Rows[iFila].Cells["documento"].Value.ToString(),
                    razonSocial = dgvUserData.Rows[iFila].Cells["nombre"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }//termina captura de datos

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
            iFila = Convert.ToInt32(dgvUserData.CurrentRow.Index);

            if (iFila >= 0 )
            {
                _Proveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32(dgvUserData.Rows[iFila].Cells["idProveedor"].Value.ToString()),
                    documento = dgvUserData.Rows[iFila].Cells["documento"].Value.ToString(),
                    razonSocial = dgvUserData.Rows[iFila].Cells["nombre"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }//Termina clase
}
