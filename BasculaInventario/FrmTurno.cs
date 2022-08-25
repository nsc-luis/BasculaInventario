﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class FrmTurno : Form
    {
        public FrmTurno()
        {
            InitializeComponent();
        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            bd.AgregarTurno(txtDescTurno.Text);
            bd.conexion.Close();
            this.Close();
        }
    }
}
