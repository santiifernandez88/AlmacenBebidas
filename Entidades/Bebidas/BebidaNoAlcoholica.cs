using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public enum TiposBebidasNoAlc
    {
        Gaseosa,
        Jugo,
        Energizante
    }
    public class BebidaNoAlcoholica : Bebida
    {
        private TiposBebidasNoAlc tipo;
        private bool contienenAzucar;

        public BebidaNoAlcoholica(string marca, float precio, int stock, string descripcion, int mLitros, TiposBebidasNoAlc tipo, bool contienenAzucar) : base(marca, precio, stock, mLitros, descripcion)
        {
            this.tipo = tipo;
            this.contienenAzucar = contienenAzucar;
        }

        public bool ContienenAzucar { get => contienenAzucar; set => contienenAzucar = value; }
        public TiposBebidasNoAlc Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString() + "" + this.tipo);

            return base.ToString();
        }
    }
}
