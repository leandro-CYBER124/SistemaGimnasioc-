using CapaEntidad;

namespace CapaPresentacion
{
    /// <summary>Guarda quién inició sesión. Es "static" para que todas las pantallas lo puedan usar.</summary>
    public static class Sesion
    {
        public static Usuario Usuario;
        public static bool CerroSesion;

        /// <summary>true si el usuario que inició sesión es administrador.</summary>
        public static bool EsAdmin
        {
            get { return Usuario != null && Usuario.Rol == "Administrador"; }
        }
    }
}
