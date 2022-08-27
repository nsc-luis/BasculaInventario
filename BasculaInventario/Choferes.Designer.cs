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
            this.lblAditivos.Location = new System.Drawing.Point(10, 42);
            this.lblAditivos.Name = "lblAditivos";
            this.lblAditivos.Size = new System.Drawing.Size(52, 13);
            this.lblAditivos.TabIndex = 14;
            this.lblAditivos.Text = "Choferes:";
            // 
            // gridChoferes
            // 
            this.gridChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChoferes.Location = new System.Drawing.Point(10, 61);
            this.gridChoferes.Name = "gridChoferes";
            this.gridChoferes.Size = new System.Drawing.Size(261, 121);
            this.gridChoferes.TabIndex = 13;
            // 
            // btnEliminarChofer
            // 
            this.btnEliminarChofer.Location = new System.Drawing.Point(196, 7);
            this.btnEliminarChofer.Name = "btnEliminarChofer";
            this.btnEliminarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarChofer.TabIndex = 12;
            this.btnEliminarChofer.Text = "Eliminar";
            this.btnEliminarChofer.UseVisualStyleBackColor = true;
            // 
            // btnEditarChofer
            // 
            this.btnEditarChofer.Location = new System.Drawing.Point(102, 7);
            this.btnEditarChofer.Name = "btnEditarChofer";
            this.btnEditarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnEditarChofer.TabIndex = 11;
            this.btnEditarChofer.Text = "Editar";
            this.btnEditarChofer.UseVisualStyleBackColor = true;
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(10, 8);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarChofer.TabIndex = 10;
            this.btnAgregarChofer.Text = "Agregar";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 193);
            this.Controls.Add(this.lblAditivos);
            this.Controls.Add(this.gridChoferes);
            this.Controls.Add(this.btnEliminarChofer);
            this.Controls.Add(this.btnEditarChofer);
            this.Controls.Add(this.btnAgregarChofer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Choferes";
            this.Text = "Choferes";
            this.Load += new System.EventHandler(this.Choferes_Load);
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