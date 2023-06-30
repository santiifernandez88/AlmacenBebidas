using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Bebidas
{
    public delegate void delegadoBebida(object sender, BebidaEventArgs e);
    public class BebidaEventArgs : EventArgs
    {
        private int stockRestante;

        public int StockRestante { get => stockRestante; set => stockRestante = value; }
    }
}
