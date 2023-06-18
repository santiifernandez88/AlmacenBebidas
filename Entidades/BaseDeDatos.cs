using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Entidades.Bebidas;
using Entidades.Clientes;
using Entidades.Empleados;
using Entidades.Usuarios;
using Entidades.Ventas;

namespace Entidades
{
    public class BaseDeDatos
    {
        private static List<Empleado> empleados;
        private static List<Cliente> clientes;
        private static List<Usuario> usuarios;
        private static List<BebidaAlcoholica> bebidaAlcoholicas;
        private static List<BebidaNoAlcoholica> bebidaNoAlcoholicas;
        private static List<Venta> ventas;

        #region Constructor
        static BaseDeDatos() // clase que herede todas las listas de forma abstracta
        {
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            usuarios = new List<Usuario>();
            bebidaAlcoholicas = new List<BebidaAlcoholica>();
            bebidaNoAlcoholicas = new List<BebidaNoAlcoholica>();
            ventas = new List<Venta>();
            HarcodearEmpleados(empleados);
            HardcodearUsuarios(usuarios);
            HardcodearBebidasAlcoholicas(bebidaAlcoholicas);
            HardcodearBebidasNoAlcoholicas(bebidaNoAlcoholicas);
            HardcodearClientes(clientes);
            HardcodearVentas(ventas);
        }
        #endregion

        #region Empleados
        /// <summary>
        /// Realiza un hardcodeo de una lista de empleados
        /// </summary>
        /// <param name="empleados"></param>
        private static void HarcodearEmpleados(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("Santiago", "Fernández", 19, 44943743, 15000, PuestosDeTrabajo.Jefe));
            empleados.Add(new Empleado("Carlos", "Gomez", 45, 33900233, 11000, PuestosDeTrabajo.Encargado));
            empleados.Add(new Empleado("Lucio", "Pedrosa", 41, 36889455, 10000, PuestosDeTrabajo.Vendedor));
            empleados.Add(new Empleado("Jorge", "Loriente", 24, 40829451, 10000, PuestosDeTrabajo.Vendedor));
        }

        /// <summary>
        /// Obtiene la lista de empleados
        /// </summary>
        /// <returns>lista de empleados</returns>
        public static List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }
        /// <summary>
        /// Guarda un empleado en la lista
        /// </summary>
        /// <param name="empleado"></param>
        public static void GuardarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }
        /// <summary>
        /// Elimina un empleado de la lista
        /// </summary>
        /// <param name="empleado"></param>
        public static void EliminarEmpleado(Empleado empleado)
        {
            empleados.Remove(empleado);
        }


        #endregion

        #region Usuarios
        /// <summary>
        /// Realiza un hardcodeo de una lista de ususarios
        /// </summary>
        /// <param name="usuarios"></param>
        private static void HardcodearUsuarios(List<Usuario> usuarios)
        {
            usuarios.Add(new Usuario("aaa", "aaa", empleados[0]));
            usuarios.Add(new Usuario("bbb", "bbb", empleados[1]));
            usuarios.Add(new Usuario("ccc", "ccc", empleados[2]));
        }
        /// <summary>
        /// Obtiene la lista de usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        public static List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }
        /// <summary>
        /// Guarda un usuario en la lista
        /// </summary>
        /// <param name="usuario"></param>
        public static void GuardarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        #endregion

        #region Clientes
        /// <summary>
        /// Realiza un hardcodeo de la lista de clientes
        /// </summary>
        /// <param name="clientes"></param>
        private static void HardcodearClientes(List<Cliente> clientes)
        {
            clientes.Add(new Cliente("Maria", "Vazquez", 22, 42893233, Estatus.Activo));
            clientes.Add(new Cliente("Carlos", "Alsina", 50, 30912321, Estatus.PocoFrecuente));
            clientes.Add(new Cliente("Laura", "Macias", 34, 38347234, Estatus.Inactivo));
            clientes.Add(new Cliente("Marcos", "Mura", 18, 45893444, Estatus.Activo));
            clientes.Add(new Cliente("Valentin", "Ramos", 28, 40999765, Estatus.Activo));
            clientes.Add(new Cliente("Lorenzo", "Cesa", 78, 20908480, Estatus.Inactivo));
            clientes.Add(new Cliente("Blas", "Parra", 20, 44938414, Estatus.PocoFrecuente));
            clientes.Add(new Cliente("Clara", "Comas", 48, 3328481, Estatus.PocoFrecuente));
            clientes.Add(new Cliente("Carlos", "Torres", 31, 36068250, Estatus.Activo));
        }
        /// <summary>
        /// Obtiene la lista de clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public static List<Cliente> ObtenerClientes()
        {
            return clientes;
        }
        /// <summary>
        /// Guarda un cliente en la lista
        /// </summary>
        /// <param name="cliente"></param>
        public static void GuardarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        /// <summary>
        /// Elimina un cliente de la lista
        /// </summary>
        /// <param name="cliente"></param>
        public static void EliminarCliente(Cliente cliente)
        {
            clientes.Remove(cliente);
        }

        #endregion

        #region Bebidas
  
        private static void HardcodearBebidasNoAlcoholicas(List<BebidaNoAlcoholica> bebidaNoAlcoholicas)
        {
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Coca Cola", 500, 25, "Coca cola Light", 2500, TiposBebidasNoAlc.Gaseosa, false));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Sprite", 470, 25, "Gaseosa lima limon", 2500, TiposBebidasNoAlc.Gaseosa, true));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Fanta", 420, 25, "Gaseosa de naranja", 2500, TiposBebidasNoAlc.Gaseosa, true));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Paso de los toros", 400, 25, "Agua tonica", 1500, TiposBebidasNoAlc.Gaseosa, false));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Baggio", 300, 25, "Jugo de durazno", 1500, TiposBebidasNoAlc.Jugo, false));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Cepita", 350, 25, "Jugo de Naranja", 1000, TiposBebidasNoAlc.Jugo, false));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Red bull", 250, 25, "Tropical", 2500, TiposBebidasNoAlc.Energizante, true));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Monster", 270, 25, "Mango loco", 473, TiposBebidasNoAlc.Energizante, true));
            bebidaNoAlcoholicas.Add(new BebidaNoAlcoholica("Speed", 250, 25, "Energizante", 2500, TiposBebidasNoAlc.Energizante, true));
        }
        /// <summary>
        /// Obtiene la lista de bebidas
        /// </summary>
        /// <returns>lista de bebidas</returns>
        public static List<BebidaNoAlcoholica> ObtenerBebidasNoAlcoholicas()
        {
            return bebidaNoAlcoholicas;
        }
        /// <summary>
        /// Guarda una bebida en la lista
        /// </summary>
        /// <param name="bebida"></param>
        public static void GuardarBebidasNoAlcoholicas(BebidaNoAlcoholica bebida)
        {
            bebidaNoAlcoholicas.Add(bebida);
        }
        /// <summary>
        /// Elimina una bebida de la lista
        /// </summary>
        /// <param name="bebida"></param>
        public static void EliminarBebidaNoAlcoholica(BebidaNoAlcoholica bebida)
        {
            bebidaNoAlcoholicas.Remove(bebida);
        }

        /// <summary>
        /// Realiza un hardcodeo de la lista de bebidas
        /// </summary>
        /// <param name="bebidas"></param>
        private static void HardcodearBebidasAlcoholicas(List<BebidaAlcoholica> bebidaAlcoholicas)
        {     
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Malbec", 25, 900, 1200, 14,"Vino tinto dulce", TiposBebidasAlcoholicas.Vino));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Malbec", 25, 1400, 1400, 14,"Vino blanco", TiposBebidasAlcoholicas.Vino));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Ruttini",25, 30000, 1200, 14, "Vino tinto", TiposBebidasAlcoholicas.Vino));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Branca",25,2500, 750,40, "Bebida oscura de hierbas" , TiposBebidasAlcoholicas.Fernet));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("1882", 25,1800, 750, 40, "Bebida oscura de hierbas", TiposBebidasAlcoholicas.Fernet));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Gordon", 25, 2000, 1000, 44, "Bebida alcoholica destilada", TiposBebidasAlcoholicas.Gin));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Brahma", 25, 1500, 473, 6, "Lata de cerveza", TiposBebidasAlcoholicas.Cerveza));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Patagonia",25, 780, 700, 6, "Botella de cerveza", TiposBebidasAlcoholicas.Cerveza));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Smirnoff", 25, 1600, 1000, 37, "Aguardiente transparente",TiposBebidasAlcoholicas.Vodka));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Sky", 25, 1700, 1000, 37, "Aguardiente transparente", TiposBebidasAlcoholicas.Vodka));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Jameson", 25, 4500, 1000, 40, "Whiskey escoces",TiposBebidasAlcoholicas.Whiskey));
            bebidaAlcoholicas.Add(new BebidaAlcoholica("Jack Daniels", 25, 5000, 1000, 45, "Whiskey irlandes",TiposBebidasAlcoholicas.Whiskey));
        }
        /// <summary>
        /// Obtiene la lista de bebidas
        /// </summary>
        /// <returns>lista de bebidas</returns>
        public static List<BebidaAlcoholica> ObtenerBebidasAlcoholicas()
        {
            return bebidaAlcoholicas;
        }
        /// <summary>
        /// Guarda una bebida en la lista
        /// </summary>
        /// <param name="bebida"></param>
        public static void GuardarBebidasAlcoholicas(BebidaAlcoholica bebida)
        {
            bebidaAlcoholicas.Add(bebida);
        }
        /// <summary>
        /// Elimina una bebida de la lista
        /// </summary>
        /// <param name="bebida"></param>
        public static void EliminarBebidaAlcoholica(BebidaAlcoholica bebida)
        {
            bebidaAlcoholicas.Remove(bebida);
        }
        #endregion

        #region Ventas
        /// <summary>
        /// Realiza el hardcodeo de la lista de ventas
        /// </summary>
        /// <param name="ventas"></param>
        private static void HardcodearVentas(List<Venta> ventas)
        {
            ventas.Add(new Venta(MetodoDePago.MercadoPago, clientes[0].Dni, bebidaAlcoholicas[0].Id, empleados[3].Id, bebidaAlcoholicas[0].Precio, new DateTime(2023, 5, 9)));
            ventas.Add(new Venta(MetodoDePago.Efectivo, clientes[1].Dni, bebidaAlcoholicas[0].Id, empleados[3].Id, bebidaAlcoholicas[0].Precio, new DateTime(2023, 5, 10)));
            ventas.Add(new Venta(MetodoDePago.MercadoPago, clientes[3].Dni, bebidaAlcoholicas[3].Id, empleados[2].Id, bebidaAlcoholicas[3].Precio, new DateTime(2023, 5, 11)));
            ventas.Add(new Venta(MetodoDePago.Debito, clientes[2].Dni, bebidaAlcoholicas[5].Id, empleados[1].Id, bebidaAlcoholicas[5].Precio, new DateTime(2023, 5, 11)));
  
        }
        /// <summary>
        /// Obtiene la lista de ventas
        /// </summary>
        /// <returns></returns>
        public static List<Venta> ObtenerVentas()
        {
            return ventas;
        }
        /// <summary>
        /// Guarda una venta en la lista
        /// </summary>
        /// <param name="venta"></param>
        public static void GuardarVentas(Venta venta)
        {
            ventas.Add(venta);
        }
        /// <summary>
        /// Elimina una venta de la lista
        /// </summary>
        /// <param name="venta"></param>
        public static void EliminarVenta(Venta venta)
        {
            ventas.Remove(venta);
        }
        #endregion
    }
}
