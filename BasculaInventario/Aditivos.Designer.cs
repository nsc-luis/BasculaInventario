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
            this.gridTurnos = new System.Windows.Forms.DataGridView();
            this.btnEliminarAditivo = new System.Windows.Forms.Button();
            this.btnEditarAditivo = new System.Windows.Forms.Button();
            this.btnAgregarAditivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAditivos
            // 
            this.lblAditivos.AutoSize = true;
            this.lblAditivos.Location = new System.Drawing.Point(13, 60);
            this.lblAditivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAditivos.Name = "lblAditivos";
            this.lblAditivos.Size = new System.Drawing.Size(61, 17);
            this.lblAditivos.TabIndex = 9;
            this.lblAditivos.Text = "Aditivos:";
            // 
            // gridTurnos
            // 
            this.gridTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTurnos.Location = new System.Drawing.Point(13, 83);
            this.gridTurnos.Margin = new System.Windows.Forms.Padding(4);
            this.gridTurnos.Name = "gridTurnos";
            this.gridTurnos.Size = new System.Drawing.Size(348, 149);
            this.gridTurnos.TabIndex = 8;
            // 
            // btnEliminarAditivo
            // 
            this.btnEliminarAditivo.Location = new System.Drawing.Point(261, 17);
            this.btnEliminarAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAditivo.Name = "btnEliminarAditivo";
            this.btnEliminarAditivo.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarAditivo.TabIndex = 7;
            this.btnEliminarAditivo.Text = "Eliminar";
            this.btnEliminarAditivo.UseVisualStyleBackColor = true;
            // 
            // btnEditarAditivo
            // 
            this.btnEditarAditivo.Location = new System.Drawing.Point(136, 17);
            this.btnEditarAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarAditivo.Name = "btnEditarAditivo";
            this.btnEditarAditivo.Size = new System.Drawing.Size(100, 28);
            this.btnEditarAditivo.TabIndex = 6;
            this.btnEditarAditivo.Text = "Editar";
            this.btnEditarAditivo.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAditivo
            // 
            this.btnAgregarAditivo.Location = new System.Drawing.Point(13, 18);
            this.btnAgregarAditivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarAditivo.Name = "btnAgregarAditivo";
            this.btnAgregarAditivo.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarAditivo.TabIndex = 5;
            this.btnAgregarAditivo.Text = "Agregar";
            this.btnAgregarAditivo.UseVisualStyleBackColor = true;
            this.btnAgregarAditivo.Click += new System.EventHandler(this.btnAgregarAditivo_Click);
            // 
            // Aditivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 248);
            this.Controls.Add(this.lblAditivos);
            this.Controls.Add(this.gridTurnos);
            this.Controls.Add(this.btnEliminarAditivo);
            this.Controls.Add(this.btnEditarAditivo);
            this.Controls.Add(this.btnAgregarAditivo);
            this.Name = "Aditivos";
            this.Text = "Aditivos";
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAditivos;
        private System.Windows.Forms.DataGridView gridTurnos;
        private System.Windows.Forms.Button btnEliminarAditivo;
        private System.Windows.Forms.Button btnEditarAditivo;
        private System.Windows.Forms.Button btnAgregarAditivo;
    }
}