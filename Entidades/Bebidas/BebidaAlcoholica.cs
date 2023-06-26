using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public enum TiposBebidasAlcoholicas
    {
        Vino,
        Gin,
        Vodka,
        Fernet,
        Cerveza,
        Whiskey,
        Licor
    }
    public class BebidaAlcoholica : Bebida
    {
        private float gradoAlcoholico;
        private TiposBebidasAlcoholicas tipo;

        public static int siguienteId = 1;

        public BebidaAlcoholica(string marca, int stock, float precio, int mLitros, float gradoAlcoholico, string descripcion, TiposBebidasAlcoholicas tipo) : base(marca, precio, stock, mLitros, descripcion)
        {
            this.gradoAlcoholico = gradoAlcoholico;
            this.tipo = tipo;
        }

        public float GradoAlcoholico { get => gradoAlcoholico; set => gradoAlcoholico = value; }
        public TiposBebidasAlcoholicas Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {         
            StringBuilder sb = new StringBuilder();
           
            sb.Append(base.ToString() + "" + this.tipo);

            return base.ToString();
        }

    }
}




    
