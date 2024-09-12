using CapaEntidad;
using CapaNegocio;
using PuntoVenta.Herramientas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PuntoVenta.Usuarios
{
    public partial class frmEditUser : Form
    {
        private Usuario objUser;

        private GeneradorDocumento objDocumento = new GeneradorDocumento();

        private ER_Metodos expresion = new ER_Metodos();

        private MenuUpgrade menu = (MenuUpgrade)Application.OpenForms["MenuUpgrade"];

        private frmUsuarios frmUsers;

        private ToolStripMenuItem myMenu = new ToolStripMenuItem();

        public frmEditUser(Usuario user = null)
        {
            if (user!=null)
            {
                objUser = user;
            }
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUsers = new frmUsuarios();
            myMenu.Name = "frmUsuario";
            menu.AbrirFormulario(myMenu, frmUsers);
        }//End back to principal menu event

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int stateValueCbx = Convert.ToInt32(((OpcionCombo)cbxState.SelectedItem).valor);
            bool StateBoolValue = estadoBandera(stateValueCbx);

            Usuario objUsuario = new Usuario();

            bool validacion = validarCampos();

            if (validacion == true)
            {

                objUsuario.idUsuario = Convert.ToInt32(txtId.Text);
                objUsuario.documento = txtDocument.Text;
                objUsuario.apodo = txtNickname.Text;
                objUsuario.nombre = txtName.Text;
                objUsuario.correo = txtEmail.Text;
                objUsuario.clave = txtPassword.Text;
                objUsuario.objRol = new Rol() { idRol = Convert.ToInt32(((OpcionCombo)cbxRol.SelectedItem).valor.ToString()) };
                objUsuario.estado = StateBoolValue;

                bool updatedUser = new CN_Usuario().editar(objUsuario, out mensaje);


                if (updatedUser)
                {
                    MessageBox.Show("Usuario "+ objUsuario.nombre+" Actualizado Exitosamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    componentsClear();

                    frmUsers = new frmUsuarios();
                    myMenu.Name = "frmUsuario";
                    menu.AbrirFormulario(myMenu, frmUsers);
                }
                else
                {
                    MessageBox.Show(mensaje, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }//End validation components


        }//End save user event

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 4,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 4);


            System.Windows.Forms.Cursor _customCutCursor =
               new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.txtId.Visible = false;
            this.txtId.Enabled = false;

            this.Cursor = _customCutCursor;
            this.gbxBack.Cursor = _customCutCursor;
            this.gbxFormulario.Cursor = _customCutCursor;

            this.btnBack.Cursor = _customHandCursor;
            this.btnUpdateUser.Cursor = _customHandCursor;
            this.cbxRol.Cursor = _customHandCursor;
            this.cbxState.Cursor = _customHandCursor;
            this.picRolInfo.Cursor = _customHandCursor;
            this.picBackMenuInfo.Cursor = _customHandCursor;
            this.picDocumentInfo.Cursor = _customHandCursor;
            this.picStateInfo.Cursor = _customHandCursor;
            this.picNicknameInfo.Cursor = _customHandCursor;
            this.picNameInfo.Cursor = _customHandCursor;
            this.picConfirmPassInfo.Cursor = _customHandCursor;
            this.picPasswordInfo.Cursor = _customHandCursor;
            this.picUpdateUserInfo.Cursor = _customHandCursor;
            this.picEmailInfo.Cursor = _customHandCursor;

            this.btnSeeConfrimPass.Cursor = _customHandCursor;
            this.btnSeePass.Cursor = _customHandCursor;

            this.txtNickname.Cursor = _customCaretCursor;
            this.txtDocument.Cursor = _customCaretCursor;
            this.txtName.Cursor = _customCaretCursor;
            this.txtEmail.Cursor = _customCaretCursor;
            this.txtPassword.Cursor = _customCaretCursor;
            this.txtConfirmPassword.Cursor = _customCaretCursor;

            this.txtDocument.Enabled = false;
            cbxState.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cbxState.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cbxState.DisplayMember = "texto";
            cbxState.ValueMember = "valor";
            cbxState.SelectedIndex = 0;

            List<Rol> listRol = new CN_Rol().listar();

            foreach (Rol item in listRol)
            {
                cbxRol.Items.Add(new OpcionCombo() { valor = item.idRol, texto = item.descripcion });
            }
            cbxRol.DisplayMember = "texto";
            cbxRol.ValueMember = "valor";
            cbxRol.SelectedIndex = 1;
            cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;


            if (objUser != null)
            {
                txtDocument.Text = objUser.documento;
                txtNickname.Text = objUser.apodo;
                txtName.Text = objUser.nombre;
                txtId.Text = objUser.idUsuario.ToString();
                txtEmail.Text = objUser.correo;
                txtPassword.Text = objUser.clave;
                txtConfirmPassword.Text = objUser.clave;


                foreach (OpcionCombo item in cbxRol.Items)
                {
                    if (Convert.ToInt32(item.valor) == objUser.objRol.idRol)
                    {
                        int indice_combo = cbxRol.Items.IndexOf(item);
                        cbxRol.SelectedIndex = indice_combo;
                        break;
                    }
                }

                foreach (OpcionCombo item in cbxState.Items)
                {
                    if (Convert.ToInt32(item.valor) == Convert.ToInt32(objUser.estado))
                    {
                        int indice_combo = cbxState.Items.IndexOf(item);
                        cbxState.SelectedIndex = indice_combo;
                        break;
                    }
                }

            }

            btnSeePass.Image = Properties.Resources.eye;
            btnSeePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btnSeeConfrimPass.Image = Properties.Resources.eye;
            btnSeeConfrimPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            clearErrorLabels();
        }//End load method

        private bool validarCampos()
        {
            restoreBackgroundComponents();
            bool correoValido = ER_Metodos.IsValidEmail(txtEmail.Text);
            bool respuesta = true;

            if (correoValido != true)
            {
                lblErrorEmail.Text = "Correo Electronico no valido, el formato no es correcto.";
                lblErrorEmail.Visible = true;
                txtEmail.Select();
                txtEmail.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }

            if (expresion.validarSoloLetras(txtName.Text) != true)
            {
                lblErrorName.Text = "Nombre no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z.";
                lblErrorName.Visible = true;
                txtName.Select();
                txtName.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }

            if (expresion.validarSoloLetras(txtNickname.Text) != true)
            {
                lblErrorNickname.Text = "Apodo no valido, el formato no es correcto.\nSolo se permiten letras, de la A-Z.";
                lblErrorNickname.Visible = true;
                txtNickname.Select();
                txtNickname.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }


            if (expresion.validarDocumento(txtDocument.Text) != true)
            {
                lblErrorDoc.Text = "Documento no valido, solo se permiten numeros.\n" +
                    "Recuerde que son 8 números aleatorios entre 0-9.";
                lblErrorDoc.Visible = true;
                txtDocument.Select();
                txtDocument.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;

            }

            bool res = txtPassword.Text.Equals(txtConfirmPassword.Text);

            if (txtPassword.Text == "")
            {
                lblErrorPassword.Text = "Debe ingresar una contraseña, no puede ser vacia";
                lblErrorPassword.Visible = true;
                txtPassword.Select();
                txtPassword.BackColor = System.Drawing.Color.MistyRose;
                respuesta = false;
            }
            else
            {
                if (!res)
                {
                    lblErrorConfirmPass.Text = "La contraseña no coincide";
                    lblErrorConfirmPass.Visible = true;
                    txtConfirmPassword.Select();
                    txtConfirmPassword.BackColor = System.Drawing.Color.MistyRose;
                    respuesta = false;
                }
            }


            return respuesta;
        }//End fields validate

        private bool estadoBandera(int cbxValue)
        {
            int valor = cbxValue;
            bool estadoBandera = false;

            if (valor == 1)
            {
                estadoBandera = true;
            }
            else if (valor == 0)
            {
                estadoBandera = false;
            }
            else
            {
                MessageBox.Show("Valores incorrectos, verifique los datos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxState.SelectedIndex = 0;
                cbxState.BackColor = System.Drawing.Color.MistyRose;
                cbxState.Select();
            }
            return estadoBandera;
        }//End flag state

        private void componentsClear()
        {
            txtId.Text = String.Empty;
            txtDocument.Text = String.Empty;
            txtName.Text = String.Empty;
            txtNickname.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtConfirmPassword.Text = String.Empty;
            cbxRol.SelectedIndex = 1;
            cbxState.SelectedIndex = 0;
            restoreBackgroundComponents();

        }//End clear components method

        private void restoreBackgroundComponents()
        {
            cbxState.BackColor = System.Drawing.Color.White;
            cbxRol.BackColor = System.Drawing.Color.White;
            txtConfirmPassword.BackColor = System.Drawing.Color.White;
            txtDocument.BackColor = System.Drawing.Color.White;
            txtName.BackColor = System.Drawing.Color.White;
            txtNickname.BackColor = System.Drawing.Color.White;
            txtEmail.BackColor = System.Drawing.Color.White;
            txtPassword.BackColor = System.Drawing.Color.White;
            clearErrorLabels();
        }

        private void clearErrorLabels()
        {
            this.lblErrorNickname.Visible = false;
            this.lblErrorRol.Visible = false;
            this.lblErrorName.Visible = false;
            this.lblErrorDoc.Visible = false;
            this.lblErrorState.Visible = false;
            this.lblErrorEmail.Visible = false;
            this.lblErrorPassword.Visible = false;
            this.lblErrorConfirmPass.Visible = false;
        }
        private void ShowToolTip(object sender, string message, PictureBox infoImg)
        {
            new System.Windows.Forms.ToolTip().Show(message, infoImg, 30, 0, 2000);
        }//Pop up message method end.

        private void fitMessage(EventArgs e, string message, PictureBox infoImg)
        {
            PictureBox info = infoImg;

            ShowToolTip(e, message, infoImg);
        }//Called and atributes pass to showToolTip method end.

        private void picBackMenuInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic en el botón regresa al menu de usuarios.";

            fitMessage(e, mensaje, picBackMenuInfo);
        }//End gen document info event

        private void picUpdateUserInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Realiza la accion de guardar.";

            fitMessage(e, mensaje, picUpdateUserInfo);
        }//End update user info event

        private void picDocumentInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el identificador único del usuario. \n\nEs un número aleatorio de 8 digitos.";

            fitMessage(e, mensaje, picDocumentInfo);
        }//End document info event

        private void picNicknameInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el nombre de acceso al menu. \n\nPuede ser cualquier dato de tipo texto.\n\nEjemplo: JoseAnt";

            fitMessage(e, mensaje, picNicknameInfo);
        }//End nicname info event

        private void picNameInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el nombre de la persona a registrar. \n\nPuede ser cualquier dato de tipo texto.\n\nEjemplo: Jose Antonio";

            fitMessage(e, mensaje, picNameInfo);
        }//End name info event

        private void picEmailInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el email de contacto del usuario. \n\nDebe cumplir con el formato de correo electronico.\n\nEjemplo: example@example.com";

            fitMessage(e, mensaje, picEmailInfo);
        }//End email info event

        private void picPasswordInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es la contraseña de acceso al menu. \n\nPuede ser cualquier dato de tipo texto.\n\nEjemplo: pass2024";

            fitMessage(e, mensaje, picPasswordInfo);
        }//End password info event

        private void picConfirmPassInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es la confirmacion de contraseña de acceso al menu. \n\nPuede ser cualquier dato de tipo texto.\n\nEjemplo: pass2024";

            fitMessage(e, mensaje, picConfirmPassInfo);
        }//End confirm password info event

        private void picRolInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el permiso del usuario. \n\nDebe elegir si el usuario será empleado o administrador.";

            fitMessage(e, mensaje, picRolInfo);
        }//End rol info event

        private void btnSeeConfrimPass_Click(object sender, EventArgs e)
        {
            bool respuesta = txtConfirmPassword.UseSystemPasswordChar;
            if (respuesta)
            {
                txtConfirmPassword.PasswordChar = '\0';
                txtConfirmPassword.UseSystemPasswordChar = false;
                btnSeeConfrimPass.Image = Properties.Resources.sleep;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                btnSeeConfrimPass.Image = Properties.Resources.eye;
            }
        }//End confirm pass clic event

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            bool respuesta = txtPassword.UseSystemPasswordChar;
            if (respuesta)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                btnSeePass.Image = Properties.Resources.sleep;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnSeePass.Image = Properties.Resources.eye;
            }
        }//End show pass clic event

        private void btnSeePass_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Muestra u oculta la contraseña.";

            fitMessage(e, mensaje, picConfirmPassInfo);
        }//End show pass hover event

        private void btnSeeConfrimPass_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Muestra u oculta la confirmación de contraseña.";

            fitMessage(e, mensaje, picConfirmPassInfo);
        }//End show confirm pass hover event

        private void picStateInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el estado del usuario. \n\nDebe elegir si el usuario se encuentra activo.";

            fitMessage(e, mensaje, picStateInfo);
        }//End state info event

    }//End class

}//End namespace
