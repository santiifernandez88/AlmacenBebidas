using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Net;
using System.Text;
using Entidades.Bebidas;
using Entidades.Clientes;
using Entidades.Empleados;
using Entidades.Usuarios;
using Entidades.Ventas;
using Entidades.Archivos;

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


        public void AltaCliente(string nombre, string apellido, string edadStr, string dniStr, int frecuenciaIndex)
        {       
            if(!administradorCliente.CrearCliente(nombre, apellido, edadStr, dniStr, frecuenciaIndex))
            {
                throw new Exception("No se pudo crear el cliente.");
            }
        }
       
        public void BajaCliente(int idAEliminar)
        {
            if(!administradorCliente.Borrar(idAEliminar))
            {
                throw new Exception("No se pudo eliminar el cliente.");
            }
        }

        public void ModificarCliente(Cliente cliente, string nombre, string apellido, string edadStr, string dniStr, int frecienciaIndex)
        {
            if(!administradorCliente.ModificarCliente(cliente, nombre, apellido, edadStr, dniStr, frecienciaIndex))
            {
                throw new Exception("No se pudo modificar el cliente.");
            }
        }

        #endregion


        #region Empleados
        AdministradorEmpleado administradorEmpleado = new AdministradorEmpleado();

        public void AltaEmpleado(string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, string nombreUsuario, string contraseña, int puestoIndex)
        {
            if(!administradorEmpleado.CrearEmpleado(nombre, apellido, edadStr, dniStr, sueldoStr, nombreUsuario, contraseña, puestoIndex))
            {
                throw new Exception("No se pudo crear el empleado.");
            }
        }

        public void BajaEmpleado(int idAEliminar)
        {
            if(!administradorEmpleado.Borrar(idAEliminar))
            {
                throw new Exception("No se pudo elimnar el empleado.");
            }
        }

        public void ModificarEmpleado(Empleado empleado, string nombre, string apellido, string edadStr, string dniStr, string sueldoStr, int puestoIndex)
        {
            if(!administradorEmpleado.ModificarEmpleado(empleado, nombre, apellido, edadStr, dniStr, sueldoStr, puestoIndex))
            {
                throw new Exception("No se pudo modificar el empleado.");
            }
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

        public void ValidarUsuario(string nombreUsuario, string contraseña, out Usuario usuarioValidado)
        {
            if(!administradorUsuario.ValidarUsuario(nombreUsuario, contraseña, out usuarioValidado))
            {
                throw new Exception("No se pudo validar el usuario.");
            }
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

        public void AltaBebidaAlcoholica(string marca, string stockStr, string precioStr, string mLitrosStr, string gradoAlcStr, string descripcion, int tipoIndex)
        {
            if(!administradorBebidaAlcoholicas.CrearBebidaAlcoholica(marca, stockStr, precioStr, mLitrosStr, gradoAlcStr, descripcion, tipoIndex))
            {
                throw new Exception("No se pudo crear la bebida alcoholica.");
            }
        }

        public void AltaBebidaNoAlcoholica(string marca, string stockStr, string precioStr, string mLitrosStr, string descripcion, int tipoIndex, bool contieneAzucar)
        {
            if(!administradorBebidasNoAlcoholicas.CrearBebidaNoAlcoholica(marca, precioStr, stockStr, descripcion, mLitrosStr, tipoIndex, contieneAzucar))
            {
                throw new Exception("No se pudo crear la bebida no alcoholica.");
            }
        }

        public void BajaBebidaAlcoholica(int idAEliminar)
        {
            if(!administradorBebidaAlcoholicas.Borrar(idAEliminar))
            {
                throw new Exception("No se pudo eliminar la bebida alcoholica.");
            }
        }

        public void BajaBebidaNoAlcoholica(int idAEliminar)
        {
            if(!administradorBebidasNoAlcoholicas.Borrar(idAEliminar))
            {
                throw new Exception("No se pudo eliminar la bebida alcoholica.");
            }  
        }

        #endregion

        #region Ventas
        AdministradorVenta administradorVenta = new AdministradorVenta();   

        public List<Venta> ObtenerTodasVentas()
        {
            return administradorVenta.ObtenerTodos();
        }

        public void AltaVenta(int metodoInt, int bebidaId, int dniCliente, int idEmpleado)
        {
            if(!administradorVenta.CrearVenta(metodoInt, bebidaId, dniCliente, idEmpleado))
            {
                throw new Exception("No se pudo crear la venta.");
            }
        }

        public void AltaVenta(int metodoInt, int idbebidaUno, int idBebidaDos, int dniCliente, int idEmpleadoStr)
        { 
            if(!administradorVenta.CrearVenta(metodoInt, dniCliente, idEmpleadoStr, idbebidaUno, idBebidaDos))
            {
                throw new Exception("No se pudo crear la venta.");
            }

 
        }

        public void BajaVenta(int idAEliminar) 
        {
            if(!administradorVenta.Borrar(idAEliminar))
            {
                throw new Exception("No se pudo eliminar la venta.");
            }
        }

        public float AcumuladorGanancias()
        {
            return administradorVenta.AcumuladorGanancias();
        }

        public void GenerarTicket(Venta venta) // Proyecto de data dentro del de entidades como una carpeta
        {
            SerializadoraPDF pdf = new SerializadoraPDF();
            SerializadoraTXT txt = new SerializadoraTXT();
            
            string pathTxt = Environment.CurrentDirectory + $@"/Archivos/Tickets/NumeroTicket.txt";
            string numeroTicketStr = txt.Leer(pathTxt);
            int numeroTicket;

            if(Validaciones.ValidarEntero(numeroTicketStr, out numeroTicket))
            {
                Ticket ticket = new Ticket(venta, numeroTicket);
                string pathPdf = Environment.CurrentDirectory + $@"/Archivos/Tickets/ticket{ticket.Id}.pdf";
                Bebida bebida = TraerBebidaPorId(venta.IdBebida);
                Bebida bebidaUnoCombo = TraerBebidaPorId(venta.IdBebidaUnoCombo);
                Bebida bebidaDosCombo = TraerBebidaPorId(venta.IdBebidaDosCombo);
                pdf.GenerarTicket(pathPdf, ticket, bebida, bebidaUnoCombo, bebidaDosCombo);     
            }
        }

        public Venta TraerVentaId(int id)
        {
            if(administradorVenta.TraerVentaId(id) is null)
            {
                throw new Exception("No se encontro ninguna venta.");
            }
            else
            {
                return administradorVenta.TraerVentaId((int)id);
            }    
        }

        public Bebida TraerBebidaPorId(int id)
        {
            Bebida bebida = null;
            foreach(BebidaAlcoholica bebidaAlcoholica in ObtenerTodasBebidasAlcoholicas())
            {
                if(bebidaAlcoholica.Id == id)
                {
                    bebida = bebidaAlcoholica;
                    break;
                }
            }

            foreach(BebidaNoAlcoholica bebidaNoAlcoholica in ObtenerTodasBebidasNoAlcoholicas())
            {
                if(bebidaNoAlcoholica.Id == id)
                {
                    bebida = bebidaNoAlcoholica;
                    break;
                }
            }
            return bebida;
        }

        #endregion
    }
}