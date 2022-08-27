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
    public partial class frmMaquina : Form
    {
        public frmMaquina()
        {
            InitializeComponent();
        }

        private void btnGuardarMaquina_Click(object sender, EventArgs e)
        {
            if (txtNoMaquina.Text != "")
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.AgregarMaquina(txtNoMaquina.Text, txtDescMaquina.Text);
                bd.conexion.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: \n Debes ingresar al menos el numero de maquina.");
            }
        }
    }
}
