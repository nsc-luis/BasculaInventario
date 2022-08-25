namespace BasculaInventario
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.cATALOGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aditivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPERACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionABDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cATALOGOSToolStripMenuItem,
            this.oPERACIÓNToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem,
            this.salirMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(500, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // cATALOGOSToolStripMenuItem
            // 
            this.cATALOGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aditivosToolStripMenuItem,
            this.coloresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.maquinasToolStripMenuItem,
            this.operadoresToolStripMenuItem,
            this.trasporteToolStripMenuItem});
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.coloresToolStripMenuItem.Text = "Colores";
            // 
            // aditivosToolStripMenuItem
            // 
            this.aditivosToolStripMenuItem.Name = "aditivosToolStripMenuItem";
            this.aditivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aditivosToolStripMenuItem.Text = "Aditivos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // operadoresToolStripMenuItem
            // 
            this.operadoresToolStripMenuItem.Name = "operadoresToolStripMenuItem";
            this.operadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.operadoresToolStripMenuItem.Text = "Choferes";
            // 
            // maquinasToolStripMenuItem
            // 
            this.maquinasToolStripMenuItem.Name = "maquinasToolStripMenuItem";
            this.maquinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maquinasToolStripMenuItem.Text = "Maquinas";
            // 
            // trasporteToolStripMenuItem
            // 
            this.trasporteToolStripMenuItem.Name = "trasporteToolStripMenuItem";
            this.trasporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trasporteToolStripMenuItem.Text = "Vehiculos";
            // 
            // oPERACIÓNToolStripMenuItem
            // 
            this.oPERACIÓNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPesoToolStripMenuItem,
            this.ordenDeTrabajoToolStripMenuItem,
            this.salidasToolStripMenuItem});
            this.oPERACIÓNToolStripMenuItem.Name = "oPERACIÓNToolStripMenuItem";
            this.oPERACIÓNToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.oPERACIÓNToolStripMenuItem.Text = "OPERACION";
            // 
            // registrarPesoToolStripMenuItem
            // 
            this.registrarPesoToolStripMenuItem.Name = "registrarPesoToolStripMenuItem";
            this.registrarPesoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPesoToolStripMenuItem.Text = "Registrar peso";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de trabajo";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salidasToolStripMenuItem.Text = "Salidas";
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnosMenuItem,
            this.usuariosMenuItem,
            this.conexionABDToolStripMenuItem});
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // conexionABDToolStripMenuItem
            // 
            this.conexionABDToolStripMenuItem.Name = "conexionABDToolStripMenuItem";
            this.conexionABDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conexionABDToolStripMenuItem.Text = "Conexion a BD";
            // 
            // usuariosMenuItem
            // 
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosMenuItem.Text = "Usuarios";
            this.usuariosMenuItem.Click += new System.EventHandler(this.usuariosMenuItem_Click);
            // 
            // turnosMenuItem
            // 
            this.turnosMenuItem.Name = "turnosMenuItem";
            this.turnosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turnosMenuItem.Text = "Turnos";
            this.turnosMenuItem.Click += new System.EventHandler(this.turnosMenuItem_Click);
            // 
            // salirMenuItem
            // 
            this.salirMenuItem.Name = "salirMenuItem";
            this.salirMenuItem.Size = new System.Drawing.Size(49, 20);
            this.salirMenuItem.Text = "SALIR";
            this.salirMenuItem.Click += new System.EventHandler(this.salirMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 311);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem cATALOGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aditivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPERACIÓNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexionABDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirMenuItem;
    }
}

