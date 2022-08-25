namespace BasculaInventario
{
    partial class FrmTurno
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
            this.lblDescTurno = new System.Windows.Forms.Label();
            this.txtDescTurno = new System.Windows.Forms.TextBox();
            this.btnGuardarTurno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescTurno
            // 
            this.lblDescTurno.AutoSize = true;
            this.lblDescTurno.Location = new System.Drawing.Point(13, 28);
            this.lblDescTurno.Name = "lblDescTurno";
            this.lblDescTurno.Size = new System.Drawing.Size(63, 13);
            this.lblDescTurno.TabIndex = 0;
            this.lblDescTurno.Text = "Descripcion";
            // 
            // txtDescTurno
            // 
            this.txtDescTurno.Location = new System.Drawing.Point(84, 21);
            this.txtDescTurno.Name = "txtDescTurno";
            this.txtDescTurno.Size = new System.Drawing.Size(167, 20);
            this.txtDescTurno.TabIndex = 1;
            // 
            // btnGuardarTurno
            // 
            this.btnGuardarTurno.Location = new System.Drawing.Point(84, 56);
            this.btnGuardarTurno.Name = "btnGuardarTurno";
            this.btnGuardarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTurno.TabIndex = 2;
            this.btnGuardarTurno.Text = "Guardar";
            this.btnGuardarTurno.UseVisualStyleBackColor = true;
            this.btnGuardarTurno.Click += new System.EventHandler(this.btnGuardarTurno_Click);
            // 
            // FrmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 91);
            this.Controls.Add(this.btnGuardarTurno);
            this.Controls.Add(this.txtDescTurno);
            this.Controls.Add(this.lblDescTurno);
            this.Name = "FrmTurno";
            this.Text = "FrmTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescTurno;
        private System.Windows.Forms.TextBox txtDescTurno;
        private System.Windows.Forms.Button btnGuardarTurno;
    }
}