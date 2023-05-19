using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum MetodoDePago
    {
        MercadoPago,
        Efectivo,
        Debito,
        Credito
    }

    public class Ventas
    {
        private int id;
        private MetodoDePago metodoDePago;
        private int dniCliente;
        private int idBebida;
        private int  idEmpleado;
        private float ganancias;
        private DateTime fechaDeVenta;

        private static int siguienteId = 1;

        public Ventas(MetodoDePago metodoDePago, int dniCliente, int idBebida, int idEmpleado, float ganancias, DateTime fechaDeVenta)
        {
            this.id = siguienteId++;
            this.MetodoDePago = metodoDePago;
            this.DniCliente = dniCliente;
            this.idBebida = idBebida;
            this.IdEmpleado = idEmpleado;
            this.Ganancias = ganancias;
            this.FechaDeVenta = fechaDeVenta;
        }

        public int Id { get => id;}
        public MetodoDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public int IdBebida { get => idBebida; set => idBebida = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public float Ganancias { get => ganancias; set => ganancias = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }

        public static bool operator ==(Ventas v1, Ventas v2)
        {
            return v1.dniCliente == v2.dniCliente;
        }

        public static bool operator !=(Ventas v1, Ventas v2)
        {
            return !(v1 == v2);
        }
        
    }
}
