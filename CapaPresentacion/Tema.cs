using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>Dos colores que usa el código y el cartel de error que se repite en las pantallas.</summary>
    public static class Tema
    {
        public static Color Verde = Color.FromArgb(22, 163, 74);
        public static Color Rojo = Color.FromArgb(220, 38, 38);

        public static void MostrarError(Exception excepcion)
        {
            MessageBox.Show(
                "No se pudo acceder a la base de datos.\n\n" + excepcion.Message +
                "\n\nRevisá que SQL Server esté iniciado y que la conexión de app.config sea correcta.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
