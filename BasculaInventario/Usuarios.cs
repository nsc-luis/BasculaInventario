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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            ConsultaUsuarios();
        }

        public void ConsultaUsuarios()
        {
            BaseDeDatos bd = new BaseDeDatos();
            gridUsuarios.DataSource = bd.ConsultarUsuarios();
        }

        int id = 0;
        public void LimpiarFormilario()
        {
            id = 0;
            txtNombreUsuario.Text = "";
            txtUsuario.Text = "";
            txtPassUsuario.Text = "";
            txtConfirmacion.Text = "";
            cmbPerfil.Text = "";
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != ""
                && txtUsuario.Text != ""
                && txtPassUsuario.Text != ""
                && txtConfirmacion.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarUsuario(txtNombreUsuario.Text, txtUsuario.Text, txtPassUsuario.Text, cmbPerfil.Text);
                bd.conexion.Close();
                ConsultaUsuarios();
                LimpiarFormilario();
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != ""
                && txtUsuario.Text != ""
                && txtPassUsuario.Text != ""
                && cmbPerfil.Text != ""
                && id != 0)
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.EditarUsuario(id, txtNombreUsuario.Text, txtUsuario.Text, txtPassUsuario.Text, cmbPerfil.Text);
                bd.conexion.Close();
                ConsultaUsuarios();
                LimpiarFormilario();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el usuario: {txtNombreUsuario.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BaseDeDatos bd = new BaseDeDatos();
                    bd.EliminarUsuario(id);
                    bd.conexion.Close();
                    ConsultaUsuarios();
                    LimpiarFormilario();
                }
            }
        }

        private void gridUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridUsuarios.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNombreUsuario.Text = gridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtUsuario.Text = gridUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPassUsuario.Text = "";
                txtConfirmacion.Text = "";
                cmbPerfil.Text = gridUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else
            {
                LimpiarFormilario();
            }
        }
    }
}
