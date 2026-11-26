using System;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos de usuarios.</summary>
    public class CD_Usuario
    {
        /// <summary>Busca un usuario por documento. Devuelve null si no existe.</summary>
        public Usuario ObtenerPorDocumento(string documento)
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ObtenerUsuario",
                Conexion.Parametro("@Documento", documento));

            if (tabla.Rows.Count == 0) return null;

            DataRow fila = tabla.Rows[0];
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(fila["id_usuario"]);
            usuario.Documento = Convert.ToString(fila["documento"]);
            usuario.NombreCompleto = Convert.ToString(fila["nombre_completo"]);
            usuario.ClaveHash = Convert.ToString(fila["clave_hash"]);
            usuario.Rol = Convert.ToString(fila["rol"]);
            usuario.Estado = Convert.ToBoolean(fila["estado"]);
            return usuario;
        }
    }
}
