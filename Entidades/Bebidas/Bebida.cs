using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public abstract class Bebida // id para todas las bebidas, y para diferenciar una de otras un codigo que represente a las no alcoholicas y a las alcoholicas // Lanzar excepciones en el modelo y trabajarlas dependiendo // reprogramar mis clases, controlador esta bien podria hacer un administrador por cada entidad, separar en otra biblioteca de clases todo lo que tenga que ver con datos de archivos y base de datos
    {
        private int id;
        private string marca;
        private float precio;
        private int stock;
        private string descripcion;

        private static int siguienteId = 1;

        protected Bebida(string marca, float precio, int stock, string descripcion)
        {
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            id = siguienteId++;
            this.descripcion = descripcion;
        }

        public int Id { get => id; }
        public string Marca { get => marca; set => marca = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
