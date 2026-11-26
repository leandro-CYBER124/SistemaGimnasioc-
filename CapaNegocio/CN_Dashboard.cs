using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    /// <summary>Datos de la pantalla de inicio. Solo pide a la capa de datos y devuelve.</summary>
    public class CN_Dashboard
    {
        private CD_Dashboard datosDashboard = new CD_Dashboard();

        public ResumenDashboard Resumen() { return datosDashboard.Resumen(); }

        public DataTable ListarMorosos() { return datosDashboard.ListarMorosos(); }
        public DataTable ListarPorVencer() { return datosDashboard.ListarPorVencer(); }
        public DataTable IngresosPorDia() { return datosDashboard.IngresosPorDia(); }
    }
}
