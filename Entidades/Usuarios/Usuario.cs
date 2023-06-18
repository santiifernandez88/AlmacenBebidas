
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Empleados;

namespace Entidades.Usuarios
{
    public class Usuario
    {
        private string nombreUsuario;
        private string contraseña;
        private Empleado empleado;

        public Usuario(string nombreUsuario, string contraseña)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
        }

        public Usuario(string nombreUsuario, string contraseña, Empleado empleado) : this(nombreUsuario, contraseña)
        {
            Empleado = empleado;
        }

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public Empleado Empleado { get => empleado; set => empleado = value; }

    }
}
