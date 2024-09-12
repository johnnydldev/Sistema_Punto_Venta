using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Wordprocessing;
using PuntoVenta.Herramientas;
using PuntoVenta.Usuarios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PuntoVenta
{
    public partial class frmUsuarios : Form
    {
        private Usuario objUser;

        private GeneradorDocumento objDocumento = new GeneradorDocumento();

        private ER_Metodos expresion = new ER_Metodos();

        private MenuUpgrade frmMenu  = (MenuUpgrade) Application.OpenForms["MenuUpgrade"];

        private frmAddUser frmAddUser = new frmAddUser();

        private frmEditUser frmEditUser;

        private ToolStripMenuItem mySubMenu = new ToolStripMenuItem();
        
        private int rowSelected, rowSelecting;

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
            this.btnAgregar.Cursor = _customHandCursor;
            this.btnEdit.Cursor = _customHandCursor;
            this.btnDelete.Cursor = _customHandCursor;
            this.dgvUserData.Cursor = _customHandCursor;
            this.cboBuscar.Cursor = _customHandCursor;
            this.picAddInfo.Cursor = _customHandCursor;
            this.picCaptureInfo.Cursor = _customHandCursor;
            this.picCleanInfo.Cursor = _customHandCursor;
            this.picDeleteInfo.Cursor = _customHandCursor;
            this.picOptionsInfo.Cursor = _customHandCursor;
            this.picEditInfo.Cursor = _customHandCursor;
            this.picSearchInfo.Cursor = _customHandCursor;

            this.txtBuscar.Cursor = _customCaretCursor;
            this.gbtnOpciones.Cursor = _customCutCursor;

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
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mySubMenu.Name = "menuUsuario";
            frmMenu.AbrirFormulario(mySubMenu, frmAddUser);

        }//Termina Método Agregar

        private void openEditView(Usuario user)
        {
            frmEditUser = new frmEditUser(user);
            mySubMenu.Name = "menuUsuario";
            frmMenu.AbrirFormulario(mySubMenu, frmEditUser);
        }//Termina

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            rowSelecting = dgvUserData.SelectedRows.Count;

            if (rowSelecting > 0)
            {
                if (rowSelected >= 0)
                {
                    var resulDialog = MessageBox.Show("Seguro que desea editar el usuario", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (resulDialog == DialogResult.OK)
                    {
                        objUser = new Usuario();
                        objUser.idUsuario = Convert.ToInt32(dgvUserData.Rows[rowSelected].Cells["idUsuario"].Value.ToString());
                        objUser.documento = dgvUserData.Rows[rowSelected].Cells["documento"].Value.ToString();
                        objUser.apodo = dgvUserData.Rows[rowSelected].Cells["apodo"].Value.ToString();
                        objUser.nombre = dgvUserData.Rows[rowSelected].Cells["nombre"].Value.ToString();
                        objUser.correo = dgvUserData.Rows[rowSelected].Cells["correo"].Value.ToString();
                        objUser.clave = dgvUserData.Rows[rowSelected].Cells["contrasenia"].Value.ToString();
                        objUser.objRol = new Rol() { idRol = Convert.ToInt32(dgvUserData.Rows[rowSelected].Cells["idRol"].Value) };
                        objUser.estado = Convert.ToBoolean(dgvUserData.Rows[rowSelected].Cells["estadoValor"].Value);
                        openEditView(objUser);
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//End edit user selected

        }//End edit user event

        private void btnDelete_Click(object sender, EventArgs e)
        {
            rowSelecting = dgvUserData.SelectedRows.Count;

            if (rowSelecting > 0)
            {
                if (rowSelected >= 0)
                {
                    var resulDialog = MessageBox.Show("Seguro que desea eliminar el usuario", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (resulDialog == DialogResult.OK)
                    {
                       
                            objUser = new Usuario();
                            objUser.idUsuario = Convert.ToInt32(dgvUserData.Rows[rowSelected].Cells["idUsuario"].Value.ToString());

                            if (objUser.idUsuario != 0)
                            {
                                if (objUser.idUsuario == 1)
                                {
                                    MessageBox.Show("No puedes eliminar el usuario predeterminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                                else
                                {
                                    string mensaje = String.Empty;
                                    bool resultado = new CN_Usuario().eliminar(objUser, out mensaje);

                                    if (resultado)
                                    {
                                        dgvUserData.Rows.Clear();
                                        cargarTabla();
                                        MessageBox.Show("Usuario Eliminado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }

                                }
                            }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//End delete user selected
        }//End delete user event

        private void dgvUserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = dgvUserData.CurrentCell.RowIndex;
        }//End row user selected

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelected = dgvUserData.CurrentCell.RowIndex;

        }//End row user selected

        private void ShowToolTip(object sender, string message, PictureBox infoImg)
        {
            new System.Windows.Forms.ToolTip().Show(message, infoImg, 30, 0, 2000);
        }//Pop up message method end.

        private void fitMessage(EventArgs e, string message, PictureBox infoImg)
        {
            PictureBox info = infoImg;

            ShowToolTip(e, message, infoImg);
        }//Called and atributes pass to showToolTip method end.


        private void picCleanInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón restaura los componentes de busqueda.";

            fitMessage(e, mensaje, picCleanInfo);
        }//End clean info hover event

        private void picSearchInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón realiza una busqueda de usuarios.";

            fitMessage(e, mensaje, picSearchInfo);
        }//End search info hover event

        private void picOptionsInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Despliega opciones de busqueda de usuarios.";

            fitMessage(e, mensaje, picOptionsInfo);
        }//End options info hover event

        private void picCaptureInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Captura la información de busqueda de usuario.";

            fitMessage(e, mensaje, picCaptureInfo);
        }//End capture info hover event

        private void picDeleteInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón elimina el usuario seleccionado.";

            fitMessage(e, mensaje, picDeleteInfo);
        }//End delete info hover event

        private void picEditInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón recoge la información\n" +
                " del usuario seleccionado y muestra u formulario de edición.";

            fitMessage(e, mensaje, picEditInfo);
        }//End edit info hover event

        private void picAddInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón muestra un formulario de creación de usuarios.";

            fitMessage(e, mensaje, picAddInfo);
        }//End add info hover event


    }//End class

}//End namespace
