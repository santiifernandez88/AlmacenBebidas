using Entidades.BaseDeDatos.SQL;
using Entidades.Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BaseDeDatos.SQL
{
    public class EmpleadoSQL : ConsultaSQL, IBaseDeDatos<Empleado>
    {
        public void Agregar(Empleado objeto)
        {
            string query = $"INSERT INTO EmpleadoDos (nombre, apellido, edad, dni, sueldo, puesto) VALUES ('{objeto.Nombre}', '{objeto.Apellido}', '{objeto.Edad}', '{objeto.Dni}', '{Convert.ToInt32(objeto.Sueldo)}', '{objeto.Puesto.ToString()}')";
            this.EjecutarNonQuery(query);
        }

        public void Borrar(int id)
        {
            string query = $"DELETE FROM EmpleadoDos WHERE id = {id}";
            this.EjecutarNonQuery(query);
        }

        public void Modificar(Empleado objeto)
        {
            string query = $"UPDATE EmpleadoDos SET nombre = '{objeto.Nombre}', apellido = '{objeto.Apellido}', edad = {objeto.Edad}, dni = {objeto.Dni}, sueldo = {Convert.ToInt32(objeto.Sueldo)}, puesto = '{objeto.Puesto.ToString()}' WHERE id = {objeto.Id}";
            this.EjecutarNonQuery(query);
        }

        public List<Empleado> TraerTodo()
        {
            List<Empleado> listaEmpleado = new List<Empleado>();
            var dataTable = this.EjecutarQuery("SELECT * FROM EmpleadoDos");

            foreach(DataRow item in dataTable.Rows) 
            {
                int id = (int)item["id"];
                string nombre = item["nombre"].ToString() ?? "";
                string apellido = item["apellido"].ToString() ?? "";
                int edad = (int)item["edad"];
                int dni = (int)item["dni"];
                decimal sueldo = Convert.ToDecimal(item["sueldo"]);
                string puesto = item["puesto"].ToString();
                int entero;
                float sueldoEmp = (float)sueldo;
                if (puesto == "Jefe")
                {
                    listaEmpleado.Add(new Empleado(id, nombre, apellido, edad, dni, sueldoEmp, PuestosDeTrabajo.Jefe));
                }
                else
                {
                    if(puesto == "Encargado")
                    {
                        listaEmpleado.Add(new Empleado(id, nombre, apellido, edad, dni, sueldoEmp, PuestosDeTrabajo.Encargado));
                    }
                    else
                    {
                        listaEmpleado.Add(new Empleado(id, nombre, apellido, edad, dni, sueldoEmp, PuestosDeTrabajo.Vendedor));

                    }
                }

                

                
            }

            return listaEmpleado;
        }
    }
}
