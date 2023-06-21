namespace CapaPresentacion
{
    partial class frmClientes
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
            label11 = new Label();
            txttId = new TextBox();
            label10 = new Label();
            txtIndice = new TextBox();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtNombreYApellido = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(16, 243);
            label11.Name = "label11";
            label11.Size = new Size(65, 18);
            label11.TabIndex = 45;
            label11.Text = "Telefono";
            // 
            // txttId
            // 
            txttId.BorderStyle = BorderStyle.FixedSingle;
            txttId.Location = new Point(220, 27);
            txttId.Name = "txttId";
            txttId.Size = new Size(40, 23);
            txttId.TabIndex = 44;
            txttId.Text = "0";
            txttId.Visible = false;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(280, 38);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 43;
            label10.Text = "LISTA DE CLIENTES";
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(174, 27);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(40, 23);
            txtIndice.TabIndex = 46;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Documento, NombreCompleto, Correo, Telefono, EstadoValor, Estado });
            dgvData.Location = new Point(280, 82);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(845, 503);
            dgvData.TabIndex = 42;
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
            NombreCompleto.Width = 250;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(69, 45);
            label9.Name = "label9";
            label9.Size = new Size(165, 28);
            label9.TabIndex = 41;
            label9.Text = "NUEVO CLIENTE";
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
            btnEliminar.Location = new Point(16, 544);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 41);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnLimpiar.Location = new Point(16, 497);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 41);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
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
            btnGuardar.Location = new Point(17, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 41);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(16, 323);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(224, 23);
            cboEstado.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(16, 305);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 36;
            label8.Text = "Estado";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(16, 261);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 23);
            txtTelefono.TabIndex = 32;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(16, 206);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(224, 23);
            txtCorreo.TabIndex = 31;
            txtCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(16, 188);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 30;
            label4.Text = "Correo";
            // 
            // txtNombreYApellido
            // 
            txtNombreYApellido.BorderStyle = BorderStyle.FixedSingle;
            txtNombreYApellido.Location = new Point(16, 153);
            txtNombreYApellido.Name = "txtNombreYApellido";
            txtNombreYApellido.Size = new Size(224, 23);
            txtNombreYApellido.TabIndex = 29;
            txtNombreYApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(16, 135);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 28;
            label3.Text = "Nombre y Apellido";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(16, 97);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(224, 23);
            txtDni.TabIndex = 27;
            txtDni.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(16, 79);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 26;
            label2.Text = "Nro Documento";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 628);
            label1.TabIndex = 47;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 628);
            Controls.Add(label11);
            Controls.Add(txttId);
            Controls.Add(label10);
            Controls.Add(txtIndice);
            Controls.Add(dgvData);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cboEstado);
            Controls.Add(label8);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtNombreYApellido);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClientes";
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox txttId;
        private Label label10;
        private TextBox txtIndice;
        private DataGridView dgvData;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboEstado;
        private Label label8;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Label label4;
        private TextBox txtNombreYApellido;
        private Label label3;
        private TextBox txtDni;
        private Label label2;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private Label label1;
    }
}