using CapaDatos;
using CapaEntidad;
using System.Data;
using System.Text.RegularExpressions;

namespace CapaNegocio
{
    /// <summary>Reglas de los socios.</summary>
    public class CN_Socio
    {
        private CD_Socio datosSocio = new CD_Socio();
        private CD_Plan datosPlan = new CD_Plan();

        public DataTable Listar(string textoABuscar)
        {
            return datosSocio.Listar(textoABuscar.Trim());
        }

        public Socio ObtenerPorId(int idSocio)
        {
            return datosSocio.ObtenerPorId(idSocio);
        }

        public Socio ObtenerPorDni(string dni)
        {
            return datosSocio.ObtenerPorDni(dni.Trim());
        }

        /// <summary>
        /// Valida y guarda el socio. Devuelve el mensaje de error, o "" si se guardó bien.
        /// Por qué devuelve un texto: así la pantalla solo muestra el mensaje, sin decidir nada.
        /// </summary>
        public string Guardar(Socio socio, int idUsuario)
        {
            socio.Dni = socio.Dni.Trim();
            socio.Nombre = socio.Nombre.Trim();
            socio.Apellido = socio.Apellido.Trim();
            socio.Telefono = socio.Telefono.Trim();
            socio.Email = socio.Email.Trim();

            if (DniEsValido(socio.Dni) == false) return "El DNI debe tener 7 u 8 números.";
            if (socio.Nombre == "") return "Ingresá el nombre.";
            if (socio.Apellido == "") return "Ingresá el apellido.";
            if (socio.IdPlan == 0) return "Elegí un plan.";
            if (socio.Telefono != "" && Regex.IsMatch(socio.Telefono, @"^\d{7,15}$") == false)
                return "Ingresá un teléfono válido (de 7 a 15 números).";
            if (socio.Email != "" && Regex.IsMatch(socio.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$") == false)
                return "Ingresá un correo electrónico válido.";

            Plan plan = datosPlan.ObtenerPorId(socio.IdPlan);
            if (plan.Estado == false) return "El plan elegido está dado de baja.";

            // Socio nuevo (IdSocio = 0): se registra. Socio existente: se edita.
            // El DNI repetido lo controla el procedimiento almacenado y devuelve el mensaje.
            if (socio.IdSocio == 0) return datosSocio.Registrar(socio, idUsuario);
            return datosSocio.Editar(socio);
        }

        public void CambiarEstado(int idSocio, bool nuevoEstado)
        {
            datosSocio.CambiarEstado(idSocio, nuevoEstado);
        }

        /// <summary>Un DNI es válido si tiene 7 u 8 caracteres y todos son dígitos.</summary>
        private bool DniEsValido(string dni)
        {
            if (dni.Length < 7 || dni.Length > 8) return false;

            foreach (char caracter in dni)
            {
                if (char.IsDigit(caracter) == false) return false;
            }
            return true;
        }
    }
}
