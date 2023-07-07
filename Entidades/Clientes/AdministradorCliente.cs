using Data.BaseDeDatos.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class AdministradorCliente : IAdministrable<Cliente>
    {
        /// <summary>
        /// Crea un cliente y lo agrega a la lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edadStr"></param>
        /// <param name="dniStr"></param>
        /// <param name="tipoBebidaIndex"></param>
        /// <returns>true o false dependiendo si se pudo crear y agregar en la lista</returns>
        public bool CrearCliente(string nombre, string apellido, string edadStr, string dniStr, int frecuenciaIndex)
        {
            bool validado = false;
            int edad;
            int dni;
            Estatus frecuencia = (Estatus)frecuenciaIndex;

            if (Validaciones.ValidarString(nombre) && Validaciones.ValidarString(apellido) && Validaciones.ValidarEntero(edadStr, out edad) && Validaciones.ValidarEntero(dniStr, out dni))
            {
                Cliente clienteNuevo = new Cliente(nombre, apellido, edad, dni, frecuencia);
                if (Agregar(clienteNuevo))
                {
                    validado = true;
                }
            }
            return validado;
        }
        /// <summary>
        /// Modifica un cliente y valida que no sea igual a otro de la lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edadStr"></param>
        /// <param name="dniStr"></param>
        /// <param name="tipoIndex"></param>
        /// <returns>true o false si se pudo modificar</returns>
        public bool ModificarCliente(Cliente cliente, string nombre, string apellido, string edadStr, string dniStr, int frecuenciaIndex)
        {
            bool modificado = false;
            int edad;
            int dni;
            Estatus frecuencia = (Estatus)frecuenciaIndex;

            if (Validaciones.ValidarString(nombre) && Validaciones.ValidarString(apellido) && Validaciones.ValidarEntero(edadStr, out edad) && Validaciones.ValidarEntero(dniStr, out dni))
            {
                Cliente clienteModificado = new Cliente(nombre, apellido, edad, dni, frecuencia);

                if (ValidarEnLista(clienteModificado) || clienteModificado.Dni == cliente.Dni)
                {
                    cliente.Apellido = clienteModificado.Apellido;
                    cliente.Nombre = clienteModificado.Nombre;
                    cliente.Edad = clienteModificado.Edad;
                    cliente.Dni = clienteModificado.Dni;
                    cliente.Frecuencia = clienteModificado.Frecuencia;
                    modificado = true;
                }
            }

            return modificado;
        }
        /// <summary>
        /// Valida si se puede agregar el cliente en la lista y se agrega
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true o false dependiendo de si se pudo agregar un cliente o no</returns>
        public bool Agregar(Cliente cliente)
        {
            bool añadido = false;
            ClienteSQL clienteSQL = new ClienteSQL();   

            if (ValidarEnLista(cliente))
            {
                clienteSQL.Agregar(cliente);
                añadido = true;
            }

            return añadido;
        }
        /// <summary>
        /// Recorre la lista de empleados y busca encontrar dni igual al de algun cliente en la lista y lo elimina 
        /// </summary>
        /// <param name="dniAEliminar"></param>
        /// <returns>retorna true o false dependiendo si se pudo eliminar o no</returns>
        public bool Borrar(int dniAEliminar)
        {
            bool eliminado = false;
            ClienteSQL clienteSQL = new ClienteSQL();

            foreach (Cliente cliente in ObtenerTodos())
            {
                if (cliente.Dni == dniAEliminar)
                {
                    clienteSQL.Borrar(cliente.Dni);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }
        /// <summary>
        /// Obtiene todos los clientes y los retorna
        /// </summary>
        /// <returns>lista de clientes</returns>
        public List<Cliente> ObtenerTodos()
        {
            ClienteSQL clienteSQL = new ClienteSQL();
            var listaClientes = clienteSQL.TraerTodo();

            return listaClientes;
        }
        /// <summary>
        /// Realiza una validacion para que no haya clientes iguales en la lista
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>true o false dependiendo si se encontro un cliente igual o no</returns>
        public bool ValidarEnLista(Cliente cliente)
        {
            bool noEncontrado = true;

            foreach (Cliente c in ObtenerTodos())
            {
                if (c == cliente)
                {
                    noEncontrado = false;
                    break;
                }
            }

            return noEncontrado;
        }
        /// <summary>
        /// Realiza una busqueda de cliente y si se encuentra lo retorna
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>cliente a retornar</returns>
        public Cliente TraerClienteDni(int dni)
        {
            Cliente clienteARetornar = null;
            foreach (Cliente cliente in ObtenerTodos())
            {
                if (cliente.Dni == dni)
                {
                    clienteARetornar = cliente;
                    break;
                }
            }

            return clienteARetornar;
        }
    }
}
