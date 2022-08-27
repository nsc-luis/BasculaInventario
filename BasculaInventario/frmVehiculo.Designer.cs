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
            this.txtDescVehiculo = new System.Windows.Forms.TextBox();
            this.lblDescVehiculo = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardarPlacas
            // 
            this.btnGuardarPlacas.Location = new System.Drawing.Point(82, 80);
            this.btnGuardarPlacas.Name = "btnGuardarPlacas";
            this.btnGuardarPlacas.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPlacas.TabIndex = 8;
            this.btnGuardarPlacas.Text = "Guardar";
            this.btnGuardarPlacas.UseVisualStyleBackColor = true;
            this.btnGuardarPlacas.Click += new System.EventHandler(this.btnGuardarPlacas_Click);
            // 
            // txtDescVehiculo
            // 
            this.txtDescVehiculo.Location = new System.Drawing.Point(82, 11);
            this.txtDescVehiculo.Name = "txtDescVehiculo";
            this.txtDescVehiculo.Size = new System.Drawing.Size(167, 20);
            this.txtDescVehiculo.TabIndex = 7;
            // 
            // lblDescVehiculo
            // 
            this.lblDescVehiculo.AutoSize = true;
            this.lblDescVehiculo.Location = new System.Drawing.Point(10, 17);
            this.lblDescVehiculo.Name = "lblDescVehiculo";
            this.lblDescVehiculo.Size = new System.Drawing.Size(66, 13);
            this.lblDescVehiculo.TabIndex = 6;
            this.lblDescVehiculo.Text = "Descripcion:";
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(13, 49);
            this.lblPlacas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(42, 13);
            this.lblPlacas.TabIndex = 9;
            this.lblPlacas.Text = "Placas:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(82, 44);
            this.txtPlacas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 10;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 115);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.btnGuardarPlacas);
            this.Controls.Add(this.txtDescVehiculo);
            this.Controls.Add(this.lblDescVehiculo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehiculo";
            this.Text = "frmVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPlacas;
        private System.Windows.Forms.TextBox txtDescVehiculo;
        private System.Windows.Forms.Label lblDescVehiculo;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.TextBox txtPlacas;
    }
}