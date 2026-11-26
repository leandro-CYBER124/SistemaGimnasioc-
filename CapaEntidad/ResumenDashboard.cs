namespace CapaEntidad
{
    /// <summary>Los cinco números que muestran las tarjetas de la pantalla de inicio.</summary>
    public class ResumenDashboard
    {
        public int SociosActivos { get; set; }
        public int SociosAlDia { get; set; }
        public int Morosos { get; set; }
        public decimal IngresosMes { get; set; }
        public int AsistenciasHoy { get; set; }
    }
}
