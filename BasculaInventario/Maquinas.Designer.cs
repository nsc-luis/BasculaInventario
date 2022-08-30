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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDescMaquina = new System.Windows.Forms.Label();
            this.txtDescMaquina = new System.Windows.Forms.TextBox();
            this.lblMaquinas = new System.Windows.Forms.Label();
            this.gridMaquinas = new System.Windows.Forms.DataGridView();
            this.btnEliminarMaquina = new System.Windows.Forms.Button();
            this.btnEditarMaquina = new System.Windows.Forms.Button();
            this.btnAgregarMaquina = new System.Windows.Forms.Button();
            this.lblNoMaquina = new System.Windows.Forms.Label();
            this.txtNoMaquina = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescMaquina
            // 
            this.lblDescMaquina.AutoSize = true;
            this.lblDescMaquina.Location = new System.Drawing.Point(19, 63);
            this.lblDescMaquina.Name = "lblDescMaquina";
            this.lblDescMaquina.Size = new System.Drawing.Size(66, 13);
            this.lblDescMaquina.TabIndex = 23;
            this.lblDescMaquina.Text = "Descripcion:";
            // 
            // txtDescMaquina
            // 
            this.txtDescMaquina.Location = new System.Drawing.Point(94, 56);
            this.txtDescMaquina.Name = "txtDescMaquina";
            this.txtDescMaquina.Size = new System.Drawing.Size(215, 20);
            this.txtDescMaquina.TabIndex = 22;
            // 
            // lblMaquinas
            // 
            this.lblMaquinas.AutoSize = true;
            this.lblMaquinas.Location = new System.Drawing.Point(19, 131);
            this.lblMaquinas.Name = "lblMaquinas";
            this.lblMaquinas.Size = new System.Drawing.Size(56, 13);
            this.lblMaquinas.TabIndex = 21;
            this.lblMaquinas.Text = "Maquinas:";
            // 
            // gridMaquinas
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMaquinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMaquinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridMaquinas.Location = new System.Drawing.Point(12, 147);
            this.gridMaquinas.Name = "gridMaquinas";
            this.gridMaquinas.Size = new System.Drawing.Size(435, 121);
            this.gridMaquinas.TabIndex = 20;
            this.gridMaquinas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridMaquinas_RowHeaderMouseClick);
            // 
            // btnEliminarMaquina
            // 
            this.btnEliminarMaquina.Location = new System.Drawing.Point(208, 96);
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMaquina.TabIndex = 19;
            this.btnEliminarMaquina.Text = "Eliminar";
            this.btnEliminarMaquina.UseVisualStyleBackColor = true;
            this.btnEliminarMaquina.Click += new System.EventHandler(this.btnEliminarMaquina_Click);
            // 
            // btnEditarMaquina
            // 
            this.btnEditarMaquina.Location = new System.Drawing.Point(114, 96);
            this.btnEditarMaquina.Name = "btnEditarMaquina";
            this.btnEditarMaquina.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMaquina.TabIndex = 18;
            this.btnEditarMaquina.Text = "Editar";
            this.btnEditarMaquina.UseVisualStyleBackColor = true;
            this.btnEditarMaquina.Click += new System.EventHandler(this.btnEditarMaquina_Click);
            // 
            // btnAgregarMaquina
            // 
            this.btnAgregarMaquina.Location = new System.Drawing.Point(22, 97);
            this.btnAgregarMaquina.Name = "btnAgregarMaquina";
            this.btnAgregarMaquina.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMaquina.TabIndex = 17;
            this.btnAgregarMaquina.Text = "Agregar";
            this.btnAgregarMaquina.UseVisualStyleBackColor = true;
            this.btnAgregarMaquina.Click += new System.EventHandler(this.btnAgregarMaquina_Click);
            // 
            // lblNoMaquina
            // 
            this.lblNoMaquina.AutoSize = true;
            this.lblNoMaquina.Location = new System.Drawing.Point(19, 22);
            this.lblNoMaquina.Name = "lblNoMaquina";
            this.lblNoMaquina.Size = new System.Drawing.Size(71, 13);
            this.lblNoMaquina.TabIndex = 24;
            this.lblNoMaquina.Text = "No. Maquina:";
            // 
            // txtNoMaquina
            // 
            this.txtNoMaquina.Location = new System.Drawing.Point(94, 15);
            this.txtNoMaquina.Name = "txtNoMaquina";
            this.txtNoMaquina.Size = new System.Drawing.Size(100, 20);
            this.txtNoMaquina.TabIndex = 25;
            // 
            // Maquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.txtNoMaquina);
            this.Controls.Add(this.lblNoMaquina);
            this.Controls.Add(this.lblDescMaquina);
            this.Controls.Add(this.txtDescMaquina);
            this.Controls.Add(this.lblMaquinas);
            this.Controls.Add(this.gridMaquinas);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.btnEditarMaquina);
            this.Controls.Add(this.btnAgregarMaquina);
            this.Name = "Maquinas";
            this.Text = "Maquinas";
            ((System.ComponentModel.ISupportInitialize)(this.gridMaquinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescMaquina;
        private System.Windows.Forms.TextBox txtDescMaquina;
        private System.Windows.Forms.Label lblMaquinas;
        private System.Windows.Forms.DataGridView gridMaquinas;
        private System.Windows.Forms.Button btnEliminarMaquina;
        private System.Windows.Forms.Button btnEditarMaquina;
        private System.Windows.Forms.Button btnAgregarMaquina;
        private System.Windows.Forms.Label lblNoMaquina;
        private System.Windows.Forms.TextBox txtNoMaquina;
    }
}