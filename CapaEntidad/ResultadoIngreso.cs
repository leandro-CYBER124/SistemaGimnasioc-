namespace CapaEntidad
{
    /// <summary>Respuesta del control de ingreso: si puede entrar y el mensaje para mostrar.</summary>
    public class ResultadoIngreso
    {
        public bool Permitido { get; set; }
        public string Mensaje { get; set; }
    }
}
