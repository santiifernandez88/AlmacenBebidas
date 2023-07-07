using Entidades.BaseDeDatos.SQL;
using Entidades.Bebidas;
using Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class BebidaNoAlcoholicaSQL : ConsultaSQL, IBaseDeDatos<BebidaNoAlcoholica>
    {
        public void Agregar(BebidaNoAlcoholica objeto)
        {
            string query = $"INSERT INTO BebidasNoAlcoholicas (marca, stock, precio. miliLitros, descripcion, tipoDeBebida, contieneAzucar) VALUES ('{objeto.Marca}', '{objeto.Stock}', '{objeto.Precio}', '{objeto.MLitros}', '{objeto.Descripcion}', '{Convert.ToInt32(objeto.Tipo)}', '{objeto.ContienenAzucar}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int id)
        {
            string query = $"DELETE FROM BebidasNoAlcoholicas WHERE id = {id}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(BebidaNoAlcoholica objeto)
        {
            string query = $"UPDATE FORM BebidasNoAlcoholicas SET id = {objeto.Id}, marca = {objeto.Marca}, stock = {objeto.Stock}, precio = {objeto.Precio}, miliLitros = {objeto.MLitros}, descripcion = {objeto.Descripcion}, tipoDeBebida = {Convert.ToInt32(objeto.Tipo)}, contieneAzucar = {objeto.ContienenAzucar.ToString()}  WHERE id = {objeto.Id}";
            this.EjecutarNonQuery(query);
        }

        public List<BebidaNoAlcoholica> TraerTodo()
        {
            List<BebidaNoAlcoholica> listaBebidasNoAlcoholicas = new List<BebidaNoAlcoholica>();
            var dataTable = this.EjecutarQuery("SELECT * FROM BebidasNoAlcoholicas");

            foreach (DataRow item in dataTable.Rows)
            {
                string marca = item["marca"].ToString() ?? "";
                int stock = (int)item["stock"];
                decimal precio = Convert.ToDecimal(item["precio"]);
                int mLitros = (int)item["miliLitros"];
                string descripcion = item["descripcion"].ToString() ?? "";
                TiposBebidasNoAlc tipo = (TiposBebidasNoAlc)item["tipoDeBebida"];
                bool contieneAzucar = Convert.ToBoolean(item["contieneAzucar"]);

                float precioBeb = (float)precio;

                listaBebidasNoAlcoholicas.Add(new BebidaNoAlcoholica(marca, precioBeb, stock, descripcion, mLitros, tipo, contieneAzucar));
            }

            return listaBebidasNoAlcoholicas;
        }
    }
}
