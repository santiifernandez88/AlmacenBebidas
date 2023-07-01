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

        public Ticket(Venta venta, int siguienteId)
        {
            this.id = siguienteId;
            this.venta = venta;
        }

        
        public Venta Venta { get => venta; set => venta = value; }
        public int Id { get => id; set => id = value; }
    }
}
