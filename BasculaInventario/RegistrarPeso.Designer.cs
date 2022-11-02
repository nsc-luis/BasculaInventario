namespace BasculaInventario
{
    partial class RegistrarPeso
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
            this.cmbOdT = new System.Windows.Forms.ComboBox();
            this.lblOdT = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.gridRegistrosDePeso = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnGuardarRegistro = new System.Windows.Forms.Button();
            this.txtKgPorUnidadDeProducto = new System.Windows.Forms.TextBox();
            this.lblProductoKG = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.lblKGSurtidos = new System.Windows.Forms.Label();
            this.txtKgPorSurtir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrdenDeTrabajo = new System.Windows.Forms.TextBox();
            this.lblOrdenDeTrabajo = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblFolioOdt = new System.Windows.Forms.Label();
            this.txtKgSurtidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistrosDePeso)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOdT
            // 
            this.cmbOdT.FormattingEnabled = true;
            this.cmbOdT.Location = new System.Drawing.Point(156, 36);
            this.cmbOdT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOdT.Name = "cmbOdT";
            this.cmbOdT.Size = new System.Drawing.Size(208, 24);
            this.cmbOdT.TabIndex = 0;
            this.cmbOdT.SelectionChangeCommitted += new System.EventHandler(this.cmbOdT_SelectionChangeCommitted);
            // 
            // lblOdT
            // 
            this.lblOdT.AutoSize = true;
            this.lblOdT.Location = new System.Drawing.Point(16, 46);
            this.lblOdT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdT.Name = "lblOdT";
            this.lblOdT.Size = new System.Drawing.Size(120, 17);
            this.lblOdT.TabIndex = 1;
            this.lblOdT.Text = "Orden de trabajo:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 95);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 17);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(156, 85);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(208, 24);
            this.cmbProducto.TabIndex = 3;
            this.cmbProducto.SelectionChangeCommitted += new System.EventHandler(this.cmbProducto_SelectionChangeCommitted);
            // 
            // gridRegistrosDePeso
            // 
            this.gridRegistrosDePeso.AllowUserToAddRows = false;
            this.gridRegistrosDePeso.AllowUserToDeleteRows = false;
            this.gridRegistrosDePeso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistrosDePeso.Location = new System.Drawing.Point(16, 347);
            this.gridRegistrosDePeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridRegistrosDePeso.Name = "gridRegistrosDePeso";
            this.gridRegistrosDePeso.ReadOnly = true;
            this.gridRegistrosDePeso.Size = new System.Drawing.Size(697, 192);
            this.gridRegistrosDePeso.TabIndex = 4;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(16, 327);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(72, 17);
            this.lblRegistros.TabIndex = 6;
            this.lblRegistros.Text = "Registros:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPeso.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPeso.Location = new System.Drawing.Point(61, 142);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(267, 78);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.Text = "9999.99";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegistro.Location = new System.Drawing.Point(71, 240);
            this.btnGuardarRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(244, 71);
            this.btnGuardarRegistro.TabIndex = 8;
            this.btnGuardarRegistro.Text = "Guardar e Imprimir";
            this.btnGuardarRegistro.UseVisualStyleBackColor = true;
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // txtKgPorUnidadDeProducto
            // 
            this.txtKgPorUnidadDeProducto.Location = new System.Drawing.Point(544, 178);
            this.txtKgPorUnidadDeProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKgPorUnidadDeProducto.Name = "txtKgPorUnidadDeProducto";
            this.txtKgPorUnidadDeProducto.ReadOnly = true;
            this.txtKgPorUnidadDeProducto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKgPorUnidadDeProducto.Size = new System.Drawing.Size(160, 22);
            this.txtKgPorUnidadDeProducto.TabIndex = 40;
            // 
            // lblProductoKG
            // 
            this.lblProductoKG.Location = new System.Drawing.Point(409, 164);
            this.lblProductoKG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductoKG.Name = "lblProductoKG";
            this.lblProductoKG.Size = new System.Drawing.Size(116, 39);
            this.lblProductoKG.TabIndex = 39;
            this.lblProductoKG.Text = "KG por unidad de producto:";
            this.lblProductoKG.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(544, 121);
            this.txtKilos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.ReadOnly = true;
            this.txtKilos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKilos.Size = new System.Drawing.Size(160, 22);
            this.txtKilos.TabIndex = 38;
            // 
            // lblKilos
            // 
            this.lblKilos.Location = new System.Drawing.Point(409, 111);
            this.lblKilos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(104, 34);
            this.lblKilos.TabIndex = 37;
            this.lblKilos.Text = "Total de KG de la orden:";
            this.lblKilos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblKGSurtidos
            // 
            this.lblKGSurtidos.Location = new System.Drawing.Point(409, 234);
            this.lblKGSurtidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKGSurtidos.Name = "lblKGSurtidos";
            this.lblKGSurtidos.Size = new System.Drawing.Size(116, 25);
            this.lblKGSurtidos.TabIndex = 41;
            this.lblKGSurtidos.Text = "KG surtidos:";
            this.lblKGSurtidos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblKGSurtidos.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKgPorSurtir
            // 
            this.txtKgPorSurtir.Location = new System.Drawing.Point(544, 279);
            this.txtKgPorSurtir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKgPorSurtir.Name = "txtKgPorSurtir";
            this.txtKgPorSurtir.ReadOnly = true;
            this.txtKgPorSurtir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKgPorSurtir.Size = new System.Drawing.Size(160, 22);
            this.txtKgPorSurtir.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(409, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "KG por surtir:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOrdenDeTrabajo
            // 
            this.txtOrdenDeTrabajo.Location = new System.Drawing.Point(544, 69);
            this.txtOrdenDeTrabajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrdenDeTrabajo.Name = "txtOrdenDeTrabajo";
            this.txtOrdenDeTrabajo.ReadOnly = true;
            this.txtOrdenDeTrabajo.Size = new System.Drawing.Size(160, 22);
            this.txtOrdenDeTrabajo.TabIndex = 48;
            // 
            // lblOrdenDeTrabajo
            // 
            this.lblOrdenDeTrabajo.Location = new System.Drawing.Point(409, 52);
            this.lblOrdenDeTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdenDeTrabajo.Name = "lblOrdenDeTrabajo";
            this.lblOrdenDeTrabajo.Size = new System.Drawing.Size(116, 42);
            this.lblOrdenDeTrabajo.TabIndex = 47;
            this.lblOrdenDeTrabajo.Text = "Orden de trabajo:";
            this.lblOrdenDeTrabajo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(544, 15);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(160, 22);
            this.txtFolio.TabIndex = 46;
            // 
            // lblFolioOdt
            // 
            this.lblFolioOdt.Location = new System.Drawing.Point(409, 15);
            this.lblFolioOdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolioOdt.Name = "lblFolioOdt";
            this.lblFolioOdt.Size = new System.Drawing.Size(116, 25);
            this.lblFolioOdt.TabIndex = 45;
            this.lblFolioOdt.Text = "Folio:";
            this.lblFolioOdt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtKgSurtidos
            // 
            this.txtKgSurtidos.Location = new System.Drawing.Point(544, 233);
            this.txtKgSurtidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKgSurtidos.Name = "txtKgSurtidos";
            this.txtKgSurtidos.ReadOnly = true;
            this.txtKgSurtidos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKgSurtidos.Size = new System.Drawing.Size(168, 22);
            this.txtKgSurtidos.TabIndex = 49;
            // 
            // RegistrarPeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 554);
            this.Controls.Add(this.txtKgSurtidos);
            this.Controls.Add(this.txtOrdenDeTrabajo);
            this.Controls.Add(this.lblOrdenDeTrabajo);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.lblFolioOdt);
            this.Controls.Add(this.txtKgPorSurtir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKGSurtidos);
            this.Controls.Add(this.txtKgPorUnidadDeProducto);
            this.Controls.Add(this.lblProductoKG);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.lblKilos);
            this.Controls.Add(this.btnGuardarRegistro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.gridRegistrosDePeso);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblOdT);
            this.Controls.Add(this.cmbOdT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrarPeso";
            this.Text = "RegistrarPeso";
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistrosDePeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOdT;
        private System.Windows.Forms.Label lblOdT;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DataGridView gridRegistrosDePeso;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnGuardarRegistro;
        private System.Windows.Forms.TextBox txtKgPorUnidadDeProducto;
        private System.Windows.Forms.Label lblProductoKG;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Label lblKGSurtidos;
        private System.Windows.Forms.TextBox txtKgPorSurtir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrdenDeTrabajo;
        private System.Windows.Forms.Label lblOrdenDeTrabajo;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblFolioOdt;
        private System.Windows.Forms.TextBox txtKgSurtidos;
    }
}