namespace CapaPresentacion
{
    partial class frmCuotas
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
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIngreso = new System.Windows.Forms.Panel();
            this.lblTituloIngreso = new System.Windows.Forms.Label();
            this.lblDniIngreso = new System.Windows.Forms.Label();
            this.txtDniIngreso = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblResultadoTitulo = new System.Windows.Forms.Label();
            this.lblResultadoDetalle = new System.Windows.Forms.Label();
            this.lblHoy = new System.Windows.Forms.Label();
            this.gridHoy = new System.Windows.Forms.DataGridView();
            this.pnlCobro = new System.Windows.Forms.Panel();
            this.lblTituloCobro = new System.Windows.Forms.Label();
            this.lblDniCobro = new System.Windows.Forms.Label();
            this.txtDniCobro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNueva = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.cmbMedio = new System.Windows.Forms.ComboBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.gridCuotas = new System.Windows.Forms.DataGridView();
            this.colHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoyDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoySocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPagada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenceCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).BeginInit();
            this.tlpPrincipal.SuspendLayout();
            this.pnlIngreso.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.Controls.Add(this.pnlIngreso, 0, 0);
            this.tlpPrincipal.Controls.Add(this.pnlCobro, 1, 0);
            this.tlpPrincipal.ColumnCount = 2;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.RowCount = 1;
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tlpPrincipal.Size = new System.Drawing.Size(1200, 700);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // pnlIngreso
            // 
            this.pnlIngreso.Controls.Add(this.lblTituloIngreso);
            this.pnlIngreso.Controls.Add(this.lblDniIngreso);
            this.pnlIngreso.Controls.Add(this.txtDniIngreso);
            this.pnlIngreso.Controls.Add(this.btnVerificar);
            this.pnlIngreso.Controls.Add(this.pnlResultado);
            this.pnlIngreso.Controls.Add(this.lblHoy);
            this.pnlIngreso.Controls.Add(this.gridHoy);
            this.pnlIngreso.Name = "pnlIngreso";
            this.pnlIngreso.BackColor = System.Drawing.Color.White;
            this.pnlIngreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIngreso.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlIngreso.Size = new System.Drawing.Size(580, 676);
            this.pnlIngreso.TabIndex = 0;
            // 
            // lblTituloIngreso
            // 
            this.lblTituloIngreso.Name = "lblTituloIngreso";
            this.lblTituloIngreso.AutoSize = true;
            this.lblTituloIngreso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIngreso.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTituloIngreso.Location = new System.Drawing.Point(16, 14);
            this.lblTituloIngreso.Text = "Control de ingreso";
            this.lblTituloIngreso.TabIndex = 0;
            // 
            // lblDniIngreso
            // 
            this.lblDniIngreso.Name = "lblDniIngreso";
            this.lblDniIngreso.AutoSize = true;
            this.lblDniIngreso.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDniIngreso.Location = new System.Drawing.Point(16, 56);
            this.lblDniIngreso.Text = "DNI del socio (sin puntos)";
            this.lblDniIngreso.TabIndex = 1;
            // 
            // txtDniIngreso
            // 
            this.txtDniIngreso.Name = "txtDniIngreso";
            this.txtDniIngreso.Location = new System.Drawing.Point(16, 80);
            this.txtDniIngreso.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniIngreso.MaxLength = 8;
            this.txtDniIngreso.Size = new System.Drawing.Size(300, 36);
            this.txtDniIngreso.TabIndex = 2;
            this.txtDniIngreso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDniIngreso_KeyDown);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(330, 80);
            this.btnVerificar.Size = new System.Drawing.Size(170, 40);
            this.btnVerificar.Text = "Verificar ingreso";
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.lblResultadoTitulo);
            this.pnlResultado.Controls.Add(this.lblResultadoDetalle);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlResultado.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.pnlResultado.Location = new System.Drawing.Point(16, 136);
            this.pnlResultado.Size = new System.Drawing.Size(548, 120);
            this.pnlResultado.TabIndex = 4;
            // 
            // lblResultadoTitulo
            // 
            this.lblResultadoTitulo.Name = "lblResultadoTitulo";
            this.lblResultadoTitulo.AutoSize = true;
            this.lblResultadoTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblResultadoTitulo.Location = new System.Drawing.Point(16, 14);
            this.lblResultadoTitulo.Text = "Esperando DNI…";
            this.lblResultadoTitulo.TabIndex = 0;
            // 
            // lblResultadoDetalle
            // 
            this.lblResultadoDetalle.Name = "lblResultadoDetalle";
            this.lblResultadoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultadoDetalle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDetalle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblResultadoDetalle.Location = new System.Drawing.Point(18, 56);
            this.lblResultadoDetalle.Size = new System.Drawing.Size(514, 56);
            this.lblResultadoDetalle.Text = "";
            this.lblResultadoDetalle.TabIndex = 1;
            // 
            // lblHoy
            // 
            this.lblHoy.Name = "lblHoy";
            this.lblHoy.AutoSize = true;
            this.lblHoy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoy.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblHoy.Location = new System.Drawing.Point(16, 274);
            this.lblHoy.Text = "Ingresos de hoy";
            this.lblHoy.TabIndex = 5;
            // 
            // gridHoy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridHoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridHoy.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridHoy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colHora, 
                        this.colHoyDni, 
                        this.colHoySocio, 
                        this.colResultado, 
                        this.colMotivo});
            this.gridHoy.RowTemplate.Height = 30;
            this.gridHoy.Name = "gridHoy";
            this.gridHoy.AllowUserToAddRows = false;
            this.gridHoy.AllowUserToDeleteRows = false;
            this.gridHoy.AllowUserToResizeRows = false;
            this.gridHoy.AutoGenerateColumns = false;
            this.gridHoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHoy.BackgroundColor = System.Drawing.Color.White;
            this.gridHoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridHoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridHoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridHoy.ColumnHeadersHeight = 34;
            this.gridHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridHoy.EnableHeadersVisualStyles = false;
            this.gridHoy.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridHoy.MultiSelect = false;
            this.gridHoy.ReadOnly = true;
            this.gridHoy.RowHeadersVisible = false;
            this.gridHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHoy.Location = new System.Drawing.Point(16, 300);
            this.gridHoy.Size = new System.Drawing.Size(548, 360);
            this.gridHoy.TabIndex = 6;
            // 
            // pnlCobro
            // 
            this.pnlCobro.Controls.Add(this.lblTituloCobro);
            this.pnlCobro.Controls.Add(this.lblDniCobro);
            this.pnlCobro.Controls.Add(this.txtDniCobro);
            this.pnlCobro.Controls.Add(this.btnBuscar);
            this.pnlCobro.Controls.Add(this.lblSocio);
            this.pnlCobro.Controls.Add(this.lblPlan);
            this.pnlCobro.Controls.Add(this.lblEstado);
            this.pnlCobro.Controls.Add(this.lblNueva);
            this.pnlCobro.Controls.Add(this.lblAviso);
            this.pnlCobro.Controls.Add(this.lblMedio);
            this.pnlCobro.Controls.Add(this.cmbMedio);
            this.pnlCobro.Controls.Add(this.btnCobrar);
            this.pnlCobro.Controls.Add(this.lblHistorial);
            this.pnlCobro.Controls.Add(this.gridCuotas);
            this.pnlCobro.Name = "pnlCobro";
            this.pnlCobro.BackColor = System.Drawing.Color.White;
            this.pnlCobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCobro.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnlCobro.Size = new System.Drawing.Size(580, 676);
            this.pnlCobro.TabIndex = 1;
            // 
            // lblTituloCobro
            // 
            this.lblTituloCobro.Name = "lblTituloCobro";
            this.lblTituloCobro.AutoSize = true;
            this.lblTituloCobro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCobro.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTituloCobro.Location = new System.Drawing.Point(16, 14);
            this.lblTituloCobro.Text = "Cobro de cuota";
            this.lblTituloCobro.TabIndex = 0;
            // 
            // lblDniCobro
            // 
            this.lblDniCobro.Name = "lblDniCobro";
            this.lblDniCobro.AutoSize = true;
            this.lblDniCobro.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDniCobro.Location = new System.Drawing.Point(16, 56);
            this.lblDniCobro.Text = "DNI del socio (sin puntos)";
            this.lblDniCobro.TabIndex = 1;
            // 
            // txtDniCobro
            // 
            this.txtDniCobro.Name = "txtDniCobro";
            this.txtDniCobro.Location = new System.Drawing.Point(16, 80);
            this.txtDniCobro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniCobro.MaxLength = 8;
            this.txtDniCobro.Size = new System.Drawing.Size(300, 36);
            this.txtDniCobro.TabIndex = 2;
            this.txtDniCobro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDniCobro_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(330, 80);
            this.btnBuscar.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar.Text = "Buscar socio";
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSocio.Location = new System.Drawing.Point(16, 138);
            this.lblSocio.Size = new System.Drawing.Size(548, 28);
            this.lblSocio.Text = "";
            this.lblSocio.TabIndex = 4;
            // 
            // lblPlan
            // 
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPlan.Location = new System.Drawing.Point(16, 170);
            this.lblPlan.Size = new System.Drawing.Size(548, 24);
            this.lblPlan.Text = "";
            this.lblPlan.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEstado.Location = new System.Drawing.Point(16, 196);
            this.lblEstado.Size = new System.Drawing.Size(548, 24);
            this.lblEstado.Text = "";
            this.lblEstado.TabIndex = 6;
            // 
            // lblNueva
            // 
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNueva.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNueva.Location = new System.Drawing.Point(16, 222);
            this.lblNueva.Size = new System.Drawing.Size(548, 24);
            this.lblNueva.Text = "";
            this.lblNueva.TabIndex = 7;
            // 
            // lblAviso
            // 
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblAviso.Location = new System.Drawing.Point(16, 250);
            this.lblAviso.Size = new System.Drawing.Size(548, 40);
            this.lblAviso.Text = "";
            this.lblAviso.TabIndex = 8;
            // 
            // lblMedio
            // 
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.AutoSize = true;
            this.lblMedio.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblMedio.Location = new System.Drawing.Point(16, 296);
            this.lblMedio.Text = "Medio de pago";
            this.lblMedio.TabIndex = 9;
            // 
            // cmbMedio
            // 
            this.cmbMedio.Name = "cmbMedio";
            this.cmbMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedio.FormattingEnabled = true;
            this.cmbMedio.Location = new System.Drawing.Point(16, 318);
            this.cmbMedio.Size = new System.Drawing.Size(200, 29);
            this.cmbMedio.TabIndex = 10;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(240, 312);
            this.btnCobrar.Size = new System.Drawing.Size(240, 40);
            this.btnCobrar.Enabled = false;
            this.btnCobrar.Text = "Cobrar cuota";
            this.btnCobrar.TabIndex = 11;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblHistorial.Location = new System.Drawing.Point(16, 372);
            this.lblHistorial.Text = "Historial de cuotas del socio";
            this.lblHistorial.TabIndex = 12;
            // 
            // gridCuotas
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridCuotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridCuotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridCuotas.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colPagada, 
                        this.colDesde, 
                        this.colVenceCuota, 
                        this.colMonto, 
                        this.colMedio, 
                        this.colCobro});
            this.gridCuotas.RowTemplate.Height = 30;
            this.gridCuotas.Name = "gridCuotas";
            this.gridCuotas.AllowUserToAddRows = false;
            this.gridCuotas.AllowUserToDeleteRows = false;
            this.gridCuotas.AllowUserToResizeRows = false;
            this.gridCuotas.AutoGenerateColumns = false;
            this.gridCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCuotas.BackgroundColor = System.Drawing.Color.White;
            this.gridCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCuotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCuotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridCuotas.ColumnHeadersHeight = 34;
            this.gridCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCuotas.EnableHeadersVisualStyles = false;
            this.gridCuotas.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridCuotas.MultiSelect = false;
            this.gridCuotas.ReadOnly = true;
            this.gridCuotas.RowHeadersVisible = false;
            this.gridCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCuotas.Location = new System.Drawing.Point(16, 398);
            this.gridCuotas.Size = new System.Drawing.Size(548, 262);
            this.gridCuotas.TabIndex = 13;
            // 
            // colHora
            // 
            dataGridViewCellStyle7.NullValue = "—";
            this.colHora.DefaultCellStyle = dataGridViewCellStyle7;
            this.colHora.DataPropertyName = "hora";
            this.colHora.FillWeight = 10F;
            this.colHora.HeaderText = "Hora";
            this.colHora.Name = "colHora";
            this.colHora.ReadOnly = true;
            // 
            // colHoyDni
            // 
            dataGridViewCellStyle8.NullValue = "—";
            this.colHoyDni.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHoyDni.DataPropertyName = "dni";
            this.colHoyDni.FillWeight = 16F;
            this.colHoyDni.HeaderText = "DNI";
            this.colHoyDni.Name = "colHoyDni";
            this.colHoyDni.ReadOnly = true;
            // 
            // colHoySocio
            // 
            dataGridViewCellStyle9.NullValue = "—";
            this.colHoySocio.DefaultCellStyle = dataGridViewCellStyle9;
            this.colHoySocio.DataPropertyName = "socio";
            this.colHoySocio.FillWeight = 30F;
            this.colHoySocio.HeaderText = "Socio";
            this.colHoySocio.Name = "colHoySocio";
            this.colHoySocio.ReadOnly = true;
            // 
            // colResultado
            // 
            dataGridViewCellStyle10.NullValue = "—";
            this.colResultado.DefaultCellStyle = dataGridViewCellStyle10;
            this.colResultado.DataPropertyName = "resultado";
            this.colResultado.FillWeight = 16F;
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.Name = "colResultado";
            this.colResultado.ReadOnly = true;
            // 
            // colMotivo
            // 
            dataGridViewCellStyle11.NullValue = "—";
            this.colMotivo.DefaultCellStyle = dataGridViewCellStyle11;
            this.colMotivo.DataPropertyName = "motivo";
            this.colMotivo.FillWeight = 36F;
            this.colMotivo.HeaderText = "Detalle";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.ReadOnly = true;
            // 
            // colPagada
            // 
            dataGridViewCellStyle12.NullValue = "—";
            dataGridViewCellStyle12.Format = "dd/MM/yyyy";
            this.colPagada.DefaultCellStyle = dataGridViewCellStyle12;
            this.colPagada.DataPropertyName = "fecha_pago";
            this.colPagada.FillWeight = 20F;
            this.colPagada.HeaderText = "Pagada";
            this.colPagada.Name = "colPagada";
            this.colPagada.ReadOnly = true;
            // 
            // colDesde
            // 
            dataGridViewCellStyle13.NullValue = "—";
            dataGridViewCellStyle13.Format = "dd/MM/yyyy";
            this.colDesde.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDesde.DataPropertyName = "fecha_desde";
            this.colDesde.FillWeight = 18F;
            this.colDesde.HeaderText = "Desde";
            this.colDesde.Name = "colDesde";
            this.colDesde.ReadOnly = true;
            // 
            // colVenceCuota
            // 
            dataGridViewCellStyle14.NullValue = "—";
            dataGridViewCellStyle14.Format = "dd/MM/yyyy";
            this.colVenceCuota.DefaultCellStyle = dataGridViewCellStyle14;
            this.colVenceCuota.DataPropertyName = "fecha_vencimiento";
            this.colVenceCuota.FillWeight = 18F;
            this.colVenceCuota.HeaderText = "Vence";
            this.colVenceCuota.Name = "colVenceCuota";
            this.colVenceCuota.ReadOnly = true;
            // 
            // colMonto
            // 
            dataGridViewCellStyle15.NullValue = "—";
            dataGridViewCellStyle15.Format = "C0";
            this.colMonto.DefaultCellStyle = dataGridViewCellStyle15;
            this.colMonto.DataPropertyName = "monto";
            this.colMonto.FillWeight = 16F;
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colMedio
            // 
            dataGridViewCellStyle16.NullValue = "—";
            this.colMedio.DefaultCellStyle = dataGridViewCellStyle16;
            this.colMedio.DataPropertyName = "medio_pago";
            this.colMedio.FillWeight = 18F;
            this.colMedio.HeaderText = "Medio";
            this.colMedio.Name = "colMedio";
            this.colMedio.ReadOnly = true;
            // 
            // colCobro
            // 
            dataGridViewCellStyle17.NullValue = "—";
            this.colCobro.DefaultCellStyle = dataGridViewCellStyle17;
            this.colCobro.DataPropertyName = "cobrado_por";
            this.colCobro.FillWeight = 24F;
            this.colCobro.HeaderText = "Cobró";
            this.colCobro.Name = "colCobro";
            this.colCobro.ReadOnly = true;
            // 
            // frmCuotas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpPrincipal);
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1040, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cuotas e ingreso";
            this.Name = "frmCuotas";
            this.Load += new System.EventHandler(this.frmCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuotas)).EndInit();
            this.pnlCobro.ResumeLayout(false);
            this.pnlCobro.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.pnlIngreso.ResumeLayout(false);
            this.pnlIngreso.PerformLayout();
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlIngreso;
        private System.Windows.Forms.Label lblTituloIngreso;
        private System.Windows.Forms.Label lblDniIngreso;
        private System.Windows.Forms.TextBox txtDniIngreso;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblResultadoTitulo;
        private System.Windows.Forms.Label lblResultadoDetalle;
        private System.Windows.Forms.Label lblHoy;
        private System.Windows.Forms.DataGridView gridHoy;
        private System.Windows.Forms.Panel pnlCobro;
        private System.Windows.Forms.Label lblTituloCobro;
        private System.Windows.Forms.Label lblDniCobro;
        private System.Windows.Forms.TextBox txtDniCobro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNueva;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.ComboBox cmbMedio;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.DataGridView gridCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoyDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoySocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPagada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenceCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCobro;
    }
}
