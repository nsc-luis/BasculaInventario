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
    public partial class Choferes : Form
    {
        public Choferes()
        {
            InitializeComponent();
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            frmChofer frmChofer = new frmChofer();
            frmChofer.Show();
        }

        private void Choferes_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarChoferes());
            gridChoferes.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
