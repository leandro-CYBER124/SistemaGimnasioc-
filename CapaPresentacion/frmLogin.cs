using CapaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// <summary>Pantalla 1: inicio de sesión. El diseño está en frmLogin.Designer.cs.</summary>
    public partial class frmLogin : Form
    {
        private CN_Usuario negocioUsuario = new CN_Usuario();

        public frmLogin()
        {
            InitializeComponent(); // crea los controles (está en el archivo Designer)
        }

        /// <summary>Se ejecuta al hacer clic en "Ingresar" o al apretar Enter.</summary>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Trim() == "" || txtClave.Text == "")
            {
                lblError.Text = "Completá el documento y la clave.";
                return;
            }

            try
            {
                Usuario usuario = negocioUsuario.Login(txtDocumento.Text, txtClave.Text);

                if (usuario == null)
                {
                    lblError.Text = "Documento o clave incorrectos.";
                    txtClave.Clear();
                    return;
                }

                Sesion.Usuario = usuario;           // lo guardamos para las demás pantallas
                DialogResult = DialogResult.OK;     // cierra el login e indica que entró bien
            }
            catch (Exception excepcion)
            {
                lblError.Text = "No se pudo conectar con la base de datos.\n" + excepcion.Message;
            }
        }
    }
}
