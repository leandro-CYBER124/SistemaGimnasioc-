// =====================================================================================
// ARCHIVO DEL DISEÑADOR de frmLogin: lo genera y mantiene Visual Studio.
// Acá están TODOS los controles del formulario (botones, cuadros de texto, grillas...)
// con su posición, tamaño, color y texto. Para modificar el aspecto conviene usar el
// diseñador visual (clic derecho en frmLogin.cs > Ver diseñador) y no editar este archivo a mano.
// La lógica (qué hace cada botón) está en frmLogin.cs.
// =====================================================================================
namespace CapaPresentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblLema = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.lblMarca);
            this.pnlLateral.Controls.Add(this.lblLema);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Size = new System.Drawing.Size(300, 440);
            this.pnlLateral.TabIndex = 0;
            // 
            // lblMarca
            // 
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.lblMarca.Location = new System.Drawing.Point(32, 120);
            this.lblMarca.Text = "GYM\r\nCONTROL";
            this.lblMarca.TabIndex = 0;
            // 
            // lblLema
            // 
            this.lblLema.Name = "lblLema";
            this.lblLema.AutoSize = true;
            this.lblLema.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblLema.Location = new System.Drawing.Point(34, 230);
            this.lblLema.Text = "Socios, cuotas e ingresos\r\nen un solo lugar.";
            this.lblLema.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(340, 60);
            this.lblTitulo.Text = "Iniciar sesión";
            this.lblTitulo.TabIndex = 1;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDocumento.Location = new System.Drawing.Point(340, 130);
            this.lblDocumento.Text = "Documento";
            this.lblDocumento.TabIndex = 2;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Location = new System.Drawing.Point(340, 154);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Size = new System.Drawing.Size(380, 27);
            this.txtDocumento.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.Name = "lblClave";
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblClave.Location = new System.Drawing.Point(340, 200);
            this.lblClave.Text = "Clave";
            this.lblClave.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.Name = "txtClave";
            this.txtClave.Location = new System.Drawing.Point(340, 224);
            this.txtClave.MaxLength = 50;
            this.txtClave.Size = new System.Drawing.Size(380, 27);
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.Name = "lblError";
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblError.Location = new System.Drawing.Point(340, 262);
            this.lblError.Size = new System.Drawing.Size(380, 62);
            this.lblError.Text = "";
            this.lblError.TabIndex = 6;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(340, 334);
            this.btnIngresar.Size = new System.Drawing.Size(380, 44);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnSalir.Location = new System.Drawing.Point(340, 388);
            this.btnSalir.Size = new System.Drawing.Size(380, 30);
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TabIndex = 8;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Control - Iniciar sesión";
            this.AcceptButton = this.btnIngresar;
            this.CancelButton = this.btnSalir;
            this.Name = "frmLogin";
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblLema;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}
