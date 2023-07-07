using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ventas;
using System.Reflection;

namespace Entidades.BaseDeDatos.SQL
{
    public class ConsultaSQL : ConexionSQL
    {
        Controlador controlador = new Controlador();
        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        public ConsultaSQL(string connectionString) : base(connectionString)
        {


        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase ConsultasSQL con una cadena de conexión predeterminada.
        /// </summary>
        public ConsultaSQL() : base(@"Server=LAPTOP-UNF5I5M6;Database=Labo2;Trusted_Connection=True;Encrypt=False;")
        {
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un DataTable.
        /// </summary>
        /// <param name="consulta">Consulta SQL a ejecutar.</param>
        /// <returns>DataTable con los resultados de la consulta.</returns>
        protected DataTable EjecutarQuery(string consulta)
        {
            Abrir();

            var command = new SqlCommand(consulta, _connection);
            var reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            Cerrar();

            return dataTable;
        }

        protected void EjecutarNonQuery(string query)
        {
            try
            {
                Abrir();

                var command = new SqlCommand(query, _connection);
                int affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string nombreClse = MethodBase.GetCurrentMethod().DeclaringType.Name;
                string nombreMetodo = MethodBase.GetCurrentMethod().Name;
                controlador.LogsErrores(ex, nombreClse, nombreMetodo);
            }
            finally
            {
                Cerrar();
            }
        }
    }
}

