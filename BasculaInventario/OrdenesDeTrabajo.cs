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
            public string descMaquina { get; set; }
        }
        public class Producto
        {
            public int idProducto { get; set; }
            public string descProducto { get; set; }
        }

        public OrdenesDeTrabajo()
        {
            InitializeComponent();
            ListaOrdenesDeTrabajo();
            ComboMaquinas();
            ComboPrductos();
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
            cmbProductos.SelectedValue = 0;
            txtKgPorUnidadDeProducto.Text = "";
        }

        public void ComboMaquinas(){
            bd = new BaseDeDatos();
            List<Maquina> ListaMaquinas = new List<Maquina>();
            dt = bd.ConsultarMaquinas();
            bd.conexion.Close();
            ListaMaquinas.Add(new Maquina { idMaquina = 0, descMaquina = "No aplica" });
            foreach (DataRow row in dt.Rows)
            {
                ListaMaquinas.Add(new Maquina { idMaquina = Int32.Parse(row[0].ToString()), descMaquina = row[2].ToString() });
            }
            cmbMaquinas.DataSource = ListaMaquinas;
            cmbMaquinas.DisplayMember = "descMaquina";
            cmbMaquinas.ValueMember = "idMaquina";
        }

        public void ComboPrductos()
        {
            bd = new BaseDeDatos();
            List<Producto> ListaProductos = new List<Producto>();
            dt = bd.ConsultarProductos();
            bd.conexion.Close();
            ListaProductos.Add(new Producto { idProducto = 0, descProducto = "No aplica" });
            foreach (DataRow row in dt.Rows)
            {
                ListaProductos.Add(new Producto { idProducto = Int32.Parse(row[0].ToString()), descProducto = row[1].ToString() });
            }
            cmbProductos.DataSource = ListaProductos;
            cmbProductos.DisplayMember = "descProducto";
            cmbProductos.ValueMember = "idProducto";
        }

        private void btnAgregarOdT_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.AgregarOdT(txtFolio.Text, txtOrden.Text, 
                Int32.Parse(cmbMaquinas.SelectedValue.ToString()), 
                Int32.Parse(txtKilos.Text), dpFecha.Value.ToString("yyyy-MM-dd"), 
                Int32.Parse(txtKgPorUnidadDeProducto.Text), 
                Int32.Parse(cmbProductos.SelectedValue.ToString()));
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
                txtKgPorUnidadDeProducto.Text = gridOdT.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbProductos.SelectedValue = int.Parse(gridOdT.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void btnEditarOdT_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.EditarOdT(
                id, txtFolio.Text, txtOrden.Text, 
                Int32.Parse(cmbMaquinas.SelectedValue.ToString()), 
                Int32.Parse(txtKilos.Text), 
                dpFecha.Value.ToString("yyyy-MM-dd"), 
                Int32.Parse(txtKgPorUnidadDeProducto.Text),
                Int32.Parse(cmbProductos.SelectedValue.ToString()));
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
