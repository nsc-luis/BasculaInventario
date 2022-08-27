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
    public partial class Maquinas : Form
    {
        public Maquinas()
        {
            InitializeComponent();
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            frmMaquina frmMaquina = new frmMaquina();
            frmMaquina.Show();
        }

        private void Maquinas_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarMaquinas());
            gridMaquinas.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
