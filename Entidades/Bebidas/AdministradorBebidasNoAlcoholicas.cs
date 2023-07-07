using Data.BaseDeDatos.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public class AdministradorBebidasNoAlcoholicas : IAdministrable<BebidaNoAlcoholica>, IBebible<BebidaNoAlcoholica>
    {
        public event delegadoBebida ReservaStock;
        public event delegadoBebida SinStock;
        public bool CrearBebidaNoAlcoholica(string marca, string precioStr, string stockStr, string descripcion, string mLitrosStr, int tipoBebidaIndex, bool contienenAzucar)
        {
            bool validado = false;
            float precio;
            int mLitros;
            int stock;
            TiposBebidasNoAlc tipoDeBebida = (TiposBebidasNoAlc)tipoBebidaIndex;

            if(Validaciones.ValidarString(marca) && Validaciones.ValidarString(descripcion) && Validaciones.ValidarEntero(mLitrosStr, out mLitros) 
                && Validaciones.ValidarFloat(precioStr, out precio) && Validaciones.ValidarEntero(stockStr, out stock))
            {
                BebidaNoAlcoholica bebidaNueva = new BebidaNoAlcoholica(marca, precio, stock, descripcion, mLitros, tipoDeBebida, contienenAzucar);
                Agregar(bebidaNueva);
                validado = true;
            }

            return validado;
        }
        public bool Agregar(BebidaNoAlcoholica bebida)
        {
            bool agregado = false;
            BebidaNoAlcoholicaSQL bebidaNoAlcoholicaSQL = new BebidaNoAlcoholicaSQL();
            if (ValidarEnLista(bebida))
            {
                bebidaNoAlcoholicaSQL.Agregar(bebida);
                agregado = true;
            }

            return agregado;
        }

        public bool Borrar(int id)
        {
            bool eliminado = false;
            BebidaNoAlcoholicaSQL bebidaNoAlcoholicaSQL = new BebidaNoAlcoholicaSQL();

            foreach (BebidaNoAlcoholica b in ObtenerTodos())
            {
                if (b.Id == id)
                {
                    bebidaNoAlcoholicaSQL.Borrar(b.Id);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public List<BebidaNoAlcoholica> ObtenerTodos()
        {
            BebidaNoAlcoholicaSQL bebidaNoAlcoholicaSQL = new BebidaNoAlcoholicaSQL();
            return bebidaNoAlcoholicaSQL.TraerTodo();
        }

        public bool ValidarEnLista(BebidaNoAlcoholica bebidaNoAlcoholica)
        {
            bool noEncontrado = true;

            foreach(BebidaNoAlcoholica b in ObtenerTodos())
            {
                if(b == bebidaNoAlcoholica)
                {
                    noEncontrado = false;
                }
            }

            return noEncontrado;
        }

        public float BuscarPrecioPorId(int id)
        {
            float precioRetornado = 0;
            foreach(BebidaNoAlcoholica b in ObtenerTodos())
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
            foreach(BebidaNoAlcoholica b in ObtenerTodos())
            {
                if (b.Stock != 25)
                {
                    b.Stock = 25;
                }
            }
        }

        public void DescontarStock(int idBebida)
        {
            foreach(BebidaNoAlcoholica b in ObtenerTodos())
            {
                if (b.Id == idBebida && b.Stock > 0)
                {
                    b.Stock--;
                    //LanzadorEvento(b);       
                    break;
                }
            }
        }

        public void LanzadorEvento(BebidaNoAlcoholica bebida)
        {
            if(bebida.Stock <= 5 && bebida.Stock > 0)
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

            foreach(BebidaNoAlcoholica b in ObtenerTodos())
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
