using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    /// <summary>
    /// Es la única clase que se conecta a SQL Server. Las clases CD_... solo dicen QUÉ procedimiento
    /// almacenado llamar y con qué parámetros; esta clase se encarga de ejecutarlo.
    /// Los valores viajan como parámetros (@Dni, @Nombre...) y el SQL vive en la base de datos.
    /// </summary>
    public static class Conexion
    {
        /// <summary>Lee la cadena de conexión de app.config.</summary>
        private static string CadenaDeConexion
        {
            get { return ConfigurationManager.ConnectionStrings["bd_gimnasio"].ConnectionString; }
        }

        /// <summary>Crea un parámetro de entrada. Si el valor es null se guarda NULL en la base (DBNull.Value).</summary>
        public static SqlParameter Parametro(string nombre, object valor)
        {
            return new SqlParameter(nombre, valor ?? DBNull.Value);
        }

        /// <summary>
        /// Crea el parámetro de SALIDA @Mensaje. El procedimiento lo completa: vacío = salió bien,
        /// con texto = motivo del error (por ejemplo "Ya existe un socio con ese DNI.").
        /// </summary>
        public static SqlParameter ParametroMensaje()
        {
            SqlParameter mensaje = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 500);
            mensaje.Direction = ParameterDirection.Output;
            return mensaje;
        }

        /// <summary>Llama a un procedimiento que hace un SELECT y devuelve las filas en un DataTable.</summary>
        public static DataTable ObtenerTabla(string procedimiento, params SqlParameter[] parametros)
        {
            // "using" cierra la conexión automáticamente al terminar el bloque.
            using (SqlConnection conexion = new SqlConnection(CadenaDeConexion))
            using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
            {
                comando.CommandType = CommandType.StoredProcedure; // le avisa que es un procedimiento y no un texto SQL
                comando.Parameters.AddRange(parametros);

                DataTable tabla = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando); // abre la conexión, lee y la cierra
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        /// <summary>Llama a un procedimiento que modifica datos (INSERT, UPDATE).</summary>
        public static void EjecutarProcedimiento(string procedimiento, params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaDeConexion))
            using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddRange(parametros);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
