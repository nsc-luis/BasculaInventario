namespace BasculaInventario
{
    partial class Maquinas
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
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.gridMaquinas = new System.Windows.Forms.DataGridView();
            this.btnEliminarMaquina = new System.Windows.Forms.Button();
            this.btnEditarMaquina = new System.Windows.Forms.Button();
            this.btnAgregarMaquina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Location = new System.Drawing.Point(13, 54);
            this.lblMaquinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Size = new System.Drawing.Size(73, 17);
            this.lblMaquinas.TabIndex = 14;
            this.lblMaquinas.Text = "Maquinas:";
            // 
            // gridMaquinas
            // 
            this.gridMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMaquinas.Location = new System.Drawing.Point(13, 77);
            this.gridMaquinas.Margin = new System.Windows.Forms.Padding(4);
            this.gridMaquinas.Name = "gridMaquinas";
            this.gridMaquinas.Size = new System.Drawing.Size(348, 149);
            this.gridMaquinas.TabIndex = 13;
            // 
            // btnEliminarMaquina
            // 
            this.btnEliminarMaquina.Location = new System.Drawing.Point(261, 11);
            this.btnEliminarMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarMaquina.TabIndex = 12;
            this.btnEliminarMaquina.Text = "Eliminar";
            this.btnEliminarMaquina.UseVisualStyleBackColor = true;
            // 
            // btnEditarMaquina
            // 
            this.btnEditarMaquina.Location = new System.Drawing.Point(136, 11);
            this.btnEditarMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarMaquina.Name = "btnEditarMaquina";
            this.btnEditarMaquina.Size = new System.Drawing.Size(100, 28);
            this.btnEditarMaquina.TabIndex = 11;
            this.btnEditarMaquina.Text = "Editar";
            this.btnEditarMaquina.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.Location = new System.Drawing.Point(13, 12);
            this.btnAgregarMaquina.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarMaquina.TabIndex = 10;
            this.btnAgregarMaquina.Text = "Agregar";
            this.btnAgregarMaquina.UseVisualStyleBackColor = true;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 241);
            this.Controls.Add(this.lblMaquinas);
            this.Controls.Add(this.gridMaquinas);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.btnEditarMaquina);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Name = "Maquinas";
            this.Text = "Maquinas";
            this.Load += new System.EventHandler(this.Maquinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMaquinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.DataGridView gridMaquinas;
        private System.Windows.Forms.Button btnEliminarMaquina;
        private System.Windows.Forms.Button btnEditarMaquina;
        private System.Windows.Forms.Button btnAgregarMaquina;
    }
}