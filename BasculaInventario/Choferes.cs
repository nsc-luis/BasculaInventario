using System;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Choferes : Form
    {
        public Choferes()
        {
            InitializeComponent();
            ConsultaChoferes();
        }

        public void ConsultaChoferes()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridChoferes.DataSource = bd.ConsultarChoferes();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtNombreChofer.Text = "";
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            if (txtNombreChofer.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarChofer(txtNombreChofer.Text);
                bd.conexion.Close();
                ConsultaChoferes();
                LimpiarFormilario();
            }
        }

        private void btnEditarChofer_Click(object sender, EventArgs e)
        {
            if (txtNombreChofer.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarChofer(id, txtNombreChofer.Text);
                bd.conexion.Close();
                ConsultaChoferes();
                LimpiarFormilario();
            }
        }

        private void btnEliminarChofer_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el chofer: {txtNombreChofer.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarChofer(id);
                    bd.conexion.Close();
                    ConsultaChoferes();
                    LimpiarFormilario();
                }
            }
        }

        private void gridChoferes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridChoferes.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridChoferes.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNombreChofer.Text = gridChoferes.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
