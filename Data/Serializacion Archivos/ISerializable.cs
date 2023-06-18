using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Serializacion_Archivos
{
    internal interface ISerializable<T>
    {
        public bool Escribir(T objeto, string path);


        public T Leer(string path);

    }
}
