using System.Security.Cryptography;
using System.Text;

namespace CapaNegocio
{
    public static class Seguridad
    {
        /// <summary>
        /// Convierte una clave en su hash SHA-256 (64 caracteres). El hash no se puede "des-hacer":
        /// por eso la base guarda el hash y no la clave. Al iniciar sesión se calcula el hash de
        /// lo que escribió la persona y se compara con el hash guardado.
        /// </summary>
        public static string Sha256(string texto)
        {
            SHA256 algoritmo = SHA256.Create();
            byte[] bytes = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(texto));

            string hashEnTexto = "";
            foreach (byte unByte in bytes)
                hashEnTexto += unByte.ToString("x2"); // cada byte se escribe con 2 caracteres hexadecimales

            return hashEnTexto;
        }
    }
}
