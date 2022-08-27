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
    public partial class frmChofer : Form
    {
        public frmChofer()
        {
            InitializeComponent();
        }

        private void btnGuardarChofer_Click(object sender, EventArgs e)
        {
            if (txtNombreChofer.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarChofer(txtNombreChofer.Text, txtLicenciaChofer.Text);
                bd.conexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: \n Debes ingresar el nombre del chofer.");
            }
        }
    }
}
