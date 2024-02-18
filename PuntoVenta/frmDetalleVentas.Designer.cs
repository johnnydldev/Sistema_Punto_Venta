﻿namespace PuntoVenta
{
    partial class frmDetalleVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMontoCambio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDescargarPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDocumentoVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.opcionesProveedor = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cuadro = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.opcionesProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.txtMontoCambio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMontoPago);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnDescargarPDF);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(907, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 306);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descargar información";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoCambio.Location = new System.Drawing.Point(30, 205);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Size = new System.Drawing.Size(237, 28);
            this.txtMontoCambio.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Monto Cambio:";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoPago.Location = new System.Drawing.Point(30, 144);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(237, 28);
            this.txtMontoPago.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Monto Pago:";
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.Green;
            this.btnDescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargarPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDescargarPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarPDF.Image")));
            this.btnDescargarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargarPDF.Location = new System.Drawing.Point(28, 242);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(237, 53);
            this.btnDescargarPDF.TabIndex = 7;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            this.btnDescargarPDF.Click += new System.EventHandler(this.btnDescargarPDF_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(592, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(348, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(28, 76);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(237, 28);
            this.txtTotal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto Total:";
            // 
            // dgvUserData
            // 
            this.dgvUserData.AllowUserToAddRows = false;
            this.dgvUserData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.dgvUserData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserData.Location = new System.Drawing.Point(235, 439);
            this.dgvUserData.MultiSelect = false;
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.ReadOnly = true;
            this.dgvUserData.RowTemplate.Height = 28;
            this.dgvUserData.Size = new System.Drawing.Size(656, 295);
            this.dgvUserData.TabIndex = 27;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 200;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 110;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.txtDocumentoCliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(241, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 116);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Location = new System.Drawing.Point(418, 65);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(265, 28);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentoCliente.Location = new System.Drawing.Point(129, 67);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(265, 28);
            this.txtDocumentoCliente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. de documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtDocumentoVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(241, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 104);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Detalle";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(592, 55);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(214, 41);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Green;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(348, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(207, 39);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDocumentoVenta
            // 
            this.txtDocumentoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumentoVenta.Location = new System.Drawing.Point(28, 61);
            this.txtDocumentoVenta.Name = "txtDocumentoVenta";
            this.txtDocumentoVenta.Size = new System.Drawing.Size(265, 28);
            this.txtDocumentoVenta.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. de documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalle de Venta";
            // 
            // opcionesProveedor
            // 
            this.opcionesProveedor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opcionesProveedor.Controls.Add(this.txtUsuario);
            this.opcionesProveedor.Controls.Add(this.label8);
            this.opcionesProveedor.Controls.Add(this.txtTipoDocumento);
            this.opcionesProveedor.Controls.Add(this.txtFecha);
            this.opcionesProveedor.Controls.Add(this.label3);
            this.opcionesProveedor.Controls.Add(this.label4);
            this.opcionesProveedor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesProveedor.Location = new System.Drawing.Point(241, 182);
            this.opcionesProveedor.Name = "opcionesProveedor";
            this.opcionesProveedor.Size = new System.Drawing.Size(815, 117);
            this.opcionesProveedor.TabIndex = 22;
            this.opcionesProveedor.TabStop = false;
            this.opcionesProveedor.Text = "Información de Venta";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(541, 76);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(265, 28);
            this.txtUsuario.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Usuario:";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoDocumento.Location = new System.Drawing.Point(261, 76);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(265, 28);
            this.txtTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Location = new System.Drawing.Point(28, 76);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(217, 28);
            this.txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // Cuadro
            // 
            this.Cuadro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cuadro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cuadro.Location = new System.Drawing.Point(77, 19);
            this.Cuadro.Name = "Cuadro";
            this.Cuadro.Size = new System.Drawing.Size(1141, 751);
            this.Cuadro.TabIndex = 21;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1328, 777);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvUserData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opcionesProveedor);
            this.Controls.Add(this.Cuadro);
            this.Name = "frmDetalleVentas";
            this.Text = "frmDetalleVentas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.opcionesProveedor.ResumeLayout(false);
            this.opcionesProveedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMontoCambio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDescargarPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDocumentoVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox opcionesProveedor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Cuadro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}