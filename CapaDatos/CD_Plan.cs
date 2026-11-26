using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos de planes.</summary>
    public class CD_Plan
    {
        public List<Plan> Listar()
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ListarPlanes");

            List<Plan> planes = new List<Plan>();
            foreach (DataRow fila in tabla.Rows)
                planes.Add(ConvertirFilaAPlan(fila));
            return planes;
        }

        public Plan ObtenerPorId(int idPlan)
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ObtenerPlan",
                Conexion.Parametro("@IdPlan", idPlan));

            if (tabla.Rows.Count == 0) return null;
            return ConvertirFilaAPlan(tabla.Rows[0]);
        }

        /// <summary>Registra un plan nuevo. Devuelve "" si salió bien o el mensaje de error del procedimiento.</summary>
        public string Registrar(Plan plan)
        {
            SqlParameter mensaje = Conexion.ParametroMensaje();

            Conexion.EjecutarProcedimiento("SP_RegistrarPlan",
                Conexion.Parametro("@Nombre", plan.Nombre),
                Conexion.Parametro("@Precio", plan.Precio),
                Conexion.Parametro("@DuracionDias", plan.DuracionDias),
                Conexion.Parametro("@Estado", plan.Estado),
                mensaje);

            return Convert.ToString(mensaje.Value); // lo que el procedimiento escribió en @Mensaje
        }

        /// <summary>Modifica un plan existente. Devuelve "" si salió bien o el mensaje de error.</summary>
        public string Editar(Plan plan)
        {
            SqlParameter mensaje = Conexion.ParametroMensaje();

            Conexion.EjecutarProcedimiento("SP_EditarPlan",
                Conexion.Parametro("@IdPlan", plan.IdPlan),
                Conexion.Parametro("@Nombre", plan.Nombre),
                Conexion.Parametro("@Precio", plan.Precio),
                Conexion.Parametro("@DuracionDias", plan.DuracionDias),
                Conexion.Parametro("@Estado", plan.Estado),
                mensaje);

            return Convert.ToString(mensaje.Value);
        }

        /// <summary>Convierte una fila de la base en un objeto Plan.</summary>
        private Plan ConvertirFilaAPlan(DataRow fila)
        {
            Plan plan = new Plan();
            plan.IdPlan = Convert.ToInt32(fila["id_plan"]);
            plan.Nombre = Convert.ToString(fila["nombre"]);
            plan.Precio = Convert.ToDecimal(fila["precio"]);
            plan.DuracionDias = Convert.ToInt32(fila["duracion_dias"]);
            plan.Estado = Convert.ToBoolean(fila["estado"]);
            return plan;
        }
    }
}
