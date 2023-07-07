using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ventas
{
    public enum MetodoDePago
    {
        MercadoPago,
        Efectivo,
        Debito,
        Credito
    }
    [Serializable]
    public class Venta
    {
        private int id;
        private MetodoDePago metodoDePago;
        private int dniCliente;
        private int idBebida;
        private int idEmpleado;
        private float ganancias;
        private DateTime fechaDeVenta;
        private int idBebidaUnoCombo;
        private int idBebidaDosCombo;

        public Venta()
        {

        }

        public Venta(int id,MetodoDePago metodoDePago, int dniCliente, int idBebida, int idEmpleado, float ganancias, DateTime fechaDeVenta)
        {
            this.id = id;
            this.metodoDePago = metodoDePago;
            this.dniCliente = dniCliente;
            this.idBebida = idBebida;
            this.idEmpleado = idEmpleado;
            this.ganancias = ganancias;
            this.fechaDeVenta = fechaDeVenta;
        }

        public Venta(int id, MetodoDePago metodoDePago, int dniCliente, int idEmpleado, float ganancias, DateTime fechaDeVenta, int idBebidaUnoCombo, int idBebidaDosCombo)
        {
            this.id = id;
            this.metodoDePago = metodoDePago;
            this.dniCliente = dniCliente;
            this.idEmpleado = idEmpleado;
            this.ganancias = ganancias;
            this.fechaDeVenta = fechaDeVenta;
            this.idBebidaUnoCombo = idBebidaUnoCombo;
            this.idBebidaDosCombo = idBebidaDosCombo;
        }

        public Venta(MetodoDePago metodoDePago, int dniCliente, int idBebida, int idEmpleado, float ganancias, DateTime fechaDeVenta)
        {
            this.metodoDePago = metodoDePago;
            this.dniCliente = dniCliente;
            this.idBebida = idBebida;
            this.idEmpleado = idEmpleado;
            this.ganancias = ganancias;
            this.fechaDeVenta = fechaDeVenta;
        }

        public Venta(MetodoDePago metodoDePago, int dniCliente, int idEmpleado, float ganancias, DateTime fechaDeVenta, int idBebidaUnoCombo, int idBebidaDosCombo)
        {
            this.metodoDePago = metodoDePago;
            this.dniCliente = dniCliente;
            this.idEmpleado = idEmpleado;
            this.ganancias = ganancias;
            this.fechaDeVenta = fechaDeVenta;
            this.idBebidaUnoCombo = idBebidaUnoCombo;
            this.idBebidaDosCombo = idBebidaDosCombo;
        }

        public int Id { get => id; set => id = value; }
        public MetodoDePago MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public int DniCliente { get => dniCliente; set => dniCliente = value; }
        public int IdBebida { get => idBebida; set => idBebida = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public float Ganancias { get => ganancias; set => ganancias = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }
        public int IdBebidaUnoCombo { get => idBebidaUnoCombo; set => idBebidaUnoCombo = value; }
        public int IdBebidaDosCombo { get => idBebidaDosCombo; set => idBebidaDosCombo = value; }

        public static bool operator ==(Venta v1, Venta v2)
        {
            return v1.dniCliente == v2.dniCliente;
        }

        public static bool operator !=(Venta v1, Venta v2)
        {
            return !(v1 == v2);
        }

    }
}
