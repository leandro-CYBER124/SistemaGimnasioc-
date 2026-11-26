using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    /// <summary>Reglas del control de ingreso al gimnasio.</summary>
    public class CN_Asistencia
    {
        private CD_Socio datosSocio = new CD_Socio();
        private CD_Asistencia datosAsistencia = new CD_Asistencia();

        /// <summary>
        /// Decide si el socio puede entrar. Puede entrar si existe, está activo y su cuota no está vencida.
        /// Cada intento (permitido o denegado) queda guardado en la tabla asistencia.
        /// </summary>
        public ResultadoIngreso RegistrarIngreso(string dni, int idUsuario)
        {
            ResultadoIngreso resultado = new ResultadoIngreso();

            Socio socio = datosSocio.ObtenerPorDni(dni.Trim());
            if (socio == null)
            {
                resultado.Permitido = false;
                resultado.Mensaje = "No existe ningún socio con ese DNI.";
                return resultado;
            }

            // Se busca el motivo por el cual NO podría entrar. Si no hay motivo, entra.
            string motivoDelRechazo = "";
            if (socio.Estado == false)
                motivoDelRechazo = "El socio está dado de baja.";
            else if (socio.EstadoCuota == "Sin cuotas")
                motivoDelRechazo = "Todavía no pagó ninguna cuota.";
            else if (socio.EstadoCuota == "Vencida")
                motivoDelRechazo = "La cuota venció el " + socio.UltimoVencimiento.Value.ToString("dd/MM/yyyy") + ".";

            if (motivoDelRechazo != "")
            {
                datosAsistencia.Registrar(socio.IdSocio, false, motivoDelRechazo, idUsuario);
                resultado.Permitido = false;
                resultado.Mensaje = socio.NombreCompleto + "\n" + motivoDelRechazo;
                return resultado;
            }

            datosAsistencia.Registrar(socio.IdSocio, true, "Ingreso correcto", idUsuario);
            resultado.Permitido = true;
            resultado.Mensaje = socio.NombreCompleto + "\nSu cuota vence el " + socio.UltimoVencimiento.Value.ToString("dd/MM/yyyy") + ".";
            return resultado;
        }

        public DataTable ListarDeHoy()
        {
            return datosAsistencia.ListarDeHoy();
        }
    }
}
