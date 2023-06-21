namespace CapaPresentacion
{
    partial class frmProveedores
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
            label9 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            label4 = new Label();
            txtRazonSocial = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(30, 242);
            label11.Name = "label11";
            label11.Size = new Size(65, 18);
            label11.TabIndex = 45;
            label11.Text = "Telefono";
            // 
            // txttId
            // 
            txttId.BorderStyle = BorderStyle.FixedSingle;
            txttId.Location = new Point(294, 12);
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
            label10.Location = new Point(294, 40);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 43;
            label10.Text = "LISTA PROVEEDORES";
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(248, 12);
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Documento, RazonSocial, Correo, telefono, EstadoValor, Estado });
            dgvData.Location = new Point(294, 84);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(845, 503);
            dgvData.TabIndex = 42;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(46, 40);
            label9.Name = "label9";
            label9.Size = new Size(205, 28);
            label9.TabIndex = 41;
            label9.Text = "NUEVO PROVEEDOR";
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
            btnEliminar.Location = new Point(30, 546);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(225, 41);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnLimpiar.Location = new Point(30, 499);
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
            btnGuardar.Location = new Point(31, 452);
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
            cboEstado.Location = new Point(30, 321);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(224, 23);
            cboEstado.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(30, 300);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 36;
            label8.Text = "Estado";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(30, 263);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(224, 23);
            txtTelefono.TabIndex = 32;
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(30, 208);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(224, 23);
            txtCorreo.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(30, 187);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 30;
            label4.Text = "Correo";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            txtRazonSocial.Location = new Point(30, 155);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(224, 23);
            txtRazonSocial.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(30, 134);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 28;
            label3.Text = "Razon Social";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Location = new Point(30, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(224, 23);
            txtDni.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(30, 78);
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
            label1.Size = new Size(288, 795);
            label1.TabIndex = 25;
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
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            RazonSocial.Width = 250;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 250;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Visible = false;
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
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 795);
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
            Controls.Add(txtRazonSocial);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
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
        private TextBox txtRazonSocial;
        private Label label3;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}