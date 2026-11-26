using System;
using System.Data;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos de asistencias (ingresos permitidos y denegados).</summary>
    public class CD_Asistencia
    {
        /// <summary>Guarda un intento de ingreso, permitido o denegado, con su motivo.</summary>
        public void Registrar(int idSocio, bool permitido, string motivo, int idUsuario)
        {
            Conexion.EjecutarProcedimiento("SP_RegistrarAsistencia",
                Conexion.Parametro("@IdSocio", idSocio),
                Conexion.Parametro("@Permitido", permitido),
                Conexion.Parametro("@Motivo", motivo),
                Conexion.Parametro("@IdUsuario", idUsuario));
        }

        /// <summary>Intentos de ingreso de hoy (para la grilla "Ingresos de hoy").</summary>
        public DataTable ListarDeHoy()
        {
            return Conexion.ObtenerTabla("SP_ListarAsistenciasHoy");
        }
    }
}
