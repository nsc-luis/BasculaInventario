namespace BasculaInventario
{
    partial class Login
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(47, 37);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassUsuario
            // 
            this.lblPassUsuario.AutoSize = true;
            this.lblPassUsuario.Location = new System.Drawing.Point(47, 81);
            this.lblPassUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassUsuario.Name = "lblPassUsuario";
            this.lblPassUsuario.Size = new System.Drawing.Size(85, 17);
            this.lblPassUsuario.TabIndex = 1;
            this.lblPassUsuario.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 27);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtPassUsuario
            // 
            this.txtPassUsuario.Location = new System.Drawing.Point(140, 73);
            this.txtPassUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassUsuario.Name = "txtPassUsuario";
            this.txtPassUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtPassUsuario.TabIndex = 3;
            this.txtPassUsuario.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(140, 124);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 167);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblPassUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassUsuario;
        private System.Windows.Forms.Button btnLogin;
    }
}