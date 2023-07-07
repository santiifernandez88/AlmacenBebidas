using Data.BaseDeDatos.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public  class AdministradorUsuario : IAdministrable<Usuario>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerTodos()
        {
            UsuariosSQL usuariosSQL = new UsuariosSQL();
            List<Usuario> listaUsuarios = usuariosSQL.TraerTodo();

            return listaUsuarios;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool Agregar(Usuario usuario)
        {
            bool agregado = false;
            UsuariosSQL usuariosSQL = new UsuariosSQL();
            if (ValidarEnLista(usuario))
            {
                usuariosSQL.Agregar(usuario);
                agregado = true;
            }
            
            return agregado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarEnLista(Usuario usuario)
        {
            bool validado = true;

            foreach(Usuario us in ObtenerTodos())
            {
                if(us == usuario)
                {
                    validado = false;
                }
            }

            return validado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool ValidarUsuario(string nombreUsuario, string contraseña, out Usuario usuario)
        {
            bool result = false;
            usuario = null;

            foreach (Usuario u in ObtenerTodos())
            {
                if (u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña)
                {
                    usuario = u;
                    result = true;
                }
            }

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Borrar(int id)
        {
            bool borrado = false;
            UsuariosSQL usuariosSQL = new UsuariosSQL();

            foreach (Usuario usu in ObtenerTodos())
            {
                if(usu.Empleado.Id == id)
                {
                    usuariosSQL.Borrar(id);
                }
            }

            return borrado;
        }
    }
}
