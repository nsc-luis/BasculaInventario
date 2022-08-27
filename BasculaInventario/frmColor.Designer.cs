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
            this.btnGuardarColor.Location = new System.Drawing.Point(86, 46);
            this.btnGuardarColor.Name = "btnGuardarColor";
            this.btnGuardarColor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarColor.TabIndex = 8;
            this.btnGuardarColor.Text = "Guardar";
            this.btnGuardarColor.UseVisualStyleBackColor = true;
            this.btnGuardarColor.Click += new System.EventHandler(this.btnGuardarColor_Click);
            // 
            // txtDescColor
            // 
            this.txtDescColor.Location = new System.Drawing.Point(86, 13);
            this.txtDescColor.Name = "txtDescColor";
            this.txtDescColor.Size = new System.Drawing.Size(167, 20);
            this.txtDescColor.TabIndex = 7;
            // 
            // lblDescColor
            // 
            this.lblDescColor.AutoSize = true;
            this.lblDescColor.Location = new System.Drawing.Point(14, 17);
            this.lblDescColor.Name = "lblDescColor";
            this.lblDescColor.Size = new System.Drawing.Size(63, 13);
            this.lblDescColor.TabIndex = 6;
            this.lblDescColor.Text = "Descripcion";
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 81);
            this.Controls.Add(this.btnGuardarColor);
            this.Controls.Add(this.txtDescColor);
            this.Controls.Add(this.lblDescColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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