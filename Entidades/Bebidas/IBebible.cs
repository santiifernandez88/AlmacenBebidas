using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    internal interface IBebible<T>
    {
        public float BuscarPrecioPorId(int id);

        public void RellenarStock();

        public void DescontarStock(int idBebida);

        public void LanzadorEvento(T bebida);

        public bool ValidarIdBebida(int id);
    }
}
