using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public class Bebida 
    {
        private int id;
        private string marca;
        private float precio;
        private int stock;
        private int mLitros;
        private string descripcion;

        public Bebida(int id,string marca, float precio, int stock, int mLitros, string descripcion)
        {
            this.id = id;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            this.mLitros = mLitros;
            this.descripcion = descripcion;
        }

        public Bebida(string marca, float precio, int stock, int mLitros, string descripcion)
        {
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            this.mLitros = mLitros;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int MLitros { get => mLitros; set => mLitros = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public static bool operator ==(Bebida b1, Bebida b2)
        {
            return b1.Marca == b2.Marca && b1.Descripcion == b2.Descripcion;
        }

        public static bool operator !=(Bebida b1, Bebida b2)
        {
            return !(b1 == b2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.marca} {this.precio} {this.stock} {this.mLitros} {this.descripcion}");

            return sb.ToString();
        }
    }
}
