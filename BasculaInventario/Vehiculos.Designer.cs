namespace BasculaInventario
{
    partial class Vehiculos
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
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.gridVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnEditarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Location = new System.Drawing.Point(16, 50);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(56, 13);
            this.lblVehiculos.TabIndex = 14;
            this.lblVehiculos.Text = "Vehiculos:";
            // 
            // gridVehiculos
            // 
            this.gridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVehiculos.Location = new System.Drawing.Point(16, 68);
            this.gridVehiculos.Name = "gridVehiculos";
            this.gridVehiculos.Size = new System.Drawing.Size(261, 121);
            this.gridVehiculos.TabIndex = 13;
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(202, 15);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVehiculo.TabIndex = 12;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnEditarVehiculo
            // 
            this.btnEditarVehiculo.Location = new System.Drawing.Point(109, 15);
            this.btnEditarVehiculo.Name = "btnEditarVehiculo";
            this.btnEditarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVehiculo.TabIndex = 11;
            this.btnEditarVehiculo.Text = "Editar";
            this.btnEditarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(16, 15);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVehiculo.TabIndex = 10;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 206);
            this.Controls.Add(this.lblVehiculos);
            this.Controls.Add(this.gridVehiculos);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.btnEditarVehiculo);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.DataGridView gridVehiculos;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnEditarVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}