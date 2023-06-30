using Entidades.Bebidas;
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
            bool noEncontrado = true;

            foreach(Venta v in ObtenerTodos())
            {
                if(venta.Id == v.Id)
                {
                    noEncontrado = false; 
                    break;
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

        public bool CrearVenta(int metodoInt, int idBebida, int dniCliente, int idEmpleado)
        {
            AdministradorBebidaAlcoholica administradorBebidaAlcoholica = new AdministradorBebidaAlcoholica();
            AdministradorBebidasNoAlcoholicas administradorBebidasNoAlcoholicas = new AdministradorBebidasNoAlcoholicas();
            bool validado = false;
            float ganancias;
            MetodoDePago metodo = (MetodoDePago)metodoInt;
            
            if(administradorBebidaAlcoholica.ValidarIdBebida(idBebida))
            {
                ganancias = administradorBebidaAlcoholica.BuscarPrecioPorId(idBebida);
                Venta ventaNueva = new Venta(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                if(Agregar(ventaNueva))
                {
                    administradorBebidaAlcoholica.DescontarStock(idBebida);
                    validado = true;
                }
            }
            
            if(administradorBebidasNoAlcoholicas.ValidarIdBebida(idBebida))
            {
                ganancias = administradorBebidasNoAlcoholicas.BuscarPrecioPorId(idBebida);
                Venta ventaNueva = new Venta(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                if (Agregar(ventaNueva))
                {
                    administradorBebidasNoAlcoholicas.DescontarStock(idBebida);
                    validado = true;
                }
            }

                    
            return validado;
        }

        public bool CrearVenta(int metodoInt, int dniCliente, int idEmpleado, int idBebidaUno, int idBebidaDos)
        {
            bool validado = false;
            float ganancias;
            MetodoDePago metodo = (MetodoDePago)metodoInt;
            ganancias = Combo.BuscarPrecioCombo(idBebidaUno, idBebidaDos);

            Venta ventaNueva = new Venta(metodo, dniCliente, idEmpleado, ganancias, DateTime.Now, idBebidaUno, idBebidaDos);
            if (Agregar(ventaNueva))
            {
                Combo.DescontarStockCombo(idBebidaUno, idBebidaDos);
                validado = true;
            }

            return validado;
        }
    }
}
