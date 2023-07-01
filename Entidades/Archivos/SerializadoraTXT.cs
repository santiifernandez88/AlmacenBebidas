using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class SerializadoraTXT : ISerializable<string>
    {
        public void Escribir(string objeto, string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(objeto);
                }
            }
            catch
            {
                throw new Exception("Hubo un problema al intentar abrir el archivo.");
            }
           
        }

        public string Leer(string path)
        {
            StringBuilder sb = new StringBuilder();
            string linea;

            using (StreamReader sr = new StreamReader(path))
            {
                while ((linea = sr.ReadLine()) != null)
                {
                    sb.AppendLine(linea);

                }
            }

            return sb.ToString();
        }
    }
}
