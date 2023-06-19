namespace CapaPresentacion
{
    partial class frmReportesVentas
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
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            label11 = new Label();
            cbobusqueda = new ComboBox();
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
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtfechafin = new DateTimePicker();
            txtfechainicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            btnexportar = new FontAwesome.Sharp.IconButton();
            btnbuscarresultado = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
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
            btnbuscar.Location = new Point(1196, 141);
            btnbuscar.Margin = new Padding(4, 3, 4, 3);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(49, 27);
            btnbuscar.TabIndex = 238;
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
            btnlimpiarbuscador.Location = new Point(1252, 141);
            btnlimpiarbuscador.Margin = new Padding(4, 3, 4, 3);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(49, 27);
            btnlimpiarbuscador.TabIndex = 239;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(1009, 143);
            txtbusqueda.Margin = new Padding(4, 3, 4, 3);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(177, 23);
            txtbusqueda.TabIndex = 237;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(789, 146);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 235;
            label11.Text = "Buscar por:";
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(867, 142);
            cbobusqueda.Margin = new Padding(4, 3, 4, 3);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(135, 23);
            cbobusqueda.TabIndex = 236;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistro, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioVenta, Cantidad, SubTotal });
            dgvdata.Location = new Point(20, 186);
            dgvdata.Margin = new Padding(4, 3, 4, 3);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(1282, 380);
            dgvdata.TabIndex = 234;
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
            DocumentoProveedor.HeaderText = "Documento Cliente";
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Nombre Cliente";
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
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(7, 0, 0, 0);
            label1.Size = new Size(1310, 452);
            label1.TabIndex = 233;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // txtfechafin
            // 
            txtfechafin.CustomFormat = "dd/MM/yyyy";
            txtfechafin.Format = DateTimePickerFormat.Short;
            txtfechafin.Location = new Point(336, 70);
            txtfechafin.Margin = new Padding(4, 3, 4, 3);
            txtfechafin.Name = "txtfechafin";
            txtfechafin.Size = new Size(112, 23);
            txtfechafin.TabIndex = 229;
            // 
            // txtfechainicio
            // 
            txtfechainicio.CustomFormat = "dd/MM/yyyy";
            txtfechainicio.Format = DateTimePickerFormat.Short;
            txtfechainicio.Location = new Point(117, 70);
            txtfechainicio.Margin = new Padding(4, 3, 4, 3);
            txtfechainicio.Name = "txtfechainicio";
            txtfechainicio.Size = new Size(112, 23);
            txtfechainicio.TabIndex = 227;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(30, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 228;
            label4.Text = "Fecha Inicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(254, 70);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 226;
            label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 225;
            label2.Text = "Reporte Ventas";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 19);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Padding = new Padding(7, 0, 0, 0);
            label10.Size = new Size(1310, 93);
            label10.TabIndex = 224;
            label10.TextAlign = ContentAlignment.MiddleLeft;
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
            btnexportar.Location = new Point(19, 142);
            btnexportar.Margin = new Padding(4, 3, 4, 3);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(138, 24);
            btnexportar.TabIndex = 240;
            btnexportar.Text = "Descargar Excel";
            btnexportar.TextAlign = ContentAlignment.MiddleRight;
            btnexportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexportar.UseVisualStyleBackColor = false;
            // 
            // btnbuscarresultado
            // 
            btnbuscarresultado.Cursor = Cursors.Hand;
            btnbuscarresultado.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnbuscarresultado.IconColor = Color.Black;
            btnbuscarresultado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscarresultado.IconSize = 17;
            btnbuscarresultado.ImageAlign = ContentAlignment.TopCenter;
            btnbuscarresultado.Location = new Point(456, 69);
            btnbuscarresultado.Margin = new Padding(4, 3, 4, 3);
            btnbuscarresultado.Name = "btnbuscarresultado";
            btnbuscarresultado.Size = new Size(91, 24);
            btnbuscarresultado.TabIndex = 241;
            btnbuscarresultado.Text = "Buscar";
            btnbuscarresultado.TextAlign = ContentAlignment.MiddleRight;
            btnbuscarresultado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscarresultado.UseVisualStyleBackColor = true;
            btnbuscarresultado.Click += btnbuscarresultado_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.Control;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            iconButton1.IconColor = Color.LimeGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 17;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(19, 146);
            iconButton1.Margin = new Padding(4, 3, 4, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(138, 24);
            iconButton1.TabIndex = 242;
            iconButton1.Text = "Descargar Excel";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // frmReportesVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 595);
            Controls.Add(iconButton1);
            Controls.Add(btnbuscarresultado);
            Controls.Add(btnbuscar);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(label11);
            Controls.Add(cbobusqueda);
            Controls.Add(dgvdata);
            Controls.Add(label1);
            Controls.Add(txtfechafin);
            Controls.Add(txtfechainicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(btnexportar);
            Name = "frmReportesVentas";
            Text = "frmReportesVentas";
            Load += frmReportesVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private Label label11;
        private ComboBox cbobusqueda;
        private DataGridView dgvdata;
        private Label label1;
        private DateTimePicker txtfechafin;
        private DateTimePicker txtfechainicio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnexportar;
        private FontAwesome.Sharp.IconButton btnbuscarresultado;
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
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}