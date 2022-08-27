namespace BasculaInventario
{
    partial class frmChofer
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
            this.btnGuardarChofer = new System.Windows.Forms.Button();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblLicenciaChofer = new System.Windows.Forms.Label();
            this.txtLicenciaChofer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarChofer
            // 
            this.btnGuardarChofer.Location = new System.Drawing.Point(86, 81);
            this.btnGuardarChofer.Name = "btnGuardarChofer";
            this.btnGuardarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarChofer.TabIndex = 8;
            this.btnGuardarChofer.Text = "Guardar";
            this.btnGuardarChofer.UseVisualStyleBackColor = true;
            this.btnGuardarChofer.Click += new System.EventHandler(this.btnGuardarChofer_Click);
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(86, 11);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(167, 20);
            this.txtNombreChofer.TabIndex = 7;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Location = new System.Drawing.Point(15, 17);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(47, 13);
            this.lblNombreChofer.TabIndex = 6;
            this.lblNombreChofer.Text = "Nombre:";
            // 
            // lblLicenciaChofer
            // 
            this.lblLicenciaChofer.AutoSize = true;
            this.lblLicenciaChofer.Location = new System.Drawing.Point(17, 47);
            this.lblLicenciaChofer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicenciaChofer.Name = "lblLicenciaChofer";
            this.lblLicenciaChofer.Size = new System.Drawing.Size(50, 13);
            this.lblLicenciaChofer.TabIndex = 9;
            this.lblLicenciaChofer.Text = "Licencia:";
            // 
            // txtLicenciaChofer
            // 
            this.txtLicenciaChofer.Location = new System.Drawing.Point(86, 42);
            this.txtLicenciaChofer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicenciaChofer.Name = "txtLicenciaChofer";
            this.txtLicenciaChofer.Size = new System.Drawing.Size(101, 20);
            this.txtLicenciaChofer.TabIndex = 10;
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 123);
            this.Controls.Add(this.txtLicenciaChofer);
            this.Controls.Add(this.lblLicenciaChofer);
            this.Controls.Add(this.btnGuardarChofer);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarChofer;
        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblLicenciaChofer;
        private System.Windows.Forms.TextBox txtLicenciaChofer;
    }
}