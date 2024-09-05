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

namespace PuntoVenta
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void validarCasillas()
        {
            if(txtUserName.Text == "")
            {
                MessageBox.Show("!!!LA CASILLA DE NOMBRE DE USUARIO O NICKNAME, NO PUEDE ESTAR VACIA!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.BackColor = Color.MistyRose;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("!!!LA CASILLA DE CONTRASEÑA, NO PUEDE ESTAR VACIA!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.BackColor = Color.MistyRose;
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
                txtPassword.Text = "";
                MessageBox.Show("!!!NO SE ENCONTRÓ EL USUARIO!!!\n\nUsuario o Contraseña incorrectos, verifque la información.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            this.btnSalir.Enabled = false;
            this.btnSalir.Visible = false;

            btnShowPass.Image = Properties.Resources.eye;
            btnShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            txtPassword.UseSystemPasswordChar = true;
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
    }//End class
}//End namespace
