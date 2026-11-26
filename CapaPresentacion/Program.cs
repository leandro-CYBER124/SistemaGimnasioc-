using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>Acá empieza el programa (Main). Muestra el login y, si entra bien, la pantalla de inicio.</summary>
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();

            // Se repite: login -> pantalla de inicio -> (si cerró sesión) vuelve al login.
            while (true)
            {
                Sesion.Usuario = null;
                Sesion.CerroSesion = false;

                frmLogin pantallaDeLogin = new frmLogin();
                if (pantallaDeLogin.ShowDialog() != DialogResult.OK) return; // no inició sesión: termina

                Application.Run(new frmInicio());

                if (Sesion.CerroSesion == false) return; // cerró la ventana con la X: termina
            }
        }
    }
}
