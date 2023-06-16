namespace CapaPresentacion
{
    partial class frmNegocio
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
            label9 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtRUC = new TextBox();
            label3 = new Label();
            txtNombreNegocio = new TextBox();
            label2 = new Label();
            btnSubirImagen = new Button();
            pickLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(272, 87);
            label9.Name = "label9";
            label9.Size = new Size(101, 28);
            label9.TabIndex = 20;
            label9.Text = "NEGOCIO";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonFace;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(643, 787);
            label1.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreNegocio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSubirImagen);
            groupBox1.Controls.Add(pickLogo);
            groupBox1.Location = new Point(28, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 286);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(325, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(216, 33);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(253, 178);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(346, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 160);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // txtRUC
            // 
            txtRUC.BorderStyle = BorderStyle.FixedSingle;
            txtRUC.Location = new Point(253, 114);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(346, 23);
            txtRUC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 96);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "RUC";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNegocio.Location = new Point(253, 56);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(346, 23);
            txtNombreNegocio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(18, 221);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(216, 33);
            btnSubirImagen.TabIndex = 1;
            btnSubirImagen.Text = "button1";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // pickLogo
            // 
            pickLogo.BorderStyle = BorderStyle.FixedSingle;
            pickLogo.Location = new Point(18, 46);
            pickLogo.Name = "pickLogo";
            pickLogo.Size = new Size(216, 159);
            pickLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pickLogo.TabIndex = 0;
            pickLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 787);
            Controls.Add(groupBox1);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnGuardar;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtRUC;
        private Label label3;
        private TextBox txtNombreNegocio;
        private Label label2;
        private Button btnSubirImagen;
        private PictureBox pickLogo;
    }
}