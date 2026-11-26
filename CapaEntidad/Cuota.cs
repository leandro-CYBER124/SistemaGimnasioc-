using System;

namespace CapaEntidad
{
    /// <summary>Un pago de un socio. Es una fila de la tabla "cuota".</summary>
    public class Cuota
    {
        public int IdSocio { get; set; }
        public int IdPlan { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaDesde { get; set; }        // primer día que cubre la cuota
        public DateTime FechaVencimiento { get; set; }  // último día que cubre la cuota
        public decimal Monto { get; set; }
        public string MedioPago { get; set; }
        public int IdUsuario { get; set; }              // quién cobró
    }
}
