using System;
using System.Data;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion
{
    /// <summary>Pantalla 2: inicio con el dashboard. El diseño está en frmInicio.Designer.cs.</summary>
    public partial class frmInicio : Form
    {
        private CN_Dashboard negocioDashboard = new CN_Dashboard();

        public frmInicio()
        {
            InitializeComponent();
        }

        /// <summary>Se ejecuta una vez, justo antes de mostrar la pantalla.</summary>
        private void frmInicio_Load(object sender, EventArgs e)
        {
            if (DesignMode) return; // el diseñador de Visual Studio también ejecuta este código: ahí no hay sesión

            lblUsuario.Text = Sesion.Usuario.NombreCompleto + "  ·  " + Sesion.Usuario.Rol;
            ActualizarDashboard();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            frmSocios pantallaSocios = new frmSocios();
            pantallaSocios.ShowDialog();   // espera a que se cierre
            ActualizarDashboard();         // y recalcula los números
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            frmCuotas pantallaCuotas = new frmCuotas();
            pantallaCuotas.ShowDialog();
            ActualizarDashboard();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDashboard();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Sesion.CerroSesion = true;
            Close();
        }

        /// <summary>Vuelve a leer la base y completa las tarjetas, el gráfico y las dos listas.</summary>
        private void ActualizarDashboard()
        {
            try
            {
                // Tarjetas
                ResumenDashboard resumen = negocioDashboard.Resumen();
                lblValActivos.Text = resumen.SociosActivos.ToString();
                lblValAlDia.Text = resumen.SociosAlDia.ToString();
                lblValMorosos.Text = resumen.Morosos.ToString();
                lblValIngresos.Text = resumen.IngresosMes.ToString("C0"); // "C0" = moneda sin decimales
                lblValHoy.Text = resumen.AsistenciasHoy.ToString();

                // Gráfico: una barra por cada día que tuvo ingresos
                Charting.Series serie = grafico.Series[0];
                serie.Points.Clear();
                DataTable ingresosPorDia = negocioDashboard.IngresosPorDia();
                foreach (DataRow fila in ingresosPorDia.Rows)
                {
                    string dia = Convert.ToDateTime(fila["dia"]).ToString("dd/MM");
                    int cantidad = Convert.ToInt32(fila["cantidad"]);
                    serie.Points.AddXY(dia, cantidad);
                }

                // Listas: DataSource enlaza la tabla con la grilla
                DataTable morosos = negocioDashboard.ListarMorosos();
                gridMorosos.DataSource = morosos;
                tabMorosos.Text = "Morosos (" + morosos.Rows.Count + ")";

                DataTable porVencer = negocioDashboard.ListarPorVencer();
                gridPorVencer.DataSource = porVencer;
                tabPorVencer.Text = "Vencen en 7 días (" + porVencer.Rows.Count + ")";
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }
    }
}
