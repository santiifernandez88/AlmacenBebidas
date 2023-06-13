using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Bebidas;

namespace Entidades.Clientes
{
    public class Cliente : Persona
    {
        private TiposDeBebida bebidaFavorita;

        public Cliente(string nombre, string apellido, int edad, int dni, TiposDeBebida bebidaFavorita) : base(nombre, apellido, edad, dni)
        {
            this.bebidaFavorita = bebidaFavorita;
        }

        public TiposDeBebida BebidaFavorita { get => bebidaFavorita; set => bebidaFavorita = value; }

        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.Dni == b.Dni;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString() + " | " + bebidaFavorita);

            return sb.ToString();
        }
    }
}
