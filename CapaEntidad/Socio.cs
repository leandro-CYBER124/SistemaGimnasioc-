using System;

namespace CapaEntidad
{
    /// <summary>Cliente del gimnasio. Es una fila de la vista "vw_socio_estado".</summary>
    public class Socio
    {
        public int IdSocio { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int IdPlan { get; set; }
        public bool Estado { get; set; }                   // true = activo, false = dado de baja
        public DateTime? UltimoVencimiento { get; set; }   // el "?" significa que puede ser null (nunca pagó)
        public string EstadoCuota { get; set; }            // "Al día", "Vencida" o "Sin cuotas"

        public string NombreCompleto
        {
            get { return Apellido + ", " + Nombre; }
        }
    }
}
