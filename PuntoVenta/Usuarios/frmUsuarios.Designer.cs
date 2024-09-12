namespace PuntoVenta
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbtnOpciones = new System.Windows.Forms.GroupBox();
            this.picAddInfo = new System.Windows.Forms.PictureBox();
            this.picEditInfo = new System.Windows.Forms.PictureBox();
            this.picDeleteInfo = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.gbtnBuscar = new System.Windows.Forms.GroupBox();
            this.picCaptureInfo = new System.Windows.Forms.PictureBox();
            this.picOptionsInfo = new System.Windows.Forms.PictureBox();
            this.picSearchInfo = new System.Windows.Forms.PictureBox();
            this.picCleanInfo = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbtnOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.gbtnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOptionsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleanInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbtnOpciones
            // 
            this.gbtnOpciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbtnOpciones.Controls.Add(this.picAddInfo);
            this.gbtnOpciones.Controls.Add(this.picEditInfo);
            this.gbtnOpciones.Controls.Add(this.picDeleteInfo);
            this.gbtnOpciones.Controls.Add(this.btnDelete);
            this.gbtnOpciones.Controls.Add(this.btnEdit);
            this.gbtnOpciones.Controls.Add(this.btnAgregar);
            this.gbtnOpciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbtnOpciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnOpciones.Location = new System.Drawing.Point(13, 648);
            this.gbtnOpciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnOpciones.Name = "gbtnOpciones";
            this.gbtnOpciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnOpciones.Size = new System.Drawing.Size(1067, 141);
            this.gbtnOpciones.TabIndex = 17;
            this.gbtnOpciones.TabStop = false;
            this.gbtnOpciones.Text = "Opciones de usuario";
            // 
            // picAddInfo
            // 
            this.picAddInfo.BackColor = System.Drawing.Color.Transparent;
            this.picAddInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAddInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picAddInfo.Location = new System.Drawing.Point(318, 45);
            this.picAddInfo.Name = "picAddInfo";
            this.picAddInfo.Size = new System.Drawing.Size(38, 32);
            this.picAddInfo.TabIndex = 29;
            this.picAddInfo.TabStop = false;
            this.picAddInfo.MouseHover += new System.EventHandler(this.picAddInfo_MouseHover);
            // 
            // picEditInfo
            // 
            this.picEditInfo.BackColor = System.Drawing.Color.Transparent;
            this.picEditInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEditInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picEditInfo.Location = new System.Drawing.Point(663, 45);
            this.picEditInfo.Name = "picEditInfo";
            this.picEditInfo.Size = new System.Drawing.Size(38, 32);
            this.picEditInfo.TabIndex = 28;
            this.picEditInfo.TabStop = false;
            this.picEditInfo.MouseHover += new System.EventHandler(this.picEditInfo_MouseHover);
            // 
            // picDeleteInfo
            // 
            this.picDeleteInfo.BackColor = System.Drawing.Color.Transparent;
            this.picDeleteInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDeleteInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picDeleteInfo.Location = new System.Drawing.Point(1003, 45);
            this.picDeleteInfo.Name = "picDeleteInfo";
            this.picDeleteInfo.Size = new System.Drawing.Size(38, 32);
            this.picDeleteInfo.TabIndex = 27;
            this.picDeleteInfo.TabStop = false;
            this.picDeleteInfo.MouseHover += new System.EventHandler(this.picDeleteInfo_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Image = global::PuntoVenta.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(719, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(281, 72);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Image = global::PuntoVenta.Properties.Resources.lapiz_;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(375, 45);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(281, 72);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = global::PuntoVenta.Properties.Resources.add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(30, 45);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(281, 72);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvUserData
            // 
            this.dgvUserData.AllowUserToAddRows = false;
            this.dgvUserData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.documento,
            this.apodo,
            this.nombre,
            this.correo,
            this.contrasenia,
            this.idRol,
            this.Rol,
            this.estadoValor,
            this.estado});
            this.dgvUserData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUserData.Location = new System.Drawing.Point(13, 268);
            this.dgvUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUserData.MultiSelect = false;
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserData.RowHeadersWidth = 62;
            this.dgvUserData.RowTemplate.Height = 28;
            this.dgvUserData.Size = new System.Drawing.Size(1067, 361);
            this.dgvUserData.TabIndex = 18;
            this.dgvUserData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserData_CellClick);
            this.dgvUserData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserData_CellContentClick);
            // 
            // gbtnBuscar
            // 
            this.gbtnBuscar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbtnBuscar.Controls.Add(this.picCaptureInfo);
            this.gbtnBuscar.Controls.Add(this.picOptionsInfo);
            this.gbtnBuscar.Controls.Add(this.picSearchInfo);
            this.gbtnBuscar.Controls.Add(this.picCleanInfo);
            this.gbtnBuscar.Controls.Add(this.txtBuscar);
            this.gbtnBuscar.Controls.Add(this.cboBuscar);
            this.gbtnBuscar.Controls.Add(this.btnLimpiar);
            this.gbtnBuscar.Controls.Add(this.btnBuscar);
            this.gbtnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBuscar.Location = new System.Drawing.Point(13, 14);
            this.gbtnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnBuscar.Name = "gbtnBuscar";
            this.gbtnBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnBuscar.Size = new System.Drawing.Size(1067, 226);
            this.gbtnBuscar.TabIndex = 21;
            this.gbtnBuscar.TabStop = false;
            this.gbtnBuscar.Text = "Buscar Usuario";
            // 
            // picCaptureInfo
            // 
            this.picCaptureInfo.BackColor = System.Drawing.Color.Transparent;
            this.picCaptureInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCaptureInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picCaptureInfo.Location = new System.Drawing.Point(49, 138);
            this.picCaptureInfo.Name = "picCaptureInfo";
            this.picCaptureInfo.Size = new System.Drawing.Size(38, 32);
            this.picCaptureInfo.TabIndex = 26;
            this.picCaptureInfo.TabStop = false;
            this.picCaptureInfo.MouseHover += new System.EventHandler(this.picCaptureInfo_MouseHover);
            // 
            // picOptionsInfo
            // 
            this.picOptionsInfo.BackColor = System.Drawing.Color.Transparent;
            this.picOptionsInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picOptionsInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picOptionsInfo.Location = new System.Drawing.Point(49, 59);
            this.picOptionsInfo.Name = "picOptionsInfo";
            this.picOptionsInfo.Size = new System.Drawing.Size(38, 32);
            this.picOptionsInfo.TabIndex = 25;
            this.picOptionsInfo.TabStop = false;
            this.picOptionsInfo.MouseHover += new System.EventHandler(this.picOptionsInfo_MouseHover);
            // 
            // picSearchInfo
            // 
            this.picSearchInfo.BackColor = System.Drawing.Color.Transparent;
            this.picSearchInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSearchInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picSearchInfo.Location = new System.Drawing.Point(933, 121);
            this.picSearchInfo.Name = "picSearchInfo";
            this.picSearchInfo.Size = new System.Drawing.Size(38, 32);
            this.picSearchInfo.TabIndex = 24;
            this.picSearchInfo.TabStop = false;
            this.picSearchInfo.MouseHover += new System.EventHandler(this.picSearchInfo_MouseHover);
            // 
            // picCleanInfo
            // 
            this.picCleanInfo.BackColor = System.Drawing.Color.Transparent;
            this.picCleanInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCleanInfo.Image = global::PuntoVenta.Properties.Resources.info;
            this.picCleanInfo.Location = new System.Drawing.Point(929, 48);
            this.picCleanInfo.Name = "picCleanInfo";
            this.picCleanInfo.Size = new System.Drawing.Size(38, 32);
            this.picCleanInfo.TabIndex = 23;
            this.picCleanInfo.TabStop = false;
            this.picCleanInfo.MouseHover += new System.EventHandler(this.picCleanInfo_MouseHover);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(97, 138);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(384, 38);
            this.txtBuscar.TabIndex = 22;
            // 
            // cboBuscar
            // 
            this.cboBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Location = new System.Drawing.Point(97, 59);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(384, 39);
            this.cboBuscar.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Image = global::PuntoVenta.Properties.Resources.limpiar;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(540, 48);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(382, 63);
            this.btnLimpiar.TabIndex = 4;
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
            this.btnBuscar.Image = global::PuntoVenta.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(540, 121);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(386, 72);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.MinimumWidth = 8;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 150;
            // 
            // documento
            // 
            this.documento.HeaderText = "Documento";
            this.documento.MinimumWidth = 8;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 150;
            // 
            // apodo
            // 
            this.apodo.HeaderText = "Nombre de usuario";
            this.apodo.MinimumWidth = 8;
            this.apodo.Name = "apodo";
            this.apodo.ReadOnly = true;
            this.apodo.Width = 150;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Completo";
            this.nombre.MinimumWidth = 8;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 8;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 250;
            // 
            // contrasenia
            // 
            this.contrasenia.HeaderText = "Contraseña";
            this.contrasenia.MinimumWidth = 8;
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.ReadOnly = true;
            this.contrasenia.Visible = false;
            this.contrasenia.Width = 150;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.MinimumWidth = 8;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            this.idRol.Width = 150;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 8;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 150;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "Estado Valor";
            this.estadoValor.MinimumWidth = 8;
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Visible = false;
            this.estadoValor.Width = 50;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 150;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1108, 799);
            this.Controls.Add(this.gbtnBuscar);
            this.Controls.Add(this.gbtnOpciones);
            this.Controls.Add(this.dgvUserData);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.gbtnOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.gbtnBuscar.ResumeLayout(false);
            this.gbtnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOptionsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleanInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbtnOpciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.GroupBox gbtnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoTexto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picAddInfo;
        private System.Windows.Forms.PictureBox picEditInfo;
        private System.Windows.Forms.PictureBox picDeleteInfo;
        private System.Windows.Forms.PictureBox picCaptureInfo;
        private System.Windows.Forms.PictureBox picOptionsInfo;
        private System.Windows.Forms.PictureBox picSearchInfo;
        private System.Windows.Forms.PictureBox picCleanInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }//End class
}