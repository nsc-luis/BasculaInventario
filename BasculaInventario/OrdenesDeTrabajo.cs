using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class OrdenesDeTrabajo : Form
    {
        int id = 0;
        BaseDeDatos bd;
        DataTable dt;
        public class Maquina
        {
            public int idMaquina { get; set; }
            public int numeroMaquina { get; set; }
        }
        public OrdenesDeTrabajo()
        {
            InitializeComponent();
            ListaOrdenesDeTrabajo();
            ComboMaquinas();
        }

        public void ListaOrdenesDeTrabajo()
        {
            bd = new BaseDeDatos();
            gridOdT.DataSource = bd.ConsultarOdT();
            bd.conexion.Close();
        }
        
        public void LimpiarFormulario()
        {
            txtFolio.Text = "";
            txtKilos.Text = null;
            txtOrden.Text = "";
            cmbMaquinas.SelectedValue = 0;
        }

        public void ComboMaquinas(){
            bd = new BaseDeDatos();
            dt = new DataTable();
            List<Maquina> ListaMaquinas = new List<Maquina>();
            dt = bd.ConsultarMaquinas();
            bd.conexion.Close();
            ListaMaquinas.Add(new Maquina { idMaquina = 0, numeroMaquina = 0 });
            foreach (DataRow row in dt.Rows)
            {
                ListaMaquinas.Add(new Maquina { idMaquina = Int32.Parse(row[0].ToString()), numeroMaquina = int.Parse(row[1].ToString()) });
            }
            cmbMaquinas.DataSource = ListaMaquinas;
            cmbMaquinas.DisplayMember = "numeroMaquina";
            cmbMaquinas.ValueMember = "idMaquina";
        }

        private void btnAgregarOdT_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.AgregarOdT(txtFolio.Text, txtOrden.Text, Int32.Parse(cmbMaquinas.SelectedValue.ToString()), Int32.Parse(txtKilos.Text), dpFecha.Value.ToString("yyyy-MM-dd"));
            bd.conexion.Close();
            ListaOrdenesDeTrabajo();
            LimpiarFormulario();
        }

        private void gridOdT_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridOdT.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridOdT.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtFolio.Text = gridOdT.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOrden.Text = gridOdT.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbMaquinas.SelectedValue = int.Parse(gridOdT.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtKilos.Text = gridOdT.Rows[e.RowIndex].Cells[4].Value.ToString();
                dpFecha.Text = gridOdT.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void btnEditarOdT_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.EditarOdT(id, txtFolio.Text, txtOrden.Text, Int32.Parse(cmbMaquinas.SelectedValue.ToString()), Int32.Parse(txtKilos.Text), dpFecha.Value.ToString("yyyy-MM-dd"));
            bd.conexion.Close();
            ListaOrdenesDeTrabajo();
            LimpiarFormulario();
        }

        private void btnEliminarOdT_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar la orden con folio: {txtFolio.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bd = new BaseDeDatos();
                    bd.EliminarOdT(id);
                    bd.conexion.Close();
                    ListaOrdenesDeTrabajo();
                    LimpiarFormulario();
                }
            }
        }
    }
}
