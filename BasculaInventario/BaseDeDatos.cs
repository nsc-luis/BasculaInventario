using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BasculaInventario
{
    class BaseDeDatos
    {
        // CONEXION A LA BASE DE DATOS
        public SqlConnection conexion;
        SqlDataAdapter adapter;
        SqlCommand cmd;

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
        public DataTable ConsultarTurnos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM turnos";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar turnos
        public void AgregarTurno(string descTruno)
        {
            try
            {
                string query = $"INSERT INTO turnos (descTurno) VALUES('{descTruno}')";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turno agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar turnos
        public void EditarTurno(int id, string descTurno)
        {
            try
            {
                string query = $"UPDATE turnos set descTurno = '{descTurno}' WHERE idTurno = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turno guardado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para eliminar Aditivos
        public void EliminarTurno(int id)
        {
            try
            {
                string query = $"DELETE FROM turnos WHERE idTurno = {id}";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Turno eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE USUARIOS
        // Metodo para consultar usuarios
        public DataTable ConsultarUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT idUsuario, usuario, nombreUsuario, perfil FROM usuarios";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
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
        // Metodo para editar usuarios
        public void EditarUsuario(
            int id,
            string nombreUsuario,
            string usuario,
            string passUsuario,
            string perfil
            )
        {
            try
            {
                string query = $"UPDATE usuarios SET nombreUsuario = '{nombreUsuario}', usuario = '{usuario}', passUsuario = '{passUsuario}', perfil = '{perfil}' WHERE idUsuario = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El usuario fue actualizado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para eliminar usuarios
        public void EliminarUsuario(int id)
        {
            try
            {
                string query = $"DELETE FROM usuarios WHERE idUsuario = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado satisfactoriamente.");
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
        public DataTable ConsultarAditivos()
        {
            string query = $"SELECT * FROM aditivos";
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conexion);
            dataAdapter.Fill(dt);
            try
            {
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar Aditivos
        public void AgregarAditivo(string descAditivo)
        {
            try
            {
                string query = $"INSERT INTO aditivos (descAditivo) VALUES('{descAditivo}')";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aditivo agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar Aditivos
        public void EditarAditivo(int id, string descAditivo)
        {
            try
            {
                string query = $"UPDATE aditivos set descAditivo = '{descAditivo}' WHERE idAditivo = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aditivo guardado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para eliminar Aditivos
        public void EliminarAditivo(int id)
        {
            try
            {
                string query = $"DELETE FROM aditivos WHERE idAditivo = {id}";
                SqlCommand command = new SqlCommand(query, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Aditivo eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE COLORES
        // Metodo para consultar colores
        public DataTable ConsultarColores()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM colores";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                conexion.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar color
        public void AgregarColor(string color)
        {
            try
            {
                string query = $"INSERT INTO colores (color) VALUES('{color}')";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Color agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para actualizar color
        public void EditartColor(int id, string color)
        {
            try
            {
                string query = $"UPDATE colores SET color='{color}' WHERE idColor = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Color actualizado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para Eliminar un color
        public void EliminarColor(int id)
        {
            try
            {
                string query = $"DELETE FROM colores WHERE idColor = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Color eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE MAQUINAS
        // Metodo para consultar maquinas
        public DataTable ConsultarMaquinas()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM maquinas";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar maquinas
        public void AgregarMaquina(string numeroMaquina, string descMaquina = "")
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
        // Metodo para actualizar la maquina
        public void EditarMaquina(int id, string noMaquina, string descMaquina = "")
        {
            try
            {
                string query = $"UPDATE maquinas SET numeroMaquina='{noMaquina}', descMaquina='{descMaquina}' WHERE idMaquina = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Maquina actualizada satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para Eliminar una maquina
        public void EliminarMaquina(int id)
        {
            try
            {
                string query = $"DELETE FROM maquinas WHERE idMaquina = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Maquina eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE CHOFERES
        // Metodo para consultar choferes
        public DataTable ConsultarChoferes()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM choferes";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar chofer
        public void AgregarChofer(string nombreChofer)
        {
            try
            {
                string query = $"INSERT INTO choferes (nombreChofer) VALUES('{nombreChofer}')";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chofer agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar chofer
        public void EditarChofer(int id, string nombreChofer)
        {
            try
            {
                string query = $"UPDATE choferes SET nombreChofer = '{nombreChofer}' WHERE idChofer = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chofer editado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para eliminar chofer
        public void EliminarChofer(int id)
        {
            try
            {
                string query = $"DELETE FROM choferes WHERE idChofer = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Chofer eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        // METODOS PARA LA TABLA DE VEHICULOS
        // Metodo para consultar vehiculos
        public DataTable ConsultarVehiculos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM vehiculos";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Metodo para agregar vehiculos
        public void AgregarVehiculo(string descVehiculo, string placas = "")
        {
            try
            {
                string query = $"INSERT INTO vehiculos (descVehiculo,placasVehiculo) VALUES('{descVehiculo}', '{placas}')";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vehiculo agregado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar el vehiculo
        public void EditarVehiculo(int id, string descVehiculo, string placas = "")
        {
            try
            {
                string query = $"UPDATE vehiculos SET descVehiculo='{descVehiculo}', placasVehiculo='{placas}' WHERE idVehiculo = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El vehiculo se ha editado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }

        }
        // Metodo para eliminar un vehiculo
        public void EliminarVehiculo(int id)
        {
            try
            {
                string query = $"DELETE FROM vehiculos WHERE idVehiculo={id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El vehiculo se ha eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        //METODOS PARA LA TABLA DE PRODUCTOS
        // Metodo para la consulta de productos
        public DataTable ConsultarProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM productos";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt;
            }
        }
        // Metodo para agregar productos
        public void AgregarProducto(
            string descProducto, int idAditivo, int idColor, string medida,
            string calibre, int KGxRollo, int metros, string soplo, string bajaDencidad,
            string linealButen, string antiblock, int tub, int ax1l, int ax2l,
            int pp, int ppRefil)
        {
            try
            {
                string query = $"INSERT INTO productos (descProducto,idAditivo," +
                    $"idColor,medida,calibre,KGxRollo,metros,soplo,bajaDencidad," +
                    $"linealButen,antiblock,tub,ax1l,ax2l,pp,ppRefil) " +
                    $"VALUES('{descProducto}',{idAditivo},{idColor},'{medida}'," +
                    $"'{calibre}',{KGxRollo},{metros},'{soplo}','{bajaDencidad}'," +
                    $"'{linealButen}','{antiblock}',{tub},{ax1l},{ax2l},{pp},{ppRefil})";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto se agrego exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar productos
        public void EditarProducto(
            int idProducto, string descProducto, int idAditivo, int idColor, string medida,
            string calibre, int KGxRollo, int metros, string soplo, string bajaDencidad,
            string linealButen, string antiblock, int tub, int ax1l, int ax2l,
            int pp, int ppRefil)
        {
            try
            {
                string query = $"UPDATE productos SET descProducto='{descProducto}',idAditivo={idAditivo}," +
                    $"idColor={idColor},medida='{medida}',calibre='{calibre}',KGxRollo={KGxRollo}," +
                    $"metros={metros},soplo='{soplo}',bajaDencidad='{bajaDencidad}',linealButen='{linealButen}'," +
                    $"antiblock='{antiblock}',tub={tub},ax1l={ax1l},ax2l={ax2l},pp={pp},ppRefil={ppRefil} " +
                    $"WHERE idProducto = {idProducto}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto se editó exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para elimiar productos
        public void EliminarProducto(int id)
        {
            try
            {
                string query = $"DELETE FROM productos WHERE idProducto = {id}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El producto se elimino satisfactoriamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        //METODOS PARA LA TABLA DE ORDENES DE TRABAJO
        // Metodo para la consulta de Ordenes de Trabajo
        public DataTable ConsultarOdT()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM ordenesDeTrabajo";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt;
            }
        }
        // Metodo para agregar orden de trabajo
        public void AgregarOdT(
            string folioOdT, string ordenDeTrabajo,
            int idMaquina, int kilosOdT, string fechaOdT,
            int kgPorUnidadDeProducto, int idProducto)
        {
            try
            {
                string query = $"INSERT INTO ordenesDeTrabajo (folioOdT,ordenDeTrabajo,idMaquina,kilosOdT,fechaOdT,kgPorUnidadDeProducto,idProducto) " +
                    $"VALUES ('{folioOdT}','{ordenDeTrabajo}',{idMaquina},{kilosOdT},'{fechaOdT}',kgPorUnidadDeProducto={kgPorUnidadDeProducto},{idProducto})";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para editar orden de trabajo
        public void EditarOdT(int idOdT,
            string folioOdT, string ordenDeTrabajo,
            int idMaquina, int kilosOdT, string fechaOdT,
            int kgPorUnidadDeProducto, int idProducto)
        {
            try
            {
                string query = $"UPDATE ordenesDeTrabajo SET folioOdT='{folioOdT}',ordenDeTrabajo='{ordenDeTrabajo}'," +
                    $"idMaquina={idMaquina},kilosOdT={kilosOdT},fechaOdT='{fechaOdT}',kgPorUnidadDeProducto={kgPorUnidadDeProducto}," +
                    $"idProducto={idProducto} " +
                    $"WHERE idOdT = {idOdT}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }
        // Metodo para eliminar una orden de trabajo
        public void EliminarOdT(int idOdT)
        {
            try
            {
                string query = $"DELETE FROM ordenesDeTrabajo WHERE idOdT = {idOdT}";
                cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        //METODOS PARA PANTALLA DE REGISTRO DE PESO
        //Consultar informacion de la orden de trabajo.
        public DataTable frmRdP_lstOdT()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM ordenesDeTrabajo";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Consulta productos por orden de trabajo
        public DataTable lstProductosPorOdT(int idOdT)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT p.idProducto, p.descProducto FROM ordenesDeTrabajo odt " +
                    "JOIN productos p ON odt.idProducto = p.idProducto " +
                    $"WHERE odt.idOdT = {idOdT}";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Consulta info de la orden de trabajo seleccionada
        public DataTable infoOdt(int idOdT)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM ordenesDeTrabajo WHERE idOdt = {idOdT}";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Consulta registros de peso segun orden de compra y producto
        public DataTable RegistrosDePeso(int idOdT, int idProducto)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT idRdP, peso, fechaRegistro FROM registroDePeso " +
                    $"WHERE idOdT = {idOdT} AND idProducto = {idProducto}";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
        // Consulta acumulado de peso segun orden de compra y producto
        public DataTable AcumuladoDePeso(int idOdT, int idProducto)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT SUM(peso) as acumulado FROM registroDePeso " +
                    $"WHERE idOdT = {idOdT} AND idProducto = {idProducto}";
                adapter = new SqlDataAdapter(query, conexion);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
                return dt = null;
            }
        }
    }
}
