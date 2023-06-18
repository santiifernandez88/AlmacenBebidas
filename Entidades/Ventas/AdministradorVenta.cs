using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ventas
{
    public class AdministradorVenta : IAdministrable<Venta>
    {
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Venta> ObtenerTodos()
        {
            var listaVentas = BaseDeDatos.ObtenerVentas();

            return listaVentas;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public bool Agregar(Venta venta)
        {
            bool agregado = false;

            if(ValidarEnLista(venta)) 
            {
                BaseDeDatos.GuardarVentas(venta);
                agregado = true;
            }
            
            return agregado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAEliminar"></param>
        /// <returns></returns>
        public bool Borrar(int idAEliminar)
        {
            bool eliminado = false;

            foreach (Venta v in ObtenerTodos())
            {
                if (v.Id == idAEliminar)
                {
                    BaseDeDatos.EliminarVenta(v);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public bool ValidarEnLista(Venta venta)
        {
            bool noEncontrado = false;

            foreach(Venta v in ObtenerTodos())
            {
                if(venta.Id == v.Id)
                {
                    noEncontrado = true;
                }
            }

            return noEncontrado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float AcumuladorGanancias()
        {
            float acumulador = 0;

            foreach (Venta v in ObtenerTodos())
            {
                acumulador += v.Ganancias;
            }

            return acumulador;
        }

        public bool CrearVenta(int metodoInt, string idBebidaStr, int dniCliente, string idEmpleadoStr)
        {
            bool validado = false;
            int idBebida;
            int idEmpleado;
            float ganancias;
            MetodoDePago metodo = (MetodoDePago)metodoInt;

            if (int.TryParse(idBebidaStr, out idBebida) && int.TryParse(idEmpleadoStr, out idEmpleado))
            {
                if (ValidarIdBebida(idBebida) && ValidarIdEmpleado(idEmpleado))
                {
                    ganancias = BuscarPrecioPorId(idBebida);
                    Venta ventaNueva = new Venta(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                    Agregar(ventaNueva);
                    DescontarStock(idBebida);
                    validado = true;
                }
            }

            return validado;
        }
    }
}
