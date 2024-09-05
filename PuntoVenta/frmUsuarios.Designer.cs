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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.gbtnOpciones = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbtnDocumento = new System.Windows.Forms.GroupBox();
            this.btnGenerarDocumento = new System.Windows.Forms.Button();
            this.gbtnBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIndiceTabla = new System.Windows.Forms.Label();
            this.gbtnOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.gbtnDocumento.SuspendLayout();
            this.gbtnBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 952);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(44, 65);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(372, 38);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtApodo
            // 
            this.txtApodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApodo.Location = new System.Drawing.Point(45, 162);
            this.txtApodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApodo.Name = "txtApodo";
            this.txtApodo.Size = new System.Drawing.Size(372, 38);
            this.txtApodo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de usuario:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(46, 260);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 38);
            this.txtNombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Completo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(42, 366);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(372, 38);
            this.txtCorreo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(42, 477);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(372, 38);
            this.txtContraseña.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(42, 586);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(372, 38);
            this.txtConfirmarContraseña.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 546);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirmar contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 654);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rol o Permiso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 777);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "Estado:";
            // 
            // cbxRol
            // 
            this.cbxRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Location = new System.Drawing.Point(40, 705);
            this.cbxRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(280, 39);
            this.cbxRol.TabIndex = 15;
            // 
            // cbxEstado
            // 
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(40, 815);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(180, 39);
            this.cbxEstado.TabIndex = 16;
            // 
            // gbtnOpciones
            // 
            this.gbtnOpciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbtnOpciones.Controls.Add(this.btnActualizar);
            this.gbtnOpciones.Controls.Add(this.btnEliminar);
            this.gbtnOpciones.Controls.Add(this.btnAgregar);
            this.gbtnOpciones.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbtnOpciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnOpciones.Location = new System.Drawing.Point(510, 565);
            this.gbtnOpciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnOpciones.Name = "gbtnOpciones";
            this.gbtnOpciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnOpciones.Size = new System.Drawing.Size(416, 343);
            this.gbtnOpciones.TabIndex = 17;
            this.gbtnOpciones.TabStop = false;
            this.gbtnOpciones.Text = "Opciones de usuario";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(14, 271);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(382, 63);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(10, 155);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(382, 63);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(10, 43);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(386, 72);
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
            this.dgvUserData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.btnSeleccionar,
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
            this.dgvUserData.Location = new System.Drawing.Point(960, 42);
            this.dgvUserData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUserData.MultiSelect = false;
            this.dgvUserData.Name = "dgvUserData";
            this.dgvUserData.ReadOnly = true;
            this.dgvUserData.RowHeadersWidth = 62;
            this.dgvUserData.RowTemplate.Height = 28;
            this.dgvUserData.Size = new System.Drawing.Size(1176, 866);
            this.dgvUserData.TabIndex = 18;
            this.dgvUserData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserData_CellContentClick);
            this.dgvUserData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvUserData_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
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
            this.correo.Width = 150;
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
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(393, 815);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 38);
            this.txtId.TabIndex = 19;
            // 
            // gbtnDocumento
            // 
            this.gbtnDocumento.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbtnDocumento.Controls.Add(this.btnGenerarDocumento);
            this.gbtnDocumento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnDocumento.Location = new System.Drawing.Point(510, 42);
            this.gbtnDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnDocumento.Name = "gbtnDocumento";
            this.gbtnDocumento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnDocumento.Size = new System.Drawing.Size(416, 129);
            this.gbtnDocumento.TabIndex = 20;
            this.gbtnDocumento.TabStop = false;
            this.gbtnDocumento.Text = "Generador de no. de Documento";
            // 
            // btnGenerarDocumento
            // 
            this.btnGenerarDocumento.BackColor = System.Drawing.Color.Green;
            this.btnGenerarDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerarDocumento.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarDocumento.Image")));
            this.btnGenerarDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarDocumento.Location = new System.Drawing.Point(14, 42);
            this.btnGenerarDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarDocumento.Name = "btnGenerarDocumento";
            this.btnGenerarDocumento.Size = new System.Drawing.Size(386, 72);
            this.btnGenerarDocumento.TabIndex = 4;
            this.btnGenerarDocumento.Text = "Generar No. Documento";
            this.btnGenerarDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGenerarDocumento.UseVisualStyleBackColor = false;
            this.btnGenerarDocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // gbtnBuscar
            // 
            this.gbtnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbtnBuscar.Controls.Add(this.txtBuscar);
            this.gbtnBuscar.Controls.Add(this.cboBuscar);
            this.gbtnBuscar.Controls.Add(this.btnLimpiar);
            this.gbtnBuscar.Controls.Add(this.btnBuscar);
            this.gbtnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtnBuscar.Location = new System.Drawing.Point(510, 197);
            this.gbtnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnBuscar.Name = "gbtnBuscar";
            this.gbtnBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbtnBuscar.Size = new System.Drawing.Size(416, 345);
            this.gbtnBuscar.TabIndex = 21;
            this.gbtnBuscar.TabStop = false;
            this.gbtnBuscar.Text = "Buscar Usuario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(16, 117);
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
            this.cboBuscar.Location = new System.Drawing.Point(16, 60);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(378, 39);
            this.cboBuscar.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(16, 271);
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
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(14, 189);
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
            // lblIndiceTabla
            // 
            this.lblIndiceTabla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIndiceTabla.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndiceTabla.Location = new System.Drawing.Point(393, 905);
            this.lblIndiceTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndiceTabla.Name = "lblIndiceTabla";
            this.lblIndiceTabla.Size = new System.Drawing.Size(82, 34);
            this.lblIndiceTabla.TabIndex = 22;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(2168, 952);
            this.Controls.Add(this.lblIndiceTabla);
            this.Controls.Add(this.gbtnBuscar);
            this.Controls.Add(this.gbtnDocumento);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvUserData);
            this.Controls.Add(this.gbtnOpciones);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.gbtnOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.gbtnDocumento.ResumeLayout(false);
            this.gbtnBuscar.ResumeLayout(false);
            this.gbtnBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.GroupBox gbtnOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbtnDocumento;
        private System.Windows.Forms.Button btnGenerarDocumento;
        private System.Windows.Forms.GroupBox gbtnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoTexto;
        private System.Windows.Forms.Label lblIndiceTabla;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
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
    }
}