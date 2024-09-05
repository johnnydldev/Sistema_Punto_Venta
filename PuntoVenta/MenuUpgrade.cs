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
using System.Runtime.InteropServices;

namespace PuntoVenta
{

   
    public partial class MenuUpgrade : Form
    {
        //Elements to do moveable the form.
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        //Elements to do round the form borders.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int x1,     // x-coordinate of upper-left corner
           int y1,      // y-coordinate of upper-left corner
           int x2,    // x-coordinate of lower-right corner
           int y2,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        //Elements to show info in menu form
        private static Usuario actual;
        private static ToolStripMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public MenuUpgrade(Usuario objUsuario = null)
        {
            if (objUsuario == null) actual = new Usuario() { nombre = "ADMIN PREDETERMINADO", idUsuario = 1 };
            else
                actual = objUsuario;

            InitializeComponent();
        }

        private void MenuUpgrade_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor _customCutCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.cursor.GetHicon());

            System.Windows.Forms.Cursor _customCaretCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.type_cursor.GetHicon());

            System.Windows.Forms.Cursor _customHandCursor =
                 new System.Windows.Forms.Cursor(Properties.Resources.decree_cursor.GetHicon());

            this.Cursor = _customCutCursor;
            this.menuPrincipal.Cursor = _customHandCursor;
            this.btnHide.Cursor = _customHandCursor;
            this.btnExit.Cursor = _customHandCursor;

            this.FormBorderStyle = FormBorderStyle.None;

            //Create and asing the color for hover menu items.
            ToolStripProfessionalRenderer colorSteel = new ToolStripProfessionalRenderer(new MyColorTable(System.Drawing.Color.SteelBlue));

            List<Permiso> listPermiso = new CN_Permiso().listar(actual.idUsuario);

            foreach (ToolStripMenuItem menuVista in this.menuPrincipal.Items)
            {
                bool encontrado = listPermiso.Any(m => m.vista == menuVista.Name);

                if (encontrado == false)
                {
                    menuVista.Visible = false;
                }

                menuVista.Owner.Renderer = colorSteel;

            }

            lblProof.Text = actual.nombre;

            this.Location = new System.Drawing.Point(0, 0);
            this.optionsContainer.Size = new System.Drawing.Size(this.Width-1, 40);
            this.optionsContainer.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1500, 1000);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.menuContainer.Size = new System.Drawing.Size(this.Width-1, 180);
            this.menuContainer.Location = new System.Drawing.Point(0, this.optionsContainer.Height);
            //this.lblProof.Location = new System.Drawing.Point(5, 40);
            this.menuPrincipal.Location = new Point(0, 0);

            this.formContainer.Size = new Size(this.Width - 1, Convert.ToInt32(this.Height / 1.29F));
            this.formContainer.Location = new System.Drawing.Point(0, this.menuContainer.Height + 10);
            this.MaximizeBox = false;
            this.ResizeRedraw = false;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }//End Load

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

            formContainer.Controls.Add(formulario);
            formulario.Show();
        }//End open form

        private void usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmUsuarios());
        }

        private void RegistrarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmVentas(actual));
        }

        private void verDetallesVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmDetalleVentas());
        }
        private void productosRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmProductos());
        }

        private void categoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmCategoria());
        }

        private void negocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmNegocio());
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmInventario());
        }

        private void proveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmProveedores());
        }

        private void registrarCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmCompras(actual));
        }

        private void verDetallesCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmDetalleCompra());
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmClientes());
        }

        private void reportesVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteVenta());
        }

        private void reportesCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteCompra());
        }

        private void reportesPorUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmReporteVenta_Usuario());
        }

        private void acerceDe_Click(object sender, EventArgs e)
        {
            AbrirFormulario((ToolStripMenuItem)sender, new frmAcercaDe());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//End click event on exit button.

        private void btnHide_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }//End click event on hide button.

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = ColorTranslator.FromHtml("#FF0000");
        }//End hover mouse event on exit button.

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Transparent;
        }//End leave mouse event on exit button.

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.LightGray;
        }//End hover mouse event on hide button.

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.BackColor = Color.Transparent;
        }//End leave mouse event on hide button.
        private void Move_Form(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }//End move form event.

    }//End class

    internal class MyColorTable : ProfessionalColorTable
    {
        private Color menuItemSelectedColor;
        public MyColorTable(Color color) : base()
        {
            menuItemSelectedColor = color;
        }

        public override Color MenuItemSelected
        {
            get { return menuItemSelectedColor; }
        }

    }//End internal class


}//End namespace
