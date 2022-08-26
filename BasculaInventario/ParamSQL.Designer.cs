namespace BasculaInventario
{
    partial class ParamSQL
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
            this.btnGuardarParamSQLServer = new System.Windows.Forms.Button();
            this.txtPassSQL = new System.Windows.Forms.TextBox();
            this.txtUserSQL = new System.Windows.Forms.TextBox();
            this.txtBasededatos = new System.Windows.Forms.TextBox();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblPassSQL = new System.Windows.Forms.Label();
            this.lblUserSQL = new System.Windows.Forms.Label();
            this.lblBasededatos = new System.Windows.Forms.Label();
            this.lblInstancia = new System.Windows.Forms.Label();
            this.lblHostSQLServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardarParamSQLServer
            // 
            this.btnGuardarParamSQLServer.Location = new System.Drawing.Point(126, 204);
            this.btnGuardarParamSQLServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarParamSQLServer.Name = "btnGuardarParamSQLServer";
            this.btnGuardarParamSQLServer.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarParamSQLServer.TabIndex = 21;
            this.btnGuardarParamSQLServer.Text = "Guardar";
            this.btnGuardarParamSQLServer.UseVisualStyleBackColor = true;
            this.btnGuardarParamSQLServer.Click += new System.EventHandler(this.btnGuardarParamSQLServer_Click);
            // 
            // txtPassSQL
            // 
            this.txtPassSQL.Location = new System.Drawing.Point(126, 161);
            this.txtPassSQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassSQL.Name = "txtPassSQL";
            this.txtPassSQL.Size = new System.Drawing.Size(132, 22);
            this.txtPassSQL.TabIndex = 20;
            this.txtPassSQL.UseSystemPasswordChar = true;
            // 
            // txtUserSQL
            // 
            this.txtUserSQL.Location = new System.Drawing.Point(126, 120);
            this.txtUserSQL.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserSQL.Name = "txtUserSQL";
            this.txtUserSQL.Size = new System.Drawing.Size(132, 22);
            this.txtUserSQL.TabIndex = 19;
            // 
            // txtBasededatos
            // 
            this.txtBasededatos.Location = new System.Drawing.Point(126, 85);
            this.txtBasededatos.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasededatos.Name = "txtBasededatos";
            this.txtBasededatos.Size = new System.Drawing.Size(132, 22);
            this.txtBasededatos.TabIndex = 18;
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(126, 48);
            this.txtInstancia.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(132, 22);
            this.txtInstancia.TabIndex = 17;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(126, 13);
            this.txtHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(132, 22);
            this.txtHost.TabIndex = 16;
            // 
            // lblPassSQL
            // 
            this.lblPassSQL.AutoSize = true;
            this.lblPassSQL.Location = new System.Drawing.Point(15, 170);
            this.lblPassSQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassSQL.Name = "lblPassSQL";
            this.lblPassSQL.Size = new System.Drawing.Size(71, 17);
            this.lblPassSQL.TabIndex = 15;
            this.lblPassSQL.Text = "Pass SQL";
            // 
            // lblUserSQL
            // 
            this.lblUserSQL.AutoSize = true;
            this.lblUserSQL.Location = new System.Drawing.Point(15, 129);
            this.lblUserSQL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserSQL.Name = "lblUserSQL";
            this.lblUserSQL.Size = new System.Drawing.Size(70, 17);
            this.lblUserSQL.TabIndex = 14;
            this.lblUserSQL.Text = "User SQL";
            // 
            // lblBasededatos
            // 
            this.lblBasededatos.AutoSize = true;
            this.lblBasededatos.Location = new System.Drawing.Point(15, 95);
            this.lblBasededatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasededatos.Name = "lblBasededatos";
            this.lblBasededatos.Size = new System.Drawing.Size(99, 17);
            this.lblBasededatos.TabIndex = 13;
            this.lblBasededatos.Text = "Base de datos";
            // 
            // lblInstancia
            // 
            this.lblInstancia.AutoSize = true;
            this.lblInstancia.Location = new System.Drawing.Point(15, 56);
            this.lblInstancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstancia.Name = "lblInstancia";
            this.lblInstancia.Size = new System.Drawing.Size(79, 17);
            this.lblInstancia.TabIndex = 12;
            this.lblInstancia.Text = "INSTANCIA";
            // 
            // lblHostSQLServer
            // 
            this.lblHostSQLServer.AutoSize = true;
            this.lblHostSQLServer.Location = new System.Drawing.Point(15, 22);
            this.lblHostSQLServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostSQLServer.Name = "lblHostSQLServer";
            this.lblHostSQLServer.Size = new System.Drawing.Size(47, 17);
            this.lblHostSQLServer.TabIndex = 11;
            this.lblHostSQLServer.Text = "HOST";
            // 
            // ParamSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 246);
            this.Controls.Add(this.btnGuardarParamSQLServer);
            this.Controls.Add(this.txtPassSQL);
            this.Controls.Add(this.txtUserSQL);
            this.Controls.Add(this.txtBasededatos);
            this.Controls.Add(this.txtInstancia);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lblPassSQL);
            this.Controls.Add(this.lblUserSQL);
            this.Controls.Add(this.lblBasededatos);
            this.Controls.Add(this.lblInstancia);
            this.Controls.Add(this.lblHostSQLServer);
            this.Name = "ParamSQL";
            this.Text = "ParamSQL";
            this.Load += new System.EventHandler(this.ParamSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarParamSQLServer;
        private System.Windows.Forms.TextBox txtPassSQL;
        private System.Windows.Forms.TextBox txtUserSQL;
        private System.Windows.Forms.TextBox txtBasededatos;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblPassSQL;
        private System.Windows.Forms.Label lblUserSQL;
        private System.Windows.Forms.Label lblBasededatos;
        private System.Windows.Forms.Label lblInstancia;
        private System.Windows.Forms.Label lblHostSQLServer;
    }
}