namespace CapaPresentacion.Utilidades
{
    partial class mdVentas
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
            CodVenta = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { Fecha, CodVenta, MontoTotal });
            dgvData.Location = new Point(12, 12);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(445, 507);
            dgvData.TabIndex = 0;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.Name = "Fecha";
            // 
            // CodVenta
            // 
            CodVenta.HeaderText = "CODIGO DE VENTA";
            CodVenta.Name = "CodVenta";
            CodVenta.Width = 150;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "MONTO TOTAL";
            MontoTotal.Name = "MontoTotal";
            MontoTotal.Width = 150;
            // 
            // mdVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 553);
            Controls.Add(dgvData);
            Name = "mdVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdVentas";
            Load += mdVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvData;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn CodVenta;
        private DataGridViewTextBoxColumn MontoTotal;
    }
}