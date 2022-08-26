namespace BasculaInventario
{
    partial class Choferes
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
            this.gridChoferes = new System.Windows.Forms.DataGridView();
            this.btnEliminarChofer = new System.Windows.Forms.Button();
            this.btnEditarChofer = new System.Windows.Forms.Button();
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAditivos
            // 
            this.lblAditivos.AutoSize = true;
            this.lblAditivos.Location = new System.Drawing.Point(13, 52);
            this.lblAditivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAditivos.Name = "lblAditivos";
            this.lblAditivos.Size = new System.Drawing.Size(69, 17);
            this.lblAditivos.TabIndex = 14;
            this.lblAditivos.Text = "Choferes:";
            // 
            // gridChoferes
            // 
            this.gridChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChoferes.Location = new System.Drawing.Point(13, 75);
            this.gridChoferes.Margin = new System.Windows.Forms.Padding(4);
            this.gridChoferes.Name = "gridChoferes";
            this.gridChoferes.Size = new System.Drawing.Size(348, 149);
            this.gridChoferes.TabIndex = 13;
            // 
            // btnEliminarChofer
            // 
            this.btnEliminarChofer.Location = new System.Drawing.Point(261, 9);
            this.btnEliminarChofer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarChofer.Name = "btnEliminarChofer";
            this.btnEliminarChofer.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarChofer.TabIndex = 12;
            this.btnEliminarChofer.Text = "Eliminar";
            this.btnEliminarChofer.UseVisualStyleBackColor = true;
            // 
            // btnEditarChofer
            // 
            this.btnEditarChofer.Location = new System.Drawing.Point(136, 9);
            this.btnEditarChofer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarChofer.Name = "btnEditarChofer";
            this.btnEditarChofer.Size = new System.Drawing.Size(100, 28);
            this.btnEditarChofer.TabIndex = 11;
            this.btnEditarChofer.Text = "Editar";
            this.btnEditarChofer.UseVisualStyleBackColor = true;
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(13, 10);
            this.btnAgregarChofer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarChofer.TabIndex = 10;
            this.btnAgregarChofer.Text = "Agregar";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 238);
            this.Controls.Add(this.lblAditivos);
            this.Controls.Add(this.gridChoferes);
            this.Controls.Add(this.btnEliminarChofer);
            this.Controls.Add(this.btnEditarChofer);
            this.Controls.Add(this.btnAgregarChofer);
            this.Name = "Choferes";
            this.Text = "Choferes";
            ((System.ComponentModel.ISupportInitialize)(this.gridChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAditivos;
        private System.Windows.Forms.DataGridView gridChoferes;
        private System.Windows.Forms.Button btnEliminarChofer;
        private System.Windows.Forms.Button btnEditarChofer;
        private System.Windows.Forms.Button btnAgregarChofer;
    }
}