using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public interface ISerializable<T> 
    {
        public void Escribir(T objeto, string path);


        public T Leer(string path);

    }
}
