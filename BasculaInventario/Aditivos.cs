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
    public partial class Aditivos : Form
    {
        public Aditivos()
        {
            InitializeComponent();
        }

        private void btnAgregarAditivo_Click(object sender, EventArgs e)
        {
            frmAditivo frmAditivo = new frmAditivo();
            frmAditivo.Show();
        }

        private void Aditivos_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarAditivos());
            gridAditivos.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
