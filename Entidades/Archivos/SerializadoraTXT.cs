using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void LogError(string path, Exception ex, string nombreClase, string nombreMetodo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    string errorMessage = $"{DateTime.Now} - Error en {nombreClase}.{nombreMetodo}: {ex.Message}";
                    writer.WriteLine(errorMessage);
                    writer.WriteLine(ex.StackTrace);
                    writer.WriteLine();
                }
            }
            catch (Exception e)
            {
                // Manejo de errores al escribir en el archivo de registro de errores
                Console.WriteLine("Error al escribir en el archivo de registro: " + e.Message);
            }
        }
    }
}
