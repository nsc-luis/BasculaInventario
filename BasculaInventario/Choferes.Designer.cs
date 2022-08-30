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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombreChofer = new System.Windows.Forms.TextBox();
            this.lblNombreChofer = new System.Windows.Forms.Label();
            this.lblChoferes = new System.Windows.Forms.Label();
            this.gridChoferes = new System.Windows.Forms.DataGridView();
            this.btnEliminarChofer = new System.Windows.Forms.Button();
            this.btnEditarChofer = new System.Windows.Forms.Button();
            this.btnAgregarChofer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreChofer
            // 
            this.txtNombreChofer.Location = new System.Drawing.Point(66, 8);
            this.txtNombreChofer.Name = "txtNombreChofer";
            this.txtNombreChofer.Size = new System.Drawing.Size(217, 20);
            this.txtNombreChofer.TabIndex = 34;
            // 
            // lblNombreChofer
            // 
            this.lblNombreChofer.AutoSize = true;
            this.lblNombreChofer.Location = new System.Drawing.Point(13, 15);
            this.lblNombreChofer.Name = "lblNombreChofer";
            this.lblNombreChofer.Size = new System.Drawing.Size(47, 13);
            this.lblNombreChofer.TabIndex = 33;
            this.lblNombreChofer.Text = "Nombre:";
            // 
            // lblChoferes
            // 
            this.lblChoferes.AutoSize = true;
            this.lblChoferes.Location = new System.Drawing.Point(13, 89);
            this.lblChoferes.Name = "lblChoferes";
            this.lblChoferes.Size = new System.Drawing.Size(52, 13);
            this.lblChoferes.TabIndex = 30;
            this.lblChoferes.Text = "Choferes:";
            // 
            // gridChoferes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridChoferes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridChoferes.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridChoferes.Location = new System.Drawing.Point(12, 110);
            this.gridChoferes.Name = "gridChoferes";
            this.gridChoferes.Size = new System.Drawing.Size(320, 121);
            this.gridChoferes.TabIndex = 29;
            this.gridChoferes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridChoferes_RowHeaderMouseClick);
            // 
            // btnEliminarChofer
            // 
            this.btnEliminarChofer.Location = new System.Drawing.Point(208, 50);
            this.btnEliminarChofer.Name = "btnEliminarChofer";
            this.btnEliminarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarChofer.TabIndex = 28;
            this.btnEliminarChofer.Text = "Eliminar";
            this.btnEliminarChofer.UseVisualStyleBackColor = true;
            this.btnEliminarChofer.Click += new System.EventHandler(this.btnEliminarChofer_Click);
            // 
            // btnEditarChofer
            // 
            this.btnEditarChofer.Location = new System.Drawing.Point(114, 50);
            this.btnEditarChofer.Name = "btnEditarChofer";
            this.btnEditarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnEditarChofer.TabIndex = 27;
            this.btnEditarChofer.Text = "Editar";
            this.btnEditarChofer.UseVisualStyleBackColor = true;
            this.btnEditarChofer.Click += new System.EventHandler(this.btnEditarChofer_Click);
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Location = new System.Drawing.Point(22, 51);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarChofer.TabIndex = 26;
            this.btnAgregarChofer.Text = "Agregar";
            this.btnAgregarChofer.UseVisualStyleBackColor = true;
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 245);
            this.Controls.Add(this.txtNombreChofer);
            this.Controls.Add(this.lblNombreChofer);
            this.Controls.Add(this.lblChoferes);
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

        private System.Windows.Forms.TextBox txtNombreChofer;
        private System.Windows.Forms.Label lblNombreChofer;
        private System.Windows.Forms.Label lblChoferes;
        private System.Windows.Forms.DataGridView gridChoferes;
        private System.Windows.Forms.Button btnEliminarChofer;
        private System.Windows.Forms.Button btnEditarChofer;
        private System.Windows.Forms.Button btnAgregarChofer;
    }
}