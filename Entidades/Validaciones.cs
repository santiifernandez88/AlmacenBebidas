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
                    if (char.IsLetter(cadena[i]))
                    {
                        validado = true;
                    }
                    else
                    {
                        throw new Exception("Error, ingrese solamente letreas.");
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(cadena));
            }

            return validado; 
        }

        public static bool ValidarEntero(string enteroStr, int entero)
        {
            bool validado = false;

            if(!string.IsNullOrEmpty(enteroStr))
            {
                for(int i = 0; i < enteroStr.Length; i++)
                {
                    if(int.TryParse(enteroStr, out entero))
                    {
                        if(entero >= 0)
                        {
                            validado = true;
                        }
                        else
                        {
                            throw new Exception("Ingrese un numero que sea 0 o mayor al mismo.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Ingrese un numero por favor.");
                    }
                }                
            }
            else
            {
                throw new ArgumentNullException(nameof(enteroStr));
            }

            return validado;
        }


       /* public static bool ValidarFloat(string flotanteStr, out float flotante)
        {
            bool validado = false;
            float f;

            if (!string.IsNullOrEmpty(flotanteStr))
            {
                for (int i = 0; i < flotanteStr.Length; i++)
                {
                    if (float.TryParse(flotanteStr, out flotante))
                    {
                        if (flotante >= 0)
                        {
                            f = flotante;

                            validado = true;
                        }
                        else
                        {
                            throw new Exception("Ingrese un numero que sea 0 o mayor al mismo.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Ingrese un numero por favor.");
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(flotanteStr));
            }

            return validado;
        }*/

    }
}
