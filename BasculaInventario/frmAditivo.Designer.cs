namespace BasculaInventario
{
    partial class frmAditivo
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
            this.btnGuardarAditivo = new System.Windows.Forms.Button();
            this.txtDescAditivo = new System.Windows.Forms.TextBox();
            this.lblDescAditivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarAditivo
            // 
            this.btnGuardarAditivo.Location = new System.Drawing.Point(110, 56);
            this.btnGuardarAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarAditivo.Name = "btnGuardarAditivo";
            this.btnGuardarAditivo.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarAditivo.TabIndex = 5;
            this.btnGuardarAditivo.Text = "Guardar";
            this.btnGuardarAditivo.UseVisualStyleBackColor = true;
            // 
            // txtDescAditivo
            // 
            this.txtDescAditivo.Location = new System.Drawing.Point(110, 13);
            this.txtDescAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescAditivo.Name = "txtDescAditivo";
            this.txtDescAditivo.Size = new System.Drawing.Size(221, 22);
            this.txtDescAditivo.TabIndex = 4;
            // 
            // lblDescAditivo
            // 
            this.lblDescAditivo.AutoSize = true;
            this.lblDescAditivo.Location = new System.Drawing.Point(15, 21);
            this.lblDescAditivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescAditivo.Name = "lblDescAditivo";
            this.lblDescAditivo.Size = new System.Drawing.Size(82, 17);
            this.lblDescAditivo.TabIndex = 3;
            this.lblDescAditivo.Text = "Descripcion";
            // 
            // frmAditivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 101);
            this.Controls.Add(this.btnGuardarAditivo);
            this.Controls.Add(this.txtDescAditivo);
            this.Controls.Add(this.lblDescAditivo);
            this.Name = "frmAditivo";
            this.Text = "frmAditivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAditivo;
        private System.Windows.Forms.TextBox txtDescAditivo;
        private System.Windows.Forms.Label lblDescAditivo;
    }
}