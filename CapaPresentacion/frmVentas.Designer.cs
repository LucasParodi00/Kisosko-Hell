namespace CapaPresentacion
{
    partial class frmVentas
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
            label1 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtFecha = new TextBox();
            cboTipoDocumento = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtIdCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label4 = new Label();
            txtDocCliente = new TextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label11 = new Label();
            BTT2 = new FontAwesome.Sharp.IconButton();
            txtCantidad = new NumericUpDown();
            txtStock = new TextBox();
            label9 = new Label();
            txtPrecio = new TextBox();
            label8 = new Label();
            txtNombreProducto = new TextBox();
            txtIdProducto = new TextBox();
            label6 = new Label();
            txtCodProducto = new TextBox();
            label7 = new Label();
            dgvData = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewTextBoxColumn();
            txtPagaCon = new TextBox();
            label13 = new Label();
            txtVuelto = new TextBox();
            label12 = new Label();
            txtTotalAPagar = new TextBox();
            label14 = new Label();
            btnComprar = new Button();
            plus = new FontAwesome.Sharp.IconButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 41);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 25;
            label1.Text = "REGISTRAR VENTA";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(1067, 608);
            label10.TabIndex = 24;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(cboTipoDocumento);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(32, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 82);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(191, 23);
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
            label2.Location = new Point(7, 24);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 0;
            label2.Text = "Fecha";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(iconButton1);
            groupBox2.Controls.Add(txtIdCliente);
            groupBox2.Controls.Add(txtNombreCliente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtDocCliente);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(494, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 82);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion del Cliente";
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 17;
            iconButton1.Location = new Point(172, 44);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(34, 23);
            iconButton1.TabIndex = 38;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.BorderStyle = BorderStyle.FixedSingle;
            txtIdCliente.Location = new Point(505, 18);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(39, 23);
            txtIdCliente.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCliente.Location = new Point(234, 44);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(312, 23);
            txtNombreCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(234, 27);
            label4.Name = "label4";
            label4.Size = new Size(107, 18);
            label4.TabIndex = 3;
            label4.Text = "Nombre Cliente";
            // 
            // txtDocCliente
            // 
            txtDocCliente.BorderStyle = BorderStyle.FixedSingle;
            txtDocCliente.Location = new Point(6, 45);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(160, 23);
            txtDocCliente.TabIndex = 2;
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
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(BTT2);
            groupBox3.Controls.Add(txtCantidad);
            groupBox3.Controls.Add(txtStock);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtPrecio);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtNombreProducto);
            groupBox3.Controls.Add(txtIdProducto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtCodProducto);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(32, 171);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(908, 97);
            groupBox3.TabIndex = 28;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion del Producto";
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
            // BTT2
            // 
            BTT2.FlatStyle = FlatStyle.Flat;
            BTT2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTT2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BTT2.IconColor = Color.Black;
            BTT2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTT2.IconSize = 17;
            BTT2.Location = new Point(163, 45);
            BTT2.Name = "BTT2";
            BTT2.Size = new Size(34, 23);
            BTT2.TabIndex = 37;
            BTT2.UseVisualStyleBackColor = true;
            BTT2.Click += BTT2_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(836, 44);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(66, 23);
            txtCantidad.TabIndex = 13;
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(737, 44);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(75, 23);
            txtStock.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(737, 23);
            label9.Name = "label9";
            label9.Size = new Size(43, 18);
            label9.TabIndex = 11;
            label9.Text = "Stock";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Location = new Point(628, 44);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(75, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(628, 23);
            label8.Name = "label8";
            label8.Size = new Size(46, 18);
            label8.TabIndex = 9;
            label8.Text = "Precio";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Location = new Point(223, 44);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(388, 23);
            txtNombreProducto.TabIndex = 8;
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, Precio, Cantidad, SubTotal, BtnEliminar });
            dgvData.Location = new Point(38, 294);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(1008, 239);
            dgvData.TabIndex = 30;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 500;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "";
            BtnEliminar.Name = "BtnEliminar";
            // 
            // txtPagaCon
            // 
            txtPagaCon.BorderStyle = BorderStyle.FixedSingle;
            txtPagaCon.Location = new Point(488, 563);
            txtPagaCon.Name = "txtPagaCon";
            txtPagaCon.Size = new Size(151, 23);
            txtPagaCon.TabIndex = 6;
            txtPagaCon.KeyDown += txtPagaCon_KeyDown;
            txtPagaCon.KeyPress += txtPagaCon_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(442, 565);
            label13.Name = "label13";
            label13.Size = new Size(40, 18);
            label13.TabIndex = 4;
            label13.Text = "Paga";
            // 
            // txtVuelto
            // 
            txtVuelto.BorderStyle = BorderStyle.FixedSingle;
            txtVuelto.Location = new Point(696, 563);
            txtVuelto.Name = "txtVuelto";
            txtVuelto.Size = new Size(151, 23);
            txtVuelto.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(645, 565);
            label12.Name = "label12";
            label12.Size = new Size(48, 18);
            label12.TabIndex = 31;
            label12.Text = "Vuelto";
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAPagar.Location = new Point(157, 563);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(151, 23);
            txtTotalAPagar.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(32, 565);
            label14.Name = "label14";
            label14.Size = new Size(119, 18);
            label14.TabIndex = 33;
            label14.Text = "TOTAL A PAGAR";
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.Location = new Point(906, 563);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(140, 24);
            btnComprar.TabIndex = 35;
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
            plus.Location = new Point(963, 188);
            plus.Name = "plus";
            plus.Padding = new Padding(1, 0, 0, 0);
            plus.Size = new Size(77, 73);
            plus.TabIndex = 36;
            plus.Text = " ";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1556, 638);
            Controls.Add(plus);
            Controls.Add(btnComprar);
            Controls.Add(txtTotalAPagar);
            Controls.Add(label14);
            Controls.Add(txtVuelto);
            Controls.Add(label12);
            Controls.Add(dgvData);
            Controls.Add(txtPagaCon);
            Controls.Add(label13);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
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

        private Label label1;
        private Label label10;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtFecha;
        private ComboBox cboTipoDocumento;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtIdCliente;
        private TextBox txtNombreCliente;
        private Label label4;
        private TextBox txtDocCliente;
        private Label label5;
        private GroupBox groupBox3;
        private Label label11;
        private NumericUpDown txtCantidad;
        private TextBox txtStock;
        private Label label9;
        private TextBox txtPrecio;
        private Label label8;
        private TextBox txtNombreProducto;
        private TextBox txtIdProducto;
        private Label label6;
        private TextBox txtCodProducto;
        private Label label7;
        private DataGridView dgvData;
        private TextBox txtPagaCon;
        private Label label13;
        private TextBox txtVuelto;
        private Label label12;
        private TextBox txtTotalAPagar;
        private Label label14;
        private Button btnComprar;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn BtnEliminar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BTT2;
        private FontAwesome.Sharp.IconButton plus;
    }
}