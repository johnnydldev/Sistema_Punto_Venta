namespace PuntoVenta
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentasRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentaDetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.Categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.Productos = new System.Windows.Forms.ToolStripMenuItem();
            this.Negocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompraRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuComprarDetalle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReporteUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuVentas,
            this.menuInventario,
            this.menuProveedores,
            this.menuProductos,
            this.menuClientes,
            this.menuCompras,
            this.menuReportes,
            this.menuAcercaDe});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 82);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1443, 167);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoToolTip = true;
            this.menuUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuUsuario.Image = ((System.Drawing.Image)(resources.GetObject("menuUsuario.Image")));
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuUsuario.Size = new System.Drawing.Size(140, 163);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVentasRegistrar,
            this.menuVentaDetalle});
            this.menuVentas.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuVentas.Image = ((System.Drawing.Image)(resources.GetObject("menuVentas.Image")));
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuVentas.Size = new System.Drawing.Size(140, 163);
            this.menuVentas.Text = "ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuVentas.Click += new System.EventHandler(this.menuVentas_Click);
            // 
            // menuVentasRegistrar
            // 
            this.menuVentasRegistrar.Name = "menuVentasRegistrar";
            this.menuVentasRegistrar.Size = new System.Drawing.Size(233, 36);
            this.menuVentasRegistrar.Text = "Registrar";
            this.menuVentasRegistrar.Click += new System.EventHandler(this.menuVentasRegistrar_Click);
            // 
            // menuVentaDetalle
            // 
            this.menuVentaDetalle.Name = "menuVentaDetalle";
            this.menuVentaDetalle.Size = new System.Drawing.Size(233, 36);
            this.menuVentaDetalle.Text = "Ver Detalles";
            this.menuVentaDetalle.Click += new System.EventHandler(this.menuVentaDetalle_Click);
            // 
            // menuInventario
            // 
            this.menuInventario.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuInventario.Image = ((System.Drawing.Image)(resources.GetObject("menuInventario.Image")));
            this.menuInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuInventario.Size = new System.Drawing.Size(151, 163);
            this.menuInventario.Text = "Inventario";
            this.menuInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuInventario.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuProveedores.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuProveedores.Image = ((System.Drawing.Image)(resources.GetObject("menuProveedores.Image")));
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuProveedores.Size = new System.Drawing.Size(178, 163);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuProveedores.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Categoria,
            this.Productos,
            this.Negocio});
            this.menuProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuProductos.Image = ((System.Drawing.Image)(resources.GetObject("menuProductos.Image")));
            this.menuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuProductos.Size = new System.Drawing.Size(150, 163);
            this.menuProductos.Text = "Productos";
            this.menuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Categoria
            // 
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(212, 36);
            this.Categoria.Text = "Categoria";
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // Productos
            // 
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(212, 36);
            this.Productos.Text = "Productos";
            this.Productos.Click += new System.EventHandler(this.Productos_Click);
            // 
            // Negocio
            // 
            this.Negocio.Name = "Negocio";
            this.Negocio.Size = new System.Drawing.Size(212, 36);
            this.Negocio.Text = "Negocio";
            this.Negocio.Click += new System.EventHandler(this.Negocio_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuClientes.Image = ((System.Drawing.Image)(resources.GetObject("menuClientes.Image")));
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuClientes.Size = new System.Drawing.Size(140, 163);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompraRegistro,
            this.menuComprarDetalle});
            this.menuCompras.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuCompras.Image = ((System.Drawing.Image)(resources.GetObject("menuCompras.Image")));
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.menuCompras.Size = new System.Drawing.Size(216, 163);
            this.menuCompras.Text = "Abastecimiento";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuCompras.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // menuCompraRegistro
            // 
            this.menuCompraRegistro.Name = "menuCompraRegistro";
            this.menuCompraRegistro.Size = new System.Drawing.Size(221, 36);
            this.menuCompraRegistro.Text = "Registrar";
            this.menuCompraRegistro.Click += new System.EventHandler(this.menuCompraRegistro_Click);
            // 
            // menuComprarDetalle
            // 
            this.menuComprarDetalle.Name = "menuComprarDetalle";
            this.menuComprarDetalle.Size = new System.Drawing.Size(221, 36);
            this.menuComprarDetalle.Text = "Ver Detalle";
            this.menuComprarDetalle.Click += new System.EventHandler(this.menuComprarDetalle_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReportVenta,
            this.MenuReportCompra,
            this.menuReporteUsuario});
            this.menuReportes.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuReportes.Image = ((System.Drawing.Image)(resources.GetObject("menuReportes.Image")));
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.menuReportes.Size = new System.Drawing.Size(140, 163);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuReportes.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // MenuReportVenta
            // 
            this.MenuReportVenta.Name = "MenuReportVenta";
            this.MenuReportVenta.Size = new System.Drawing.Size(347, 36);
            this.MenuReportVenta.Text = "Reportes Ventas";
            this.MenuReportVenta.Click += new System.EventHandler(this.MenuReportVenta_Click);
            // 
            // MenuReportCompra
            // 
            this.MenuReportCompra.Name = "MenuReportCompra";
            this.MenuReportCompra.Size = new System.Drawing.Size(347, 36);
            this.MenuReportCompra.Text = "Reportes Compras";
            this.MenuReportCompra.Click += new System.EventHandler(this.MenuReportCompra_Click);
            // 
            // menuReporteUsuario
            // 
            this.menuReporteUsuario.Name = "menuReporteUsuario";
            this.menuReporteUsuario.Size = new System.Drawing.Size(347, 36);
            this.menuReporteUsuario.Text = "Reportes por Usuario";
            this.menuReporteUsuario.Click += new System.EventHandler(this.menuReporteUsuario_Click);
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcercaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("menuAcercaDe.Image")));
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(143, 163);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.DarkCyan;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1443, 82);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuPresentacion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(38, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "SISTEMA DE VENTA";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 249);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1443, 613);
            this.Contenedor.TabIndex = 3;
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(1048, 35);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(142, 28);
            this.lblUsuarioActivo.TabIndex = 4;
            this.lblUsuarioActivo.Text = "Bienvenido: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(1182, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(113, 28);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "unknown";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem menuVentas;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuCompras;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem Categoria;
        private System.Windows.Forms.ToolStripMenuItem Productos;
        private System.Windows.Forms.ToolStripMenuItem menuVentasRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuVentaDetalle;
        private System.Windows.Forms.ToolStripMenuItem menuCompraRegistro;
        private System.Windows.Forms.ToolStripMenuItem menuComprarDetalle;
        private System.Windows.Forms.ToolStripMenuItem Negocio;
        private System.Windows.Forms.ToolStripMenuItem MenuReportVenta;
        private System.Windows.Forms.ToolStripMenuItem MenuReportCompra;
        private System.Windows.Forms.ToolStripMenuItem menuReporteUsuario;
    }
}

