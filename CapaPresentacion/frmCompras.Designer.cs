namespace CapaPresentacion
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
            label10 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtFecha = new TextBox();
            cboTipoDocumento = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BTT2 = new FontAwesome.Sharp.IconButton();
            txtIdProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            label4 = new Label();
            txtDocProveedor = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            BTT = new FontAwesome.Sharp.IconButton();
            label11 = new Label();
            txtCantidad = new NumericUpDown();
            txtPrecioVenta = new TextBox();
            label9 = new Label();
            txtPrecioCompra = new TextBox();
            label8 = new Label();
            txtNombreProducto = new TextBox();
            txtIdProducto = new TextBox();
            label6 = new Label();
            txtCodProducto = new TextBox();
            label7 = new Label();
            dgvData = new DataGridView();
            idProducto = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            precioCompra = new DataGridViewTextBoxColumn();
            precioVenta = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewButtonColumn();
            txtTotalAPagar = new TextBox();
            label12 = new Label();
            btnComprar = new Button();
            plus = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(1072, 608);
            label10.TabIndex = 21;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(cboTipoDocumento);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(27, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 82);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(190, 22);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 3;
            label3.Text = "Tipo Documento";
            // 
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Location = new Point(6, 45);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(151, 23);
            txtFecha.TabIndex = 2;
            txtFecha.TextAlign = HorizontalAlignment.Center;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(190, 44);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(189, 23);
            cboTipoDocumento.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(428, 42);
            label1.Name = "label1";
            label1.Size = new Size(210, 28);
            label1.TabIndex = 23;
            label1.Text = "REGISTRAR COMPRA";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(BTT2);
            groupBox2.Controls.Add(txtIdProveedor);
            groupBox2.Controls.Add(txtNombreProveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDocProveedor);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(483, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 82);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion de Proveedor";
            // 
            // BTT2
            // 
            BTT2.FlatStyle = FlatStyle.Flat;
            BTT2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTT2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BTT2.IconColor = Color.Black;
            BTT2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTT2.IconSize = 17;
            BTT2.Location = new Point(172, 45);
            BTT2.Name = "BTT2";
            BTT2.Size = new Size(34, 23);
            BTT2.TabIndex = 27;
            BTT2.UseVisualStyleBackColor = true;
            BTT2.Click += BTT2_Click;
            // 
            // txtIdProveedor
            // 
            txtIdProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtIdProveedor.Location = new Point(505, 18);
            txtIdProveedor.Name = "txtIdProveedor";
            txtIdProveedor.Size = new Size(39, 23);
            txtIdProveedor.TabIndex = 6;
            txtIdProveedor.Visible = false;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProveedor.Location = new Point(234, 44);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(312, 23);
            txtNombreProveedor.TabIndex = 4;
            txtNombreProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(234, 27);
            label4.Name = "label4";
            label4.Size = new Size(131, 18);
            label4.TabIndex = 3;
            label4.Text = "Nombre Proveedor";
            // 
            // txtDocProveedor
            // 
            txtDocProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtDocProveedor.Location = new Point(6, 45);
            txtDocProveedor.Name = "txtDocProveedor";
            txtDocProveedor.Size = new Size(160, 23);
            txtDocProveedor.TabIndex = 2;
            txtDocProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(6, 27);
            label5.Name = "label5";
            label5.Size = new Size(111, 18);
            label5.TabIndex = 0;
            label5.Text = "Nro Documento";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(BTT);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(txtPrecioVenta);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtPrecioCompra);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtNombreProducto);
            groupBox3.Controls.Add(txtIdProducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtCodProducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(27, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(908, 97);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion del Producto";
            // 
            // BTT
            // 
            BTT.FlatStyle = FlatStyle.Flat;
            BTT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTT.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BTT.IconColor = Color.Black;
            BTT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTT.IconSize = 17;
            BTT.Location = new Point(163, 45);
            BTT.Name = "BTT";
            BTT.Size = new Size(34, 23);
            BTT.TabIndex = 26;
            BTT.UseVisualStyleBackColor = true;
            BTT.Click += BTT_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(836, 23);
            label11.Name = "label11";
            label11.Size = new Size(64, 18);
            label11.TabIndex = 14;
            label11.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(836, 44);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(66, 23);
            txtCantidad.TabIndex = 13;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.Location = new Point(737, 44);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(75, 23);
            txtPrecioVenta.TabIndex = 12;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Center;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(737, 23);
            label9.Name = "label9";
            label9.Size = new Size(89, 18);
            label9.TabIndex = 11;
            label9.Text = "Precio Venta";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioCompra.Location = new Point(628, 44);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(75, 23);
            txtPrecioCompra.TabIndex = 10;
            txtPrecioCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(628, 23);
            label8.Name = "label8";
            label8.Size = new Size(102, 18);
            label8.TabIndex = 9;
            label8.Text = "Precio Compra";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Location = new Point(223, 44);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(388, 23);
            txtNombreProducto.TabIndex = 8;
            txtNombreProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIdProducto
            // 
            txtIdProducto.BorderStyle = BorderStyle.FixedSingle;
            txtIdProducto.Location = new Point(118, 19);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(39, 23);
            txtIdProducto.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(223, 23);
            label6.Name = "label6";
            label6.Size = new Size(65, 18);
            label6.TabIndex = 3;
            label6.Text = "Producto";
            // 
            // txtCodProducto
            // 
            txtCodProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodProducto.Location = new Point(6, 45);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(151, 23);
            txtCodProducto.TabIndex = 2;
            txtCodProducto.TextAlign = HorizontalAlignment.Center;
            txtCodProducto.KeyDown += txtCodProducto_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(6, 24);
            label7.Name = "label7";
            label7.Size = new Size(100, 18);
            label7.TabIndex = 0;
            label7.Text = "Cod. Producto";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { idProducto, producto, precioCompra, precioVenta, cantidad, subTotal, btnEliminar });
            dgvData.Location = new Point(27, 274);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(1014, 292);
            dgvData.TabIndex = 24;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // idProducto
            // 
            idProducto.HeaderText = "IDPRODUCTO";
            idProducto.Name = "idProducto";
            idProducto.Visible = false;
            // 
            // producto
            // 
            producto.HeaderText = "PRODUCTO";
            producto.Name = "producto";
            producto.Width = 435;
            // 
            // precioCompra
            // 
            precioCompra.HeaderText = "PRECIO COMPRA";
            precioCompra.Name = "precioCompra";
            precioCompra.Width = 120;
            // 
            // precioVenta
            // 
            precioVenta.HeaderText = "PRECIO VENTA";
            precioVenta.Name = "precioVenta";
            precioVenta.Width = 120;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "CANTIDAD";
            cantidad.Name = "cantidad";
            cantidad.Width = 120;
            // 
            // subTotal
            // 
            subTotal.HeaderText = "SUB TOTAL";
            subTotal.Name = "subTotal";
            subTotal.Width = 120;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "*****";
            btnEliminar.Width = 50;
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAPagar.Location = new Point(717, 573);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(171, 23);
            txtTotalAPagar.TabIndex = 15;
            txtTotalAPagar.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(615, 578);
            label12.Name = "label12";
            label12.Size = new Size(96, 18);
            label12.TabIndex = 15;
            label12.Text = "Total a Pagar";
            label12.Click += label12_Click;
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(901, 572);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(140, 24);
            btnComprar.TabIndex = 15;
            btnComprar.Text = "COMPRAR";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // plus
            // 
            plus.Cursor = Cursors.Hand;
            plus.FlatStyle = FlatStyle.Flat;
            plus.IconChar = FontAwesome.Sharp.IconChar.Add;
            plus.IconColor = Color.DarkGreen;
            plus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            plus.IconSize = 60;
            plus.Location = new Point(964, 188);
            plus.Name = "plus";
            plus.Padding = new Padding(1, 0, 0, 0);
            plus.Size = new Size(77, 73);
            plus.TabIndex = 26;
            plus.Text = " ";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 638);
            Controls.Add(plus);
            Controls.Add(btnComprar);
            Controls.Add(label12);
            Controls.Add(txtTotalAPagar);
            Controls.Add(dgvData);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            KeyPress += frmCompras_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtFecha;
        private ComboBox cboTipoDocumento;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtDocProveedor;
        private Label label5;
        private TextBox txtIdProveedor;
        private TextBox txtNombreProveedor;
        private GroupBox groupBox3;
        private Label label11;
        private NumericUpDown txtCantidad;
        private TextBox txtPrecioVenta;
        private Label label9;
        private TextBox txtPrecioCompra;
        private Label label8;
        private TextBox txtNombreProducto;
        private TextBox txtIdProducto;
        private Label label6;
        private TextBox txtCodProducto;
        private Label label7;
        private DataGridView dgvData;
        private TextBox txtTotalAPagar;
        private Label label12;
        private Button btnComprar;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn precioCompra;
        private DataGridViewTextBoxColumn precioVenta;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewButtonColumn btnEliminar;
        private FontAwesome.Sharp.IconButton BTT;
        private FontAwesome.Sharp.IconButton BTT2;
        private FontAwesome.Sharp.IconButton plus;
    }
}