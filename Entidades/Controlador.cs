using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Net;
using System.Text;
using Entidades.Bebidas;
using Entidades.Clientes;
using Entidades.Empleados;
using Entidades.Usuarios;
using Entidades.Ventas;
using Data.Serializacion_Archivos;

namespace Entidades
{
    public class Controlador
    {
       
        #region Clientes
        AdministradorCliente administradorCliente = new AdministradorCliente();

        public List<Cliente> ObtenerTodosClientes()
        {
            return administradorCliente.ObtenerTodos();
        }

        public Cliente TraerClienteDni(int dni)
        {
            return administradorCliente.TraerClienteDni(dni);
        }


        public bool AltaCliente(string nombre, string apellido, string edadStr, string dniStr, int frecuenciaIndex)
        {
            bool controlado = false;

            if(administradorCliente.CrearCliente(nombre, apellido, edadStr, dniStr, frecuenciaIndex))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear el cliente.");
            }

            return controlado;
        }
       
        public bool BajaCliente(int idAEliminar)
        {
            bool controlado = false;

            if(administradorCliente.Borrar(idAEliminar))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo eliminar el cliente.");
            }

            return controlado;
        }

        public bool ModificarCliente(Cliente cliente, string nombre, string apellido, string edadStr, string dniStr, int frecienciaIndex)
        {
            bool controlado = false;

            if(administradorCliente.ModificarCliente(cliente, nombre, apellido, edadStr, dniStr, frecienciaIndex))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo modificar el cliente.");
            }

            return controlado;
        }

        #endregion


        #region Empleados
        AdministradorEmpleado administradorEmpleado = new AdministradorEmpleado();

        public bool AltaEmpleado(string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, string nombreUsuario, string contraseña, int puestoIndex)
        {
            bool controlado = false;

            if(administradorEmpleado.CrearEmpleado(nombre, apellido, edadStr, dniStr, sueldoStr, nombreUsuario, contraseña, puestoIndex))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear el empleado.");
            }

            return controlado;
        }

        public bool BajaEmpleado(int idAEliminar)
        {
            bool controlado = false;

            if(administradorEmpleado.Borrar(idAEliminar))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo elimnar el empleado.");
            }

            return controlado;
        }

        public bool ModificarEmpleado(Empleado empleado, string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, int puestoIndex)
        {
            bool controlado = false;

            if(administradorEmpleado.ModificarEmpleado(empleado, nombre, apellido, edadStr, dniStr, sueldoStr, puestoIndex))
            {
                controlado = true;  
            }
            else
            {
                throw new Exception("No se pudo modificar el empleado.");
            }

            return controlado;
        }

        public List<Empleado> ObtenerTodosEmpleados() 
        {
            return administradorEmpleado.ObtenerTodos();
        }

        public Empleado TraerEmpleadoId(int id)
        {
            return administradorEmpleado.TraerEmpleadoId(id);
        }

        #endregion

        #region Usuarios
        AdministradorUsuario administradorUsuario = new AdministradorUsuario();

        public bool ValidarUsuario(string nombreUsuario, string contraseña, out Usuario usuarioValidado)
        {
            bool controlado = false;  

            if(administradorUsuario.ValidarUsuario(nombreUsuario, contraseña, out usuarioValidado))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo validar el usuario.");
            }

            return controlado;
        }

        #endregion

        #region Bebidas

        AdministradorBebidaAlcoholica administradorBebidaAlcoholicas = new AdministradorBebidaAlcoholica();
        AdministradorBebidasNoAlcoholicas administradorBebidasNoAlcoholicas = new AdministradorBebidasNoAlcoholicas();

        public List<BebidaAlcoholica> ObtenerTodasBebidasAlcoholicas()
        {
            return administradorBebidaAlcoholicas.ObtenerTodos();
        }

        public List<BebidaNoAlcoholica> ObtenerTodasBebidasNoAlcoholicas()
        {
            return administradorBebidasNoAlcoholicas.ObtenerTodos();
        }

        public bool AltaBebidaAlcoholica(string marca, string stockStr, string precioStr, string mLitrosStr, string gradoAlcStr, string descripcion, int tipoIndex)
        {
            bool controlado = false;

            if(administradorBebidaAlcoholicas.CrearBebidaAlcoholica(marca, stockStr, precioStr, mLitrosStr, gradoAlcStr, descripcion, tipoIndex))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear la bebida alcoholica.");
            }

            return controlado;
        }

        public bool AltaBebidaNoAlcoholica(string marca, string stockStr, string precioStr, string mLitrosStr, string descripcion, int tipoIndex, bool contieneAzucar)
        {
            bool controlado = false;

            if(administradorBebidasNoAlcoholicas.CrearBebidaNoAlcoholica(marca, precioStr, stockStr, descripcion, mLitrosStr, tipoIndex, contieneAzucar))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear la bebida no alcoholica.");
            }

            return controlado;
        }

        public bool BajaBebidaAlcoholica(int idAEliminar)
        {
            bool controlado = false;

            if(administradorBebidaAlcoholicas.Borrar(idAEliminar))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo eliminar la bebida alcoholica.");
            }

            return controlado;
        }

        public bool BajaBebidaNoAlcoholica(int idAEliminar)
        {
            bool controlado = false;

            if(administradorBebidasNoAlcoholicas.Borrar(idAEliminar))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo eliminar la bebida alcoholica.");
            }

            return controlado;
        }

        #endregion

        #region Ventas
        AdministradorVenta administradorVenta = new AdministradorVenta();   

        public List<Venta> ObtenerTodasVentas()
        {
            return administradorVenta.ObtenerTodos();
        }

        public bool AltaVenta(int metodoInt, int bebidaId, int dniCliente, int idEmpleado)
        {
            bool controlado = false;

            if(administradorVenta.CrearVenta(metodoInt, bebidaId, dniCliente, idEmpleado))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear la venta.");
            }

            return controlado;
        }

        public bool AltaVenta(int metodoInt, int idbebidaUno, int idBebidaDos, int dniCliente, int idEmpleadoStr)
        {
            bool controlado = false;

            if (administradorVenta.CrearVenta(metodoInt, dniCliente, idEmpleadoStr, idbebidaUno, idBebidaDos))
            {
                controlado = true;
            }
            else
            {
                throw new Exception("No se pudo crear la venta.");
            }

            return controlado;
        }

        public bool BajaVenta(int idAEliminar) 
        {
            bool controlado = false;

            if(administradorVenta.Borrar(idAEliminar))
            {
                controlado = true; 
            }
            else
            {
                throw new Exception("No se pudo eliminar la venta.");
            }

            return controlado;

        }

        public float AcumuladorGanancias()
        {
            return administradorVenta.AcumuladorGanancias();
        }

        /*public void GenerarTicket(Venta venta)
        {
            SerializadoraPDF pdf = 


        }*/

        #endregion
    }
}