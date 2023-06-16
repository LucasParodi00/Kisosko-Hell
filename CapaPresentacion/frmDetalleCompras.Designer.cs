﻿namespace CapaPresentacion
{
    partial class frmDetalleCompras
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
            label2 = new Label();
            label3 = new Label();
            txtDocumentoBuscar = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            txtUsuario = new TextBox();
            Usuario = new Label();
            txtTipoDocumento = new TextBox();
            label5 = new Label();
            txtFechaCompra = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtNroDocumentoCompra = new TextBox();
            txtRazonSocial = new TextBox();
            label7 = new Label();
            txtDocumentoProveedor = new TextBox();
            label8 = new Label();
            dgvData = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            txtMontoTotal = new TextBox();
            label6 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(123, 19);
            label1.Name = "label1";
            label1.Size = new Size(1086, 605);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(134, 22);
            label2.Name = "label2";
            label2.Size = new Size(218, 37);
            label2.TabIndex = 1;
            label2.Text = "Detalle Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(707, 32);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 2;
            label3.Text = "Nro. Documento";
            // 
            // txtDocumentoBuscar
            // 
            txtDocumentoBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtDocumentoBuscar.Location = new Point(850, 33);
            txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            txtDocumentoBuscar.Size = new Size(178, 23);
            txtDocumentoBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(1034, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(1115, 33);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(Usuario);
            groupBox1.Controls.Add(txtTipoDocumento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFechaCompra);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(134, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1056, 85);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion de la Compra";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(697, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(348, 23);
            txtUsuario.TabIndex = 10;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Usuario.Location = new Point(697, 24);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(69, 21);
            Usuario.TabIndex = 11;
            Usuario.Text = "Usuario";
            // 
            // txtTipoDocumento
            // 
            txtTipoDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtTipoDocumento.Location = new Point(280, 48);
            txtTipoDocumento.Name = "txtTipoDocumento";
            txtTipoDocumento.Size = new Size(348, 23);
            txtTipoDocumento.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(280, 24);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 9;
            label5.Text = "Tipo ";
            // 
            // txtFechaCompra
            // 
            txtFechaCompra.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCompra.Location = new Point(27, 48);
            txtFechaCompra.Name = "txtFechaCompra";
            txtFechaCompra.Size = new Size(191, 23);
            txtFechaCompra.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtNroDocumentoCompra);
            groupBox2.Controls.Add(txtRazonSocial);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDocumentoProveedor);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(134, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1056, 85);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proveedor";
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
            // txtRazonSocial
            // 
            txtRazonSocial.BorderStyle = BorderStyle.FixedSingle;
            txtRazonSocial.Location = new Point(280, 43);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(430, 23);
            txtRazonSocial.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(280, 19);
            label7.Name = "label7";
            label7.Size = new Size(188, 21);
            label7.TabIndex = 9;
            label7.Text = "Nombre o Razon Social";
            // 
            // txtDocumentoProveedor
            // 
            txtDocumentoProveedor.BorderStyle = BorderStyle.FixedSingle;
            txtDocumentoProveedor.Location = new Point(27, 43);
            txtDocumentoProveedor.Name = "txtDocumentoProveedor";
            txtDocumentoProveedor.Size = new Size(191, 23);
            txtDocumentoProveedor.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(27, 19);
            label8.Name = "label8";
            label8.Size = new Size(133, 21);
            label8.TabIndex = 7;
            label8.Text = "Nro Documento";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Producto, PrecioCompra, Cantidad, SubTotal });
            dgvData.Location = new Point(134, 276);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(1056, 303);
            dgvData.TabIndex = 13;
            // 
            // Producto
            // 
            Producto.HeaderText = "PRODUCTO";
            Producto.Name = "Producto";
            Producto.Width = 510;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "PRECIO COMPRA";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 160;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 160;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SUB TOTAL";
            SubTotal.Name = "SubTotal";
            SubTotal.Width = 180;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.BorderStyle = BorderStyle.FixedSingle;
            txtMontoTotal.Location = new Point(254, 582);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(191, 23);
            txtMontoTotal.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(145, 584);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 12;
            label6.Text = "Monto Total";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1068, 585);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 14;
            button1.Text = "Descargar PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmDetalleCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1404, 675);
            Controls.Add(button1);
            Controls.Add(txtMontoTotal);
            Controls.Add(label6);
            Controls.Add(dgvData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtDocumentoBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDetalleCompras";
            Text = "frmDetalleCompras";
            Load += frmDetalleCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDocumentoBuscar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private TextBox txtUsuario;
        private Label Usuario;
        private TextBox txtTipoDocumento;
        private Label label5;
        private TextBox txtFechaCompra;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox txtNroDocumentoCompra;
        private TextBox txtRazonSocial;
        private Label label7;
        private TextBox txtDocumentoProveedor;
        private Label label8;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private TextBox txtMontoTotal;
        private Label label6;
        private Button button1;
    }
}