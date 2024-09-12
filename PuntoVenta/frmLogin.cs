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
using CapaEntidad;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace PuntoVenta
{
    public partial class frmLogin : Form
    {
        //Elements to do moveable the form.
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cleanComponents()
        {
            lblErrorLogin.Visible = false;
            lblErrorNickname.Text = "";
            lblErrorNickname.Visible = false;
            lblErrorPass.Text = "";
            lblErrorPass.Visible = false;
            txtUserName.BackColor = Color.White;
            txtPassword.BackColor = Color.White;

        }
        private void validarCasillas()
        {
            cleanComponents();

            if (txtUserName.Text == "")
            {
                txtUserName.BackColor = Color.MistyRose;
                lblErrorNickname.Text = "La casilla de nombre de usuario o nickname, no puede estar vacia.";
                lblErrorNickname.Visible = true;
            }
            else if (txtPassword.Text == "")
            {
                txtPassword.BackColor = Color.MistyRose;
                lblErrorPass.Text = "La casilla de contraseña, no puede estar vacia.";
                lblErrorPass.Visible = true;
            }
            else
            {
                ejecutarMenu();
            }
            
        }

        private void ejecutarMenu()
        {
            Usuario objUsuario = new CN_Usuario().searchUser(txtUserName.Text, txtPassword.Text);

            if (objUsuario.idUsuario != 0)
            {
                //frmMenu ventana = new frmMenu(objUsuario);
                MenuUpgrade ventana = new MenuUpgrade(objUsuario);
                ventana.Show();
                this.SetVisibleCore(false);

                ventana.FormClosing += frm_Close;
            }
            else
            {
                txtPassword.Select();
                lblErrorLogin.Text = "Usuario o contraseña incorrectos.";
                lblErrorLogin.Visible = true;
                lblErrorPass.Text = "Verifque la información.";
                lblErrorPass.Visible = true;
                
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            validarCasillas();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro que deseas salir de la aplicación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) { Application.Exit(); }
            
            
        }

        private void frm_Close(Object sender, FormClosingEventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
            cleanComponents();
            this.Show();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            txtPassword.Cursor = _customCaretCursor;
            txtUserName.Cursor = _customCaretCursor;
            btnEntrar.Cursor = _customHandCursor;
            btnExit.Cursor = _customHandCursor;
            btnShowPass.Cursor = _customHandCursor;
            btnExit.Cursor = _customHandCursor;
            btnHide.Cursor = _customHandCursor;
            this.picNicknameInfo.Cursor = _customHandCursor;
            this.picPassInfo.Cursor = _customHandCursor;
            this.picEnterInfo.Cursor = _customHandCursor;

            this.btnSalir.Enabled = false;
            this.btnSalir.Visible = false;

            btnShowPass.Image = Properties.Resources.eye;
            btnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            txtPassword.UseSystemPasswordChar = true;
            lblErrorLogin.Visible = false;
            lblErrorPass.Visible = false;
            lblErrorNickname.Visible = false;

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Select();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                validarCasillas();
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            bool respuesta = txtPassword.UseSystemPasswordChar;
            if (respuesta)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.Image = Properties.Resources.sleep;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowPass.Image = Properties.Resources.eye;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Estas seguro que deseas salir de la aplicación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Crimson;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Transparent;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            this.btnHide.BackColor = Color.LightGray;
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            this.btnHide.BackColor = Color.Transparent;
        }

        private void Move_Form(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }//End move form event.

        private void ShowToolTip(object sender, string message, PictureBox infoImg)
        {
            new System.Windows.Forms.ToolTip().Show(message, infoImg, 30, 0, 2000);
        }//Pop up message method end.

        private void fitMessage(EventArgs e, string message, PictureBox infoImg)
        {
            PictureBox info = infoImg;

            ShowToolTip(e, message, infoImg);
        }//Called and atributes pass to showToolTip method end.

        private void btnShowPass_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Muestra u oculta la contraseña.";

            fitMessage(e, mensaje, btnShowPass);
        }//End show pass hover event

        private void picNicknameInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es el apodo registrado para acceso del usuario.";

            fitMessage(e, mensaje, picNicknameInfo);
        }//End txt nickname hover event

        private void picPassInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Es la contraseña registrada para el acceso del usuario.";

            fitMessage(e, mensaje, picPassInfo);
        }//End txt pass hover event

        private void picEnterInfo_MouseHover(object sender, EventArgs e)
        {
            string mensaje = "Al dar clic o hacer enter.\n" +
                "comprueba las credenciales de acceso.";

            fitMessage(e, mensaje, picEnterInfo);
        }//End btn enter hover event

    }//End class
}//End namespace
