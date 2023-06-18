using Data.Serializacion_Archivos;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SerializadoraJSON<T> : ISerializable<T>
    {

        public bool Escribir(T objeto, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(objeto, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            };
        }

        public T Leer(string path)
        {
            T lista = null;

            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {


            }

            return lista;
        }
    }
}
