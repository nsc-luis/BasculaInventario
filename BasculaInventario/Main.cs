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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //this.BackgroundImage = Properties.Resources.logo;
            InitializeComponent();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                BaseDeDatos bd = new BaseDeDatos();
                bd.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        private void turnosMenuItem_Click(object sender, EventArgs e)
        {
            Turnos turnos = new Turnos();
            turnos.Show();
        }

        private void usuariosMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void conexionABDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParamSQL paramSQL = new ParamSQL();
            paramSQL.Show();
        }

        private void aditivosMenuItem_Click(object sender, EventArgs e)
        {
            Aditivos aditivos = new Aditivos();
            aditivos.Show();
        }

        private void coloresMenuItem_Click(object sender, EventArgs e)
        {
            Colores colores = new Colores();
            colores.Show();
        }

        private void maquinasMenuItem_Click(object sender, EventArgs e)
        {
            Maquinas maquinas = new Maquinas();
            maquinas.Show();
        }

        private void choferesMenuItem_Click(object sender, EventArgs e)
        {
            Choferes choferes = new Choferes();
            choferes.Show();
        }

        private void vehiculosMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos vehiculos = new Vehiculos();
            vehiculos.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
