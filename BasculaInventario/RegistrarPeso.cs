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
    public partial class RegistrarPeso : Form
    {
        BaseDeDatos bd;
        DataTable dt;
        int idOdT = 0;
        int idProducto = 0;
        string folio = "";
        string ordenDeTrabajo = "";
        int kilosOdT = 0;
        int kgPorUnidadDeProducto = 0;
        int kgSurtidos = 0;
        int kgPorSurtir = 0;

        public class classCmbOdT
        {
            public int idOdt { get; set; }
            public string folioOdT { get; set; }
        }
        public class classCmbProducto
        {
            public int idProducto { get; set; }
            public string descProducto { get; set; }
        }

        public RegistrarPeso()
        {
            InitializeComponent();
            ComboListaOdT();
        }

        public void ComboListaOdT()
        {
            bd = new BaseDeDatos();
            dt = new DataTable();
            dt = bd.frmRdP_lstOdT();
            bd.conexion.Close();
            List<classCmbOdT> classCmbOdTs = new List<classCmbOdT>();
            classCmbOdTs.Add(new classCmbOdT { idOdt = 0, folioOdT = "Selecciona..." });
            foreach (DataRow row in dt.Rows)
            {
                classCmbOdTs.Add(new classCmbOdT { idOdt = Int32.Parse(row[0].ToString()), folioOdT = row[1].ToString() });
            }
            cmbOdT.DataSource = classCmbOdTs;
            cmbOdT.ValueMember = "idOdT";
            cmbOdT.DisplayMember = "folioOdT";

        }

        public void ComboProductos(int idOdT)
        {
            bd = new BaseDeDatos();
            dt = new DataTable();
            dt = bd.lstProductosPorOdT(idOdT);
            bd.conexion.Close();
            if (dt == null)
            {
                MessageBox.Show("Error: \n" +
                    "La orden de trabajo seleccionada no tiene producto asignado." +
                    "Consulta con tu supervisor.");
            }
            else
            {
                List<classCmbProducto> lstProductos = new List<classCmbProducto>();
                lstProductos.Add(new classCmbProducto { idProducto = 0, descProducto = "Selecciona..." });
                foreach (DataRow row in dt.Rows)
                {
                    lstProductos.Add(new classCmbProducto { idProducto = Int32.Parse(row[0].ToString()), descProducto = row[1].ToString() });
                }
                cmbProducto.DataSource = lstProductos;
                cmbProducto.ValueMember = "idProducto";
                cmbProducto.DisplayMember = "descProducto";
            }
        }

        private void InfoOdT(int idOdT)
        {
            bd = new BaseDeDatos();
            dt = new DataTable();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbOdT_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt = new DataTable();
            if (cmbOdT.SelectedValue.ToString() != "0")
            {
                idOdT = int.Parse(cmbOdT.SelectedValue.ToString());
                dt = bd.infoOdt(idOdT);
                bd.conexion.Close();
                foreach(DataRow row in dt.Rows)
                {
                    txtFolio.Text = row[1].ToString();
                    txtOrdenDeTrabajo.Text = row[2].ToString();
                    txtKilos.Text = row[4].ToString();
                    txtKgPorUnidadDeProducto.Text = row[6].ToString();
                }
                ComboProductos(idOdT);
            }
        }

        private void cmbProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt = new DataTable();
            if (cmbProducto.SelectedValue.ToString() != "0")
            {
                idProducto = int.Parse(cmbProducto.SelectedValue.ToString());
                bd = new BaseDeDatos();
                dt = bd.RegistrosDePeso(idOdT, idProducto);
                bd.conexion.Close();
                gridRegistrosDePeso.DataSource = dt;
                dt = null;

                bd = new BaseDeDatos();
                dt = bd.AcumuladoDePeso(idOdT, idProducto);
                bd.conexion.Close();
                txtKgPorSurtir.Text = "100";
            }
        }
    }
}
