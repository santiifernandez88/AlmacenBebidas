using Data.BaseDeDatos.SQL;
using Entidades.Archivos;
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
            VentasSQL ventasSQL = new VentasSQL();
            var listaVentas = ventasSQL.TraerTodo();

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
            VentasSQL ventasSQL = new VentasSQL();

            if (ValidarEnLista(venta))
            {
                ventasSQL.Agregar(venta);
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
            VentasSQL ventasSQL = new VentasSQL();

            foreach (Venta v in ObtenerTodos())
            {
                if (v.Id == idAEliminar)
                {
                    ventasSQL.Borrar(v.Id);
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
            AdministradorBebidaAlcoholica adminBebAlc = new AdministradorBebidaAlcoholica();
            AdministradorBebidasNoAlcoholicas adminBebNoAlc = new AdministradorBebidasNoAlcoholicas();
            bool validado = false;
            float ganancias;
            MetodoDePago metodo = (MetodoDePago)metodoInt;
            
            if(adminBebAlc.ValidarIdBebida(idBebida))
            {
                ganancias = adminBebAlc.BuscarPrecioPorId(idBebida);
                Venta ventaNueva = new Venta(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                if(Agregar(ventaNueva))
                {
                    adminBebAlc.DescontarStock(idBebida);
                    validado = true;
                }
            }
            
            if(adminBebNoAlc.ValidarIdBebida(idBebida))
            {
                ganancias = adminBebNoAlc.BuscarPrecioPorId(idBebida);
                Venta ventaNueva = new Venta(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                if (Agregar(ventaNueva))
                {
                    adminBebNoAlc.DescontarStock(idBebida);
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

        public Venta TraerVentaId(int id)
        {
            Venta venta = null;

            foreach(Venta v in ObtenerTodos())
            {
                if(v.Id == id)
                {
                    venta = v;
                    break;
                }
            }

            return venta;
        }

        public bool InformeDiarioVentas()
        {
            bool informado = false;
            SerializadoraXML<Venta> xml = new SerializadoraXML<Venta>();
            string path = Environment.CurrentDirectory + $@"/Archivos/InformesDiarios/Informes{DateTime.Today}.xml";

            if(ConseguirVentasDiarias() is not null)
            {
                foreach (Venta venta in ConseguirVentasDiarias())
                {
                    xml.Escribir(venta, path);
                    informado = true;   
                }
            }
            
            return informado;
        }

        public List<Venta> ConseguirVentasDiarias()
        {
            List<Venta> lista = new List<Venta>();

            foreach (Venta venta in ObtenerTodos())
            {
                if (venta.FechaDeVenta >= DateTime.Today)
                {
                    lista.Add(venta);
                }
            }

            return lista;
        }

    }
}
