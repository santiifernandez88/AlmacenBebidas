using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public class SerializadoraXML<T> : ISerializable<T> where T : class, new()
    {
        public SerializadoraXML()
        {

        }

        public T Leer(string path)
        {
            T info = default;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<T>));
                    info = (T)des.Deserialize(sr);
                }
            }
            catch
            {
                throw new Exception("Error al leer el archivo.");
            }

            return info;
        }

        public void Escribir(T queSerializar, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(sw, queSerializar);
                }
            }
            catch
            {
                throw new Exception("Error al escribir el archivo.");
            }
        }
    }
}
