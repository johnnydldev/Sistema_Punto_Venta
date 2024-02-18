namespace PuntoVenta
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cuadro = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.opcionesCompra = new System.Windows.Forms.GroupBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opcionesProveedor = new System.Windows.Forms.GroupBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opcionesProducto = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpcionesCalcular = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcionesGuardado = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.OpcionesTabla = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar_2 = new System.Windows.Forms.Button();
            this.opcionesCompra.SuspendLayout();
            this.opcionesProveedor.SuspendLayout();
            this.opcionesProducto.SuspendLayout();
            this.OpcionesCalcular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.OpcionesGuardado.SuspendLayout();
            this.OpcionesTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cuadro
            // 
            this.Cuadro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cuadro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cuadro.Location = new System.Drawing.Point(29, 9);
            this.Cuadro.Name = "Cuadro";
            this.Cuadro.Size = new System.Drawing.Size(1392, 744);
            this.Cuadro.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registrar Compra";
            // 
            // opcionesCompra
            // 
            this.opcionesCompra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opcionesCompra.Controls.Add(this.cboTipoDocumento);
            this.opcionesCompra.Controls.Add(this.txtFecha);
            this.opcionesCompra.Controls.Add(this.label2);
            this.opcionesCompra.Controls.Add(this.label1);
            this.opcionesCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesCompra.Location = new System.Drawing.Point(42, 68);
            this.opcionesCompra.Name = "opcionesCompra";
            this.opcionesCompra.Size = new System.Drawing.Size(523, 141);
            this.opcionesCompra.TabIndex = 2;
            this.opcionesCompra.TabStop = false;
            this.opcionesCompra.Text = "Información de compra";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(254, 74);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(185, 30);
            this.cboTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Location = new System.Drawing.Point(28, 74);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(185, 28);
            this.txtFecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // opcionesProveedor
            // 
            this.opcionesProveedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opcionesProveedor.Controls.Add(this.txtIdProveedor);
            this.opcionesProveedor.Controls.Add(this.btnBuscarProveedor);
            this.opcionesProveedor.Controls.Add(this.txtRazonSocial);
            this.opcionesProveedor.Controls.Add(this.txtDocumento);
            this.opcionesProveedor.Controls.Add(this.label3);
            this.opcionesProveedor.Controls.Add(this.label4);
            this.opcionesProveedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesProveedor.Location = new System.Drawing.Point(620, 68);
            this.opcionesProveedor.Name = "opcionesProveedor";
            this.opcionesProveedor.Size = new System.Drawing.Size(791, 141);
            this.opcionesProveedor.TabIndex = 4;
            this.opcionesProveedor.TabStop = false;
            this.opcionesProveedor.Text = "Información de proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProveedor.Location = new System.Drawing.Point(741, 18);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(35, 28);
            this.txtIdProveedor.TabIndex = 6;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.Green;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.Image")));
            this.btnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(338, 65);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(143, 39);
            this.btnBuscarProveedor.TabIndex = 5;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(520, 74);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(265, 28);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Location = new System.Drawing.Point(28, 76);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(265, 28);
            this.txtDocumento.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón Social:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. de documento:";
            // 
            // opcionesProducto
            // 
            this.opcionesProducto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opcionesProducto.Controls.Add(this.txtCantidad);
            this.opcionesProducto.Controls.Add(this.label8);
            this.opcionesProducto.Controls.Add(this.txtPrecioCompra);
            this.opcionesProducto.Controls.Add(this.label7);
            this.opcionesProducto.Controls.Add(this.txtIdProducto);
            this.opcionesProducto.Controls.Add(this.btnBuscarProducto);
            this.opcionesProducto.Controls.Add(this.txtNombreProducto);
            this.opcionesProducto.Controls.Add(this.txtCodigoProducto);
            this.opcionesProducto.Controls.Add(this.label5);
            this.opcionesProducto.Controls.Add(this.label6);
            this.opcionesProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesProducto.Location = new System.Drawing.Point(42, 241);
            this.opcionesProducto.Name = "opcionesProducto";
            this.opcionesProducto.Size = new System.Drawing.Size(978, 187);
            this.opcionesProducto.TabIndex = 7;
            this.opcionesProducto.TabStop = false;
            this.opcionesProducto.Text = "Información de producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Location = new System.Drawing.Point(824, 76);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 28);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(820, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCompra.Location = new System.Drawing.Point(617, 76);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(163, 28);
            this.txtPrecioCompra.TabIndex = 8;
            this.txtPrecioCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioCompra_KeyDown);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio compra:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Location = new System.Drawing.Point(258, 42);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(35, 28);
            this.txtIdProducto.TabIndex = 6;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Green;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.Location = new System.Drawing.Point(28, 124);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(143, 39);
            this.btnBuscarProducto.TabIndex = 5;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(328, 76);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(265, 28);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoProducto.Location = new System.Drawing.Point(28, 76);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(265, 28);
            this.txtCodigoProducto.TabIndex = 2;
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo:";
            // 
            // OpcionesCalcular
            // 
            this.OpcionesCalcular.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OpcionesCalcular.Controls.Add(this.btnAgregar);
            this.OpcionesCalcular.Controls.Add(this.label9);
            this.OpcionesCalcular.Controls.Add(this.txtPorcentaje);
            this.OpcionesCalcular.Controls.Add(this.btnCalcularPrecio);
            this.OpcionesCalcular.Controls.Add(this.label10);
            this.OpcionesCalcular.Controls.Add(this.txtPrecioVenta);
            this.OpcionesCalcular.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesCalcular.Location = new System.Drawing.Point(1067, 241);
            this.OpcionesCalcular.Name = "OpcionesCalcular";
            this.OpcionesCalcular.Size = new System.Drawing.Size(329, 187);
            this.OpcionesCalcular.TabIndex = 4;
            this.OpcionesCalcular.TabStop = false;
            this.OpcionesCalcular.Text = "Calcular Precio de venta";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(195, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 58);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Porcentaje ganancia";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentaje.Location = new System.Drawing.Point(21, 61);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(168, 28);
            this.txtPorcentaje.TabIndex = 12;
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCalcularPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularPrecio.Image")));
            this.btnCalcularPrecio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularPrecio.Location = new System.Drawing.Point(195, 36);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(124, 58);
            this.btnCalcularPrecio.TabIndex = 11;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcularPrecio.UseVisualStyleBackColor = false;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Precio venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Location = new System.Drawing.Point(21, 136);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(123, 28);
            this.txtPrecioVenta.TabIndex = 2;
            this.txtPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_KeyDown);
            // 
            // dgvUserData
            // 
            this.dgvUserData.AllowUserToAddRows = false;
            this.dgvUserData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.codigo,
            this.Producto,
            this.PrecioCompra,
            this.precioVenta,
            this.cantidad,
            this.subtotal});
            this.dgvUserData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserData.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserData.Location = new System.Drawing.Point(370, 475);
            this.dgvUserData.MultiSelect = false;
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.ReadOnly = true;
            this.dgvUserData.RowTemplate.Height = 28;
            this.dgvUserData.Size = new System.Drawing.Size(650, 257);
            this.dgvUserData.TabIndex = 19;
            this.dgvUserData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserData_CellContentClick);
            this.dgvUserData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUserData_CellPainting);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 200;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // OpcionesGuardado
            // 
            this.OpcionesGuardado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OpcionesGuardado.Controls.Add(this.label11);
            this.OpcionesGuardado.Controls.Add(this.txtTotalPagar);
            this.OpcionesGuardado.Controls.Add(this.btnRegistrar);
            this.OpcionesGuardado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesGuardado.Location = new System.Drawing.Point(1088, 475);
            this.OpcionesGuardado.Name = "OpcionesGuardado";
            this.OpcionesGuardado.Size = new System.Drawing.Size(248, 257);
            this.OpcionesGuardado.TabIndex = 14;
            this.OpcionesGuardado.TabStop = false;
            this.OpcionesGuardado.Text = "Opciones de guardado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total a pagar:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Location = new System.Drawing.Point(28, 69);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(185, 28);
            this.txtTotalPagar.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(28, 115);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(202, 84);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // OpcionesTabla
            // 
            this.OpcionesTabla.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OpcionesTabla.Controls.Add(this.btnEditar);
            this.OpcionesTabla.Controls.Add(this.btnEliminar_2);
            this.OpcionesTabla.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesTabla.Location = new System.Drawing.Point(70, 475);
            this.OpcionesTabla.Name = "OpcionesTabla";
            this.OpcionesTabla.Size = new System.Drawing.Size(248, 257);
            this.OpcionesTabla.TabIndex = 17;
            this.OpcionesTabla.TabStop = false;
            this.OpcionesTabla.Text = "Opciones de Tabla";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orange;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(28, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 43);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar_2
            // 
            this.btnEliminar_2.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar_2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar_2.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar_2.Image")));
            this.btnEliminar_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_2.Location = new System.Drawing.Point(28, 54);
            this.btnEliminar_2.Name = "btnEliminar_2";
            this.btnEliminar_2.Size = new System.Drawing.Size(185, 43);
            this.btnEliminar_2.TabIndex = 11;
            this.btnEliminar_2.Text = "Eliminar";
            this.btnEliminar_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar_2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar_2.UseVisualStyleBackColor = false;
            this.btnEliminar_2.Click += new System.EventHandler(this.btnEliminar_2_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1444, 778);
            this.Controls.Add(this.OpcionesTabla);
            this.Controls.Add(this.OpcionesGuardado);
            this.Controls.Add(this.dgvUserData);
            this.Controls.Add(this.OpcionesCalcular);
            this.Controls.Add(this.opcionesProducto);
            this.Controls.Add(this.opcionesProveedor);
            this.Controls.Add(this.opcionesCompra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Cuadro);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.opcionesCompra.ResumeLayout(false);
            this.opcionesCompra.PerformLayout();
            this.opcionesProveedor.ResumeLayout(false);
            this.opcionesProveedor.PerformLayout();
            this.opcionesProducto.ResumeLayout(false);
            this.opcionesProducto.PerformLayout();
            this.OpcionesCalcular.ResumeLayout(false);
            this.OpcionesCalcular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.OpcionesGuardado.ResumeLayout(false);
            this.OpcionesGuardado.PerformLayout();
            this.OpcionesTabla.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cuadro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox opcionesCompra;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox opcionesProveedor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.GroupBox opcionesProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox OpcionesCalcular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.GroupBox OpcionesGuardado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.GroupBox OpcionesTabla;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}