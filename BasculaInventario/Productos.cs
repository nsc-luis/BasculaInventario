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
            List<SiNo> siNo = new List<SiNo>();
            siNo.Add(new SiNo { llave = 0, valor = "No" });
            siNo.Add(new SiNo { llave = 1, valor = "Si" });
            cmbAX2L.DataSource = siNo;
            cmbAX2L.DisplayMember = "valor";
            cmbAX2L.ValueMember = "llave";

            cmbPP.DataSource = siNo;
            cmbPP.DisplayMember = "valor";
            cmbPP.ValueMember = "llave";

            cmbPPRefil.DataSource = siNo;
            cmbPPRefil.DisplayMember = "valor";
            cmbPPRefil.ValueMember = "llave";

            cmbTUB.DataSource = siNo;
            cmbTUB.DisplayMember = "valor";
            cmbTUB.ValueMember = "llave";

            cmbAX1L.DataSource = siNo;
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
            bd.AgregarProducto(txtDescProducto.Text, Int32.Parse(cmbAditivos.ValueMember),
                Int32.Parse(cmbColores.ValueMember), txtMedida.Text, txtCalibre.Text, 
                Int32.Parse(txtKGxRollo.ToString()),Int32.Parse(txtMetros.ToString()), 
                txtSoplo.Text, txtBajaDencidad.Text, txtLinealButen.Text,txtAntiblock.Text,
                Boolean.Parse(cmbTUB.ValueMember), Boolean.Parse(cmbAX1L.ValueMember),
                Boolean.Parse(cmbAX2L.ValueMember), Boolean.Parse(cmbPP.ValueMember), 
                Boolean.Parse(cmbPPRefil.ValueMember));
            bd.conexion.Close();
            ListaDeProductos();
            LimpiarFormulario();
        }
    }
}
