using Entidades.BaseDeDatos.SQL;
using Entidades.Bebidas;
using Entidades.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class VentasSQL : ConsultaSQL, IBaseDeDatos<Venta>
    {
        public void Agregar(Venta objeto)
        {
            string query = $"INSERT INTO Ventas (metodo, dniCliente, idBebida, idEmpleado, ganancias, fechaDeVenta, idBebidaUnoCombo, idBebidaDosCombo) VALUES ('{(int)objeto.MetodoDePago}', '{objeto.DniCliente}', '{objeto.IdBebida}', '{objeto.IdEmpleado}', '{objeto.Ganancias}', '{objeto.FechaDeVenta}', '{objeto.IdBebidaUnoCombo}', '{objeto.IdBebidaDosCombo}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int id)
        {
            string query = $"DELETE FROM Ventas WHERE id = {id}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(Venta objeto)
        {
            string query = $"UPDATE FORM Ventas SET id = {objeto.Id}, metodo = {(int)objeto.MetodoDePago}, dniCliente = {objeto.DniCliente}, idBebida = {objeto.IdBebida}, idEmpleado = {objeto.IdEmpleado}, ganancias = {objeto.Ganancias}, fechaDeVenta = {objeto.FechaDeVenta}, idBebidaUnoCombo = {objeto.IdBebidaUnoCombo}, idBebidaDosCombo = {objeto.IdBebidaDosCombo} WHERE id = {objeto.Id}";
            this.EjecutarNonQuery(query);
        }

        public List<Venta> TraerTodo()
        {
            List<Venta> listaVentas = new List<Venta>();
            var dataTable = this.EjecutarQuery("SELECT * FROM Ventas");

            foreach (DataRow item in dataTable.Rows)
            {
                int id = (int)item["id"];
                MetodoDePago metodo = (MetodoDePago)item["metodo"];
                int dniCliente = (int)item["dniCliente"];
                int idBebida = (int)item["idBebida"];
                int idEmpleado = (int)item["idEmpleado"];
                decimal ganancias = Convert.ToDecimal(item["ganancias"]);
                DateTime fechaDeVenta = (DateTime)item["fechaDeVenta"];
                int idBebidaUnoCombo = (int)item["idBebidaUnoCombo"];
                int idBebidaDosCombo = (int)item["idBebidaDosCombo"];

                float ganan = (float)ganancias;

                if(idBebidaUnoCombo > 0 && idBebidaDosCombo > 0)
                {
                    listaVentas.Add(new Venta(id,metodo, dniCliente, idEmpleado, ganan, fechaDeVenta, idBebidaUnoCombo, idBebidaDosCombo));
                }
                else
                {
                    listaVentas.Add(new Venta(id,metodo, dniCliente, idBebida, idEmpleado, ganan, fechaDeVenta));
                }
            }

            return listaVentas;
        }
    }
}
