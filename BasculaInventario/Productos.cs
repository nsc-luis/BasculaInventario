    using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class Productos : Form
    {
        BaseDeDatos bd;
        DataTable dt;
        public class Color
        {
            public int idColor { get; set; }
            public string color { get; set; }
        }
        public class Aditivo
        {
            public int idAditivo { get; set; }
            public string descAditivo { get; set; }
        }
        public class SiNo
        {
            public int llave { get; set; }
            public string valor { get; set; }
        }

        public Productos()
        {
            InitializeComponent();
            ListaDeProductos();
            comboColores();
            comboAditivos();
            comboVarios();
        }

        public void ListaDeProductos()
        {
            bd = new BaseDeDatos();
            gridProductos.DataSource = bd.ConsultarProductos();
            bd.conexion.Close();
        }

        public void comboVarios()
        {
            List<SiNo> siNo1 = new List<SiNo>();
            siNo1.Add(new SiNo { llave = 0, valor = "No" });
            siNo1.Add(new SiNo { llave = 1, valor = "Si" });
            cmbAX2L.DataSource = siNo1;
            cmbAX2L.DisplayMember = "valor";
            cmbAX2L.ValueMember = "llave";

            List<SiNo> siNo2 = new List<SiNo>();
            siNo2.Add(new SiNo { llave = 0, valor = "No" });
            siNo2.Add(new SiNo { llave = 1, valor = "Si" });
            cmbPP.DataSource = siNo2;
            cmbPP.DisplayMember = "valor";
            cmbPP.ValueMember = "llave";

            List<SiNo> siNo3 = new List<SiNo>();
            siNo3.Add(new SiNo { llave = 0, valor = "No" });
            siNo3.Add(new SiNo { llave = 1, valor = "Si" });
            cmbPPRefil.DataSource = siNo3;
            cmbPPRefil.DisplayMember = "valor";
            cmbPPRefil.ValueMember = "llave";

            List<SiNo> siNo4 = new List<SiNo>();
            siNo4.Add(new SiNo { llave = 0, valor = "No" });
            siNo4.Add(new SiNo { llave = 1, valor = "Si" });
            cmbTUB.DataSource = siNo4;
            cmbTUB.DisplayMember = "valor";
            cmbTUB.ValueMember = "llave";

            List<SiNo> siNo5 = new List<SiNo>();
            siNo5.Add(new SiNo { llave = 0, valor = "No" });
            siNo5.Add(new SiNo { llave = 1, valor = "Si" });
            cmbAX1L.DataSource = siNo5;
            cmbAX1L.DisplayMember = "valor";
            cmbAX1L.ValueMember = "llave";
        }

        public void comboColores()
        {
            bd = new BaseDeDatos();
            dt = new DataTable();
            List<Color> ListaColores = new List<Color>();
            dt = bd.ConsultarColores();
            bd.conexion.Close();
            ListaColores.Add(new Color { idColor = 0, color = "No aplica" });
            foreach (DataRow row in dt.Rows)
            {
                ListaColores.Add(new Color { idColor = Int32.Parse(row[0].ToString()), color = row[1].ToString() });
            }
            cmbColores.DataSource = ListaColores;
            cmbColores.DisplayMember = "color";
            cmbColores.ValueMember = "idColor";
        }

        public void comboAditivos()
        {
            bd = new BaseDeDatos();
            dt = new DataTable();
            List<Aditivo> ListaAditivos = new List<Aditivo>();
            dt = bd.ConsultarAditivos();
            bd.conexion.Close();
            ListaAditivos.Add(new Aditivo { idAditivo = 0, descAditivo = "No aplica" });
            foreach (DataRow row in dt.Rows)
            {
                ListaAditivos.Add(new Aditivo { idAditivo = Int32.Parse(row[0].ToString()), descAditivo = row[1].ToString() });
            }
            cmbAditivos.DataSource = ListaAditivos;
            cmbAditivos.DisplayMember = "descAditivo";
            cmbAditivos.ValueMember = "idAditivo";
        }

        int id = 0;
        public void LimpiarFormulario()
        {
            txtDescProducto.Text = "";
            txtMedida.Text = "";
            txtCalibre.Text = "";
            txtKGxRollo.Text = null;
            txtMetros.Text = null;
            txtSoplo.Text = "";
            txtBajaDencidad.Text = "";
            txtLinealButen.Text = "";
            txtAntiblock.Text = "";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.AgregarProducto(txtDescProducto.Text, int.Parse(cmbAditivos.SelectedValue.ToString()),
                int.Parse(cmbColores.SelectedValue.ToString()), txtMedida.Text, txtCalibre.Text,
                int.Parse(txtKGxRollo.Text.ToString()), int.Parse(txtMetros.Text.ToString()),
                txtSoplo.Text, txtBajaDencidad.Text, txtLinealButen.Text, txtAntiblock.Text,
                int.Parse(cmbTUB.SelectedValue.ToString()), int.Parse(cmbAX1L.SelectedValue.ToString()),
                int.Parse(cmbAX2L.SelectedValue.ToString()), int.Parse(cmbPP.SelectedValue.ToString()),
                int.Parse(cmbPPRefil.SelectedValue.ToString()));
            bd.conexion.Close();
            ListaDeProductos();
            LimpiarFormulario();
        }

        private void gridProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != (gridProductos.Rows.Count - 1))
            {
                id = Convert.ToInt32(gridProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtDescProducto.Text = gridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbAditivos.SelectedValue = int.Parse(gridProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbColores.SelectedValue = int.Parse(gridProductos.Rows[e.RowIndex].Cells[3].Value.ToString());
                txtMedida.Text = gridProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCalibre.Text = gridProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtKGxRollo.Text = gridProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtMetros.Text = gridProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtSoplo.Text = gridProductos.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtBajaDencidad.Text = gridProductos.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtLinealButen.Text = gridProductos.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtAntiblock.Text = gridProductos.Rows[e.RowIndex].Cells[11].Value.ToString();
                cmbTUB.Text = gridProductos.Rows[e.RowIndex].Cells[12].Value.ToString();
                cmbAX1L.Text = gridProductos.Rows[e.RowIndex].Cells[13].Value.ToString();
                cmbAX2L.Text = gridProductos.Rows[e.RowIndex].Cells[14].Value.ToString();
                cmbPP.Text = gridProductos.Rows[e.RowIndex].Cells[15].Value.ToString();
                cmbPPRefil.Text = gridProductos.Rows[e.RowIndex].Cells[16].Value.ToString();
            }
            else
            {
                LimpiarFormulario();
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            bd = new BaseDeDatos();
            bd.EditarProducto(id,txtDescProducto.Text, int.Parse(cmbAditivos.SelectedValue.ToString()),
                int.Parse(cmbColores.SelectedValue.ToString()), txtMedida.Text, txtCalibre.Text,
                int.Parse(txtKGxRollo.Text.ToString()), int.Parse(txtMetros.Text.ToString()),
                txtSoplo.Text, txtBajaDencidad.Text, txtLinealButen.Text, txtAntiblock.Text,
                int.Parse(cmbTUB.SelectedValue.ToString()), int.Parse(cmbAX1L.SelectedValue.ToString()),
                int.Parse(cmbAX2L.SelectedValue.ToString()), int.Parse(cmbPP.SelectedValue.ToString()),
                int.Parse(cmbPPRefil.SelectedValue.ToString()));
            bd.conexion.Close();
            ListaDeProductos();
            LimpiarFormulario();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DialogResult result = MessageBox.Show($"¿Estas seguro que deseas eliminar el producto: {txtDescProducto.Text}?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bd = new BaseDeDatos();
                    bd.EliminarProducto(id);
                    bd.conexion.Close();
                    ListaDeProductos();
                    LimpiarFormulario();
                }
            }
        }
    }
}
