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
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            frmColor frmColor = new frmColor();
            frmColor.Show();
        }

        private void Colores_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarColores());
            gridColores.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
