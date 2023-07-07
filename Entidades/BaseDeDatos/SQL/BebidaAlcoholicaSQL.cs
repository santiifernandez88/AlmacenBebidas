using Entidades.BaseDeDatos.SQL;
using Entidades.Bebidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class BebidaAlcoholicaSQL : ConsultaSQL, IBaseDeDatos<BebidaAlcoholica>
    {
        public void Agregar(BebidaAlcoholica objeto)
        {
            string query = $"INSERT INTO BebidasAlcoholicas (marca, stock, precio, miliLitros, gradoAlcoholico, descripcion, tipoDeBebida) VALUES ('{objeto.Marca}', '{objeto.Stock}', '{objeto.Precio}', '{objeto.MLitros}', '{objeto.GradoAlcoholico}', '{objeto.Descripcion}', '{Convert.ToInt32(objeto.Tipo)}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int id)
        {
            string query = $"DELETE FROM BebidasAlcoholicas WHERE id = {id}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(BebidaAlcoholica objeto)
        {
            string query = $"UPDATE FORM BebidasAlcoholicas SET id = {objeto.Id}, marca = {objeto.Marca}, stock = {objeto.Stock}, precio = {objeto.Precio}, miliLitros = {objeto.MLitros}, gradoAlcoholico = {objeto.GradoAlcoholico}, descripcion = {objeto.Descripcion}, tipoDeBebida = {Convert.ToInt32(objeto.Tipo)} WHERE id = {objeto.Id}";
            this.EjecutarNonQuery(query);
        }

        public List<BebidaAlcoholica> TraerTodo()
        {
            List<BebidaAlcoholica> listaBebidasNoAlcoholicas = new List<BebidaAlcoholica>();
            var dataTable = this.EjecutarQuery("SELECT * FROM BebidasAlcoholicas");

            foreach (DataRow item in dataTable.Rows)
            {
                string marca = item["marca"].ToString() ?? "";
                int stock = (int)item["stock"];
                double precio = (double)item["precio"];
                int mLitros = (int)item["miliLitros"];
                string descripcion = item["descripcion"].ToString() ?? "";
                TiposBebidasAlcoholicas tipo = (TiposBebidasAlcoholicas)item["tipoBebida"];
                decimal gradoAlcoholico = Convert.ToDecimal(item["gradoAlcoholico"]);

                float precioBeb = (float)precio;
                float gradoAlc = (float)gradoAlcoholico;

                listaBebidasNoAlcoholicas.Add(new BebidaAlcoholica(marca, stock, precioBeb, mLitros, gradoAlc, descripcion, tipo));
            }

            return listaBebidasNoAlcoholicas;
        }
    }
}
