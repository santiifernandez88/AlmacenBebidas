using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Bebidas;

namespace Entidades.Clientes
{
    public enum Estatus
    {
        Activo,
        PocoFrecuente,
        Inactivo
        
    }

    public class Cliente : Persona
    {
        private Estatus frecuencia;

        public Cliente(string nombre, string apellido, int edad, int dni, Estatus frecuencia) : base(nombre, apellido, edad, dni)
        {
            this.frecuencia = frecuencia;
        }

        public Estatus Frecuencia { get => frecuencia; set => frecuencia = value; }

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

            sb.Append(base.ToString() + " | " + frecuencia);

            return sb.ToString();
        }
    }
}
