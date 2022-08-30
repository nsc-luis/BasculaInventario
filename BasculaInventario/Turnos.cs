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
    public partial class Turnos : Form
    {
        public Turnos()
        {
            InitializeComponent();
            ConsultaTurnos();
        }

        public void ConsultaTurnos()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridTurnos.DataSource = bd.ConsultarTurnos();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtTurno.Text = "";
        }


        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            if (txtTurno.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarTurno(txtTurno.Text);
                bd.conexion.Close();
                ConsultaTurnos();
                LimpiarFormilario();
            }
        }

        private void btnEditarTurno_Click(object sender, EventArgs e)
        {
            if (txtTurno.Text != "" && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarTurno(id, txtTurno.Text);
                bd.conexion.Close();
                ConsultaTurnos();
                LimpiarFormilario();
            }
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el turno: {txtTurno.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarTurno(id);
                    bd.conexion.Close();
                    ConsultaTurnos();
                    LimpiarFormilario();
                }
            }
        }

        private void gridTurnos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridTurnos.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridTurnos.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTurno.Text = gridTurnos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
