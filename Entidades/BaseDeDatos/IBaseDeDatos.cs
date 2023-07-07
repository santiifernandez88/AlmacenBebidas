using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos
{
    public interface IBaseDeDatos<T>
    {
        public void Agregar(T objeto);

        public void Modificar(T objeto);

        public void Borrar(int id);

        public List<T> TraerTodo();       

    }
}
