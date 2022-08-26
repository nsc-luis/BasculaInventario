namespace BasculaInventario
{
    partial class FrmUsuario
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
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtPassUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.Location = new System.Drawing.Point(127, 224);
            this.btnGuardarTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarTurno.TabIndex = 5;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(127, 20);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(221, 22);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(16, 28);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre:";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblDescTurno_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(17, 69);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassUsuario
            // 
            this.lblPassUsuario.AutoSize = true;
            this.lblPassUsuario.Location = new System.Drawing.Point(16, 103);
            this.lblPassUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassUsuario.Name = "lblPassUsuario";
            this.lblPassUsuario.Size = new System.Drawing.Size(85, 17);
            this.lblPassUsuario.TabIndex = 7;
            this.lblPassUsuario.Text = "Contraseña:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(16, 190);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 17);
            this.lblPerfil.TabIndex = 8;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txtPassUsuario
            // 
            this.txtPassUsuario.Location = new System.Drawing.Point(127, 95);
            this.txtPassUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassUsuario.Name = "txtPassUsuario";
            this.txtPassUsuario.Size = new System.Drawing.Size(221, 22);
            this.txtPassUsuario.TabIndex = 9;
            this.txtPassUsuario.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(127, 59);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 22);
            this.txtUsuario.TabIndex = 10;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Items.AddRange(new object[] {
            "Operativo",
            "Administrativo"});
            this.cmbPerfil.Location = new System.Drawing.Point(127, 180);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(221, 24);
            this.cmbPerfil.TabIndex = 11;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(16, 145);
            this.lblConfirmacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(94, 17);
            this.lblConfirmacion.TabIndex = 12;
            this.lblConfirmacion.Text = "Confirmacion:";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(127, 135);
            this.txtConfirmacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(221, 22);
            this.txtConfirmacion.TabIndex = 13;
            this.txtConfirmacion.UseSystemPasswordChar = true;
            this.txtConfirmacion.TextChanged += new System.EventHandler(this.txtConfirmacion_TextChanged);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 263);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPassUsuario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblPassUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGuardarTurno);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarTurno;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassUsuario;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtPassUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacion;
    }
}