using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Empleados
{
    public class AdministradorEmpleado : Administrador<Empleado>
    {

        public override bool Agregar(Empleado empleado)
        {
            bool añadido = false;

            if (ValidarEnLista(empleado))
            {
                BaseDeDatos.GuardarEmpleado(empleado);
                añadido = true;
            }

            return añadido;
        }
        public override bool Borrar(int idAEliminar)
        {
            bool eliminado = false;

            foreach (Empleado emp in ObtenerTodos())
            {
                if (emp.Id == idAEliminar)
                {
                    BaseDeDatos.EliminarEmpleado(emp);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;

        }

        public override List<Empleado> ObtenerTodos()
        {
            var listaEmpleados = BaseDeDatos.ObtenerEmpleados();

            return listaEmpleados;
        }

        public override bool ValidarEnLista(Empleado empleado)
        {
            bool noEncontrado = true;
            foreach (Empleado e in ObtenerTodos())
            {
                if (e == empleado)
                {
                    noEncontrado = false;
                    break;
                }
            }

            return noEncontrado;
        }

    }
}
