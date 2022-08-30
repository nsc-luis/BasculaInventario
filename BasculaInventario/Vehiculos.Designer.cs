namespace BasculaInventario
{
    partial class Vehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescVehiculo = new System.Windows.Forms.TextBox();
            this.lblDescVehiculo = new System.Windows.Forms.Label();
            this.lblPlacasVehiculo = new System.Windows.Forms.Label();
            this.txtPlacasVehiculos = new System.Windows.Forms.TextBox();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.gridVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnEditarVehiculo = new System.Windows.Forms.Button();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescVehiculo
            // 
            this.txtDescVehiculo.Location = new System.Drawing.Point(94, 14);
            this.txtDescVehiculo.Name = "txtDescVehiculo";
            this.txtDescVehiculo.Size = new System.Drawing.Size(215, 20);
            this.txtDescVehiculo.TabIndex = 34;
            // 
            // lblDescVehiculo
            // 
            this.lblDescVehiculo.AutoSize = true;
            this.lblDescVehiculo.Location = new System.Drawing.Point(19, 21);
            this.lblDescVehiculo.Name = "lblDescVehiculo";
            this.lblDescVehiculo.Size = new System.Drawing.Size(66, 13);
            this.lblDescVehiculo.TabIndex = 33;
            this.lblDescVehiculo.Text = "Descripcion:";
            // 
            // lblPlacasVehiculo
            // 
            this.lblPlacasVehiculo.AutoSize = true;
            this.lblPlacasVehiculo.Location = new System.Drawing.Point(19, 62);
            this.lblPlacasVehiculo.Name = "lblPlacasVehiculo";
            this.lblPlacasVehiculo.Size = new System.Drawing.Size(42, 13);
            this.lblPlacasVehiculo.TabIndex = 32;
            this.lblPlacasVehiculo.Text = "Placas:";
            // 
            // txtPlacasVehiculos
            // 
            this.txtPlacasVehiculos.Location = new System.Drawing.Point(94, 55);
            this.txtPlacasVehiculos.Name = "txtPlacasVehiculos";
            this.txtPlacasVehiculos.Size = new System.Drawing.Size(95, 20);
            this.txtPlacasVehiculos.TabIndex = 31;
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Location = new System.Drawing.Point(19, 130);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(56, 13);
            this.lblVehiculos.TabIndex = 30;
            this.lblVehiculos.Text = "Vehiculos:";
            // 
            // gridVehiculos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVehiculos.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridVehiculos.Location = new System.Drawing.Point(12, 146);
            this.gridVehiculos.Name = "gridVehiculos";
            this.gridVehiculos.Size = new System.Drawing.Size(435, 121);
            this.gridVehiculos.TabIndex = 29;
            this.gridVehiculos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridVehiculos_RowHeaderMouseClick);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(208, 95);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVehiculo.TabIndex = 28;
            this.btnEliminarVehiculo.Text = "Eliminar";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.btnEliminarVehiculo_Click);
            // 
            // btnEditarVehiculo
            // 
            this.btnEditarVehiculo.Location = new System.Drawing.Point(114, 95);
            this.btnEditarVehiculo.Name = "btnEditarVehiculo";
            this.btnEditarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVehiculo.TabIndex = 27;
            this.btnEditarVehiculo.Text = "Editar";
            this.btnEditarVehiculo.UseVisualStyleBackColor = true;
            this.btnEditarVehiculo.Click += new System.EventHandler(this.btnEditarVehiculo_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(22, 96);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVehiculo.TabIndex = 26;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 281);
            this.Controls.Add(this.txtDescVehiculo);
            this.Controls.Add(this.lblDescVehiculo);
            this.Controls.Add(this.lblPlacasVehiculo);
            this.Controls.Add(this.txtPlacasVehiculos);
            this.Controls.Add(this.lblVehiculos);
            this.Controls.Add(this.gridVehiculos);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.btnEditarVehiculo);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.gridVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescVehiculo;
        private System.Windows.Forms.Label lblDescVehiculo;
        private System.Windows.Forms.Label lblPlacasVehiculo;
        private System.Windows.Forms.TextBox txtPlacasVehiculos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.DataGridView gridVehiculos;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnEditarVehiculo;
        private System.Windows.Forms.Button btnAgregarVehiculo;
    }
}