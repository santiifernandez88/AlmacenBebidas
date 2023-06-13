using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SerializadoraJSON<T>
    {
        public static bool EscribirEnJson(string rutaArchivo, T lista)
        {
            try
            {
                string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(rutaArchivo, json);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static T LeerDesdeJson(string rutaArchivo)
        {
            T lista;

            try
            {
                string json = File.ReadAllText(rutaArchivo);
                lista = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {

                
            }

            return lista;
        }


    }
}
