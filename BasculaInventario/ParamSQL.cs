using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasculaInventario
{
    public partial class ParamSQL : Form
    {
        public ParamSQL()
        {
            InitializeComponent();
        }

        private void btnGuardarParamSQLServer_Click(object sender, EventArgs e)
        {
            BaseDeDatos.GuardaParametrosSQLServer(txtHost.Text, txtInstancia.Text, txtBasededatos.Text, txtUserSQL.Text, txtPassSQL.Text);
            MessageBox.Show("Los parametros de conexion a la base de datos han cambiado\n por lo tanto se cerrara el sistema para aplicar los cambios.");
            Application.Exit();
        }

        private void ParamSQL_Load(object sender, EventArgs e)
        {
            var parametros = File.ReadAllLines("C:/Temp/param.txt")
                .Select(l => l.Split(new[] { '=' }))
                .ToDictionary(s => s[0].Trim(), s => s[1].Trim());
            txtHost.Text = parametros["hostSQLServer"];
            txtInstancia.Text = parametros["instancia"];
            txtBasededatos.Text = parametros["basededatos"];
            txtUserSQL.Text = parametros["userSQL"];
            txtPassSQL.Text = parametros["passSQL"];
        }
    }
}
