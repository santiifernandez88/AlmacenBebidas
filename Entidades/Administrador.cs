using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Administrador<T> : IAdministrable<T>
    {
        public abstract bool Agregar(T objeto);
        public abstract bool Borrar(int id);
        public abstract List<T> ObtenerTodos();
        public abstract bool ValidarEnLista(T objeto);
    }
}
