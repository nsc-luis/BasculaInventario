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
            this.aditivosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPERACIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexionABDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.aditivosMenuItem,
            this.coloresMenuItem,
            this.productosMenuItem,
            this.maquinasMenuItem,
            this.choferesMenuItem,
            this.vehiculosMenuItem});
            this.cATALOGOSToolStripMenuItem.Name = "cATALOGOSToolStripMenuItem";
            this.cATALOGOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cATALOGOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // aditivosMenuItem
            // 
            this.aditivosMenuItem.Name = "aditivosMenuItem";
            this.aditivosMenuItem.Size = new System.Drawing.Size(128, 22);
            this.aditivosMenuItem.Text = "Aditivos";
            this.aditivosMenuItem.Click += new System.EventHandler(this.aditivosMenuItem_Click);
            // 
            // coloresMenuItem
            // 
            this.coloresMenuItem.Name = "coloresMenuItem";
            this.coloresMenuItem.Size = new System.Drawing.Size(128, 22);
            this.coloresMenuItem.Text = "Colores";
            this.coloresMenuItem.Click += new System.EventHandler(this.coloresMenuItem_Click);
            // 
            // productosMenuItem
            // 
            this.productosMenuItem.Name = "productosMenuItem";
            this.productosMenuItem.Size = new System.Drawing.Size(128, 22);
            this.productosMenuItem.Text = "Productos";
            // 
            // maquinasMenuItem
            // 
            this.maquinasMenuItem.Name = "maquinasMenuItem";
            this.maquinasMenuItem.Size = new System.Drawing.Size(128, 22);
            this.maquinasMenuItem.Text = "Maquinas";
            this.maquinasMenuItem.Click += new System.EventHandler(this.maquinasMenuItem_Click);
            // 
            // choferesMenuItem
            // 
            this.choferesMenuItem.Name = "choferesMenuItem";
            this.choferesMenuItem.Size = new System.Drawing.Size(128, 22);
            this.choferesMenuItem.Text = "Choferes";
            this.choferesMenuItem.Click += new System.EventHandler(this.choferesMenuItem_Click);
            // 
            // vehiculosMenuItem
            // 
            this.vehiculosMenuItem.Name = "vehiculosMenuItem";
            this.vehiculosMenuItem.Size = new System.Drawing.Size(128, 22);
            this.vehiculosMenuItem.Text = "Vehiculos";
            this.vehiculosMenuItem.Click += new System.EventHandler(this.vehiculosMenuItem_Click);
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
            this.registrarPesoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.registrarPesoToolStripMenuItem.Text = "Registrar peso";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de trabajo";
            // 
            // salidasToolStripMenuItem
            // 
            this.salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            this.salidasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
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
            // turnosMenuItem
            // 
            this.turnosMenuItem.Name = "turnosMenuItem";
            this.turnosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.turnosMenuItem.Text = "Turnos";
            this.turnosMenuItem.Click += new System.EventHandler(this.turnosMenuItem_Click);
            // 
            // usuariosMenuItem
            // 
            this.usuariosMenuItem.Name = "usuariosMenuItem";
            this.usuariosMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosMenuItem.Text = "Usuarios";
            this.usuariosMenuItem.Click += new System.EventHandler(this.usuariosMenuItem_Click);
            // 
            // conexionABDToolStripMenuItem
            // 
            this.conexionABDToolStripMenuItem.Name = "conexionABDToolStripMenuItem";
            this.conexionABDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conexionABDToolStripMenuItem.Text = "Conexion a BD";
            this.conexionABDToolStripMenuItem.Click += new System.EventHandler(this.conexionABDToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem coloresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aditivosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choferesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosMenuItem;
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

