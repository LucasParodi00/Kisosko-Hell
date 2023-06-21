namespace CapaPresentacion
{
    partial class frmLogin
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
            TxtDocumento = new TextBox();
            TxtPassword = new TextBox();
            label3 = new Label();
            BtnIngresar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TxtDocumento
            // 
            TxtDocumento.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDocumento.Location = new Point(12, 88);
            TxtDocumento.Name = "TxtDocumento";
            TxtDocumento.Size = new Size(427, 26);
            TxtDocumento.TabIndex = 3;
            TxtDocumento.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            TxtPassword.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPassword.Location = new Point(12, 191);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '-';
            TxtPassword.Size = new Size(427, 26);
            TxtPassword.TabIndex = 4;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            TxtPassword.KeyPress += TxtPassword_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 45);
            label3.Name = "label3";
            label3.Size = new Size(203, 40);
            label3.TabIndex = 5;
            label3.Text = "DOCUMENTO";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.DodgerBlue;
            BtnIngresar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnIngresar.Location = new Point(74, 220);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(297, 62);
            BtnIngresar.TabIndex = 7;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(210, 40);
            label1.TabIndex = 8;
            label1.Text = "CONTRASEÑA";
            // 
            // frmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(451, 293);
            Controls.Add(label1);
            Controls.Add(BtnIngresar);
            Controls.Add(label3);
            Controls.Add(TxtPassword);
            Controls.Add(TxtDocumento);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtDocumento;
        private TextBox TxtPassword;
        private Label label3;
        private Button BtnIngresar;
        private Label label1;
    }
}