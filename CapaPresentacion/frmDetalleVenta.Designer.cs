namespace CapaPresentacion
{
    partial class frmDetalleVenta
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
            button1 = new Button();
            txtMontoTotal = new TextBox();
            SubTotal = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            dgvData = new DataGridView();
            txtNroDocumentoCompra = new TextBox();
            txtNombreCliente = new TextBox();
            label7 = new Label();
            txtDocumento = new TextBox();
            label8 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtUsuario = new TextBox();
            Usuario = new Label();
            txtTipoDocumento = new TextBox();
            label5 = new Label();
            txtFechaCompra = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            txtDocumentoBuscar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPago = new TextBox();
            label9 = new Label();
            txtVuelto = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(957, 575);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 26;
            button1.Text = "Descargar PDF";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.BorderStyle = BorderStyle.FixedSingle;
            txtMontoTotal.Cursor = Cursors.Hand;
            txtMontoTotal.Location = new Point(132, 575);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(150, 23);
            txtMontoTotal.TabIndex = 22;
            txtMontoTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SUB TOTAL";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 180;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 160;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PRECIO COMPRA";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 160;
            // 
            // Producto
            // 
            Producto.HeaderText = "PRODUCTO";
            Producto.Name = "Producto";
            Producto.Width = 510;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dgvData.Location = new Point(23, 266);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(1056, 303);
            dgvData.TabIndex = 25;
            // 
            // txtNroDocumentoCompra
            // 
            txtNroDocumentoCompra.BorderStyle = BorderStyle.FixedSingle;
            txtNroDocumentoCompra.Location = new Point(1035, 43);
            txtNroDocumentoCompra.Name = "txtNroDocumentoCompra";
            txtNroDocumentoCompra.Size = new Size(10, 23);
            txtNroDocumentoCompra.TabIndex = 10;
            txtNroDocumentoCompra.Visible = false;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCliente.Cursor = Cursors.Hand;
            txtNombreCliente.Location = new Point(280, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(430, 23);
            txtNombreCliente.TabIndex = 8;
            txtNombreCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(280, 19);
            label7.Name = "label7";
            label7.Size = new Size(125, 18);
            label7.TabIndex = 9;
            label7.Text = "Nombre y Apellido";
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Cursor = Cursors.Hand;
            txtDocumento.Location = new Point(27, 43);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(191, 23);
            txtDocumento.TabIndex = 7;
            txtDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(27, 19);
            label8.Name = "label8";
            label8.Size = new Size(111, 18);
            label8.TabIndex = 7;
            label8.Text = "Nro Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(39, 577);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 23;
            label6.Text = "Monto Total";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.WhiteSmoke;
            groupBox2.Controls.Add(txtNroDocumentoCompra);
            groupBox2.Controls.Add(txtNombreCliente);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDocumento);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(23, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1056, 85);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Cliente";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Cursor = Cursors.Hand;
            txtUsuario.Location = new Point(697, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(348, 23);
            txtUsuario.TabIndex = 10;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            Usuario.Location = new Point(697, 24);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(114, 18);
            Usuario.TabIndex = 11;
            Usuario.Text = "Realizo la venta:";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtTipoDocumento.Location = new Point(280, 48);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(348, 23);
            txtTipoDocumento.TabIndex = 8;
            txtTipoDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(280, 24);
            label5.Name = "label5";
            label5.Size = new Size(41, 18);
            label5.TabIndex = 9;
            label5.Text = "Tipo ";
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCompra.Cursor = Cursors.Hand;
            txtFechaCompra.Location = new Point(27, 48);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.Size = new Size(191, 23);
            txtFechaCompra.TabIndex = 7;
            txtFechaCompra.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Controls.Add(txtTipoDocumento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFechaCompra);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(23, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 85);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la Venta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(1004, 23);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(923, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDocumentoBuscar
            // 
            txtDocumentoBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtDocumentoBuscar.Cursor = Cursors.Hand;
            txtDocumentoBuscar.Location = new Point(739, 23);
            txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            txtDocumentoBuscar.Size = new Size(178, 23);
            txtDocumentoBuscar.TabIndex = 18;
            txtDocumentoBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(596, 22);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 17;
            label3.Text = "Nro. Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 12);
            label2.Name = "label2";
            label2.Size = new Size(189, 37);
            label2.TabIndex = 16;
            label2.Text = "Detalle Venta";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1086, 605);
            label1.TabIndex = 15;
            // 
            // txtPago
            // 
            txtPago.BorderStyle = BorderStyle.FixedSingle;
            txtPago.Cursor = Cursors.Hand;
            txtPago.Location = new Point(433, 575);
            txtPago.Name = "txtPago";
            txtPago.Size = new Size(150, 23);
            txtPago.TabIndex = 27;
            txtPago.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(387, 577);
            label9.Name = "label9";
            label9.Size = new Size(40, 18);
            label9.TabIndex = 28;
            label9.Text = "Pago";
            // 
            // txtVuelto
            // 
            txtVuelto.BorderStyle = BorderStyle.FixedSingle;
            txtVuelto.Cursor = Cursors.Hand;
            txtVuelto.Location = new Point(744, 575);
            txtVuelto.Name = "txtVuelto";
            txtVuelto.Size = new Size(150, 23);
            txtVuelto.TabIndex = 29;
            txtVuelto.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(690, 577);
            label10.Name = "label10";
            label10.Size = new Size(48, 18);
            label10.TabIndex = 30;
            label10.Text = "Vuelto";
            // 
            // frmDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 666);
            Controls.Add(txtVuelto);
            Controls.Add(label10);
            Controls.Add(txtPago);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(txtMontoTotal);
            Controls.Add(dgvData);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtDocumentoBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetalleVenta";
            Text = "frmDetalleVenta";
            Load += frmDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtMontoTotal;
        private DataGridViewTextBoxColumn SubTotal;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Producto;
        private DataGridView dgvData;
        private TextBox txtNroDocumentoCompra;
        private TextBox txtNombreCliente;
        private Label label7;
        private TextBox txtDocumento;
        private Label label8;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox txtUsuario;
        private Label Usuario;
        private TextBox txtTipoDocumento;
        private Label label5;
        private TextBox txtFechaCompra;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnLimpiar;
        private Button btnBuscar;
        private TextBox txtDocumentoBuscar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPago;
        private Label label9;
        private TextBox txtVuelto;
        private Label label10;
    }
}