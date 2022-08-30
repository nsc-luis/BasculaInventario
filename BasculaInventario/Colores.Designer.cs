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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblColores = new System.Windows.Forms.Label();
            this.gridColores = new System.Windows.Forms.DataGridView();
            this.btnEliminarColor = new System.Windows.Forms.Button();
            this.btnEditarColor = new System.Windows.Forms.Button();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridColores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(19, 77);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(45, 13);
            this.lblColores.TabIndex = 14;
            this.lblColores.Text = "Colores:";
            // 
            // gridColores
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridColores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColores.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridColores.Location = new System.Drawing.Point(12, 93);
            this.gridColores.Name = "gridColores";
            this.gridColores.Size = new System.Drawing.Size(294, 121);
            this.gridColores.TabIndex = 13;
            this.gridColores.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridColores_RowHeaderMouseClick);
            // 
            // btnEliminarColor
            // 
            this.btnEliminarColor.Location = new System.Drawing.Point(208, 42);
            this.btnEliminarColor.Name = "btnEliminarColor";
            this.btnEliminarColor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarColor.TabIndex = 12;
            this.btnEliminarColor.Text = "Eliminar";
            this.btnEliminarColor.UseVisualStyleBackColor = true;
            this.btnEliminarColor.Click += new System.EventHandler(this.btnEliminarColor_Click);
            // 
            // btnEditarColor
            // 
            this.btnEditarColor.Location = new System.Drawing.Point(114, 42);
            this.btnEditarColor.Name = "btnEditarColor";
            this.btnEditarColor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarColor.TabIndex = 11;
            this.btnEditarColor.Text = "Editar";
            this.btnEditarColor.UseVisualStyleBackColor = true;
            this.btnEditarColor.Click += new System.EventHandler(this.btnEditarColor_Click);
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.Location = new System.Drawing.Point(22, 43);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarColor.TabIndex = 10;
            this.btnAgregarColor.Text = "Agregar";
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            this.btnAgregarColor.Click += new System.EventHandler(this.btnAgregarColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(68, 11);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(215, 20);
            this.txtColor.TabIndex = 15;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(19, 18);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 16;
            this.lblColor.Text = "Color: ";
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 225);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.gridColores);
            this.Controls.Add(this.btnEliminarColor);
            this.Controls.Add(this.btnEditarColor);
            this.Controls.Add(this.btnAgregarColor);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
    }
}