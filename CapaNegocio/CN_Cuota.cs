using CapaDatos;
using CapaEntidad;
using System;
using System.Data;

namespace CapaNegocio
{
    /// <summary>Reglas del cobro de cuotas.</summary>
    public class CN_Cuota
    {
        /// <summary>Medios de pago disponibles (la pantalla los muestra en el desplegable).</summary>
        public static string[] MediosDePago = { "Efectivo", "Transferencia", "Tarjeta", "Mercado Pago" };

        private CD_Cuota datosCuota = new CD_Cuota();

        /// <summary>
        /// Arma la próxima cuota del socio (todavía no la guarda):
        ///  - Si tiene la cuota vigente, la nueva empieza el día siguiente a su vencimiento.
        ///  - Si está vencida o nunca pagó, empieza hoy.
        ///  - Dura los días del plan: vence a los (duración - 1) días, porque el día de inicio cuenta como el primero.
        /// </summary>
        public Cuota Calcular(Socio socio, Plan plan)
        {
            DateTime fechaDesde = DateTime.Today;

            bool tieneCuotaVigente = socio.UltimoVencimiento != null && socio.UltimoVencimiento.Value >= DateTime.Today;
            if (tieneCuotaVigente)
                fechaDesde = socio.UltimoVencimiento.Value.AddDays(1);

            Cuota cuota = new Cuota();
            cuota.IdSocio = socio.IdSocio;
            cuota.IdPlan = plan.IdPlan;
            cuota.FechaPago = DateTime.Now;
            cuota.FechaDesde = fechaDesde;
            cuota.FechaVencimiento = fechaDesde.AddDays(plan.DuracionDias - 1);
            cuota.Monto = plan.Precio;
            return cuota;
        }

        /// <summary>Guarda la cuota calculada. Devuelve "" si salió bien o el mensaje de error.</summary>
        public string Cobrar(Cuota cuota, string medioDePago, int idUsuario)
        {
            cuota.MedioPago = medioDePago;
            cuota.IdUsuario = idUsuario;

            // El procedimiento verifica que el socio exista y esté activo.
            return datosCuota.Registrar(cuota);
        }

        public DataTable ListarPorSocio(int idSocio)
        {
            return datosCuota.ListarPorSocio(idSocio);
        }
    }
}
