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
            groupBox2 = new GroupBox();
            btnBuscarCopia = new FontAwesome.Sharp.IconButton();
            btnCargarCopia = new Button();
            txtRuta = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtNombreCopia = new TextBox();
            button1 = new Button();
            openFileDialog = new OpenFileDialog();
            label5 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(231, 34);
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
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRUC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreNegocio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSubirImagen);
            groupBox1.Controls.Add(pickLogo);
            groupBox1.Location = new Point(28, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 320);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del Negocio";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(326, 267);
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
            txtDireccion.Location = new Point(254, 228);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(346, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 210);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // txtRUC
            // 
            txtRUC.BorderStyle = BorderStyle.FixedSingle;
            txtRUC.Location = new Point(254, 164);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(346, 23);
            txtRUC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 146);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "RUC";
            // 
            // txtNombreNegocio
            // 
            txtNombreNegocio.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNegocio.Location = new Point(254, 106);
            txtNombreNegocio.Name = "txtNombreNegocio";
            txtNombreNegocio.Size = new Size(346, 23);
            txtNombreNegocio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.Location = new Point(19, 271);
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
            pickLogo.Location = new Point(19, 96);
            pickLogo.Name = "pickLogo";
            pickLogo.Size = new Size(216, 159);
            pickLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pickLogo.TabIndex = 0;
            pickLogo.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnBuscarCopia);
            groupBox2.Controls.Add(btnCargarCopia);
            groupBox2.Controls.Add(txtRuta);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNombreCopia);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(649, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 477);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Copia y Restauracion";
            // 
            // btnBuscarCopia
            // 
            btnBuscarCopia.FlatStyle = FlatStyle.Flat;
            btnBuscarCopia.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarCopia.IconColor = Color.Black;
            btnBuscarCopia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarCopia.IconSize = 20;
            btnBuscarCopia.Location = new Point(441, 382);
            btnBuscarCopia.Name = "btnBuscarCopia";
            btnBuscarCopia.Size = new Size(46, 23);
            btnBuscarCopia.TabIndex = 27;
            btnBuscarCopia.UseVisualStyleBackColor = true;
            btnBuscarCopia.Click += btnBuscarCopia_Click;
            // 
            // btnCargarCopia
            // 
            btnCargarCopia.Location = new Point(158, 414);
            btnCargarCopia.Name = "btnCargarCopia";
            btnCargarCopia.Size = new Size(216, 32);
            btnCargarCopia.TabIndex = 26;
            btnCargarCopia.Text = "Cargar";
            btnCargarCopia.UseVisualStyleBackColor = true;
            btnCargarCopia.Click += btnCargarCopia_Click;
            // 
            // txtRuta
            // 
            txtRuta.BorderStyle = BorderStyle.FixedSingle;
            txtRuta.Location = new Point(6, 382);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(429, 23);
            txtRuta.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(195, 300);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 24;
            label7.Text = "RESTAURAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(101, 34);
            label6.Name = "label6";
            label6.Size = new Size(295, 28);
            label6.TabIndex = 23;
            label6.Text = "NUEVA COPIA DE SEGURIDAD";
            // 
            // txtNombreCopia
            // 
            txtNombreCopia.BorderStyle = BorderStyle.FixedSingle;
            txtNombreCopia.Location = new Point(6, 106);
            txtNombreCopia.Name = "txtNombreCopia";
            txtNombreCopia.Size = new Size(481, 23);
            txtNombreCopia.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(137, 137);
            button1.Name = "button1";
            button1.Size = new Size(216, 32);
            button1.TabIndex = 0;
            button1.Text = "Generar Copia ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 88);
            label5.Name = "label5";
            label5.Size = new Size(183, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre de la copia de Seguridad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 364);
            label8.Name = "label8";
            label8.Size = new Size(186, 15);
            label8.TabIndex = 28;
            label8.Text = "Ubicacion archivo de restauracion";
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 787);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pickLogo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private Button button1;
        private GroupBox groupBox2;
        private TextBox txtNombreCopia;
        private Button btnCargarCopia;
        private TextBox txtRuta;
        private Label label7;
        private Label label6;
        private OpenFileDialog openFileDialog;
        private FontAwesome.Sharp.IconButton btnBuscarCopia;
        private Label label8;
        private Label label5;
    }
}