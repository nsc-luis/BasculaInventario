using System;

using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Maquinas : Form
    {
        public Maquinas()
        {
            InitializeComponent();
            ConsultaMaquinas();
        }

        public void ConsultaMaquinas()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridMaquinas.DataSource = bd.ConsultarMaquinas();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtNoMaquina.Text = "";
            txtDescMaquina.Text = "";
        }

        private void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            if (txtNoMaquina.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarMaquina(txtNoMaquina.Text, txtDescMaquina.Text);
                bd.conexion.Close();
                ConsultaMaquinas();
                LimpiarFormilario();
            }
        }

        private void btnEditarMaquina_Click(object sender, EventArgs e)
        {
            if (txtNoMaquina.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarMaquina(id, txtNoMaquina.Text, txtDescMaquina.Text);
                bd.conexion.Close();
                ConsultaMaquinas();
                LimpiarFormilario();
            }
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar la maquina: {txtNoMaquina.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarMaquina(id);
                    bd.conexion.Close();
                    ConsultaMaquinas();
                    LimpiarFormilario();
                }
            }
        }

        private void gridMaquinas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridMaquinas.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridMaquinas.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNoMaquina.Text = gridMaquinas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescMaquina.Text = gridMaquinas.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
