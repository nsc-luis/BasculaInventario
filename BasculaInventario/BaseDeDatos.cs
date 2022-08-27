using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasculaInventario
{
    class BaseDeDatos
    {
        // CONEXION A LA BASE DE DATOS
        public SqlConnection conexion;
        public BaseDeDatos()
        {
            var parametros = File.ReadAllLines("C:/Temp/param.txt")
                .Select(l => l.Split(new[] { '=' }))
                .ToDictionary(s => s[0].Trim(), s => s[1].Trim());

            conexion = new SqlConnection($"Server={parametros["hostSQLServer"]}\\{parametros["instancia"]}; Database={parametros["basededatos"]}; User Id={parametros["userSQL"]}; Password={parametros["passSQL"]} ; MultipleActiveResultSets=true");
            conexion.Open();
        }
        // Parametros para conexion a SQL
        public static void GuardaParametrosSQLServer(
            string hostSQLServer = "",
            string instancia = "",
            string basededatos = "",
            string userSQL = "",
            string passSQL = ""
            )
        {
            using (StreamWriter writer = new StreamWriter("C:/Temp/param.txt"))
            {
                writer.WriteLine("hostSQLServer = " + hostSQLServer);
                writer.WriteLine("instancia = " + instancia);
                writer.WriteLine("basededatos = " + basededatos);
                writer.WriteLine("userSQL = " + userSQL);
                writer.WriteLine("passSQL = " + passSQL);
            }
        }

        // METODOS PARA TABLA DE TURNOS
        // Metodo para consultar turnos
        public SqlDataReader ConsultarTurnos()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM turnos";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar turnos
        public void AgregarTurno(string descTruno)
        {
            try
            {
                string query = $"INSERT INTO turnos (descTurno) VALUES('{descTruno}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Turno agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE USUARIOS
        // Metodo para consultar usuarios
        public SqlDataReader ConsultarUsuarios()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT usuario, nombreUsuario, perfil FROM usuarios";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar Usuarios
        public void AgregarUsuario(
            string nombreUsuario,
            string usuario,
            string passUsuario,
            string perfil
            )
        {
            try
            {
                string query = $"INSERT INTO usuarios (nombreUsuario,usuario,passUsuario,perfil) VALUES('{nombreUsuario}','{usuario}','{passUsuario}','{perfil}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para validar credenciales
        public bool ValidarCredenciales(string usuario, string passUsuario)
        {
            try
            {
                string query = $"SELECT * FROM usuarios WHERE usuario='{usuario}' AND passUsuario='{passUsuario}'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error: \nUsuario y/o contraseña incorrecta.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return false;
            }
        }

        // METODOS PARA LA TABLA DE ADITIVOS
        // Metodo para consultar aditivos
        public SqlDataReader ConsultarAditivos()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM aditivos";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar Aditivos
        public void AgregarAditivo(string descAditivo)
        {
            try
            {
                string query = $"INSERT INTO aditivos (descAditivo) VALUES('{descAditivo}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Aditivo agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE COLORES
        // Metodo para consultar colores
        public SqlDataReader ConsultarColores()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM colores";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar color
        public void AgregarColor(string color)
        {
            try
            {
                string query = $"INSERT INTO colores (color) VALUES('{color}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Color agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE MAQUINAS
        // Metodo para consultar maquinas
        public SqlDataReader ConsultarMaquinas()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM maquinas";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar maquinas
        public void AgregarMaquina(string numeroMaquina, string descMaquina)
        {
            try
            {
                string query = $"INSERT INTO maquinas (numeroMaquina,descMaquina) VALUES('{numeroMaquina}', '{descMaquina}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Maquina agregada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE MAQUINAS
        // Metodo para consultar maquinas
        public SqlDataReader ConsultarChoferes()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM choferes";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar maquinas
        public void AgregarChofer(string nombreChofer, string licenciaChofer)
        {
            try
            {
                string query = $"INSERT INTO choferes (nombreChofer,licenciaChofer) VALUES('{nombreChofer}', '{licenciaChofer}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Chofer agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE VEHICULOS
        // Metodo para consultar vehiculos
        public SqlDataReader ConsultarVehiculos()
        {
            SqlDataReader reader;
            try
            {
                string query = $"SELECT * FROM vehiculos";
                SqlCommand command = new SqlCommand(query, conexion);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return reader = null;
            }
        }
        // Metodo para agregar vehiculos
        public void AgregarVehiculo(string descVehiculo, string placas)
        {
            try
            {
                string query = $"INSERT INTO vehiculos (descVehiculo,placasVehiculo) VALUES('{descVehiculo}', '{placas}')";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Vehiculo agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
    }
}
