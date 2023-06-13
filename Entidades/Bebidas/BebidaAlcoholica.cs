using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public enum TiposDeBebida
    {
        Vino,
        Gin,
        Vodka,
        Fernet,
        Cerveza,
        Licor,
        Whiskey,
        Vermu
    }
    public abstract class BebidaAlcoholica : Bebida
    {
        private float gradoAlcoholico;
        private float litros;


        public static int siguienteId = 1;

        public BebidaAlcoholica(string marca, int stock, float precio, string descripcion, float gradoAlcoholico) : base(marca, precio, stock, descripcion)
        {

            this.gradoAlcoholico = gradoAlcoholico;

        }


        public float GradoAlcoholico { get => gradoAlcoholico; set => gradoAlcoholico = value; }

        public static bool operator ==(BebidaAlcoholica b1, BebidaAlcoholica b2)
        {
            return b1.Id == b2.Id;
        }

        public static bool operator !=(BebidaAlcoholica b1, BebidaAlcoholica b2)
        {
            return !(b1 == b2);
        }
    }
}