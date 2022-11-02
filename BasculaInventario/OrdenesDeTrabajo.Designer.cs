namespace BasculaInventario
{
    partial class OrdenesDeTrabajo
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
            this.gridOdT = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbMaquinas = new System.Windows.Forms.ComboBox();
            this.btnEliminarOdT = new System.Windows.Forms.Button();
            this.btnEditarOdT = new System.Windows.Forms.Button();
            this.btnAgregarOdT = new System.Windows.Forms.Button();
            this.lblOrdenesDeTrabajo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdT)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOdT
            // 
            this.gridOdT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOdT.Location = new System.Drawing.Point(12, 259);
            this.gridOdT.Name = "gridOdT";
            this.gridOdT.Size = new System.Drawing.Size(464, 150);
            this.gridOdT.TabIndex = 0;
            this.gridOdT.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridOdT_RowHeaderMouseClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(22, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(107, 50);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folio:";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(107, 92);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(100, 20);
            this.txtOrden.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orden:";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(232, 57);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(71, 13);
            this.lblMaquina.TabIndex = 7;
            this.lblMaquina.Text = "No. Maquina:";
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(107, 138);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 10;
            // 
            // lblKilos
            // 
            this.lblKilos.Location = new System.Drawing.Point(23, 130);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(78, 28);
            this.lblKilos.TabIndex = 9;
            this.lblKilos.Text = "Total de KG de la orden:";
            this.lblKilos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(107, 12);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(200, 20);
            this.dpFecha.TabIndex = 13;
            // 
            // cmbMaquinas
            // 
            this.cmbMaquinas.FormattingEnabled = true;
            this.cmbMaquinas.Location = new System.Drawing.Point(333, 49);
            this.cmbMaquinas.Name = "cmbMaquinas";
            this.cmbMaquinas.Size = new System.Drawing.Size(121, 21);
            this.cmbMaquinas.TabIndex = 14;
            // 
            // btnEliminarOdT
            // 
            this.btnEliminarOdT.Location = new System.Drawing.Point(211, 196);
            this.btnEliminarOdT.Name = "btnEliminarOdT";
            this.btnEliminarOdT.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarOdT.TabIndex = 31;
            this.btnEliminarOdT.Text = "Eliminar";
            this.btnEliminarOdT.UseVisualStyleBackColor = true;
            this.btnEliminarOdT.Click += new System.EventHandler(this.btnEliminarOdT_Click);
            // 
            // btnEditarOdT
            // 
            this.btnEditarOdT.Location = new System.Drawing.Point(117, 196);
            this.btnEditarOdT.Name = "btnEditarOdT";
            this.btnEditarOdT.Size = new System.Drawing.Size(75, 23);
            this.btnEditarOdT.TabIndex = 30;
            this.btnEditarOdT.Text = "Editar";
            this.btnEditarOdT.UseVisualStyleBackColor = true;
            this.btnEditarOdT.Click += new System.EventHandler(this.btnEditarOdT_Click);
            // 
            // btnAgregarOdT
            // 
            this.btnAgregarOdT.Location = new System.Drawing.Point(25, 197);
            this.btnAgregarOdT.Name = "btnAgregarOdT";
            this.btnAgregarOdT.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarOdT.TabIndex = 29;
            this.btnAgregarOdT.Text = "Agregar";
            this.btnAgregarOdT.UseVisualStyleBackColor = true;
            this.btnAgregarOdT.Click += new System.EventHandler(this.btnAgregarOdT_Click);
            // 
            // lblOrdenesDeTrabajo
            // 
            this.lblOrdenesDeTrabajo.AutoSize = true;
            this.lblOrdenesDeTrabajo.Location = new System.Drawing.Point(20, 241);
            this.lblOrdenesDeTrabajo.Name = "lblOrdenesDeTrabajo";
            this.lblOrdenesDeTrabajo.Size = new System.Drawing.Size(100, 13);
            this.lblOrdenesDeTrabajo.TabIndex = 32;
            this.lblOrdenesDeTrabajo.Text = "Ordenes de trabajo:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(232, 99);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 33;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(333, 91);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbProductos.TabIndex = 34;
            // 
            // OrdenesDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 424);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblOrdenesDeTrabajo);
            this.Controls.Add(this.btnEliminarOdT);
            this.Controls.Add(this.btnEditarOdT);
            this.Controls.Add(this.btnAgregarOdT);
            this.Controls.Add(this.cmbMaquinas);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.lblKilos);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.gridOdT);
            this.Name = "OrdenesDeTrabajo";
            this.Text = "OrdenesDeTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.gridOdT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOdT;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.ComboBox cmbMaquinas;
        private System.Windows.Forms.Button btnEliminarOdT;
        private System.Windows.Forms.Button btnEditarOdT;
        private System.Windows.Forms.Button btnAgregarOdT;
        private System.Windows.Forms.Label lblOrdenesDeTrabajo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
    }
}