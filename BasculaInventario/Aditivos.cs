using System;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Aditivos : Form
    {
        public Aditivos()
        {
            InitializeComponent();
            ConsultaAditivos();
        }

        public void ConsultaAditivos()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridAditivos.DataSource = bd.ConsultarAditivos();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtAditivo.Text = "";
        }

        private void Colores_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarAditivo_Click_1(object sender, EventArgs e)
        {
            if (txtAditivo.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarAditivo(txtAditivo.Text);
                bd.conexion.Close();
                ConsultaAditivos();
                LimpiarFormilario();
            }
        }

        private void btnEditarAditivo_Click_1(object sender, EventArgs e)
        {
            if (txtAditivo.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarAditivo(id, txtAditivo.Text);
                bd.conexion.Close();
                ConsultaAditivos();
                LimpiarFormilario();
            }
        }

        private void btnEliminarAditivo_Click_1(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el aditivo: {txtAditivo.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarAditivo(id);
                    bd.conexion.Close();
                    ConsultaAditivos();
                    LimpiarFormilario();
                }
            }
        }

        private void gridAditivos_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridAditivos.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridAditivos.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtAditivo.Text = gridAditivos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
