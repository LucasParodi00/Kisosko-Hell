namespace CapaPresentacion.Utilidades
{
    partial class mdCompras
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
            dgvData = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            CodCompra = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Fecha, CodCompra, NombreCompleto, MontoTotal });
            dgvData.Location = new Point(8, 12);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(643, 507);
            dgvData.TabIndex = 1;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.Name = "Fecha";
            // 
            // CodCompra
            // 
            CodCompra.HeaderText = "CODIGO DE VENTA";
            CodCompra.Name = "CodCompra";
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "PROVEEDOR";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.Width = 250;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "MONTO TOTAL";
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 150;
            // 
            // mdCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 521);
            Controls.Add(dgvData);
            Name = "mdCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdCompras";
            Load += mdCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn CodCompra;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn MontoTotal;
    }
}