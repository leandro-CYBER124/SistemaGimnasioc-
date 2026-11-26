using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    /// <summary>Reglas de los planes.</summary>
    public class CN_Plan
    {
        private CD_Plan datosPlan = new CD_Plan();

        public List<Plan> Listar()
        {
            return datosPlan.Listar();
        }

        public Plan ObtenerPorId(int idPlan)
        {
            return datosPlan.ObtenerPorId(idPlan);
        }

        /// <summary>
        /// Valida y guarda el plan. Devuelve el mensaje de error, o "" si se guardó bien.
        /// El nombre repetido lo controla el procedimiento almacenado.
        /// </summary>
        public string Guardar(Plan plan)
        {
            plan.Nombre = plan.Nombre.Trim();

            if (plan.Nombre == "") return "Ingresá el nombre del plan.";
            if (plan.Precio <= 0) return "El precio debe ser mayor a cero.";
            if (plan.DuracionDias <= 0) return "La duración debe ser mayor a cero.";

            // Plan nuevo (IdPlan = 0): se registra. Plan existente: se edita.
            if (plan.IdPlan == 0) return datosPlan.Registrar(plan);
            return datosPlan.Editar(plan);
        }
    }
}
