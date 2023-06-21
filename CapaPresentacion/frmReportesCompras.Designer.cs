namespace CapaPresentacion
{
    partial class frmReportesCompras
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label10 = new Label();
            label2 = new Label();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnbuscarresultado = new FontAwesome.Sharp.IconButton();
            cboproveedor = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            dgvdata = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistro = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnexportar = new FontAwesome.Sharp.IconButton();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbobusqueda = new ComboBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(7, 0, 0, 0);
            label10.Size = new Size(1310, 93);
            label10.TabIndex = 57;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 64;
            label2.Text = "Reporte Compras";
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(343, 61);
            txtfechafin.Margin = new Padding(4, 3, 4, 3);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(112, 23);
            txtfechafin.TabIndex = 209;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(124, 61);
            txtfechainicio.Margin = new Padding(4, 3, 4, 3);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(112, 23);
            txtfechainicio.TabIndex = 207;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(26, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 18);
            label4.TabIndex = 208;
            label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(260, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 206;
            label3.Text = "Fecha Fin:";
            // 
            // btnbuscarresultado
            // 
            btnbuscarresultado.Cursor = Cursors.Hand;
            btnbuscarresultado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarresultado.IconColor = Color.Black;
            btnbuscarresultado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarresultado.IconSize = 17;
            btnbuscarresultado.ImageAlign = ContentAlignment.TopCenter;
            btnbuscarresultado.Location = new Point(783, 61);
            btnbuscarresultado.Margin = new Padding(4, 3, 4, 3);
            btnbuscarresultado.Name = "btnbuscarresultado";
            btnbuscarresultado.Size = new Size(91, 24);
            btnbuscarresultado.TabIndex = 215;
            btnbuscarresultado.Text = "Buscar";
            btnbuscarresultado.TextAlign = ContentAlignment.MiddleRight;
            btnbuscarresultado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarresultado.UseVisualStyleBackColor = true;
            btnbuscarresultado.Click += btnbuscarresultado_Click;
            // 
            // cboproveedor
            // 
            cboproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboproveedor.FormattingEnabled = true;
            cboproveedor.Location = new Point(561, 61);
            cboproveedor.Margin = new Padding(4, 3, 4, 3);
            cboproveedor.Name = "cboproveedor";
            cboproveedor.Size = new Size(206, 23);
            cboproveedor.TabIndex = 214;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(474, 64);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 213;
            label5.Text = "Proveedor:";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(7, 0, 0, 0);
            label1.Size = new Size(1460, 452);
            label1.TabIndex = 216;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(27, 177);
            dgvdata.Margin = new Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(1445, 389);
            dgvdata.TabIndex = 217;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "Tipo Documento";
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            UsuarioRegistro.HeaderText = "Usuario Registro";
            UsuarioRegistro.Name = "UsuarioRegistro";
            UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btnexportar
            // 
            btnexportar.BackColor = SystemColors.Control;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatStyle = FlatStyle.Popup;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnexportar.IconColor = Color.LimeGreen;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnexportar.IconSize = 17;
            btnexportar.ImageAlign = ContentAlignment.TopCenter;
            btnexportar.Location = new Point(26, 133);
            btnexportar.Margin = new Padding(4, 3, 4, 3);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(138, 24);
            btnexportar.TabIndex = 223;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            btnexportar.Click += btnexportar_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.BackColor = Color.White;
            btnbuscar.Cursor = Cursors.Hand;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Flat;
            btnbuscar.ForeColor = Color.Black;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 16;
            btnbuscar.Location = new Point(1203, 132);
            btnbuscar.Margin = new Padding(4, 3, 4, 3);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(49, 27);
            btnbuscar.TabIndex = 221;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.Black;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 18;
            btnlimpiarbuscador.Location = new Point(1259, 132);
            btnlimpiarbuscador.Margin = new Padding(4, 3, 4, 3);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(49, 27);
            btnlimpiarbuscador.TabIndex = 222;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1016, 134);
            txtbusqueda.Margin = new Padding(4, 3, 4, 3);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(177, 23);
            txtbusqueda.TabIndex = 220;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(874, 133);
            cbobusqueda.Margin = new Padding(4, 3, 4, 3);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(135, 23);
            cbobusqueda.TabIndex = 219;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(783, 135);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(83, 18);
            label11.TabIndex = 218;
            label11.Text = "Buscar por:";
            // 
            // frmReportesCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 578);
            Controls.Add(btnexportar);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbobusqueda);
            Controls.Add(label11);
            Controls.Add(dgvdata);
            Controls.Add(label1);
            Controls.Add(btnbuscarresultado);
            Controls.Add(cboproveedor);
            Controls.Add(label5);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmReportesCompras";
            Text = "frmReporteCompras";
            Load += frmReportesCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label2;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnbuscarresultado;
        private ComboBox cboproveedor;
        private Label label5;
        private Label label1;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistro;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbobusqueda;
        private Label label11;
    }
}