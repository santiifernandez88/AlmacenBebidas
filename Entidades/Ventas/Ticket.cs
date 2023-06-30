using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ventas
{
    public class Ticket
    {
        private int id;
        private Venta venta;

        private static int siguienteId = 1;

        public Ticket(Venta venta)
        {
            this.id = siguienteId++;
            this.venta = venta;
        }

        public int Id { get => id;}
        public Venta Venta { get => venta; set => venta = value; }
    }
}
