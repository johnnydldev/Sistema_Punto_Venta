using System.Drawing;

namespace PuntoVenta
{
    partial class MenuUpgrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUpgrade));
            this.menuContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblProof = new System.Windows.Forms.Label();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.productosRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.negocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesPorUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcerceDe = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.formContainer = new System.Windows.Forms.Panel();
            this.menuContainer.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.optionsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.menuContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.menuContainer.ColumnCount = 1;
            this.menuContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuContainer.Controls.Add(this.lblProof, 0, 0);
            this.menuContainer.Controls.Add(this.menuPrincipal, 0, 1);
            this.menuContainer.Location = new System.Drawing.Point(1, 74);
            this.menuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.menuContainer.MinimumSize = new System.Drawing.Size(1046, 180);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.RowCount = 2;
            this.menuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.menuContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.menuContainer.Size = new System.Drawing.Size(1401, 180);
            this.menuContainer.TabIndex = 0;
            // 
            // lblProof
            // 
            this.lblProof.AutoSize = true;
            this.lblProof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProof.ForeColor = System.Drawing.Color.White;
            this.lblProof.Location = new System.Drawing.Point(4, 1);
            this.lblProof.Name = "lblProof";
            this.lblProof.Size = new System.Drawing.Size(78, 32);
            this.lblProof.TabIndex = 2;
            this.lblProof.Text = "Proof";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPrincipal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuVentas,
            this.menuProductos,
            this.menuInventario,
            this.menuProveedores,
            this.menuCompras,
            this.menuClientes,
            this.menuReportes,
            this.menuAcerceDe});
            this.menuPrincipal.Location = new System.Drawing.Point(1, 37);
            this.menuPrincipal.MinimumSize = new System.Drawing.Size(0, 100);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1399, 126);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.ForeColor = System.Drawing.Color.White;
            this.menuUsuario.Image = global::PuntoVenta.Properties.Resources.user_128;
            this.menuUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(129, 116);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuario.Click += new System.EventHandler(this.usuarios_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrarVentas,
            this.verDetallesVenta});
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.White;
            this.menuVentas.Image = global::PuntoVenta.Properties.Resources.sells_128;
            this.menuVentas.Margin = new System.Windows.Forms.Padding(3);
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(105, 116);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RegistrarVentas
            // 
            this.RegistrarVentas.Name = "RegistrarVentas";
            this.RegistrarVentas.Size = new System.Drawing.Size(253, 40);
            this.RegistrarVentas.Text = "Registrar";
            this.RegistrarVentas.Click += new System.EventHandler(this.RegistrarVentas_Click);
            // 
            // verDetallesVenta
            // 
            this.verDetallesVenta.Name = "verDetallesVenta";
            this.verDetallesVenta.Size = new System.Drawing.Size(253, 40);
            this.verDetallesVenta.Text = "Ver Detalles";
            this.verDetallesVenta.Click += new System.EventHandler(this.verDetallesVenta_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosRegistrar,
            this.categoria,
            this.negocio});
            this.menuProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductos.ForeColor = System.Drawing.Color.White;
            this.menuProductos.Image = global::PuntoVenta.Properties.Resources.products_128;
            this.menuProductos.Margin = new System.Windows.Forms.Padding(3);
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(147, 116);
            this.menuProductos.Text = "Productos";
            this.menuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // productosRegistrar
            // 
            this.productosRegistrar.Name = "productosRegistrar";
            this.productosRegistrar.Size = new System.Drawing.Size(235, 40);
            this.productosRegistrar.Text = "Productos";
            this.productosRegistrar.Click += new System.EventHandler(this.productosRegistrar_Click);
            // 
            // categoria
            // 
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(235, 40);
            this.categoria.Text = "Categoria";
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            // 
            // negocio
            // 
            this.negocio.Name = "negocio";
            this.negocio.Size = new System.Drawing.Size(235, 40);
            this.negocio.Text = "Negocio";
            this.negocio.Click += new System.EventHandler(this.negocio_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInventario.ForeColor = System.Drawing.Color.White;
            this.menuInventario.Image = global::PuntoVenta.Properties.Resources.inventory_128;
            this.menuInventario.Margin = new System.Windows.Forms.Padding(3);
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(148, 116);
            this.menuInventario.Text = "Inventario";
            this.menuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInventario.Click += new System.EventHandler(this.inventario_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.Color.White;
            this.menuProveedores.Image = global::PuntoVenta.Properties.Resources.provider_128;
            this.menuProveedores.Margin = new System.Windows.Forms.Padding(3);
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(173, 116);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCompras,
            this.verDetallesCompras});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.Color.White;
            this.menuCompras.Image = global::PuntoVenta.Properties.Resources.supplier_128;
            this.menuCompras.Margin = new System.Windows.Forms.Padding(3);
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(208, 116);
            this.menuCompras.Text = "Abastecimiento";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registrarCompras
            // 
            this.registrarCompras.Name = "registrarCompras";
            this.registrarCompras.Size = new System.Drawing.Size(253, 40);
            this.registrarCompras.Text = "Registrar";
            this.registrarCompras.Click += new System.EventHandler(this.registrarCompras_Click);
            // 
            // verDetallesCompras
            // 
            this.verDetallesCompras.Name = "verDetallesCompras";
            this.verDetallesCompras.Size = new System.Drawing.Size(253, 40);
            this.verDetallesCompras.Text = "Ver Detalles";
            this.verDetallesCompras.Click += new System.EventHandler(this.verDetallesCompras_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.Color.White;
            this.menuClientes.Image = global::PuntoVenta.Properties.Resources.customer_128;
            this.menuClientes.Margin = new System.Windows.Forms.Padding(3);
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(120, 116);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.clientes_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesVenta,
            this.reportesCompra,
            this.reportesPorUsuario});
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.Color.White;
            this.menuReportes.Image = global::PuntoVenta.Properties.Resources.report_128;
            this.menuReportes.Margin = new System.Windows.Forms.Padding(3);
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(132, 116);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // reportesVenta
            // 
            this.reportesVenta.Name = "reportesVenta";
            this.reportesVenta.Size = new System.Drawing.Size(362, 40);
            this.reportesVenta.Text = "Reportes Venta";
            this.reportesVenta.Click += new System.EventHandler(this.reportesVenta_Click);
            // 
            // reportesCompra
            // 
            this.reportesCompra.Name = "reportesCompra";
            this.reportesCompra.Size = new System.Drawing.Size(362, 40);
            this.reportesCompra.Text = "Reportes Compra";
            this.reportesCompra.Click += new System.EventHandler(this.reportesCompra_Click);
            // 
            // reportesPorUsuario
            // 
            this.reportesPorUsuario.Name = "reportesPorUsuario";
            this.reportesPorUsuario.Size = new System.Drawing.Size(362, 40);
            this.reportesPorUsuario.Text = "Reportes por Usuario";
            this.reportesPorUsuario.Click += new System.EventHandler(this.reportesPorUsuario_Click);
            // 
            // menuAcerceDe
            // 
            this.menuAcerceDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcerceDe.ForeColor = System.Drawing.Color.White;
            this.menuAcerceDe.Image = global::PuntoVenta.Properties.Resources.about_128;
            this.menuAcerceDe.Margin = new System.Windows.Forms.Padding(3);
            this.menuAcerceDe.Name = "menuAcerceDe";
            this.menuAcerceDe.Size = new System.Drawing.Size(142, 116);
            this.menuAcerceDe.Text = "Acerca de";
            this.menuAcerceDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAcerceDe.Click += new System.EventHandler(this.acerceDe_Click);
            // 
            // optionsContainer
            // 
            this.optionsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.optionsContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.optionsContainer.ColumnCount = 2;
            this.optionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.optionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.optionsContainer.Controls.Add(this.btnHide, 0, 0);
            this.optionsContainer.Controls.Add(this.btnExit, 1, 0);
            this.optionsContainer.Location = new System.Drawing.Point(0, 0);
            this.optionsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.optionsContainer.MinimumSize = new System.Drawing.Size(1046, 20);
            this.optionsContainer.Name = "optionsContainer";
            this.optionsContainer.RowCount = 1;
            this.optionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsContainer.Size = new System.Drawing.Size(1402, 50);
            this.optionsContainer.TabIndex = 0;
            this.optionsContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImage = global::PuntoVenta.Properties.Resources.remove_32;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.Location = new System.Drawing.Point(1263, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(64, 42);
            this.btnHide.TabIndex = 1;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            this.btnHide.MouseHover += new System.EventHandler(this.btnHide_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::PuntoVenta.Properties.Resources.close_32;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(1334, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // formContainer
            // 
            this.formContainer.BackColor = System.Drawing.Color.Transparent;
            this.formContainer.Location = new System.Drawing.Point(1, 281);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(270, 142);
            this.formContainer.TabIndex = 1;
            // 
            // MenuUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::PuntoVenta.Properties.Resources.shop_64;
            this.ClientSize = new System.Drawing.Size(1408, 785);
            this.Controls.Add(this.formContainer);
            this.Controls.Add(this.menuContainer);
            this.Controls.Add(this.optionsContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "MenuUpgrade";
            this.Text = "MenuUpgrade";
            this.Load += new System.EventHandler(this.MenuUpgrade_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.optionsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }//End InitComponents

        #endregion

        private System.Windows.Forms.TableLayoutPanel menuContainer;
        private System.Windows.Forms.TableLayoutPanel optionsContainer;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuAcerceDe;
        private System.Windows.Forms.ToolStripMenuItem RegistrarVentas;
        private System.Windows.Forms.ToolStripMenuItem verDetallesVenta;
        private System.Windows.Forms.ToolStripMenuItem productosRegistrar;
        private System.Windows.Forms.ToolStripMenuItem categoria;
        private System.Windows.Forms.ToolStripMenuItem negocio;
        private System.Windows.Forms.ToolStripMenuItem registrarCompras;
        private System.Windows.Forms.ToolStripMenuItem verDetallesCompras;
        private System.Windows.Forms.ToolStripMenuItem reportesVenta;
        private System.Windows.Forms.ToolStripMenuItem reportesCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesPorUsuario;
        private System.Windows.Forms.Panel formContainer;
        private System.Windows.Forms.Label lblProof;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.PictureBox btnExit;
    }
}