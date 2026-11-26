using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos de cuotas (historial de pagos).</summary>
    public class CD_Cuota
    {
        /// <summary>Guarda un pago. Devuelve "" si salió bien o el mensaje de error del procedimiento.</summary>
        public string Registrar(Cuota cuota)
        {
            SqlParameter mensaje = Conexion.ParametroMensaje();

            Conexion.EjecutarProcedimiento("SP_RegistrarCuota",
                Conexion.Parametro("@IdSocio", cuota.IdSocio),
                Conexion.Parametro("@IdPlan", cuota.IdPlan),
                Conexion.Parametro("@FechaPago", cuota.FechaPago),
                Conexion.Parametro("@FechaDesde", cuota.FechaDesde),
                Conexion.Parametro("@FechaVencimiento", cuota.FechaVencimiento),
                Conexion.Parametro("@Monto", cuota.Monto),
                Conexion.Parametro("@MedioPago", cuota.MedioPago),
                Conexion.Parametro("@IdUsuario", cuota.IdUsuario),
                mensaje);

            return Convert.ToString(mensaje.Value);
        }

        /// <summary>Pagos de un socio, del más reciente al más antiguo.</summary>
        public DataTable ListarPorSocio(int idSocio)
        {
            return Conexion.ObtenerTabla("SP_ListarCuotasSocio",
                Conexion.Parametro("@IdSocio", idSocio));
        }
    }
}
