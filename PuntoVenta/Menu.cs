using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta
{
    public partial class frmMenu : Form
    {
        private static Usuario actual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo = null;
       

        public frmMenu(Usuario objUsuario = null)
        {
            if (objUsuario == null) actual = new Usuario() { nombre = "ADMIN PREDETERMINADO", idUsuario = 1 };
            else
            actual = objUsuario;
           

            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            List<Permiso> listPermiso = new CN_Permiso().listar(actual.idUsuario);

            foreach (ToolStripMenuItem menuVista in MainMenuStrip.Items)
            {
                bool encontrado = listPermiso.Any(m => m.vista == menuVista.Name);

                if (encontrado == false )
                {
                    menuVista.Visible = false;
                }
            }

            lblUsuario.Text = actual.nombre;

        }

        private void AbrirFormulario(ToolStripMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.LightSeaGreen;
            }
            menu.BackColor = Color.SteelBlue;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);
            formulario.Show();



        }

        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmUsuarios());
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmCategoria());

        }

        private void Productos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmProductos());
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmInventario());
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmProveedores());
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmClientes());
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            //Menu Reportes
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmAcercaDe());
        }

        private void menuVentasRegistrar_Click(object sender, EventArgs e)
        {

            AbrirFormulario((ToolStripMenuItem)sender, new frmVentas(actual));
        }

        private void menuVentaDetalle_Click(object sender, EventArgs e)
        {

            AbrirFormulario((ToolStripMenuItem)sender, new frmDetalleVentas());
        }

        private void menuCompraRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmCompras(actual));
        }

        private void menuComprarDetalle_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmDetalleCompra());
        }

        private void Negocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmNegocio());
        }

        private void MenuReportVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteVenta());
        }

        private void MenuReportCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteCompra());
        }

        private void menuReporteUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteVenta_Usuario());
        }
    }
}
