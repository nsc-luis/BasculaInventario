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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAditivo = new System.Windows.Forms.Label();
            this.txtAditivo = new System.Windows.Forms.TextBox();
            this.lblAditivos = new System.Windows.Forms.Label();
            this.gridAditivos = new System.Windows.Forms.DataGridView();
            this.btnEliminarAditivo = new System.Windows.Forms.Button();
            this.btnEditarAditivo = new System.Windows.Forms.Button();
            this.btnAgregarAditivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAditivos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAditivo
            // 
            this.lblAditivo.AutoSize = true;
            this.lblAditivo.Location = new System.Drawing.Point(19, 19);
            this.lblAditivo.Name = "lblAditivo";
            this.lblAditivo.Size = new System.Drawing.Size(45, 13);
            this.lblAditivo.TabIndex = 23;
            this.lblAditivo.Text = "Aditivo: ";
            // 
            // txtAditivo
            // 
            this.txtAditivo.Location = new System.Drawing.Point(68, 12);
            this.txtAditivo.Name = "txtAditivo";
            this.txtAditivo.Size = new System.Drawing.Size(215, 20);
            this.txtAditivo.TabIndex = 22;
            // 
            // lblAditivos
            // 
            this.lblAditivos.AutoSize = true;
            this.lblAditivos.Location = new System.Drawing.Point(19, 78);
            this.lblAditivos.Name = "lblAditivos";
            this.lblAditivos.Size = new System.Drawing.Size(47, 13);
            this.lblAditivos.TabIndex = 21;
            this.lblAditivos.Text = "Aditivos:";
            // 
            // gridAditivos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAditivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridAditivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAditivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridAditivos.Location = new System.Drawing.Point(12, 94);
            this.gridAditivos.Name = "gridAditivos";
            this.gridAditivos.Size = new System.Drawing.Size(294, 121);
            this.gridAditivos.TabIndex = 20;
            this.gridAditivos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridAditivos_RowHeaderMouseClick_1);
            // 
            // btnEliminarAditivo
            // 
            this.btnEliminarAditivo.Location = new System.Drawing.Point(208, 43);
            this.btnEliminarAditivo.Name = "btnEliminarAditivo";
            this.btnEliminarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAditivo.TabIndex = 19;
            this.btnEliminarAditivo.Text = "Eliminar";
            this.btnEliminarAditivo.UseVisualStyleBackColor = true;
            this.btnEliminarAditivo.Click += new System.EventHandler(this.btnEliminarAditivo_Click_1);
            // 
            // btnEditarAditivo
            // 
            this.btnEditarAditivo.Location = new System.Drawing.Point(114, 43);
            this.btnEditarAditivo.Name = "btnEditarAditivo";
            this.btnEditarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAditivo.TabIndex = 18;
            this.btnEditarAditivo.Text = "Editar";
            this.btnEditarAditivo.UseVisualStyleBackColor = true;
            this.btnEditarAditivo.Click += new System.EventHandler(this.btnEditarAditivo_Click_1);
            // 
            // btnAgregarAditivo
            // 
            this.btnAgregarAditivo.Location = new System.Drawing.Point(22, 44);
            this.btnAgregarAditivo.Name = "btnAgregarAditivo";
            this.btnAgregarAditivo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAditivo.TabIndex = 17;
            this.btnAgregarAditivo.Text = "Agregar";
            this.btnAgregarAditivo.UseVisualStyleBackColor = true;
            this.btnAgregarAditivo.Click += new System.EventHandler(this.btnAgregarAditivo_Click_1);
            // 
            // Aditivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 228);
            this.Controls.Add(this.lblAditivo);
            this.Controls.Add(this.txtAditivo);
            this.Controls.Add(this.lblAditivos);
            this.Controls.Add(this.gridAditivos);
            this.Controls.Add(this.btnEliminarAditivo);
            this.Controls.Add(this.btnEditarAditivo);
            this.Controls.Add(this.btnAgregarAditivo);
            this.Name = "Aditivos";
            this.Text = "Aditivos";
            ((System.ComponentModel.ISupportInitialize)(this.gridAditivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAditivo;
        private System.Windows.Forms.TextBox txtAditivo;
        private System.Windows.Forms.Label lblAditivos;
        private System.Windows.Forms.DataGridView gridAditivos;
        private System.Windows.Forms.Button btnEliminarAditivo;
        private System.Windows.Forms.Button btnEditarAditivo;
        private System.Windows.Forms.Button btnAgregarAditivo;
    }
}