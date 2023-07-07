using Entidades.BaseDeDatos.SQL;
using Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class ClienteSQL : ConsultaSQL, IBaseDeDatos<Cliente>
    {
        public void Agregar(Cliente objeto)
        {
            string query = $"INSERT INTO Clientes (nombre, apellido, edad, dni, frecuencia) VALUES ('{objeto.Nombre}', '{objeto.Apellido}', '{objeto.Edad}', '{objeto.Dni}', '{Convert.ToInt32(objeto.Frecuencia)}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int dni)
        {
            string query = $"DELETE FROM Clientes WHERE id = {dni}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(Cliente objeto)
        {
            string query = $"UPDATE FORM Clientes SET nombre = {objeto.Nombre}, apellido = {objeto.Apellido}, edad = {objeto.Edad}, dni = {objeto.Dni}, frecuencia = {Convert.ToInt32(objeto.Frecuencia)} WHERE dni = {objeto.Dni}";
            this.EjecutarNonQuery(query);
        }

        public List<Cliente> TraerTodo()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            var dataTable = this.EjecutarQuery("SELECT * FROM Clientes");

            foreach (DataRow item in dataTable.Rows)
            {
                string nombre = item["nombre"].ToString() ?? "";
                string apellido = item["apellido"].ToString() ?? "";
                int edad = (int)item["edad"];
                int dni = (int)item["dni"];
                Estatus Frecuencia = (Estatus)item["frecuencia"];

                listaCliente.Add(new Cliente(nombre, apellido, edad, dni, Frecuencia));
            }

            return listaCliente;
        }
    }
}
