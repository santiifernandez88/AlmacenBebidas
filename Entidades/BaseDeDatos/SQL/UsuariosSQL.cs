using Entidades;
using Entidades.BaseDeDatos.SQL;
using Entidades.Empleados;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class UsuariosSQL : ConsultaSQL, IBaseDeDatos<Usuario>
    {
        Controlador controlador = new Controlador();

        public void Agregar(Usuario objeto)
        {
            string query = $"INSERT INTO Usuarios (nombreUsuario, contraseña, idEmpleado) VALUES ('{objeto.NombreUsuario}', '{objeto.Contraseña}', '{objeto.Empleado.Id}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int id)
        {
            string query = $"DELETE FROM Usuarios WHERE idEmpleado = {id}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(Usuario objeto)
        {
            string query = $"UPDATE Usuarios SET nombre = {objeto.NombreUsuario}, apellido = {objeto.Contraseña}, id = {objeto.Empleado.Id}  WHERE id = {objeto.Empleado.Id}";
            this.EjecutarNonQuery(query);
        }

        public List<Usuario> TraerTodo()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            var dataTable = this.EjecutarQuery("SELECT * FROM Usuarios");

            foreach (DataRow item in dataTable.Rows)
            {
                string nombreUsuario = item["nombreUsuario"].ToString() ?? "";
                string contraseña = item["contraseña"].ToString() ?? "";
                int idEmpleado = (int)item["idEmpleado"];

                Empleado empleado = controlador.TraerEmpleadoId(idEmpleado);

                listaUsuario.Add(new Usuario(nombreUsuario, contraseña, empleado));
            }

            return listaUsuario;
        }
    }
}
