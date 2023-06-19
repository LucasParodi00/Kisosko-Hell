using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CapaPresentacion
{
    partial class frmCategorias
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
            txtIndice = new TextBox();
            txttId = new TextBox();
            label10 = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label9 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cboEstado = new ComboBox();
            label8 = new Label();
            txtDescripcionCategoria = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIndice
            // 
            txtIndice.BorderStyle = BorderStyle.FixedSingle;
            txtIndice.Location = new Point(145, 66);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(40, 23);
            txtIndice.TabIndex = 46;
            txtIndice.Text = "-1";
            // 
            // txttId
            // 
            txttId.BorderStyle = BorderStyle.FixedSingle;
            txttId.Location = new Point(191, 66);
            txttId.Name = "txttId";
            txttId.Size = new Size(40, 23);
            txttId.TabIndex = 44;
            txttId.Text = "0";
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(294, 48);
            label10.Name = "label10";
            label10.Size = new Size(785, 41);
            label10.TabIndex = 43;
            label10.Text = "CATEGORIAS";
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
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, id, Descripcion, EstadoValor, Estado });
            dgvData.Location = new Point(294, 92);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(785, 503);
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 350;
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
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(46, 35);
            label9.Name = "label9";
            label9.Size = new Size(195, 28);
            label9.TabIndex = 41;
            label9.Text = "NUEVA CATEGORIA";
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
            btnEliminar.Location = new Point(26, 584);
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
            btnLimpiar.Location = new Point(26, 537);
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
            btnGuardar.Location = new Point(27, 490);
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
            cboEstado.Location = new Point(27, 280);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(224, 23);
            cboEstado.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Location = new Point(27, 262);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 36;
            label8.Text = "Estado";
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionCategoria.Location = new Point(27, 227);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(224, 23);
            txtDescripcionCategoria.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Location = new Point(27, 209);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 27;
            label3.Text = "Descripcion";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(288, 636);
            label1.TabIndex = 24;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 636);
            Controls.Add(txtIndice);
            Controls.Add(txttId);
            Controls.Add(label10);
            Controls.Add(dgvData);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(cboEstado);
            Controls.Add(label8);
            Controls.Add(txtDescripcionCategoria);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIndice;
        private TextBox txttId;
        private Label label10;
        private DataGridView dgvData;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cboEstado;
        private Label label8;
        private TextBox txtDescripcionCategoria;
        private Label label3;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}