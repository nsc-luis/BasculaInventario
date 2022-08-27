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
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnGuardarColor_Click(object sender, EventArgs e)
        {
            if (txtDescColor.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarColor(txtDescColor.Text);
                bd.conexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: \n Debes ingresar el color/descripcion.");
            }
        }
    }
}
