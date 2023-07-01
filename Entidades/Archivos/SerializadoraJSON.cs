using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    /*public class SerializadoraJSON : ISerializable<string>
    {
       

        public bool Escribir(string objeto, string path)
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

        public string Leer(string path)
        {
            string lista =  "";

            try
            {
                string json = File.ReadAllText(path);
                lista = JsonConvert.DeserializeObject<string>(json);
            }
            catch (Exception ex)
            {


            }

            return  lista;
        }
    }*/
}
