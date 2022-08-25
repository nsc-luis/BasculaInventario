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
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            FrmTurno frmTurno = new FrmTurno();
            frmTurno.Show();
        }

        private void Turnos_Load(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            DataTable dt = new DataTable();
            dt.Load(bd.ConsultarTurnos());
            gridTurnos.DataSource = dt;
            bd.conexion.Close();
        }
    }
}
