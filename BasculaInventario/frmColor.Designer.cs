namespace BasculaInventario
{
    partial class frmColor
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
            this.btnGuardarColor = new System.Windows.Forms.Button();
            this.txtDescColor = new System.Windows.Forms.TextBox();
            this.lblDescColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarColor
            // 
            this.btnGuardarColor.Location = new System.Drawing.Point(114, 56);
            this.btnGuardarColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarColor.Name = "btnGuardarColor";
            this.btnGuardarColor.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarColor.TabIndex = 8;
            this.btnGuardarColor.Text = "Guardar";
            this.btnGuardarColor.UseVisualStyleBackColor = true;
            // 
            // txtDescColor
            // 
            this.txtDescColor.Location = new System.Drawing.Point(114, 16);
            this.txtDescColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescColor.Name = "txtDescColor";
            this.txtDescColor.Size = new System.Drawing.Size(221, 22);
            this.txtDescColor.TabIndex = 7;
            // 
            // lblDescColor
            // 
            this.lblDescColor.AutoSize = true;
            this.lblDescColor.Location = new System.Drawing.Point(19, 21);
            this.lblDescColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescColor.Name = "lblDescColor";
            this.lblDescColor.Size = new System.Drawing.Size(82, 17);
            this.lblDescColor.TabIndex = 6;
            this.lblDescColor.Text = "Descripcion";
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 100);
            this.Controls.Add(this.btnGuardarColor);
            this.Controls.Add(this.txtDescColor);
            this.Controls.Add(this.lblDescColor);
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarColor;
        private System.Windows.Forms.TextBox txtDescColor;
        private System.Windows.Forms.Label lblDescColor;
    }
}