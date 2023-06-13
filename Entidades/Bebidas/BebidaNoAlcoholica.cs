using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public abstract class BebidaNoAlcoholica : Bebida
    {
        private bool tieneGas;
        private float litros;

        protected BebidaNoAlcoholica(string marca, float precio, int stock, string descripcion, bool tieneGas, float litros) : base(marca, precio, stock, descripcion)
        {
            this.tieneGas = tieneGas;
            this.litros = litros;
        }


        public bool TieneGas { get => tieneGas; set => tieneGas = value; }
        public float Litros { get => litros; set => litros = value; }
    }
}
