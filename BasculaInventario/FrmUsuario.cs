using System;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void lblDescTurno_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarTurno_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            bd.AgregarUsuario(txtNombreUsuario.Text, txtUsuario.Text, txtPassUsuario.Text, cmbPerfil.Text);
            bd.conexion.Close();
            this.Close();
        }
    }
}
