using Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public class AdministradorBebidaAlcoholica : IAdministrable<BebidaAlcoholica>, IBebible<BebidaAlcoholica>
    {
        public event delegadoBebida ReservaStock;
        public event delegadoBebida SinStock;
        public bool CrearBebidaAlcoholica(string marca, string stockStr, string precioStr, string mLitrosStr, string gradoAlcStr, string descripcion, int tipoBebidaIndex)
        {
            bool validado = false;
            float gradoAlc;
            float precio;
            int mLitros;
            int stock;
            TiposBebidasAlcoholicas tipoDeBebida = (TiposBebidasAlcoholicas)tipoBebidaIndex;

            if(Validaciones.ValidarString(marca) && Validaciones.ValidarString(descripcion) && Validaciones.ValidarFloat(gradoAlcStr, out gradoAlc) 
               && Validaciones.ValidarFloat(precioStr, out precio) && Validaciones.ValidarEntero(stockStr, out stock) && Validaciones.ValidarEntero(mLitrosStr, out mLitros))
            {
                BebidaAlcoholica bebidaNueva = new BebidaAlcoholica(marca, stock, precio, mLitros, gradoAlc, descripcion, tipoDeBebida);
                Agregar(bebidaNueva);
                validado = true;
            }

            return validado;
        }
        public bool Agregar(BebidaAlcoholica bebidaAlcoholica)
        {
            bool agregado = false;
            if(ValidarEnLista(bebidaAlcoholica)) 
            {
                BaseDeDatos.GuardarBebidasAlcoholicas(bebidaAlcoholica);
                agregado = true;
            }
            
            return agregado;
        }

        public bool Borrar(int id)
        {
            bool eliminado = false;

            foreach(BebidaAlcoholica bebida in ObtenerTodos())
            {
                if (bebida.Id == id)
                {
                    BaseDeDatos.EliminarBebidaAlcoholica(bebida);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public List<BebidaAlcoholica> ObtenerTodos()
        {
            return BaseDeDatos.ObtenerBebidasAlcoholicas();
        }

        public bool ValidarEnLista(BebidaAlcoholica bebidaAlcoholica)
        {
            bool noEncontrado = true;

            foreach(BebidaAlcoholica b in ObtenerTodos())
            {
                if (b == bebidaAlcoholica)
                {
                    noEncontrado = false;
                }
            }

            return noEncontrado;
        }

        public float BuscarPrecioPorId(int id)
        {
            float precioRetornado = 0;
            foreach (BebidaAlcoholica b in ObtenerTodos())
            {
                if (b.Id == id)
                {
                    precioRetornado = b.Precio;
                }
            }

            return precioRetornado;
        }

        public void RellenarStock()
        {
            foreach(BebidaAlcoholica b in ObtenerTodos())
            {
                if (b.Stock != 25)
                {
                    b.Stock = 25;
                }
            }
        }

        public void DescontarStock(int idBebida)
        {
            foreach (BebidaAlcoholica b in ObtenerTodos())
            {
                if (b.Id == idBebida)
                {
                    b.Stock--;
                    //LanzadorEvento(b);
                    break;
                }
            }
        }

        public void LanzadorEvento(BebidaAlcoholica bebida)
        {
            if (bebida.Stock <= 5 && bebida.Stock > 0)
            {
                BebidaEventArgs e = new BebidaEventArgs();
                e.StockRestante = bebida.Stock;
                ReservaStock(bebida, e);
            }

            if (bebida.Stock == 0)
            {
                BebidaEventArgs e = new BebidaEventArgs();
                e.StockRestante = bebida.Stock;
                SinStock(bebida, e);
            }
        }

        public bool ValidarIdBebida(int id)
        {
            bool validado = false;

            foreach (BebidaAlcoholica b in ObtenerTodos())
            {
                if (id == b.Id)
                {
                    validado = true;
                    break;
                }
            }

            return validado;
        }
    }
}
