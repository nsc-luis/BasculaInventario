namespace BasculaInventario
{
    partial class Turnos
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
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.gridTurnos = new System.Windows.Forms.DataGridView();
            this.btnEliminarTurno = new System.Windows.Forms.Button();
            this.btnEditarTurno = new System.Windows.Forms.Button();
            this.btnAgregarTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(19, 18);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 23;
            this.lblTurno.Text = "Turno:";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(68, 11);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(215, 20);
            this.txtTurno.TabIndex = 22;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Location = new System.Drawing.Point(19, 77);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(43, 13);
            this.lblTurnos.TabIndex = 21;
            this.lblTurnos.Text = "Turnos:";
            // 
            // gridTurnos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTurnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTurnos.Location = new System.Drawing.Point(12, 93);
            this.gridTurnos.Name = "gridTurnos";
            this.gridTurnos.Size = new System.Drawing.Size(294, 121);
            this.gridTurnos.TabIndex = 20;
            this.gridTurnos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTurnos_RowHeaderMouseClick);
            // 
            // btnEliminarTurno
            // 
            this.btnEliminarTurno.Location = new System.Drawing.Point(208, 42);
            this.btnEliminarTurno.Name = "btnEliminarTurno";
            this.btnEliminarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTurno.TabIndex = 19;
            this.btnEliminarTurno.Text = "Eliminar";
            this.btnEliminarTurno.UseVisualStyleBackColor = true;
            this.btnEliminarTurno.Click += new System.EventHandler(this.btnEliminarTurno_Click);
            // 
            // btnEditarTurno
            // 
            this.btnEditarTurno.Location = new System.Drawing.Point(114, 42);
            this.btnEditarTurno.Name = "btnEditarTurno";
            this.btnEditarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTurno.TabIndex = 18;
            this.btnEditarTurno.Text = "Editar";
            this.btnEditarTurno.UseVisualStyleBackColor = true;
            this.btnEditarTurno.Click += new System.EventHandler(this.btnEditarTurno_Click);
            // 
            // btnAgregarTurno
            // 
            this.btnAgregarTurno.Location = new System.Drawing.Point(22, 43);
            this.btnAgregarTurno.Name = "btnAgregarTurno";
            this.btnAgregarTurno.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTurno.TabIndex = 17;
            this.btnAgregarTurno.Text = "Agregar";
            this.btnAgregarTurno.UseVisualStyleBackColor = true;
            this.btnAgregarTurno.Click += new System.EventHandler(this.btnAgregarTurno_Click);
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.gridTurnos);
            this.Controls.Add(this.btnEliminarTurno);
            this.Controls.Add(this.btnEditarTurno);
            this.Controls.Add(this.btnAgregarTurno);
            this.Name = "Turnos";
            this.Text = "Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.gridTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.DataGridView gridTurnos;
        private System.Windows.Forms.Button btnEliminarTurno;
        private System.Windows.Forms.Button btnEditarTurno;
        private System.Windows.Forms.Button btnAgregarTurno;
    }
}