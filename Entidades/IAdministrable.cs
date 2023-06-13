using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAdministrable<T>
    {
        public List<T> ObtenerTodos();

        public bool Agregar(T objeto);

        public bool Borrar(int id);

        public bool ValidarEnLista(T objeto);


    }
}
