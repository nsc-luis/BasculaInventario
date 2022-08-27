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
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void btnGuardarPlacas_Click(object sender, EventArgs e)
        {
            if (txtDescVehiculo.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarVehiculo(txtDescVehiculo.Text, txtPlacas.Text);
                bd.conexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: \n Debes ingresar al menos la descripcion del vehiculo.");
            }
        }
    }
}
