// =====================================================================================
// ARCHIVO DEL DISEÑADOR de frmSocios: lo genera y mantiene Visual Studio.
// Acá están TODOS los controles del formulario (botones, cuadros de texto, grillas...)
// con su posición, tamaño, color y texto. Para modificar el aspecto conviene usar el
// diseñador visual (clic derecho en frmSocios.cs > Ver diseñador) y no editar este archivo a mano.
// La lógica (qué hace cada botón) está en frmSocios.cs.
// =====================================================================================
namespace CapaPresentacion
{
    partial class frmSocios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSocios = new System.Windows.Forms.TabPage();
            this.tlpSocios = new System.Windows.Forms.TableLayoutPanel();
            this.pnlListaSocios = new System.Windows.Forms.Panel();
            this.gridSocios = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlFichaSocio = new System.Windows.Forms.Panel();
            this.lblTituloSocio = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.btnNuevoSocio = new System.Windows.Forms.Button();
            this.btnGuardarSocio = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tabPlanes = new System.Windows.Forms.TabPage();
            this.tlpPlanes = new System.Windows.Forms.TableLayoutPanel();
            this.gridPlanes = new System.Windows.Forms.DataGridView();
            this.pnlFichaPlan = new System.Windows.Forms.Panel();
            this.lblTituloPlan = new System.Windows.Forms.Label();
            this.lblPlanNombre = new System.Windows.Forms.Label();
            this.txtPlanNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.numDuracion = new System.Windows.Forms.NumericUpDown();
            this.chkPlanActivo = new System.Windows.Forms.CheckBox();
            this.btnNuevoPlan = new System.Windows.Forms.Button();
            this.btnGuardarPlan = new System.Windows.Forms.Button();
            this.colIdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabSocios.SuspendLayout();
            this.tlpSocios.SuspendLayout();
            this.pnlListaSocios.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlFichaSocio.SuspendLayout();
            this.tabPlanes.SuspendLayout();
            this.tlpPlanes.SuspendLayout();
            this.pnlFichaPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSocios);
            this.tabs.Controls.Add(this.tabPlanes);
            this.tabs.Name = "tabs";
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1180, 680);
            this.tabs.TabIndex = 0;
            // 
            // tabSocios
            // 
            this.tabSocios.Controls.Add(this.tlpSocios);
            this.tabSocios.Name = "tabSocios";
            this.tabSocios.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabSocios.Size = new System.Drawing.Size(1172, 642);
            this.tabSocios.Text = "Socios";
            this.tabSocios.UseVisualStyleBackColor = true;
            // 
            // tlpSocios
            // 
            this.tlpSocios.Controls.Add(this.pnlListaSocios, 0, 0);
            this.tlpSocios.Controls.Add(this.pnlFichaSocio, 1, 0);
            this.tlpSocios.ColumnCount = 2;
            this.tlpSocios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpSocios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpSocios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSocios.RowCount = 1;
            this.tlpSocios.Name = "tlpSocios";
            this.tlpSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSocios.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tlpSocios.Size = new System.Drawing.Size(1172, 642);
            this.tlpSocios.TabIndex = 0;
            // 
            // pnlListaSocios
            // 
            this.pnlListaSocios.Controls.Add(this.gridSocios);
            this.pnlListaSocios.Controls.Add(this.pnlBusqueda);
            this.pnlListaSocios.Name = "pnlListaSocios";
            this.pnlListaSocios.BackColor = System.Drawing.Color.White;
            this.pnlListaSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaSocios.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlListaSocios.Size = new System.Drawing.Size(700, 618);
            this.pnlListaSocios.TabIndex = 0;
            // 
            // gridSocios
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridSocios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridSocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colIdSocio, 
                        this.colDni, 
                        this.colApellido, 
                        this.colNombre, 
                        this.colPlan, 
                        this.colVence, 
                        this.colEstadoCuota, 
                        this.colEstado});
            this.gridSocios.RowTemplate.Height = 30;
            this.gridSocios.Name = "gridSocios";
            this.gridSocios.AllowUserToAddRows = false;
            this.gridSocios.AllowUserToDeleteRows = false;
            this.gridSocios.AllowUserToResizeRows = false;
            this.gridSocios.AutoGenerateColumns = false;
            this.gridSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSocios.BackgroundColor = System.Drawing.Color.White;
            this.gridSocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSocios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridSocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridSocios.ColumnHeadersHeight = 34;
            this.gridSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSocios.EnableHeadersVisualStyles = false;
            this.gridSocios.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridSocios.MultiSelect = false;
            this.gridSocios.ReadOnly = true;
            this.gridSocios.RowHeadersVisible = false;
            this.gridSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSocios.Location = new System.Drawing.Point(0, 52);
            this.gridSocios.Size = new System.Drawing.Size(700, 566);
            this.gridSocios.TabIndex = 0;
            this.gridSocios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSocios_CellClick);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.lblTotal);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Size = new System.Drawing.Size(700, 52);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblBuscar.Location = new System.Drawing.Point(12, 6);
            this.lblBuscar.Text = "Buscar por DNI, nombre o apellido";
            this.lblBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Location = new System.Drawing.Point(12, 26);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Size = new System.Drawing.Size(300, 27);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTotal.Location = new System.Drawing.Point(330, 29);
            this.lblTotal.Text = "";
            this.lblTotal.TabIndex = 2;
            // 
            // pnlFichaSocio
            // 
            this.pnlFichaSocio.Controls.Add(this.lblTituloSocio);
            this.pnlFichaSocio.Controls.Add(this.lblDni);
            this.pnlFichaSocio.Controls.Add(this.txtDni);
            this.pnlFichaSocio.Controls.Add(this.lblNombre);
            this.pnlFichaSocio.Controls.Add(this.txtNombre);
            this.pnlFichaSocio.Controls.Add(this.lblApellido);
            this.pnlFichaSocio.Controls.Add(this.txtApellido);
            this.pnlFichaSocio.Controls.Add(this.lblTelefono);
            this.pnlFichaSocio.Controls.Add(this.txtTelefono);
            this.pnlFichaSocio.Controls.Add(this.lblEmail);
            this.pnlFichaSocio.Controls.Add(this.txtEmail);
            this.pnlFichaSocio.Controls.Add(this.lblPlan);
            this.pnlFichaSocio.Controls.Add(this.cmbPlan);
            this.pnlFichaSocio.Controls.Add(this.chkActivo);
            this.pnlFichaSocio.Controls.Add(this.lblCuota);
            this.pnlFichaSocio.Controls.Add(this.btnNuevoSocio);
            this.pnlFichaSocio.Controls.Add(this.btnGuardarSocio);
            this.pnlFichaSocio.Controls.Add(this.btnBaja);
            this.pnlFichaSocio.Name = "pnlFichaSocio";
            this.pnlFichaSocio.AutoScroll = true;
            this.pnlFichaSocio.BackColor = System.Drawing.Color.White;
            this.pnlFichaSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFichaSocio.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlFichaSocio.Size = new System.Drawing.Size(424, 618);
            this.pnlFichaSocio.TabIndex = 1;
            // 
            // lblTituloSocio
            // 
            this.lblTituloSocio.Name = "lblTituloSocio";
            this.lblTituloSocio.AutoSize = true;
            this.lblTituloSocio.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSocio.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTituloSocio.Location = new System.Drawing.Point(16, 12);
            this.lblTituloSocio.Text = "Datos del socio";
            this.lblTituloSocio.TabIndex = 0;
            // 
            // lblDni
            // 
            this.lblDni.Name = "lblDni";
            this.lblDni.AutoSize = true;
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDni.Location = new System.Drawing.Point(16, 52);
            this.lblDni.Text = "DNI";
            this.lblDni.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Name = "txtDni";
            this.txtDni.Location = new System.Drawing.Point(16, 74);
            this.txtDni.MaxLength = 8;
            this.txtDni.Size = new System.Drawing.Size(396, 27);
            this.txtDni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDni.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblNombre.Location = new System.Drawing.Point(16, 114);
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(16, 136);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Size = new System.Drawing.Size(396, 27);
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.AutoSize = true;
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblApellido.Location = new System.Drawing.Point(16, 176);
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Location = new System.Drawing.Point(16, 198);
            this.txtApellido.MaxLength = 60;
            this.txtApellido.Size = new System.Drawing.Size(396, 27);
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.TabIndex = 6;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTelefono.Location = new System.Drawing.Point(16, 238);
            this.lblTelefono.Text = "Teléfono (opcional)";
            this.lblTelefono.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Location = new System.Drawing.Point(16, 260);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Size = new System.Drawing.Size(396, 27);
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblEmail.Location = new System.Drawing.Point(16, 300);
            this.lblEmail.Text = "Email (opcional)";
            this.lblEmail.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Location = new System.Drawing.Point(16, 322);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Size = new System.Drawing.Size(396, 27);
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.TabIndex = 10;
            // 
            // lblPlan
            // 
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.AutoSize = true;
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPlan.Location = new System.Drawing.Point(16, 362);
            this.lblPlan.Text = "Plan";
            this.lblPlan.TabIndex = 11;
            // 
            // cmbPlan
            // 
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(16, 384);
            this.cmbPlan.Size = new System.Drawing.Size(396, 29);
            this.cmbPlan.TabIndex = 12;
            // 
            // chkActivo
            // 
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(16, 424);
            this.chkActivo.Text = "Socio activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.TabIndex = 13;
            // 
            // lblCuota
            // 
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(16, 454);
            this.lblCuota.Size = new System.Drawing.Size(396, 24);
            this.lblCuota.Text = "";
            this.lblCuota.TabIndex = 14;
            // 
            // btnNuevoSocio
            // 
            this.btnNuevoSocio.Name = "btnNuevoSocio";
            this.btnNuevoSocio.BackColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnNuevoSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoSocio.FlatAppearance.BorderSize = 0;
            this.btnNuevoSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoSocio.ForeColor = System.Drawing.Color.White;
            this.btnNuevoSocio.Location = new System.Drawing.Point(16, 492);
            this.btnNuevoSocio.Size = new System.Drawing.Size(100, 38);
            this.btnNuevoSocio.Text = "Nuevo";
            this.btnNuevoSocio.TabIndex = 15;
            this.btnNuevoSocio.UseVisualStyleBackColor = false;
            this.btnNuevoSocio.Click += new System.EventHandler(this.btnNuevoSocio_Click);
            // 
            // btnGuardarSocio
            // 
            this.btnGuardarSocio.Name = "btnGuardarSocio";
            this.btnGuardarSocio.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnGuardarSocio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarSocio.FlatAppearance.BorderSize = 0;
            this.btnGuardarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSocio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSocio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarSocio.Location = new System.Drawing.Point(126, 492);
            this.btnGuardarSocio.Size = new System.Drawing.Size(110, 38);
            this.btnGuardarSocio.Text = "Guardar";
            this.btnGuardarSocio.TabIndex = 16;
            this.btnGuardarSocio.UseVisualStyleBackColor = false;
            this.btnGuardarSocio.Click += new System.EventHandler(this.btnGuardarSocio_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.White;
            this.btnBaja.Location = new System.Drawing.Point(246, 492);
            this.btnBaja.Size = new System.Drawing.Size(110, 38);
            this.btnBaja.Visible = false;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.TabIndex = 17;
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // tabPlanes
            // 
            this.tabPlanes.Controls.Add(this.tlpPlanes);
            this.tabPlanes.Name = "tabPlanes";
            this.tabPlanes.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabPlanes.Size = new System.Drawing.Size(1172, 642);
            this.tabPlanes.Text = "Planes";
            this.tabPlanes.UseVisualStyleBackColor = true;
            // 
            // tlpPlanes
            // 
            this.tlpPlanes.Controls.Add(this.gridPlanes, 0, 0);
            this.tlpPlanes.Controls.Add(this.pnlFichaPlan, 1, 0);
            this.tlpPlanes.ColumnCount = 2;
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPlanes.RowCount = 1;
            this.tlpPlanes.Name = "tlpPlanes";
            this.tlpPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlanes.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tlpPlanes.Size = new System.Drawing.Size(1172, 642);
            this.tlpPlanes.TabIndex = 0;
            // 
            // gridPlanes
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridPlanes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridPlanes.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colPlanId, 
                        this.colPlanNombre, 
                        this.colPlanPrecio, 
                        this.colPlanDuracion, 
                        this.colPlanEstado});
            this.gridPlanes.RowTemplate.Height = 30;
            this.gridPlanes.Name = "gridPlanes";
            this.gridPlanes.AllowUserToAddRows = false;
            this.gridPlanes.AllowUserToDeleteRows = false;
            this.gridPlanes.AllowUserToResizeRows = false;
            this.gridPlanes.AutoGenerateColumns = false;
            this.gridPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPlanes.BackgroundColor = System.Drawing.Color.White;
            this.gridPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPlanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPlanes.ColumnHeadersHeight = 34;
            this.gridPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPlanes.EnableHeadersVisualStyles = false;
            this.gridPlanes.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridPlanes.MultiSelect = false;
            this.gridPlanes.ReadOnly = true;
            this.gridPlanes.RowHeadersVisible = false;
            this.gridPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPlanes.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.gridPlanes.Size = new System.Drawing.Size(700, 618);
            this.gridPlanes.TabIndex = 0;
            this.gridPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPlanes_CellClick);
            // 
            // pnlFichaPlan
            // 
            this.pnlFichaPlan.Controls.Add(this.lblTituloPlan);
            this.pnlFichaPlan.Controls.Add(this.lblPlanNombre);
            this.pnlFichaPlan.Controls.Add(this.txtPlanNombre);
            this.pnlFichaPlan.Controls.Add(this.lblPrecio);
            this.pnlFichaPlan.Controls.Add(this.numPrecio);
            this.pnlFichaPlan.Controls.Add(this.lblDuracion);
            this.pnlFichaPlan.Controls.Add(this.numDuracion);
            this.pnlFichaPlan.Controls.Add(this.chkPlanActivo);
            this.pnlFichaPlan.Controls.Add(this.btnNuevoPlan);
            this.pnlFichaPlan.Controls.Add(this.btnGuardarPlan);
            this.pnlFichaPlan.Name = "pnlFichaPlan";
            this.pnlFichaPlan.BackColor = System.Drawing.Color.White;
            this.pnlFichaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFichaPlan.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlFichaPlan.Size = new System.Drawing.Size(424, 618);
            this.pnlFichaPlan.TabIndex = 1;
            // 
            // lblTituloPlan
            // 
            this.lblTituloPlan.Name = "lblTituloPlan";
            this.lblTituloPlan.AutoSize = true;
            this.lblTituloPlan.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPlan.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTituloPlan.Location = new System.Drawing.Point(16, 12);
            this.lblTituloPlan.Text = "Datos del plan";
            this.lblTituloPlan.TabIndex = 0;
            // 
            // lblPlanNombre
            // 
            this.lblPlanNombre.Name = "lblPlanNombre";
            this.lblPlanNombre.AutoSize = true;
            this.lblPlanNombre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPlanNombre.Location = new System.Drawing.Point(16, 52);
            this.lblPlanNombre.Text = "Nombre del plan";
            this.lblPlanNombre.TabIndex = 1;
            // 
            // txtPlanNombre
            // 
            this.txtPlanNombre.Name = "txtPlanNombre";
            this.txtPlanNombre.Location = new System.Drawing.Point(16, 74);
            this.txtPlanNombre.MaxLength = 60;
            this.txtPlanNombre.Size = new System.Drawing.Size(396, 27);
            this.txtPlanNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanNombre.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblPrecio.Location = new System.Drawing.Point(16, 114);
            this.lblPrecio.Text = "Precio ($)";
            this.lblPrecio.TabIndex = 3;
            // 
            // numPrecio
            // 
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.DecimalPlaces = 2;
            this.numPrecio.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            this.numPrecio.Location = new System.Drawing.Point(16, 136);
            this.numPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numPrecio.Size = new System.Drawing.Size(180, 27);
            this.numPrecio.TabIndex = 4;
            // 
            // lblDuracion
            // 
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDuracion.Location = new System.Drawing.Point(16, 176);
            this.lblDuracion.Text = "Duración (días)";
            this.lblDuracion.TabIndex = 5;
            // 
            // numDuracion
            // 
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Location = new System.Drawing.Point(16, 198);
            this.numDuracion.Maximum = new decimal(new int[] { 730, 0, 0, 0 });
            this.numDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numDuracion.Size = new System.Drawing.Size(180, 27);
            this.numDuracion.Value = new decimal(new int[] { 30, 0, 0, 0 });
            this.numDuracion.TabIndex = 6;
            // 
            // chkPlanActivo
            // 
            this.chkPlanActivo.Name = "chkPlanActivo";
            this.chkPlanActivo.AutoSize = true;
            this.chkPlanActivo.Checked = true;
            this.chkPlanActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlanActivo.Location = new System.Drawing.Point(16, 238);
            this.chkPlanActivo.Text = "Plan activo (se puede asignar a socios)";
            this.chkPlanActivo.UseVisualStyleBackColor = true;
            this.chkPlanActivo.TabIndex = 7;
            // 
            // btnNuevoPlan
            // 
            this.btnNuevoPlan.Name = "btnNuevoPlan";
            this.btnNuevoPlan.BackColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnNuevoPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPlan.FlatAppearance.BorderSize = 0;
            this.btnNuevoPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPlan.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPlan.Location = new System.Drawing.Point(16, 282);
            this.btnNuevoPlan.Size = new System.Drawing.Size(100, 38);
            this.btnNuevoPlan.Text = "Nuevo";
            this.btnNuevoPlan.TabIndex = 8;
            this.btnNuevoPlan.UseVisualStyleBackColor = false;
            this.btnNuevoPlan.Click += new System.EventHandler(this.btnNuevoPlan_Click);
            // 
            // btnGuardarPlan
            // 
            this.btnGuardarPlan.Name = "btnGuardarPlan";
            this.btnGuardarPlan.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnGuardarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPlan.FlatAppearance.BorderSize = 0;
            this.btnGuardarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPlan.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPlan.Location = new System.Drawing.Point(126, 282);
            this.btnGuardarPlan.Size = new System.Drawing.Size(110, 38);
            this.btnGuardarPlan.Text = "Guardar";
            this.btnGuardarPlan.TabIndex = 9;
            this.btnGuardarPlan.UseVisualStyleBackColor = false;
            this.btnGuardarPlan.Click += new System.EventHandler(this.btnGuardarPlan_Click);
            // 
            // colIdSocio
            // 
            dataGridViewCellStyle7.NullValue = "—";
            this.colIdSocio.DefaultCellStyle = dataGridViewCellStyle7;
            this.colIdSocio.DataPropertyName = "id_socio";
            this.colIdSocio.FillWeight = 5F;
            this.colIdSocio.HeaderText = "Id";
            this.colIdSocio.Name = "colIdSocio";
            this.colIdSocio.ReadOnly = true;
            this.colIdSocio.Visible = false;
            // 
            // colDni
            // 
            dataGridViewCellStyle8.NullValue = "—";
            this.colDni.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDni.DataPropertyName = "dni";
            this.colDni.FillWeight = 14F;
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colApellido
            // 
            dataGridViewCellStyle9.NullValue = "—";
            this.colApellido.DefaultCellStyle = dataGridViewCellStyle9;
            this.colApellido.DataPropertyName = "apellido";
            this.colApellido.FillWeight = 18F;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            dataGridViewCellStyle10.NullValue = "—";
            this.colNombre.DefaultCellStyle = dataGridViewCellStyle10;
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.FillWeight = 18F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPlan
            // 
            dataGridViewCellStyle11.NullValue = "—";
            this.colPlan.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPlan.DataPropertyName = "nombre_plan";
            this.colPlan.FillWeight = 22F;
            this.colPlan.HeaderText = "Plan";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            // 
            // colVence
            // 
            dataGridViewCellStyle12.NullValue = "—";
            dataGridViewCellStyle12.Format = "dd/MM/yyyy";
            this.colVence.DefaultCellStyle = dataGridViewCellStyle12;
            this.colVence.DataPropertyName = "ultimo_vencimiento";
            this.colVence.FillWeight = 14F;
            this.colVence.HeaderText = "Vence";
            this.colVence.Name = "colVence";
            this.colVence.ReadOnly = true;
            // 
            // colEstadoCuota
            // 
            dataGridViewCellStyle13.NullValue = "—";
            this.colEstadoCuota.DefaultCellStyle = dataGridViewCellStyle13;
            this.colEstadoCuota.DataPropertyName = "estado_cuota";
            this.colEstadoCuota.FillWeight = 12F;
            this.colEstadoCuota.HeaderText = "Cuota";
            this.colEstadoCuota.Name = "colEstadoCuota";
            this.colEstadoCuota.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle14.NullValue = "—";
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle14;
            this.colEstado.DataPropertyName = "estado_texto";
            this.colEstado.FillWeight = 10F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colPlanId
            // 
            dataGridViewCellStyle15.NullValue = "—";
            this.colPlanId.DefaultCellStyle = dataGridViewCellStyle15;
            this.colPlanId.DataPropertyName = "IdPlan";
            this.colPlanId.FillWeight = 5F;
            this.colPlanId.HeaderText = "Id";
            this.colPlanId.Name = "colPlanId";
            this.colPlanId.ReadOnly = true;
            this.colPlanId.Visible = false;
            // 
            // colPlanNombre
            // 
            dataGridViewCellStyle16.NullValue = "—";
            this.colPlanNombre.DefaultCellStyle = dataGridViewCellStyle16;
            this.colPlanNombre.DataPropertyName = "Nombre";
            this.colPlanNombre.FillWeight = 36F;
            this.colPlanNombre.HeaderText = "Plan";
            this.colPlanNombre.Name = "colPlanNombre";
            this.colPlanNombre.ReadOnly = true;
            // 
            // colPlanPrecio
            // 
            dataGridViewCellStyle17.NullValue = "—";
            dataGridViewCellStyle17.Format = "C0";
            this.colPlanPrecio.DefaultCellStyle = dataGridViewCellStyle17;
            this.colPlanPrecio.DataPropertyName = "Precio";
            this.colPlanPrecio.FillWeight = 20F;
            this.colPlanPrecio.HeaderText = "Precio";
            this.colPlanPrecio.Name = "colPlanPrecio";
            this.colPlanPrecio.ReadOnly = true;
            // 
            // colPlanDuracion
            // 
            dataGridViewCellStyle18.NullValue = "—";
            this.colPlanDuracion.DefaultCellStyle = dataGridViewCellStyle18;
            this.colPlanDuracion.DataPropertyName = "DuracionDias";
            this.colPlanDuracion.FillWeight = 20F;
            this.colPlanDuracion.HeaderText = "Duración (días)";
            this.colPlanDuracion.Name = "colPlanDuracion";
            this.colPlanDuracion.ReadOnly = true;
            // 
            // colPlanEstado
            // 
            dataGridViewCellStyle19.NullValue = "—";
            this.colPlanEstado.DefaultCellStyle = dataGridViewCellStyle19;
            this.colPlanEstado.DataPropertyName = "EstadoTexto";
            this.colPlanEstado.FillWeight = 14F;
            this.colPlanEstado.HeaderText = "Estado";
            this.colPlanEstado.Name = "colPlanEstado";
            this.colPlanEstado.ReadOnly = true;
            // 
            // frmSocios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabs);
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Socios y planes";
            this.Name = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracion)).EndInit();
            this.pnlFichaPlan.ResumeLayout(false);
            this.pnlFichaPlan.PerformLayout();
            this.tlpPlanes.ResumeLayout(false);
            this.tlpPlanes.PerformLayout();
            this.tabPlanes.ResumeLayout(false);
            this.pnlFichaSocio.ResumeLayout(false);
            this.pnlFichaSocio.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlListaSocios.ResumeLayout(false);
            this.pnlListaSocios.PerformLayout();
            this.tlpSocios.ResumeLayout(false);
            this.tlpSocios.PerformLayout();
            this.tabSocios.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSocios;
        private System.Windows.Forms.TableLayoutPanel tlpSocios;
        private System.Windows.Forms.Panel pnlListaSocios;
        private System.Windows.Forms.DataGridView gridSocios;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlFichaSocio;
        private System.Windows.Forms.Label lblTituloSocio;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Button btnNuevoSocio;
        private System.Windows.Forms.Button btnGuardarSocio;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.TabPage tabPlanes;
        private System.Windows.Forms.TableLayoutPanel tlpPlanes;
        private System.Windows.Forms.DataGridView gridPlanes;
        private System.Windows.Forms.Panel pnlFichaPlan;
        private System.Windows.Forms.Label lblTituloPlan;
        private System.Windows.Forms.Label lblPlanNombre;
        private System.Windows.Forms.TextBox txtPlanNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.NumericUpDown numDuracion;
        private System.Windows.Forms.CheckBox chkPlanActivo;
        private System.Windows.Forms.Button btnNuevoPlan;
        private System.Windows.Forms.Button btnGuardarPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanEstado;
    }
}
