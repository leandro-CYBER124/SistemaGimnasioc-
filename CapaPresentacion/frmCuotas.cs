using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    /// <summary>
    /// Pantalla 4: control de ingreso (izquierda) y cobro de cuotas (derecha).
    /// El diseño está en frmCuotas.Designer.cs.
    /// </summary>
    public partial class frmCuotas : Form
    {
        private CN_Asistencia negocioAsistencia = new CN_Asistencia();
        private CN_Socio negocioSocio = new CN_Socio();
        private CN_Plan negocioPlan = new CN_Plan();
        private CN_Cuota negocioCuota = new CN_Cuota();

        // El socio al que se le va a cobrar y su plan (null si todavía no se buscó ninguno).
        private Socio socioACobrar = null;
        private Plan planDelSocio = null;
        private Cuota cuotaPrevista = null;   // la cuota calculada que se va a cobrar

        public frmCuotas()
        {
            InitializeComponent();
        }

        private void frmCuotas_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            cmbMedio.DataSource = CN_Cuota.MediosDePago;
            CargarIngresosDeHoy();
        }

        // =================================================================== CONTROL DE INGRESO

        /// <summary>Permite verificar apretando Enter, sin usar el mouse.</summary>
        private void txtDniIngreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita el "beep" de Windows
                VerificarIngreso();
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarIngreso();
        }

        private void VerificarIngreso()
        {
            try
            {
                // La capa de negocio decide si puede entrar. La pantalla solo muestra el resultado.
                ResultadoIngreso resultado = negocioAsistencia.RegistrarIngreso(txtDniIngreso.Text, Sesion.Usuario.IdUsuario);

                if (resultado.Permitido)
                {
                    pnlResultado.BackColor = Tema.Verde;
                    lblResultadoTitulo.Text = "INGRESO PERMITIDO";
                }
                else
                {
                    pnlResultado.BackColor = Tema.Rojo;
                    lblResultadoTitulo.Text = "INGRESO DENEGADO";
                }

                lblResultadoTitulo.ForeColor = Color.White;
                lblResultadoDetalle.ForeColor = Color.White;
                lblResultadoDetalle.Text = resultado.Mensaje;

                CargarIngresosDeHoy();
                txtDniIngreso.SelectAll();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        private void CargarIngresosDeHoy()
        {
            try
            {
                gridHoy.DataSource = negocioAsistencia.ListarDeHoy();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        // =================================================================== COBRO DE CUOTAS

        private void txtDniCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarSocio();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarSocio();
        }

        /// <summary>Busca al socio por DNI y muestra sus datos y el período que se le va a cobrar.</summary>
        private void BuscarSocio()
        {
            try
            {
                socioACobrar = negocioSocio.ObtenerPorDni(txtDniCobro.Text);

                if (socioACobrar == null)
                {
                    lblSocio.Text = "";
                    lblPlan.Text = "";
                    lblEstado.Text = "";
                    lblNueva.Text = "";
                    lblAviso.Text = "No existe ningún socio con ese DNI.";
                    btnCobrar.Enabled = false;
                    gridCuotas.DataSource = null;
                    return;
                }

                planDelSocio = negocioPlan.ObtenerPorId(socioACobrar.IdPlan);

                lblSocio.Text = socioACobrar.NombreCompleto;
                lblPlan.Text = "Plan: " + planDelSocio.Nombre + " · $" + planDelSocio.Precio.ToString("N0");
                lblEstado.Text = "Cuota actual: " + socioACobrar.EstadoCuota;
                gridCuotas.DataSource = negocioCuota.ListarPorSocio(socioACobrar.IdSocio);

                if (socioACobrar.Estado == false)
                {
                    lblNueva.Text = "";
                    lblAviso.Text = "El socio está dado de baja: no se le puede cobrar.";
                    btnCobrar.Enabled = false;
                    return;
                }

                // Vista previa: se calcula la cuota pero todavía no se guarda.
                cuotaPrevista = negocioCuota.Calcular(socioACobrar, planDelSocio);
                lblNueva.Text = "Nueva cuota: del " + cuotaPrevista.FechaDesde.ToString("dd/MM/yyyy") +
                                " al " + cuotaPrevista.FechaVencimiento.ToString("dd/MM/yyyy");
                lblAviso.Text = "";
                btnCobrar.Enabled = true;
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (socioACobrar == null) return;

            try
            {
                string medioDePago = cmbMedio.SelectedItem.ToString();
                string mensajeDeError = negocioCuota.Cobrar(cuotaPrevista, medioDePago, Sesion.Usuario.IdUsuario);

                if (mensajeDeError != "")
                {
                    MessageBox.Show(mensajeDeError, "No se pudo cobrar");
                    return;
                }

                MessageBox.Show("Cuota cobrada.\nPeríodo: " + cuotaPrevista.FechaDesde.ToString("dd/MM/yyyy") +
                                " al " + cuotaPrevista.FechaVencimiento.ToString("dd/MM/yyyy") +
                                "\nMonto: $" + cuotaPrevista.Monto.ToString("N0"));

                BuscarSocio(); // vuelve a buscar para mostrar el nuevo vencimiento y el historial
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }
    }
}
