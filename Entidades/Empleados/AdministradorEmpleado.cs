using Data.BaseDeDatos.SQL;
using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Empleados
{
    public class AdministradorEmpleado : IAdministrable<Empleado>
    {
        /// <summary>
        /// Crea un empleado y valida que no este en la lsita
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edadStr"></param>
        /// <param name="dniStr"></param>
        /// <param name="sueldoStr"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="puestoIndex"></param>
        /// <returns>true o false si se pudo crear y agregar a la lista</returns>
        public bool CrearEmpleado(string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, string nombreUsuario, string contraseña, int puestoIndex)
        {
            AdministradorUsuario administradorUsuario = new AdministradorUsuario();
            bool result = false;
            int edad;
            int dni;
            float sueldo;
            PuestosDeTrabajo puesto = (PuestosDeTrabajo)puestoIndex;

            if (Validaciones.ValidarString(nombre) && Validaciones.ValidarString(apellido) && Validaciones.ValidarString(nombreUsuario) && Validaciones.ValidarString(contraseña)
                && Validaciones.ValidarEntero(edadStr, out edad) && Validaciones.ValidarEntero(dniStr, out dni) && Validaciones.ValidarFloat(sueldoStr, out sueldo))
            {
                Empleado empleadoNuevo = new Empleado(nombre, apellido, edad, dni, sueldo, puesto);
                Usuario usuarioNuevo = new Usuario(nombreUsuario, contraseña, empleadoNuevo);
                if(Agregar(empleadoNuevo))
                {
                    administradorUsuario.Agregar(usuarioNuevo);
                    result = true;
                }
            }

            return result;
        }
        /// <summary>
        /// Modifica un empleado
        /// </summary>
        /// <param name="empleado"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edadStr"></param>
        /// <param name="dniStr"></param>
        /// <param name="sueldoStr"></param>
        /// <param name="puestoIndex"></param>
        /// <returns>true o false si se pudo modificar</returns>
        public bool ModificarEmpleado(Empleado empleado, string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, int puestoIndex)
        {
            bool modificado = false;
            int edad;
            int dni;
            float sueldo;
            PuestosDeTrabajo puesto = (PuestosDeTrabajo)puestoIndex;

            if (Validaciones.ValidarString(nombre) && Validaciones.ValidarString(apellido) && Validaciones.ValidarEntero(edadStr, out edad)
                && Validaciones.ValidarEntero(dniStr,out dni) && Validaciones.ValidarFloat(sueldoStr, out sueldo))
            {

                Empleado empleadoModificado = new Empleado(nombre, apellido, edad, dni, sueldo, puesto);

                if (ValidarEnLista(empleadoModificado) || empleadoModificado.Dni == empleado.Dni)
                {
                    empleadoModificado.Id = empleado.Id;
                    empleado.Apellido = empleadoModificado.Apellido;
                    empleado.Nombre = empleadoModificado.Nombre;
                    empleado.Edad = empleadoModificado.Edad;
                    empleado.Dni = empleadoModificado.Dni;
                    empleado.Sueldo = empleadoModificado.Sueldo;
                    empleado.Puesto = empleadoModificado.Puesto;
                    EmpleadoSQL empleadoSQL = new EmpleadoSQL();
                    empleadoSQL.Modificar(empleadoModificado);
                    modificado = true;
                }
            }

            return modificado;
        }

        /// <summary>
        /// Agrega un empleado que no este en lista
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns>true o false si se pudo agregar</returns>
        public bool Agregar(Empleado empleado)
        {
            bool añadido = false;
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();

            if (ValidarEnLista(empleado))
            {
                empleadoSQL.Agregar(empleado);
                añadido = true;
            }

            return añadido;
        }
        /// <summary>
        /// Se le pasa un id a eliminar como parametra, y una vez encontrado el empleado lo elimina.
        /// </summary>
        /// <param name="idAEliminar"></param>
        /// <returns>true o false si se pudo eliminar</returns>
        public bool Borrar(int idAEliminar)
        {
            bool eliminado = false;
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();

            foreach (Empleado emp in ObtenerTodos())
            {
                if (emp.Id == idAEliminar)
                {
                    empleadoSQL.Borrar(emp.Id);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;

        }
        /// <summary>
        /// Obtiene la lista de empleados
        /// </summary>
        /// <returns>lista de empleados</returns>
        public List<Empleado> ObtenerTodos()
        {
            EmpleadoSQL empleadoSQL = new EmpleadoSQL();
            List<Empleado> listaEmpleados = empleadoSQL.TraerTodo();

            return listaEmpleados;
        }
        /// <summary>
        /// Valida si un empleado ya existe o no en la lista
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns>true o false si se encuentra o no se encuentra</returns>
        public bool ValidarEnLista(Empleado empleado)
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
        /// <summary>
        /// Obtiene un empleado mediante una id pasada por parametro y lo retorna
        /// </summary>
        /// <param name="index"></param>
        /// <returns>empleado a retornar</returns>
        public Empleado TraerEmpleadoId(int id)
        {
            Empleado empleadoRetornar = null;
            foreach (Empleado emp in ObtenerTodos())
            {
                if (emp.Id == id)
                {
                    empleadoRetornar = emp;
                }
            }

            return empleadoRetornar;
        }

        /// <summary>
        /// Valida que la id pasada por parametro sea de un empleado en especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True o false si esa id pasada por parametro es de un empleado</returns>
        public bool ValidarIdEmpleado(int id)
        {
            bool validado = false;

            foreach (Empleado e in ObtenerTodos())
            {
                if (id <= e.Id)
                {
                    validado = true;
                }
            }

            return validado;
        }
    }
}
