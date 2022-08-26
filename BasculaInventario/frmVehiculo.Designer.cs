namespace BasculaInventario
{
    partial class frmVehiculo
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
            this.btnGuardarPlacas = new System.Windows.Forms.Button();
            this.txtDescAditivo = new System.Windows.Forms.TextBox();
            this.lblDescVehiculo = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarPlacas
            // 
            this.btnGuardarPlacas.Location = new System.Drawing.Point(109, 98);
            this.btnGuardarPlacas.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPlacas.Name = "btnGuardarPlacas";
            this.btnGuardarPlacas.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarPlacas.TabIndex = 8;
            this.btnGuardarPlacas.Text = "Guardar";
            this.btnGuardarPlacas.UseVisualStyleBackColor = true;
            // 
            // txtDescAditivo
            // 
            this.txtDescAditivo.Location = new System.Drawing.Point(109, 13);
            this.txtDescAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescAditivo.Name = "txtDescAditivo";
            this.txtDescAditivo.Size = new System.Drawing.Size(221, 22);
            this.txtDescAditivo.TabIndex = 7;
            // 
            // lblDescVehiculo
            // 
            this.lblDescVehiculo.AutoSize = true;
            this.lblDescVehiculo.Location = new System.Drawing.Point(14, 21);
            this.lblDescVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescVehiculo.Name = "lblDescVehiculo";
            this.lblDescVehiculo.Size = new System.Drawing.Size(86, 17);
            this.lblDescVehiculo.TabIndex = 6;
            this.lblDescVehiculo.Text = "Descripcion:";
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(17, 60);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(54, 17);
            this.lblPlacas.TabIndex = 9;
            this.lblPlacas.Text = "Placas:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(109, 54);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(132, 22);
            this.txtPlacas.TabIndex = 10;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 141);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.btnGuardarPlacas);
            this.Controls.Add(this.txtDescAditivo);
            this.Controls.Add(this.lblDescVehiculo);
            this.Name = "frmVehiculo";
            this.Text = "frmVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPlacas;
        private System.Windows.Forms.TextBox txtDescAditivo;
        private System.Windows.Forms.Label lblDescVehiculo;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.TextBox txtPlacas;
    }
}