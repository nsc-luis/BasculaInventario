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
                string query = $"SELECT * FROM usuarios";
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
    }
}
