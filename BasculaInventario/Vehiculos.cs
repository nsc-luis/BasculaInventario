using System;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Vehiculos : Form
    {
        public Vehiculos()
        {
            InitializeComponent();
            ConsultaVehiculos();
        }

        public void ConsultaVehiculos()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridVehiculos.DataSource = bd.ConsultarVehiculos();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtDescVehiculo.Text = "";
            txtPlacasVehiculos.Text = "";
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtDescVehiculo.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarVehiculo(txtDescVehiculo.Text, txtPlacasVehiculos.Text);
                bd.conexion.Close();
                ConsultaVehiculos();
                LimpiarFormilario();
            }
        }

        private void btnEditarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtDescVehiculo.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarVehiculo(id, txtDescVehiculo.Text, txtPlacasVehiculos.Text);
                bd.conexion.Close();
                ConsultaVehiculos();
                LimpiarFormilario();
            }
        }

        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el vehiculo: {txtDescVehiculo.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarVehiculo(id);
                    bd.conexion.Close();
                    ConsultaVehiculos();
                    LimpiarFormilario();
                }
            }
        }

        private void gridVehiculos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridVehiculos.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDescVehiculo.Text = gridVehiculos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPlacasVehiculos.Text = gridVehiculos.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
