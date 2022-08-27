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
            this.gridColores = new System.Windows.Forms.DataGridView();
            this.btnEliminarColor = new System.Windows.Forms.Button();
            this.btnEditarColor = new System.Windows.Forms.Button();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridColores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(10, 45);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(45, 13);
            this.lblColores.TabIndex = 14;
            this.lblColores.Text = "Colores:";
            // 
            // gridColores
            // 
            this.gridColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColores.Location = new System.Drawing.Point(10, 63);
            this.gridColores.Name = "gridColores";
            this.gridColores.Size = new System.Drawing.Size(261, 121);
            this.gridColores.TabIndex = 13;
            // 
            // btnEliminarColor
            // 
            this.btnEliminarColor.Location = new System.Drawing.Point(196, 10);
            this.btnEliminarColor.Name = "btnEliminarColor";
            this.btnEliminarColor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarColor.TabIndex = 12;
            this.btnEliminarColor.Text = "Eliminar";
            this.btnEliminarColor.UseVisualStyleBackColor = true;
            // 
            // btnEditarColor
            // 
            this.btnEditarColor.Location = new System.Drawing.Point(102, 10);
            this.btnEditarColor.Name = "btnEditarColor";
            this.btnEditarColor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarColor.TabIndex = 11;
            this.btnEditarColor.Text = "Editar";
            this.btnEditarColor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.Location = new System.Drawing.Point(10, 11);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarColor.TabIndex = 10;
            this.btnAgregarColor.Text = "Agregar";
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 197);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.gridColores);
            this.Controls.Add(this.btnEliminarColor);
            this.Controls.Add(this.btnEditarColor);
            this.Controls.Add(this.btnAgregarColor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Colores";
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.Colores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridColores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColores;
        private System.Windows.Forms.DataGridView gridColores;
        private System.Windows.Forms.Button btnEliminarColor;
        private System.Windows.Forms.Button btnEditarColor;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}