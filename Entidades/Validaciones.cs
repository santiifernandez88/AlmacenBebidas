﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        /*public static bool ValidarString(string cadena)
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
        }*/

        public static bool ValidarEntero(int entero)
        {
            bool validado = false;

            if(entero != null && entero > 0)
            {
                validado = true;
            }
            else
            {
                throw new Exception("Error ingrese un numero");
            }

            return validado;
        }



    }
}
