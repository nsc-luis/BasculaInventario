﻿namespace BasculaInventario
{
    partial class Usuarios
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
            this.lblTurnos = new System.Windows.Forms.Label();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Location = new System.Drawing.Point(16, 58);
            this.lblTurnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(68, 17);
            this.lblTurnos.TabIndex = 9;
            this.lblTurnos.Text = "Usuarios:";
            this.lblTurnos.Click += new System.EventHandler(this.lblTurnos_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(16, 81);
            this.gridUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(472, 149);
            this.gridUsuarios.TabIndex = 8;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(264, 15);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(139, 15);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnEditarUsuario.TabIndex = 6;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(16, 16);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarUsuario.TabIndex = 5;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 251);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
    }
}