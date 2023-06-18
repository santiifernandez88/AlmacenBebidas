using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    internal class AdministradorBebidasNoAlcoholicas : IAdministrable<BebidaNoAlcoholica>, IBebible
    {
        public bool CrearBebidaNoAlcoholica(string marca, string precioStr, string stockStr, string descripcion, string mLitrosStr, int tipoBebidaIndex)
        {
            bool validado = false;
            bool contienenAzucar;
            float gradoAlc;
            float precio;
            int mLitros;
            int stock;
            TiposBebidasNoAlc tipoDeBebida = (TiposBebidasNoAlc)tipoBebidaIndex;

            if (!string.IsNullOrEmpty(marca) && int.TryParse(mLitrosStr, out mLitros) && float.TryParse(precioStr, out precio) && int.TryParse(stockStr, out stock))
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
            if (ValidarEnLista(bebida))
            {
                BaseDeDatos.GuardarBebidasNoAlcoholicas(bebida);
                agregado = true;
            }

            return agregado;
        }

        public bool Borrar(int id)
        {
            bool eliminado = false;

            foreach (BebidaNoAlcoholica b in ObtenerTodos())
            {
                if (b.Id == id)
                {
                    BaseDeDatos.EliminarBebidaNoAlcoholica(b);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public List<BebidaNoAlcoholica> ObtenerTodos()
        {
            return BaseDeDatos.ObtenerBebidasNoAlcoholicas();
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
                if (b.Id == idBebida)
                {
                    b.Stock--;
                }
            }
        }

        public bool ValidarIdBebida(int id)
        {
            bool validado = false;

            foreach(BebidaNoAlcoholica b in ObtenerTodos())
            {
                if (id <= b.Id)
                {
                    validado = true;
                }
            }

            return validado;
        }
    }
}
