namespace CapaEntidad
{
    /// <summary>Persona que inicia sesión. Cada propiedad es una columna de la tabla "usuario".</summary>
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string ClaveHash { get; set; }   // la clave se guarda como hash, nunca en texto plano
        public string Rol { get; set; }         // "Administrador" o "Recepcionista"
        public bool Estado { get; set; }        // true = habilitado
    }
}
