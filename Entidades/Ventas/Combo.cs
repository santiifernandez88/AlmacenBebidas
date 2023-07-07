using Entidades.Bebidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ventas
{
    public class Combo
    {
        private BebidaAlcoholica bebidaAlcoholica;
        private BebidaNoAlcoholica bebidaNoAlcoholica;

        public Combo(BebidaAlcoholica bebidaAlcoholica, BebidaNoAlcoholica bebidaNoAlcoholica)
        {
            this.bebidaAlcoholica = bebidaAlcoholica;
            this.bebidaNoAlcoholica = bebidaNoAlcoholica;
        }

        public BebidaAlcoholica BebidaAlcoholica { get => bebidaAlcoholica; set => bebidaAlcoholica = value; }
        public BebidaNoAlcoholica BebidaNoAlcoholica { get => bebidaNoAlcoholica; set => bebidaNoAlcoholica = value; }

        public static float BuscarPrecioCombo(int idbebidaUno, int idBebidaDos)
        {
            AdministradorBebidaAlcoholica adminBebAlc = new AdministradorBebidaAlcoholica();
            AdministradorBebidasNoAlcoholicas adminBebNoAlc = new AdministradorBebidasNoAlcoholicas();
            float precioUno = adminBebAlc.BuscarPrecioPorId(idbebidaUno);
            float precioDos = adminBebNoAlc.BuscarPrecioPorId(idBebidaDos);

            return precioUno + precioDos;
        }

        public static void DescontarStockCombo(int idbebidaUno, int idBebidaDos)
        {
            AdministradorBebidaAlcoholica adminBebAlc = new AdministradorBebidaAlcoholica();
            AdministradorBebidasNoAlcoholicas adminBebNoAlc = new AdministradorBebidasNoAlcoholicas();
            adminBebAlc.DescontarStock(idbebidaUno);
            adminBebNoAlc.DescontarStock(idBebidaDos);

        }
    }
}
