namespace CapaPresentacion
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txtDni = new TextBox();
            txtNombreYApellido = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            txtRepetirContraseña = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cboEstado = new ComboBox();
            label8 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            idRol = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label10 = new Label();
            txttId = new TextBox();
            label11 = new Label();
            txtIndice = new TextBox();
            cboRol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 608);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 1;
            label2.Text = "Nro Documento";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(27, 90);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(224, 23);
            txtDni.TabIndex = 2;
            // 
            // txtNombreYApellido
            // 
            txtNombreYApellido.BorderStyle = BorderStyle.FixedSingle;
            txtNombreYApellido.Location = new Point(27, 146);
            txtNombreYApellido.Name = "txtNombreYApellido";
            txtNombreYApellido.Size = new Size(224, 23);
            txtNombreYApellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(27, 125);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 3;
            label3.Text = "Nombre y Apellido";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(27, 199);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(224, 23);
            txtCorreo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(27, 178);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 5;
            label4.Text = "Correo";
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(27, 254);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(224, 23);
            txtContraseña.TabIndex = 8;
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtRepetirContraseña.Location = new Point(27, 305);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.PasswordChar = '*';
            txtRepetirContraseña.Size = new Size(224, 23);
            txtRepetirContraseña.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(27, 284);
            label6.Name = "label6";
            label6.Size = new Size(130, 18);
            label6.TabIndex = 9;
            label6.Text = "Repetir contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(27, 339);
            label7.Name = "label7";
            label7.Size = new Size(27, 18);
            label7.TabIndex = 11;
            label7.Text = "Rol";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(27, 414);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(224, 23);
            cboEstado.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(27, 393);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 13;
            label8.Text = "Estado";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderColor = Color.Black;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(28, 466);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 41);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Orange;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.Location = new Point(27, 513);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 41);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += iconButton2_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(27, 560);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 41);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(76, 38);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 18;
            label9.Text = "USUARIO";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Documento, NombreCompleto, Correo, Clave, idRol, rol, EstadoValor, Estado });
            dgvData.Location = new Point(294, 98);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(853, 503);
            dgvData.TabIndex = 19;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 50;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "Nombre y Apellido";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // idRol
            // 
            idRol.HeaderText = "idRol";
            idRol.Name = "idRol";
            idRol.ReadOnly = true;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(294, 54);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 20;
            label10.Text = "LISTA USUARIOS";
            // 
            // txttId
            // 
            txttId.BorderStyle = BorderStyle.FixedSingle;
            txttId.Location = new Point(248, 12);
            txttId.Name = "txttId";
            txttId.Size = new Size(40, 23);
            txttId.TabIndex = 21;
            txttId.Text = "0";
            txttId.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(27, 233);
            label11.Name = "label11";
            label11.Size = new Size(82, 18);
            label11.TabIndex = 22;
            label11.Text = "Contraseña";
            label11.Click += label11_Click;
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(202, 12);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(40, 23);
            txtIndice.TabIndex = 23;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(27, 360);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(224, 23);
            cboRol.TabIndex = 24;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1151, 608);
            Controls.Add(cboRol);
            Controls.Add(txtIndice);
            Controls.Add(label11);
            Controls.Add(txttId);
            Controls.Add(label10);
            Controls.Add(dgvData);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cboEstado);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(label6);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNombreYApellido);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private TextBox txtNombreYApellido;
        private Label label3;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtContraseña;
        private TextBox txtRepetirContraseña;
        private Label label6;
        private Label label7;
        private ComboBox cboEstado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label9;
        private DataGridView dgvData;
        private Label label10;
        private TextBox txttId;
        private Label label11;
        private TextBox txtIndice;
        private ComboBox cboRol;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn idRol;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}