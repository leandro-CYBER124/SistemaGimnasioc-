using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    /// <summary>Reglas de los usuarios: iniciar sesión.</summary>
    public class CN_Usuario
    {
        private CD_Usuario datosUsuario = new CD_Usuario();

        /// <summary>Devuelve el usuario si el documento y la clave son correctos; si no, devuelve null.</summary>
        public Usuario Login(string documento, string clave)
        {
            Usuario usuario = datosUsuario.ObtenerPorDocumento(documento.Trim());

            if (usuario == null) return null;               // el documento no existe
            if (usuario.Estado == false) return null;       // usuario deshabilitado

            // Se compara el hash de la clave escrita con el hash guardado en la base.
            if (usuario.ClaveHash != Seguridad.Sha256(clave)) return null;

            return usuario;
        }
    }
}
