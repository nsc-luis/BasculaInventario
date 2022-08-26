namespace BasculaInventario
{
    partial class frmMaquina
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
            this.btnGuardarMaquina = new System.Windows.Forms.Button();
            this.txtDescMaquina = new System.Windows.Forms.TextBox();
            this.lblDescMaquina = new System.Windows.Forms.Label();
            this.lblNoMaquina = new System.Windows.Forms.Label();
            this.txtNoMaquina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarMaquina
            // 
            this.btnGuardarMaquina.Location = new System.Drawing.Point(109, 95);
            this.btnGuardarMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarMaquina.Name = "btnGuardarMaquina";
            this.btnGuardarMaquina.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarMaquina.TabIndex = 8;
            this.btnGuardarMaquina.Text = "Guardar";
            this.btnGuardarMaquina.UseVisualStyleBackColor = true;
            // 
            // txtDescMaquina
            // 
            this.txtDescMaquina.Location = new System.Drawing.Point(109, 56);
            this.txtDescMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescMaquina.Name = "txtDescMaquina";
            this.txtDescMaquina.Size = new System.Drawing.Size(221, 22);
            this.txtDescMaquina.TabIndex = 7;
            // 
            // lblDescMaquina
            // 
            this.lblDescMaquina.AutoSize = true;
            this.lblDescMaquina.Location = new System.Drawing.Point(14, 64);
            this.lblDescMaquina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescMaquina.Name = "lblDescMaquina";
            this.lblDescMaquina.Size = new System.Drawing.Size(86, 17);
            this.lblDescMaquina.TabIndex = 6;
            this.lblDescMaquina.Text = "Descripcion:";
            // 
            // lblNoMaquina
            // 
            this.lblNoMaquina.AutoSize = true;
            this.lblNoMaquina.Location = new System.Drawing.Point(14, 22);
            this.lblNoMaquina.Name = "lblNoMaquina";
            this.lblNoMaquina.Size = new System.Drawing.Size(92, 17);
            this.lblNoMaquina.TabIndex = 9;
            this.lblNoMaquina.Text = "No. maquina:";
            // 
            // txtNoMaquina
            // 
            this.txtNoMaquina.Location = new System.Drawing.Point(109, 17);
            this.txtNoMaquina.Name = "txtNoMaquina";
            this.txtNoMaquina.Size = new System.Drawing.Size(100, 22);
            this.txtNoMaquina.TabIndex = 10;
            // 
            // frmMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 141);
            this.Controls.Add(this.txtNoMaquina);
            this.Controls.Add(this.lblNoMaquina);
            this.Controls.Add(this.btnGuardarMaquina);
            this.Controls.Add(this.txtDescMaquina);
            this.Controls.Add(this.lblDescMaquina);
            this.Name = "frmMaquina";
            this.Text = "frmMaquina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarMaquina;
        private System.Windows.Forms.TextBox txtDescMaquina;
        private System.Windows.Forms.Label lblDescMaquina;
        private System.Windows.Forms.Label lblNoMaquina;
        private System.Windows.Forms.TextBox txtNoMaquina;
    }
}