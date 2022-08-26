namespace BasculaInventario
{
    partial class Colores
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
            this.lblColores = new System.Windows.Forms.Label();
            this.gridColor = new System.Windows.Forms.DataGridView();
            this.btnEliminarColor = new System.Windows.Forms.Button();
            this.btnEditarColor = new System.Windows.Forms.Button();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(13, 55);
            this.lblColores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(60, 17);
            this.lblColores.TabIndex = 14;
            this.lblColores.Text = "Colores:";
            // 
            // gridColor
            // 
            this.gridColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColor.Location = new System.Drawing.Point(13, 78);
            this.gridColor.Margin = new System.Windows.Forms.Padding(4);
            this.gridColor.Name = "gridColor";
            this.gridColor.Size = new System.Drawing.Size(348, 149);
            this.gridColor.TabIndex = 13;
            // 
            // btnEliminarColor
            // 
            this.btnEliminarColor.Location = new System.Drawing.Point(261, 12);
            this.btnEliminarColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarColor.Name = "btnEliminarColor";
            this.btnEliminarColor.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarColor.TabIndex = 12;
            this.btnEliminarColor.Text = "Eliminar";
            this.btnEliminarColor.UseVisualStyleBackColor = true;
            // 
            // btnEditarColor
            // 
            this.btnEditarColor.Location = new System.Drawing.Point(136, 12);
            this.btnEditarColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarColor.Name = "btnEditarColor";
            this.btnEditarColor.Size = new System.Drawing.Size(100, 28);
            this.btnEditarColor.TabIndex = 11;
            this.btnEditarColor.Text = "Editar";
            this.btnEditarColor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.Location = new System.Drawing.Point(13, 13);
            this.btnAgregarColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarColor.TabIndex = 10;
            this.btnAgregarColor.Text = "Agregar";
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 243);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.gridColor);
            this.Controls.Add(this.btnEliminarColor);
            this.Controls.Add(this.btnEditarColor);
            this.Controls.Add(this.btnAgregarColor);
            this.Name = "Colores";
            this.Text = "Colores";
            ((System.ComponentModel.ISupportInitialize)(this.gridColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.DataGridView gridColor;
        private System.Windows.Forms.Button btnEliminarColor;
        private System.Windows.Forms.Button btnEditarColor;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}