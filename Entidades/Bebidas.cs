using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
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
    public class Bebidas
    {
        private int id;
        private string marca;
        private float gradoAlcoholico;
        private float precio;
        private TiposDeBebida tipoBebida;
        private int stock;

        public static int siguienteId = 1;

        public Bebidas(string marca, float gradoAlcoholico, float precio, TiposDeBebida tipoBebida, int stock)
        {
            this.id = siguienteId++;
            this.marca = marca;
            this.gradoAlcoholico = gradoAlcoholico;
            this.precio = precio;
            this.tipoBebida = tipoBebida;
            this.Stock = stock;
        }

        public int Id { get => id;}
        public string Marca { get => marca; set => marca = value; }
        public float GradoAlcoholico { get => gradoAlcoholico; set => gradoAlcoholico = value; }
        public float Precio { get => precio; set => precio = value; }
        public TiposDeBebida TipoBebida { get => tipoBebida; set => tipoBebida = value; }
        public int Stock { get => stock; set => stock = value; }

        public static bool operator ==(Bebidas b1, Bebidas b2)
        {
            return b1.Id == b2.Id;
        }

        public static bool operator !=(Bebidas b1, Bebidas b2)
        {
            return !(b1 == b2);
        }
    }
}
