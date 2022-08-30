using System;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Colores : Form
    {
        public Colores()
        {
            InitializeComponent();
            ConsultaColores();
        }

        public void ConsultaColores()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridColores.DataSource = bd.ConsultarColores();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtColor.Text = "";
        }

        private void btnAgregarColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarColor(txtColor.Text);
                bd.conexion.Close();
                ConsultaColores();
                LimpiarFormilario();
            }
        }

        private void Colores_Load(object sender, EventArgs e)
        {

        }

        private void gridColores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridColores.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridColores.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtColor.Text = gridColores.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }

        private void btnEditarColor_Click(object sender, EventArgs e)
        {
            if (txtColor.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditartColor(id, txtColor.Text);
                bd.conexion.Close();
                ConsultaColores();
                LimpiarFormilario();
            }
        }

        private void btnEliminarColor_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el color: {txtColor.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarColor(id);
                    bd.conexion.Close();
                    ConsultaColores();
                    LimpiarFormilario();
                }
            }
        }
    }
}
