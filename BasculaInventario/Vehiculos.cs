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
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo();
            frmVehiculo.Show();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarVehiculos());
            gridVehiculos.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
