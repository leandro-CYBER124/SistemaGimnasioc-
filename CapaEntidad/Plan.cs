namespace CapaEntidad
{
    /// <summary>Plan de membresía (ej.: "Mensual libre"). Es una fila de la tabla "plan_membresia".</summary>
    public class Plan
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int DuracionDias { get; set; }   // cuántos días dura una cuota de este plan
        public bool Estado { get; set; }        // true = activo, false = dado de baja

        public string EstadoTexto
        {
            get { return Estado ? "Activo" : "Baja"; }
        }

        /// <summary>Es el texto que muestra el desplegable de planes.</summary>
        public override string ToString()
        {
            return Nombre + " - $" + Precio.ToString("N0") + (Estado ? "" : " (baja)");
        }
    }
}
