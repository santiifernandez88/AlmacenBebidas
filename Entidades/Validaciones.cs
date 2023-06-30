using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroNoValidoException : Exception
    {
        public NumeroNoValidoException() : base()
        {
        
        }

        public NumeroNoValidoException(string mensaje) : base(mensaje)
        {

        }

        public NumeroNoValidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }

    public class CadenaNoValidaException : Exception
    {
        public CadenaNoValidaException() : base() 
        {
        
        }

        public CadenaNoValidaException(string mensaje) : base(mensaje)
        {

        }

        public CadenaNoValidaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }


    public class Validaciones
    {
        public static bool ValidarString(string cadena)
        {
            bool validado = false;

            if(!string.IsNullOrEmpty(cadena))
            {
                for(int i = 0; i < cadena.Length; i++)
                {
                    if (char.IsLetter(cadena[i]))
                    {
                        validado = true;
                    }
                    else
                    {
                        throw new CadenaNoValidaException("Error, ingrese solamente letreas.");
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(cadena), "Ingrese una palabra o letra.");
            }

            return validado; 
        }

        public static bool ValidarEntero(string enteroStr, out int entero)
        {
            bool validado = false;
            int aux;

            if(!string.IsNullOrEmpty(enteroStr))
            {
                if (int.TryParse(enteroStr, out aux))
                {
                    if (aux >= 0)
                    {
                        entero = aux;
                        validado = true;
                    }
                    else
                    {
                        throw new NumeroNoValidoException("Ingrese un numero que sea 0 o mayor al mismo.");
                    }
                }
                else
                {
                    throw new FormatException("Ingrese un numero por favor.");
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(enteroStr), "Ingrese un numero");
            }

            return validado;
        }


        public static bool ValidarFloat(string flotanteStr, out float flotante)
        {
            bool validado = false;
            float aux;

            if (!string.IsNullOrEmpty(flotanteStr))
            { 
                if (float.TryParse(flotanteStr, out aux))
                {
                    if (aux >= 0)
                    {
                        flotante = aux;
                        validado = true;
                    }
                    else
                    {
                        throw new NumeroNoValidoException("Ingrese un numero que sea 0 o mayor al mismo.");
                    }
                }
                else
                {
                    throw new FormatException("Ingrese un numero por favor.");
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(flotanteStr), "Ingrese un numero.");
            }

            return validado;
        }

    }
}
