using CapaEntidad;
using System;
using System.Data;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos que alimentan la pantalla de inicio.</summary>
    public class CD_Dashboard
    {
        /// <summary>Los cinco números de las tarjetas (el procedimiento devuelve una sola fila).</summary>
        public ResumenDashboard Resumen()
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ResumenDashboard");
            DataRow fila = tabla.Rows[0];

            ResumenDashboard resumen = new ResumenDashboard();
            resumen.SociosActivos = Convert.ToInt32(fila["socios_activos"]);
            resumen.SociosAlDia = Convert.ToInt32(fila["socios_al_dia"]);
            resumen.Morosos = Convert.ToInt32(fila["morosos"]);
            resumen.IngresosMes = Convert.ToDecimal(fila["ingresos_mes"]);
            resumen.AsistenciasHoy = Convert.ToInt32(fila["asistencias_hoy"]);
            return resumen;
        }

        public DataTable ListarMorosos()
        {
            return Conexion.ObtenerTabla("SP_ListarMorosos");
        }

        public DataTable ListarPorVencer()
        {
            return Conexion.ObtenerTabla("SP_ListarPorVencer");
        }

        public DataTable IngresosPorDia()
        {
            return Conexion.ObtenerTabla("SP_IngresosPorDia");
        }
    }
}
