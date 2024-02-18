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
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("!!!LA CASILLA DE CONTRASEÑA, NO PUEDE ESTAR VACIA!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ejecutarMenu();
            }
            
        }

        private void ejecutarMenu()
        {
            Usuario objUsuario = new CN_Usuario().listar().Where(cons => cons.apodo == txtUserName.Text && cons.clave == txtPassword.Text).FirstOrDefault();

            if (objUsuario != null)
            {
                frmMenu ventana = new frmMenu(objUsuario);
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
    }
}
