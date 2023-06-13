using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        public static bool ValidarString(string cadena)
        {
            bool validado = false;

            if(!string.IsNullOrEmpty(cadena))
            {
                for(int i = 0; i < cadena.Length; i++)
                {
                    if (cadena.CompareTo()== ' ')
                }
            }


            return validado; 
        }

        public static bool ValidarEntero(int entero)
        {
            bool validado = false;

            if(entero != null && entero > 0)
            {
                validado = true;
            }

            return validado;
        }

        public static bool ValidarEntidadEnLista<T>(T entidad, List<T> lista)
        {
            bool validado = true;

            foreach(T e in lista) 
            {
                if(e == entidad)
                {

                }
            }
        }

    }
}
