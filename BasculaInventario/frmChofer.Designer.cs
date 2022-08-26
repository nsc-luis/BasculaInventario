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
            this.btnGuardarChofer.Location = new System.Drawing.Point(115, 100);
            this.btnGuardarChofer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarChofer.Name = "btnGuardarChofer";
            this.btnGuardarChofer.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarChofer.TabIndex = 8;
            this.btnGuardarChofer.Text = "Guardar";
            this.btnGuardarChofer.UseVisualStyleBackColor = true;
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(115, 13);
            this.txtNombreChofer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(221, 22);
            this.txtNombreChofer.TabIndex = 7;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Location = new System.Drawing.Point(20, 21);
            this.lblNombreChofer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(62, 17);
            this.lblNombreChofer.TabIndex = 6;
            this.lblNombreChofer.Text = "Nombre:";
            // 
            // lblLicenciaChofer
            // 
            this.lblLicenciaChofer.AutoSize = true;
            this.lblLicenciaChofer.Location = new System.Drawing.Point(23, 58);
            this.lblLicenciaChofer.Name = "lblLicenciaChofer";
            this.lblLicenciaChofer.Size = new System.Drawing.Size(64, 17);
            this.lblLicenciaChofer.TabIndex = 9;
            this.lblLicenciaChofer.Text = "Licencia:";
            // 
            // txtLicenciaChofer
            // 
            this.txtLicenciaChofer.Location = new System.Drawing.Point(115, 52);
            this.txtLicenciaChofer.Name = "txtLicenciaChofer";
            this.txtLicenciaChofer.Size = new System.Drawing.Size(133, 22);
            this.txtLicenciaChofer.TabIndex = 10;
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 151);
            this.Controls.Add(this.txtLicenciaChofer);
            this.Controls.Add(this.lblLicenciaChofer);
            this.Controls.Add(this.btnGuardarChofer);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.lblNombreChofer);
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