using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal interface IBebible
    {
        public float BuscarPrecioPorId(int id);

        public void RellenarStock();

        public void DescontarStock(int idBebida);

        public bool ValidarIdBebida(int id);
    }
}
