namespace CapaPresentacion.Utilidades
{
    partial class mdProducto
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
            label10 = new Label();
            dgvData = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 42);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 45;
            label10.Text = "PRODUCTOS";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { id, Codigo, Nombre, categoria, stock, PrecioCompra, PrecioVenta });
            dgvData.Location = new Point(12, 96);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(805, 503);
            dgvData.TabIndex = 44;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
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
            Codigo.Width = 110;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 305;
            // 
            // categoria
            // 
            categoria.HeaderText = "CATEGORIA";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 115;
            // 
            // stock
            // 
            stock.HeaderText = "STOCK";
            stock.Name = "stock";
            stock.ReadOnly = true;
            stock.Width = 75;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "ULTIMA COMPRA";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Resizable = DataGridViewTriState.True;
            PrecioCompra.Width = 75;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "ULTIMA VENTA";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 75;
            // 
            // mdProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 611);
            Controls.Add(label10);
            Controls.Add(dgvData);
            Name = "mdProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProducto";
            Load += mdProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
    }
}