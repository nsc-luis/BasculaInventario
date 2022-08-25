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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BaseDeDatos bd = new BaseDeDatos();
            bool credencialesValidas = bd.ValidarCredenciales(txtUsuario.Text, txtPassUsuario.Text);
            if (credencialesValidas)
            {
                frmMain main = new frmMain();
                main.Show();
            }
        }
    }
}
