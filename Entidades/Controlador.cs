﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Net;
using System.Text;

namespace Entidades
{
    public class Controlador
    {
         
        #region Clientes
        public static List<Cliente> ObtenerTodosClientes()
        {
            var listaClientes = BaseDeDatos.ObtenerClientes();

            return listaClientes;
        }

        public static bool AgregarCliente(Cliente cliente)
        {
            bool añadido = false;

            if (ValidarClienteEnLista(cliente))
            {
                BaseDeDatos.GuardarCliente(cliente);
                añadido = true;
            }

            return añadido;
        }

        public static bool BorrarCliente(int dniAEliminar)
        {
            bool eliminado = false;

            foreach (Cliente cliente in ObtenerTodosClientes())
            {
                if (cliente.Dni == dniAEliminar)
                {
                    BaseDeDatos.EliminarCliente(cliente);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public static bool CrearCliente(string nombre, string apellido, string edadStr, string dniStr, int tipoBebidaIndex)
        {
            bool validado = false;
            int edad;
            int dni;
            TiposDeBebida tipoDeBebida = (TiposDeBebida)tipoBebidaIndex;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && int.TryParse(edadStr, out edad) && int.TryParse(dniStr, out dni))
            {
                Cliente clienteNuevo = new Cliente(nombre, apellido, edad, dni, tipoDeBebida);
                if (AgregarCliente(clienteNuevo))
                {
                    validado = true;
                }
            }
            return validado;
        }

        public static bool ValidarClienteEnLista(Cliente cliente)
        {
            bool noEncontrado = true;

            foreach (Cliente c in ObtenerTodosClientes())
            {
                if (c == cliente)
                {
                    noEncontrado = false;
                    break;
                }
            }

            return noEncontrado;
        }

        public static Cliente TraerClienteDni(int dniAModificar)
        {
            Cliente clienteARetornar = null;
            foreach (Cliente cliente in ObtenerTodosClientes())
            {
                if (cliente.Dni == dniAModificar)
                {
                    clienteARetornar = cliente;
                    break;
                }
            }

            return clienteARetornar;
        }

        public static bool ModificarCliente(Cliente cliente, string nombre, string apellido, string edadStr, string dniStr, int tipoIndex)
        {
            bool modificado = false;
            int edad;
            int dni;
            TiposDeBebida tipoDeBebida = (TiposDeBebida)tipoIndex;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && int.TryParse(edadStr, out edad) && int.TryParse(dniStr, out dni))
            {
                Cliente clienteModificado = new Cliente(nombre, apellido, edad, dni, tipoDeBebida);

                if (ValidarClienteEnLista(clienteModificado) || clienteModificado.Dni == cliente.Dni)
                {
                    cliente.Apellido = clienteModificado.Apellido;
                    cliente.Nombre = clienteModificado.Nombre;
                    cliente.Edad = clienteModificado.Edad;
                    cliente.Dni = clienteModificado.Dni;
                    cliente.BebidaFavorita = clienteModificado.BebidaFavorita;
                    modificado = true;
                }
            }

            return modificado;
        }


        #endregion

        #region Empleados
        public static List<Empleado> ObtenerTodosEmpleados()
        {

            var listaEmpleados = BaseDeDatos.ObtenerEmpleados();

            return listaEmpleados;

        }

        public static bool AgregarEmpleado(Empleado empleado)
        {
            bool añadido = false;

            if (ValidarEmpleadoEnLista(empleado))
            {
                BaseDeDatos.GuardarEmpleado(empleado);
                añadido = true;
            }

            return añadido;
        }

        public static bool BorrarEmpleado(int IdAEliminar)
        {
            bool eliminado = false;

            foreach (Empleado emp in ObtenerTodosEmpleados())
            {
                if (emp.Id == IdAEliminar)
                {
                    BaseDeDatos.EliminarEmpleado(emp);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public static Empleado TraerEmpleadoId(int index)
        {
            Empleado empleadoRetornar = null;
            foreach (Empleado emp in ObtenerTodosEmpleados())
            {
                if (emp.Id == index)
                {
                    empleadoRetornar = emp;
                }
            }

            return empleadoRetornar;
        }

        public static bool ModificarEmpleado(Empleado empleado, string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, int puestoIndex)
        {
            bool modificado = false;
            int edad;
            int dni;
            float sueldo;
            PuestosDeTrabajo puesto = (PuestosDeTrabajo)puestoIndex;


            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && int.TryParse(edadStr, out edad)
                && int.TryParse(dniStr, out dni) && float.TryParse(sueldoStr, out sueldo))
            {

                Empleado empleadoModificado = new Empleado(nombre, apellido, edad, dni, sueldo, puesto);

                if (ValidarEmpleadoEnLista(empleadoModificado) || empleadoModificado.Dni == empleado.Dni)
                {
                    empleado.Apellido = empleadoModificado.Apellido;
                    empleado.Nombre = empleadoModificado.Nombre;
                    empleado.Edad = empleadoModificado.Edad;
                    empleado.Dni = empleadoModificado.Dni;
                    empleado.Sueldo = empleadoModificado.Sueldo;
                    empleado.Puesto = empleadoModificado.Puesto;
                    modificado = true;
                }
            }

            return modificado;
        }

        private static bool ValidarEmpleadoEnLista(Empleado empleado)
        {
            bool noEncontrado = true;
            foreach (Empleado e in ObtenerTodosEmpleados())
            {
                if (e == empleado)
                {
                    noEncontrado = false;
                    break;
                }
            }

            return noEncontrado;
        }

        public static bool CrearEmpleado(string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, string nombreUsuario, string contraseña, int puestoIndex)
        {
            bool result = false;
            int edad;
            int dni;
            float sueldo;
            PuestosDeTrabajo puesto = (PuestosDeTrabajo)puestoIndex;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(nombreUsuario) && !string.IsNullOrEmpty(contraseña)
                && int.TryParse(edadStr, out edad) && int.TryParse(dniStr, out dni) && float.TryParse(sueldoStr, out sueldo))
            {
                Empleado empleadoNuevo = new Empleado(nombre, apellido, edad, dni, sueldo, puesto);
                Usuario usuarioNuevo = new Usuario(nombreUsuario, contraseña, empleadoNuevo);
                if (AgregarEmpleado(empleadoNuevo))
                {
                    AgregarUsuario(usuarioNuevo);
                    result = true;
                }
            }

            return result;
        }

        public static bool ValidarIdEmpleado(int id)
        {
            bool validado = false;

            foreach(Empleado e in ObtenerTodosEmpleados())
            {
                if(id <= e.Id)
                {
                    validado = true;
                }
            }

            return validado;
        }

        #endregion

        #region Usuarios
        public static List<Usuario> ObtenerTodosUsuarios()
        {
            var listaUsuarios = BaseDeDatos.ObtenerUsuarios();

            return listaUsuarios;
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            BaseDeDatos.GuardarUsuario(usuario);
        }


        public static bool ValidarUsuario(string nombreUsuario, string contraseña, out Usuario usuarioValidado)
        {
            bool result = false;
            usuarioValidado = null;
            List<Usuario> listaUsuarios = ObtenerTodosUsuarios();
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.ValidarUsuario(nombreUsuario, contraseña))
                {
                    usuarioValidado = usuario;
                    result = true;
                }
            }

            return result;
        }

        #endregion

        #region Bebidas

        public static List<Bebidas> ObtenerTodasBebidas()
        {
            var listaBebidas = BaseDeDatos.ObtenerBebidas();

            return listaBebidas;
        }

        public static void AgregarBebida(Bebidas bebidas)
        {
            BaseDeDatos.GuardarBebidas(bebidas);
        }

        public static bool BorrarBebida(int idAEliminar)
        {
            bool eliminado = false;

            foreach (Bebidas b in ObtenerTodasBebidas())
            {
                if (b.Id == idAEliminar)
                {
                    BaseDeDatos.EliminarBebida(b);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public static void RellenarStock()
        {
            foreach (Bebidas b in ObtenerTodasBebidas())
            {
                if (b.Stock != 25)
                {
                    b.Stock = 25;
                }
            }
        }

        public static bool CrearBebida(string marca, string gradoAlcStr, string precioStr, string stockStr, int tipoBebidaIndex)
        {
            bool validado = false;
            float gradoAlc;
            float precio;
            int stock;
            TiposDeBebida tipoDeBebida = (TiposDeBebida)tipoBebidaIndex;

            if (!string.IsNullOrEmpty(marca) && float.TryParse(gradoAlcStr, out gradoAlc) && float.TryParse(precioStr, out precio) && int.TryParse(stockStr, out stock))
            {
                Bebidas bebidaNueva = new Bebidas(marca, gradoAlc, precio, tipoDeBebida, stock);
                AgregarBebida(bebidaNueva);
                validado = true;
            }

            return validado;
        }

        public static float BuscarPrecioPorId(int id)
        {
            float precioRetornado = 0;
            foreach (Bebidas b in ObtenerTodasBebidas())
            {
                if (b.Id == id)
                {
                    precioRetornado = b.Precio;
                }
            }

            return precioRetornado;
        }

        public static void DescontarStock(int idBebida)
        {
            foreach(Bebidas b in ObtenerTodasBebidas())
            {
                if(b.Id == idBebida)
                {
                    b.Stock--;
                }
            }
        }

        public static bool ValidarIdBebida(int id)
        {
            bool validado = false;

            foreach(Bebidas b in ObtenerTodasBebidas())
            {
                if(id <= b.Id)
                {
                    validado = true;
                }
            }

            return validado;
        }

        #endregion

        #region Ventas

        public static List<Ventas> ObtenerTodasVentas()
        {
            var listaVentas = BaseDeDatos.ObtenerVentas();

            return listaVentas;
        }

        public static bool BorrarVentas(int idAEliminar)
        {
            bool eliminado = false;

            foreach (Ventas v in ObtenerTodasVentas())
            {
                if (v.Id == idAEliminar)
                {
                    BaseDeDatos.EliminarVenta(v);
                    eliminado = true;
                    break;
                }
            }

            return eliminado;
        }

        public static float AcumuladorVentas()
        {
            float acumulador = 0;

            foreach (Ventas v in ObtenerTodasVentas())
            {
                acumulador += v.Ganancias;
            }

            return acumulador;
        }

        public static void AgregarVenta(Ventas venta)
        {
            BaseDeDatos.GuardarVentas(venta);
        }

        public static bool CrearVenta(int metodoInt, string idBebidaStr, int dniCliente, string idEmpleadoStr)
        {
            bool validado = false;
            int idBebida;
            int idEmpleado;
            float ganancias;
            MetodoDePago metodo = (MetodoDePago)metodoInt;

            if (int.TryParse(idBebidaStr, out idBebida) && int.TryParse(idEmpleadoStr, out idEmpleado))
            {
                if(ValidarIdBebida(idBebida) && ValidarIdEmpleado(idEmpleado))
                {
                    ganancias = BuscarPrecioPorId(idBebida);
                    Ventas ventaNueva = new Ventas(metodo, dniCliente, idBebida, idEmpleado, ganancias, DateTime.Now);
                    AgregarVenta(ventaNueva);
                    DescontarStock(idBebida);
                    validado = true;
                }              
            }

            return validado;
        }

        #endregion
    }
}