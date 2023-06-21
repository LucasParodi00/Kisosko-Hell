namespace CapaPresentacion
{
    partial class frmProductos
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
            cboCategoria = new ComboBox();
            txttId = new TextBox();
            label10 = new Label();
            txtIndice = new TextBox();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            idCategoria = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtDescripcion = new TextBox();
            s = new Label();
            txtNombreProducto = new TextBox();
            a = new Label();
            txtCodigoProducto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(19, 358);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(224, 23);
            cboCategoria.TabIndex = 47;
            // 
            // txttId
            // 
            txttId.BorderStyle = BorderStyle.FixedSingle;
            txttId.Location = new Point(282, 12);
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
            label10.Location = new Point(283, 29);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 43;
            label10.Text = "LISTA DE PRODUCTOS";
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(236, 12);
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Codigo, Nombre, Descripcion, idCategoria, categoria, stock, PrecioCompra, PrecioVenta, EstadoValor, Estado });
            dgvData.Location = new Point(294, 88);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(983, 503);
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
            // Codigo
            // 
            Codigo.HeaderText = "CODIGO";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 80;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 200;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "DESCRIPCION";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 250;
            // 
            // idCategoria
            // 
            idCategoria.HeaderText = "idCategoria";
            idCategoria.Name = "idCategoria";
            idCategoria.ReadOnly = true;
            idCategoria.Visible = false;
            // 
            // categoria
            // 
            categoria.HeaderText = "CATEGORIA";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 80;
            // 
            // stock
            // 
            stock.HeaderText = "STOCK";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 30;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PRECIO C";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 75;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PRECIO V";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 75;
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
            Estado.Width = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(36, 29);
            label9.Name = "label9";
            label9.Size = new Size(194, 28);
            label9.TabIndex = 41;
            label9.Text = "NUEVO PRODUCTO";
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
            btnEliminar.Location = new Point(15, 565);
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
            btnLimpiar.Location = new Point(15, 518);
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
            btnGuardar.Location = new Point(16, 471);
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
            cboEstado.Location = new Point(19, 412);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(224, 23);
            cboEstado.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(19, 391);
            label8.Name = "label8";
            label8.Size = new Size(52, 18);
            label8.TabIndex = 36;
            label8.Text = "Estado";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(19, 337);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 35;
            label7.Text = "Categoria";
            label7.Click += label7_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(19, 197);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(224, 23);
            txtDescripcion.TabIndex = 31;
            // 
            // s
            // 
            s.AutoSize = true;
            s.BackColor = SystemColors.ButtonFace;
            s.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            s.Location = new Point(19, 176);
            s.Name = "s";
            s.Size = new Size(80, 18);
            s.TabIndex = 30;
            s.Text = "Descripcion";
            s.Click += s_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Location = new Point(19, 144);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(224, 23);
            txtNombreProducto.TabIndex = 29;
            // 
            // a
            // 
            a.AutoSize = true;
            a.BackColor = SystemColors.ButtonFace;
            a.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            a.Location = new Point(19, 123);
            a.Name = "a";
            a.Size = new Size(60, 18);
            a.TabIndex = 28;
            a.Text = "Nombre";
            a.Click += a_Click;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProducto.Location = new Point(19, 88);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(224, 23);
            txtCodigoProducto.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 18);
            label2.TabIndex = 26;
            label2.Text = "Codigo";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 624);
            label1.TabIndex = 25;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 624);
            Controls.Add(cboCategoria);
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
            Controls.Add(label7);
            Controls.Add(txtDescripcion);
            Controls.Add(s);
            Controls.Add(txtNombreProducto);
            Controls.Add(a);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCategoria;
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
        private Label label7;
        private TextBox txtDescripcion;
        private Label s;
        private TextBox txtNombreProducto;
        private Label a;
        private TextBox txtCodigoProducto;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn idCategoria;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}