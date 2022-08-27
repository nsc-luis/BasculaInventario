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
    public partial class frmAditivo : Form
    {
        public frmAditivo()
        {
            InitializeComponent();
        }

        private void btnGuardarAditivo_Click(object sender, EventArgs e)
        {
            if (txtDescAditivo.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarAditivo(txtDescAditivo.Text);
                bd.conexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: \n Debes ingresar una descripcion para el aditivo.");
            }
        }
    }
}
