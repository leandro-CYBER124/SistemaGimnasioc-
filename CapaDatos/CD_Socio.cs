using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    /// <summary>Llama a los procedimientos de socios.</summary>
    public class CD_Socio
    {
        /// <summary>Lista los socios cuyo DNI, nombre o apellido contienen el texto.</summary>
        public DataTable Listar(string textoABuscar)
        {
            return Conexion.ObtenerTabla("SP_ListarSocios",
                Conexion.Parametro("@Texto", textoABuscar));
        }

        public Socio ObtenerPorId(int idSocio)
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ObtenerSocioPorId",
                Conexion.Parametro("@IdSocio", idSocio));

            if (tabla.Rows.Count == 0) return null;
            return ConvertirFilaASocio(tabla.Rows[0]);
        }

        public Socio ObtenerPorDni(string dni)
        {
            DataTable tabla = Conexion.ObtenerTabla("SP_ObtenerSocioPorDni",
                Conexion.Parametro("@Dni", dni));

            if (tabla.Rows.Count == 0) return null;
            return ConvertirFilaASocio(tabla.Rows[0]);
        }

        /// <summary>Registra un socio nuevo. Devuelve "" si salió bien o el mensaje de error (ej.: DNI repetido).</summary>
        public string Registrar(Socio socio, int idUsuario)
        {
            SqlParameter mensaje = Conexion.ParametroMensaje();

            Conexion.EjecutarProcedimiento("SP_RegistrarSocio",
                Conexion.Parametro("@Dni", socio.Dni),
                Conexion.Parametro("@Nombre", socio.Nombre),
                Conexion.Parametro("@Apellido", socio.Apellido),
                Conexion.Parametro("@Telefono", socio.Telefono),
                Conexion.Parametro("@Email", socio.Email),
                Conexion.Parametro("@IdPlan", socio.IdPlan),
                Conexion.Parametro("@Estado", socio.Estado),
                Conexion.Parametro("@IdUsuario", idUsuario),
                mensaje);

            return Convert.ToString(mensaje.Value);
        }

        /// <summary>Modifica un socio existente. Devuelve "" si salió bien o el mensaje de error.</summary>
        public string Editar(Socio socio)
        {
            SqlParameter mensaje = Conexion.ParametroMensaje();

            Conexion.EjecutarProcedimiento("SP_EditarSocio",
                Conexion.Parametro("@IdSocio", socio.IdSocio),
                Conexion.Parametro("@Dni", socio.Dni),
                Conexion.Parametro("@Nombre", socio.Nombre),
                Conexion.Parametro("@Apellido", socio.Apellido),
                Conexion.Parametro("@Telefono", socio.Telefono),
                Conexion.Parametro("@Email", socio.Email),
                Conexion.Parametro("@IdPlan", socio.IdPlan),
                Conexion.Parametro("@Estado", socio.Estado),
                mensaje);

            return Convert.ToString(mensaje.Value);
        }

        /// <summary>Baja o reactivación: solo cambia el campo estado, no se borra ninguna fila.</summary>
        public void CambiarEstado(int idSocio, bool nuevoEstado)
        {
            Conexion.EjecutarProcedimiento("SP_CambiarEstadoSocio",
                Conexion.Parametro("@IdSocio", idSocio),
                Conexion.Parametro("@Estado", nuevoEstado));
        }

        /// <summary>Convierte una fila de la vista en un objeto Socio.</summary>
        private Socio ConvertirFilaASocio(DataRow fila)
        {
            Socio socio = new Socio();
            socio.IdSocio = Convert.ToInt32(fila["id_socio"]);
            socio.Dni = Convert.ToString(fila["dni"]);
            socio.Nombre = Convert.ToString(fila["nombre"]);
            socio.Apellido = Convert.ToString(fila["apellido"]);
            socio.Telefono = Convert.ToString(fila["telefono"]);
            socio.Email = Convert.ToString(fila["email"]);
            socio.IdPlan = Convert.ToInt32(fila["id_plan"]);
            socio.Estado = Convert.ToBoolean(fila["estado"]);
            socio.EstadoCuota = Convert.ToString(fila["estado_cuota"]);

            // Si el socio nunca pagó, la base devuelve NULL (DBNull) y la fecha queda en null.
            if (fila["ultimo_vencimiento"] != DBNull.Value)
                socio.UltimoVencimiento = Convert.ToDateTime(fila["ultimo_vencimiento"]);

            return socio;
        }
    }
}
