namespace BasculaInventario
{
    partial class Aditivos
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
            this.lblAditivos = new System.Windows.Forms.Label();
            this.gridAditivos = new System.Windows.Forms.DataGridView();
            this.btnEliminarAditivo = new System.Windows.Forms.Button();
            this.btnEditarAditivo = new System.Windows.Forms.Button();
            this.btnAgregarAditivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAditivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAditivos
            // 
            this.lblAditivos.AutoSize = true;
            this.lblAditivos.Location = new System.Drawing.Point(10, 49);
            this.lblAditivos.Name = "lblAditivos";
            this.lblAditivos.Size = new System.Drawing.Size(47, 13);
            this.lblAditivos.TabIndex = 9;
            this.lblAditivos.Text = "Aditivos:";
            // 
            // gridAditivos
            // 
            this.gridAditivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAditivos.Location = new System.Drawing.Point(10, 67);
            this.gridAditivos.Name = "gridAditivos";
            this.gridAditivos.Size = new System.Drawing.Size(261, 121);
            this.gridAditivos.TabIndex = 8;
            // 
            // btnEliminarAditivo
            // 
            this.btnEliminarAditivo.Location = new System.Drawing.Point(196, 14);
            this.btnEliminarAditivo.Name = "btnEliminarAditivo";
            this.btnEliminarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAditivo.TabIndex = 7;
            this.btnEliminarAditivo.Text = "Eliminar";
            this.btnEliminarAditivo.UseVisualStyleBackColor = true;
            // 
            // btnEditarAditivo
            // 
            this.btnEditarAditivo.Location = new System.Drawing.Point(102, 14);
            this.btnEditarAditivo.Name = "btnEditarAditivo";
            this.btnEditarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAditivo.TabIndex = 6;
            this.btnEditarAditivo.Text = "Editar";
            this.btnEditarAditivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAditivo
            // 
            this.btnAgregarAditivo.Location = new System.Drawing.Point(10, 15);
            this.btnAgregarAditivo.Name = "btnAgregarAditivo";
            this.btnAgregarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAditivo.TabIndex = 5;
            this.btnAgregarAditivo.Text = "Agregar";
            this.btnAgregarAditivo.UseVisualStyleBackColor = true;
            this.btnAgregarAditivo.Click += new System.EventHandler(this.btnAgregarAditivo_Click);
            // 
            // Aditivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.lblAditivos);
            this.Controls.Add(this.gridAditivos);
            this.Controls.Add(this.btnEliminarAditivo);
            this.Controls.Add(this.btnEditarAditivo);
            this.Controls.Add(this.btnAgregarAditivo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Aditivos";
            this.Text = "Aditivos";
            this.Load += new System.EventHandler(this.Aditivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAditivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAditivos;
        private System.Windows.Forms.DataGridView gridAditivos;
        private System.Windows.Forms.Button btnEliminarAditivo;
        private System.Windows.Forms.Button btnEditarAditivo;
        private System.Windows.Forms.Button btnAgregarAditivo;
    }
}