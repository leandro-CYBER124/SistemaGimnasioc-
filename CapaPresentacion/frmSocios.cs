using CapaEntidad;
using CapaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>
    /// Pantalla 3: alta, modificación y baja de socios y de planes.
    /// La pestaña "Planes" solo la ve el administrador. El diseño está en frmSocios.Designer.cs.
    /// </summary>
    public partial class frmSocios : Form
    {
        private CN_Socio negocioSocio = new CN_Socio();
        private CN_Plan negocioPlan = new CN_Plan();

        // El socio y el plan que se están editando. Si es null, se está cargando uno nuevo.
        private Socio socioSeleccionado = null;
        private Plan planSeleccionado = null;

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            // Permiso por rol: el recepcionista no ve la pestaña de planes.
            if (Sesion.EsAdmin == false) tabs.TabPages.Remove(tabPlanes);

            try
            {
                cmbPlan.DataSource = negocioPlan.Listar();  // llena el desplegable de planes
                CargarGrillaDeSocios();
                LimpiarFormularioDeSocio();

                if (Sesion.EsAdmin)
                {
                    CargarGrillaDePlanes();
                    LimpiarFormularioDePlan();
                }
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        // =================================================================== SOCIOS

        private void CargarGrillaDeSocios()
        {
            DataTable tablaDeSocios = negocioSocio.Listar(txtBuscar.Text);
            gridSocios.DataSource = tablaDeSocios;
            lblTotal.Text = tablaDeSocios.Rows.Count + " socios";
        }

        /// <summary>Se ejecuta cada vez que cambia el texto del buscador: filtra la lista mientras se escribe.</summary>
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarGrillaDeSocios();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        /// <summary>Al hacer clic en una fila, se cargan los datos de ese socio en el formulario.</summary>
        private void gridSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // clic en el encabezado: no hacer nada

            try
            {
                int idSocio = Convert.ToInt32(gridSocios.Rows[e.RowIndex].Cells[colIdSocio.Index].Value);
                socioSeleccionado = negocioSocio.ObtenerPorId(idSocio);

                txtDni.Text = socioSeleccionado.Dni;
                txtNombre.Text = socioSeleccionado.Nombre;
                txtApellido.Text = socioSeleccionado.Apellido;
                txtTelefono.Text = socioSeleccionado.Telefono;
                txtEmail.Text = socioSeleccionado.Email;
                chkActivo.Checked = socioSeleccionado.Estado;
                lblCuota.Text = "Cuota: " + socioSeleccionado.EstadoCuota;

                // Se elige en el desplegable el plan del socio.
                foreach (Plan plan in cmbPlan.Items)
                {
                    if (plan.IdPlan == socioSeleccionado.IdPlan) cmbPlan.SelectedItem = plan;
                }

                btnBaja.Visible = true;
                btnBaja.Text = socioSeleccionado.Estado ? "Dar de baja" : "Reactivar";
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        private void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            LimpiarFormularioDeSocio();
        }

        /// <summary>Deja el formulario vacío para cargar un socio nuevo.</summary>
        private void LimpiarFormularioDeSocio()
        {
            socioSeleccionado = null;
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            chkActivo.Checked = true;
            if (cmbPlan.Items.Count > 0) cmbPlan.SelectedIndex = 0;
            lblCuota.Text = "";
            btnBaja.Visible = false;
            txtDni.Focus();
        }

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            try
            {
                // PASO 1: armar un objeto Socio con lo que hay en el formulario.
                Socio socio = new Socio();
                if (socioSeleccionado != null) socio.IdSocio = socioSeleccionado.IdSocio; // si es nuevo queda en 0
                socio.Dni = txtDni.Text;
                socio.Nombre = txtNombre.Text;
                socio.Apellido = txtApellido.Text;
                socio.Telefono = txtTelefono.Text;
                socio.Email = txtEmail.Text;
                socio.Estado = chkActivo.Checked;

                Plan planElegido = cmbPlan.SelectedItem as Plan;
                if (planElegido != null) socio.IdPlan = planElegido.IdPlan;

                // PASO 2: la capa de negocio valida y guarda. Devuelve "" si salió bien o el mensaje de error.
                string mensajeDeError = negocioSocio.Guardar(socio, Sesion.Usuario.IdUsuario);
                if (mensajeDeError != "")
                {
                    MessageBox.Show(mensajeDeError, "Revisá los datos");
                    return;
                }

                // PASO 3: actualizar la lista y dejar el formulario limpio.
                MessageBox.Show("Socio guardado correctamente.");
                CargarGrillaDeSocios();
                LimpiarFormularioDeSocio();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        /// <summary>Dar de baja o reactivar: solo se cambia el estado, el socio no se borra.</summary>
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (socioSeleccionado == null) return;

            try
            {
                bool nuevoEstado = !socioSeleccionado.Estado; // si estaba activo pasa a baja y viceversa
                negocioSocio.CambiarEstado(socioSeleccionado.IdSocio, nuevoEstado);

                CargarGrillaDeSocios();
                LimpiarFormularioDeSocio();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        // =================================================================== PLANES

        private void CargarGrillaDePlanes()
        {
            gridPlanes.DataSource = negocioPlan.Listar();
        }

        private void gridPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int idPlan = Convert.ToInt32(gridPlanes.Rows[e.RowIndex].Cells[colPlanId.Index].Value);
                planSeleccionado = negocioPlan.ObtenerPorId(idPlan);

                txtPlanNombre.Text = planSeleccionado.Nombre;
                numPrecio.Value = planSeleccionado.Precio;
                numDuracion.Value = planSeleccionado.DuracionDias;
                chkPlanActivo.Checked = planSeleccionado.Estado;
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }

        private void btnNuevoPlan_Click(object sender, EventArgs e)
        {
            LimpiarFormularioDePlan();
        }

        private void LimpiarFormularioDePlan()
        {
            planSeleccionado = null;
            txtPlanNombre.Clear();
            numPrecio.Value = 0;
            numDuracion.Value = 30;
            chkPlanActivo.Checked = true;
            txtPlanNombre.Focus();
        }

        private void btnGuardarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                Plan plan = new Plan();
                if (planSeleccionado != null) plan.IdPlan = planSeleccionado.IdPlan; // si es nuevo queda en 0
                plan.Nombre = txtPlanNombre.Text;
                plan.Precio = numPrecio.Value;
                plan.DuracionDias = (int)numDuracion.Value;
                plan.Estado = chkPlanActivo.Checked;

                string mensajeDeError = negocioPlan.Guardar(plan);
                if (mensajeDeError != "")
                {
                    MessageBox.Show(mensajeDeError, "Revisá los datos");
                    return;
                }

                MessageBox.Show("Plan guardado correctamente.");
                CargarGrillaDePlanes();
                cmbPlan.DataSource = negocioPlan.Listar(); // para que la pestaña Socios vea el cambio
                LimpiarFormularioDePlan();
            }
            catch (Exception excepcion)
            {
                Tema.MostrarError(excepcion);
            }
        }
    }
}
