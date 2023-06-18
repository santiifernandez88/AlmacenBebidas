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
            var listaUsuarios = BaseDeDatos.ObtenerUsuarios();

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
            if(ValidarEnLista(usuario))
            {
                BaseDeDatos.GuardarUsuario(usuario);
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
            return false;
        }
    }
}
