using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clientes
{
    public class AdministradorCliente : Administrador<Cliente>
    {
        public override bool Agregar(Cliente cliente)
        {
            bool añadido = false;

            if (ValidarEnLista(cliente))
            {
                BaseDeDatos.GuardarCliente(cliente);
                añadido = true;
            }

            return añadido;
        }

        public override bool Borrar(int dniAEliminar)
        {
            bool eliminado = false;

            foreach (Cliente cliente in ObtenerTodos())
            {
                if (cliente.Dni == dniAEliminar)
                {
                    BaseDeDatos.EliminarCliente(cliente);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public override List<Cliente> ObtenerTodos()
        {
            var listaClientes = BaseDeDatos.ObtenerClientes();

            return listaClientes;
        }

        public override bool ValidarEnLista(Cliente cliente)
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
    }
}
