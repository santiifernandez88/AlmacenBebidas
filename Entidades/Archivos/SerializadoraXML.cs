using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public class SerializadoraXML
    {
        /*private string pathfile;

        public SerializadoraXML(string pathfile)
        {
            this.pathfile = pathfile;
        }

        public T LeerXml<T>()
        {
            T lista;
            try
            {
                using (StreamReader sr = new StreamReader(pathfile))
                {
                    XmlSerializer des = new XmlSerializer(typeof(T));
                    lista = (T)des.Deserialize(sr);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lista;
        }

        public void Escribir<T>(T queSerializar)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathfile))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(sw, queSerializar);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}
