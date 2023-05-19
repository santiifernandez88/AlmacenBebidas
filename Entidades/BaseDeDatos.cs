using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BaseDeDatos
    {
        private static List<Empleado> empleados;
        private static List<Cliente> clientes;
        private static List<Usuario> usuarios;
        private static List<Bebidas> bebidas;
        private static List<Ventas> ventas;

        

        #region Constructor
        static BaseDeDatos() // clase que herede todas las listas de forma abstracta
        {
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            usuarios = new List<Usuario>();
            bebidas = new List<Bebidas>();
            ventas = new List<Ventas>();
            HarcodearEmpleados(empleados);
            HardcodearUsuarios(usuarios);
            HardcodearBebidas(bebidas);
            HardcodearClientes(clientes);
            HardcodearVentas(ventas);
        }
        #endregion

        #region Empleados

        private static void HarcodearEmpleados(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("Santiago", "Fernández", 19, 44943743, 15000, PuestosDeTrabajo.Jefe));
            empleados.Add(new Empleado("Carlos", "Gomez", 45, 33900233, 11000, PuestosDeTrabajo.Encargado));
            empleados.Add(new Empleado("Lucio", "Pedrosa", 41, 36889455, 10000, PuestosDeTrabajo.Vendedor));
            empleados.Add(new Empleado("Jorge", "Loriente", 24, 40829451, 10000, PuestosDeTrabajo.Vendedor));
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        public static void GuardarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public static void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }


        #endregion

        #region Usuarios
        private static void HardcodearUsuarios(List<Usuario> usuarios)
        {
            usuarios.Add(new Usuario("aaa", "aaa", empleados[0]));
            usuarios.Add(new Usuario("bbb", "bbb", empleados[1]));
            usuarios.Add(new Usuario("ccc", "ccc", empleados[2]));
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public static void GuardarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        #endregion

        #region Clientes
        private static void HardcodearClientes(List<Cliente> clientes)
        {
            clientes.Add(new Cliente("Maria", "Vazquez", 22, 42893233, TiposDeBebida.Fernet));
            clientes.Add(new Cliente("Carlos", "Alsina", 50, 30912321, TiposDeBebida.Whiskey));
            clientes.Add(new Cliente("Laura", "Macias", 34, 38347234, TiposDeBebida.Cerveza));
            clientes.Add(new Cliente("Marcos", "Mura", 18, 45893444, TiposDeBebida.Vodka));
            clientes.Add(new Cliente("Valentin", "Ramos", 28, 40999765, TiposDeBebida.Fernet));
            clientes.Add(new Cliente("Lorenzo", "Cesa", 78, 20908480, TiposDeBebida.Licor));
            clientes.Add(new Cliente("Blas", "Parra", 20, 44938414, TiposDeBebida.Vino));
            clientes.Add(new Cliente("Clara", "Comas", 48, 3328481, TiposDeBebida.Gin));
            clientes.Add(new Cliente("Carlos", "Torres", 31, 36068250, TiposDeBebida.Vermu));
        }

        public static List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public static void GuardarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static void EliminarCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        #endregion

        #region Bebidas
        private static void HardcodearBebidas(List<Bebidas> bebidas)
        {
            bebidas.Add(new Bebidas("Malbec", 14, 900, TiposDeBebida.Vino, 25));
            bebidas.Add(new Bebidas("Malbec", 14, 1400, TiposDeBebida.Vino, 25));
            bebidas.Add(new Bebidas("Ruttini", 14, 30000, TiposDeBebida.Vino, 25));
            bebidas.Add(new Bebidas("Branca", 40, 2500, TiposDeBebida.Fernet, 25));
            bebidas.Add(new Bebidas("1882", 40, 1800, TiposDeBebida.Fernet, 25));
            bebidas.Add(new Bebidas("Gordon", 44, 2000, TiposDeBebida.Gin, 25));
            bebidas.Add(new Bebidas("Brahma", 6, 1500, TiposDeBebida.Cerveza, 25));
            bebidas.Add(new Bebidas("Patagonia", 6, 2000, TiposDeBebida.Cerveza, 25));
            bebidas.Add(new Bebidas("Amargo Obrero", 14, 600, TiposDeBebida.Vermu, 25));
            bebidas.Add(new Bebidas("Cinzano", 14, 900, TiposDeBebida.Vermu, 25));
            bebidas.Add(new Bebidas("Smirnoff", 37, 1600, TiposDeBebida.Vodka, 25));
            bebidas.Add(new Bebidas("Sky", 37, 1700, TiposDeBebida.Vodka, 25));
            bebidas.Add(new Bebidas("Jameson", 40, 4500, TiposDeBebida.Whiskey, 25));
            bebidas.Add(new Bebidas("Jack Daniels", 43, 5000, TiposDeBebida.Whiskey, 25));
            bebidas.Add(new Bebidas("Bacardi", 40, 3000, TiposDeBebida.Licor, 25));
            bebidas.Add(new Bebidas("Jagermeister", 40, 11000, TiposDeBebida.Licor, 25));
        }

        public static List<Bebidas> ObtenerBebidas()
        {
            return bebidas;
        }

        public static void GuardarBebidas(Bebidas bebida)
        {
            bebidas.Add(bebida);
        }

        public static void EliminarBebida(Bebidas bebida)
        {
            bebidas.Remove(bebida);
        }
        #endregion

        #region Ventas

        private static void HardcodearVentas(List<Ventas> ventas)
        {
            ventas.Add(new Ventas(MetodoDePago.MercadoPago, clientes[0].Dni, bebidas[0].Id, empleados[3].Id, bebidas[0].Precio, new DateTime(2023, 5, 9)));
            ventas.Add(new Ventas(MetodoDePago.Efectivo, clientes[1].Dni, bebidas[0].Id, empleados[3].Id, bebidas[0].Precio, new DateTime(2023, 5, 10)));
            ventas.Add(new Ventas(MetodoDePago.MercadoPago, clientes[3].Dni, bebidas[3].Id, empleados[2].Id, bebidas[3].Precio, new DateTime(2023, 5, 11)));
            ventas.Add(new Ventas(MetodoDePago.Debito, clientes[2].Dni, bebidas[5].Id, empleados[1].Id, bebidas[5].Precio, new DateTime(2023, 5, 11)));

        }

        public static List<Ventas> ObtenerVentas()
        {
            return ventas;
        }

        public static void GuardarVentas(Ventas venta)
        {
            ventas.Add(venta);
        }

        public static void EliminarVenta(Ventas venta)
        {
            ventas.Remove(venta);
        }
        #endregion
    }
}
