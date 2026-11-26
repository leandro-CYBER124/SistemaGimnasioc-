// =====================================================================================
// ARCHIVO DEL DISEÑADOR de frmInicio: lo genera y mantiene Visual Studio.
// Acá están TODOS los controles del formulario (botones, cuadros de texto, grillas...)
// con su posición, tamaño, color y texto. Para modificar el aspecto conviene usar el
// diseñador visual (clic derecho en frmInicio.cs > Ver diseñador) y no editar este archivo a mano.
// La lógica (qué hace cada botón) está en frmInicio.cs.
// =====================================================================================
namespace CapaPresentacion
{
    partial class frmInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMarco = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnCuotas = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.flpTarjetas = new System.Windows.Forms.FlowLayoutPanel();
            this.tarjetaActivos = new System.Windows.Forms.Panel();
            this.tarjetaActivosFranja = new System.Windows.Forms.Panel();
            this.tarjetaActivosTitulo = new System.Windows.Forms.Label();
            this.lblValActivos = new System.Windows.Forms.Label();
            this.tarjetaAlDia = new System.Windows.Forms.Panel();
            this.tarjetaAlDiaFranja = new System.Windows.Forms.Panel();
            this.tarjetaAlDiaTitulo = new System.Windows.Forms.Label();
            this.lblValAlDia = new System.Windows.Forms.Label();
            this.tarjetaMorosos = new System.Windows.Forms.Panel();
            this.tarjetaMorososFranja = new System.Windows.Forms.Panel();
            this.tarjetaMorososTitulo = new System.Windows.Forms.Label();
            this.lblValMorosos = new System.Windows.Forms.Label();
            this.tarjetaIngresos = new System.Windows.Forms.Panel();
            this.tarjetaIngresosFranja = new System.Windows.Forms.Panel();
            this.tarjetaIngresosTitulo = new System.Windows.Forms.Label();
            this.lblValIngresos = new System.Windows.Forms.Label();
            this.tarjetaHoy = new System.Windows.Forms.Panel();
            this.tarjetaHoyFranja = new System.Windows.Forms.Panel();
            this.tarjetaHoyTitulo = new System.Windows.Forms.Label();
            this.lblValHoy = new System.Windows.Forms.Label();
            this.tlpCuerpo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabsDashboard = new System.Windows.Forms.TabControl();
            this.tabMorosos = new System.Windows.Forms.TabPage();
            this.gridMorosos = new System.Windows.Forms.DataGridView();
            this.tabPorVencer = new System.Windows.Forms.TabPage();
            this.gridPorVencer = new System.Windows.Forms.DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiasAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDniPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombrePV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefonoPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencePV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiasRestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMorosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPorVencer)).BeginInit();
            this.tlpMarco.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.flpTarjetas.SuspendLayout();
            this.tarjetaActivos.SuspendLayout();
            this.tarjetaActivosFranja.SuspendLayout();
            this.tarjetaAlDia.SuspendLayout();
            this.tarjetaAlDiaFranja.SuspendLayout();
            this.tarjetaMorosos.SuspendLayout();
            this.tarjetaMorososFranja.SuspendLayout();
            this.tarjetaIngresos.SuspendLayout();
            this.tarjetaIngresosFranja.SuspendLayout();
            this.tarjetaHoy.SuspendLayout();
            this.tarjetaHoyFranja.SuspendLayout();
            this.tlpCuerpo.SuspendLayout();
            this.pnlGrafico.SuspendLayout();
            this.tabsDashboard.SuspendLayout();
            this.tabMorosos.SuspendLayout();
            this.tabPorVencer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMarco
            // 
            this.tlpMarco.Controls.Add(this.pnlEncabezado, 0, 0);
            this.tlpMarco.Controls.Add(this.flpTarjetas, 0, 1);
            this.tlpMarco.Controls.Add(this.tlpCuerpo, 0, 2);
            this.tlpMarco.ColumnCount = 1;
            this.tlpMarco.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMarco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpMarco.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMarco.RowCount = 3;
            this.tlpMarco.Name = "tlpMarco";
            this.tlpMarco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMarco.Location = new System.Drawing.Point(0, 0);
            this.tlpMarco.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpMarco.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpMarco.Size = new System.Drawing.Size(1200, 740);
            this.tlpMarco.TabIndex = 0;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.flpBotones);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(1200, 64);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.lblTitulo.Location = new System.Drawing.Point(20, 18);
            this.lblTitulo.Text = "GYM CONTROL";
            this.lblTitulo.TabIndex = 0;
            // 
            // flpBotones
            // 
            this.flpBotones.Controls.Add(this.lblUsuario);
            this.flpBotones.Controls.Add(this.btnSocios);
            this.flpBotones.Controls.Add(this.btnCuotas);
            this.flpBotones.Controls.Add(this.btnActualizar);
            this.flpBotones.Controls.Add(this.btnCerrarSesion);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.AutoSize = true;
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpBotones.Location = new System.Drawing.Point(600, 0);
            this.flpBotones.Padding = new System.Windows.Forms.Padding(0, 10, 12, 0);
            this.flpBotones.Size = new System.Drawing.Size(600, 64);
            this.flpBotones.WrapContents = false;
            this.flpBotones.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 9, 18, 0);
            this.lblUsuario.Text = "";
            this.lblUsuario.TabIndex = 0;
            // 
            // btnSocios
            // 
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.ForeColor = System.Drawing.Color.White;
            this.btnSocios.Location = new System.Drawing.Point(0, 0);
            this.btnSocios.Size = new System.Drawing.Size(150, 38);
            this.btnSocios.Text = "Socios y planes";
            this.btnSocios.TabIndex = 1;
            this.btnSocios.UseVisualStyleBackColor = false;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnCuotas
            // 
            this.btnCuotas.Name = "btnCuotas";
            this.btnCuotas.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.btnCuotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuotas.FlatAppearance.BorderSize = 0;
            this.btnCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuotas.ForeColor = System.Drawing.Color.White;
            this.btnCuotas.Location = new System.Drawing.Point(0, 0);
            this.btnCuotas.Size = new System.Drawing.Size(150, 38);
            this.btnCuotas.Text = "Cuotas e ingreso";
            this.btnCuotas.TabIndex = 2;
            this.btnCuotas.UseVisualStyleBackColor = false;
            this.btnCuotas.Click += new System.EventHandler(this.btnCuotas_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(63, 63, 70);
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(100, 38);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(63, 63, 70);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 38);
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // flpTarjetas
            // 
            this.flpTarjetas.Controls.Add(this.tarjetaActivos);
            this.flpTarjetas.Controls.Add(this.tarjetaAlDia);
            this.flpTarjetas.Controls.Add(this.tarjetaMorosos);
            this.flpTarjetas.Controls.Add(this.tarjetaIngresos);
            this.flpTarjetas.Controls.Add(this.tarjetaHoy);
            this.flpTarjetas.Name = "flpTarjetas";
            this.flpTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTarjetas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.flpTarjetas.Padding = new System.Windows.Forms.Padding(16, 16, 0, 0);
            this.flpTarjetas.Size = new System.Drawing.Size(1200, 118);
            this.flpTarjetas.WrapContents = false;
            this.flpTarjetas.TabIndex = 1;
            // 
            // tarjetaActivos
            // 
            this.tarjetaActivos.Controls.Add(this.tarjetaActivosFranja);
            this.tarjetaActivos.Controls.Add(this.tarjetaActivosTitulo);
            this.tarjetaActivos.Controls.Add(this.lblValActivos);
            this.tarjetaActivos.Name = "tarjetaActivos";
            this.tarjetaActivos.BackColor = System.Drawing.Color.White;
            this.tarjetaActivos.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.tarjetaActivos.Size = new System.Drawing.Size(218, 88);
            this.tarjetaActivos.TabIndex = 0;
            // 
            // tarjetaActivosFranja
            // 
            this.tarjetaActivosFranja.Name = "tarjetaActivosFranja";
            this.tarjetaActivosFranja.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.tarjetaActivosFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarjetaActivosFranja.Size = new System.Drawing.Size(6, 88);
            this.tarjetaActivosFranja.TabIndex = 0;
            // 
            // tarjetaActivosTitulo
            // 
            this.tarjetaActivosTitulo.Name = "tarjetaActivosTitulo";
            this.tarjetaActivosTitulo.AutoSize = true;
            this.tarjetaActivosTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.tarjetaActivosTitulo.Location = new System.Drawing.Point(18, 10);
            this.tarjetaActivosTitulo.Text = "Socios activos";
            this.tarjetaActivosTitulo.TabIndex = 1;
            // 
            // lblValActivos
            // 
            this.lblValActivos.Name = "lblValActivos";
            this.lblValActivos.AutoSize = true;
            this.lblValActivos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValActivos.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValActivos.Location = new System.Drawing.Point(16, 36);
            this.lblValActivos.Text = "—";
            this.lblValActivos.TabIndex = 2;
            // 
            // tarjetaAlDia
            // 
            this.tarjetaAlDia.Controls.Add(this.tarjetaAlDiaFranja);
            this.tarjetaAlDia.Controls.Add(this.tarjetaAlDiaTitulo);
            this.tarjetaAlDia.Controls.Add(this.lblValAlDia);
            this.tarjetaAlDia.Name = "tarjetaAlDia";
            this.tarjetaAlDia.BackColor = System.Drawing.Color.White;
            this.tarjetaAlDia.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.tarjetaAlDia.Size = new System.Drawing.Size(218, 88);
            this.tarjetaAlDia.TabIndex = 1;
            // 
            // tarjetaAlDiaFranja
            // 
            this.tarjetaAlDiaFranja.Name = "tarjetaAlDiaFranja";
            this.tarjetaAlDiaFranja.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.tarjetaAlDiaFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarjetaAlDiaFranja.Size = new System.Drawing.Size(6, 88);
            this.tarjetaAlDiaFranja.TabIndex = 0;
            // 
            // tarjetaAlDiaTitulo
            // 
            this.tarjetaAlDiaTitulo.Name = "tarjetaAlDiaTitulo";
            this.tarjetaAlDiaTitulo.AutoSize = true;
            this.tarjetaAlDiaTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.tarjetaAlDiaTitulo.Location = new System.Drawing.Point(18, 10);
            this.tarjetaAlDiaTitulo.Text = "Al día";
            this.tarjetaAlDiaTitulo.TabIndex = 1;
            // 
            // lblValAlDia
            // 
            this.lblValAlDia.Name = "lblValAlDia";
            this.lblValAlDia.AutoSize = true;
            this.lblValAlDia.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValAlDia.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblValAlDia.Location = new System.Drawing.Point(16, 36);
            this.lblValAlDia.Text = "—";
            this.lblValAlDia.TabIndex = 2;
            // 
            // tarjetaMorosos
            // 
            this.tarjetaMorosos.Controls.Add(this.tarjetaMorososFranja);
            this.tarjetaMorosos.Controls.Add(this.tarjetaMorososTitulo);
            this.tarjetaMorosos.Controls.Add(this.lblValMorosos);
            this.tarjetaMorosos.Name = "tarjetaMorosos";
            this.tarjetaMorosos.BackColor = System.Drawing.Color.White;
            this.tarjetaMorosos.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.tarjetaMorosos.Size = new System.Drawing.Size(218, 88);
            this.tarjetaMorosos.TabIndex = 2;
            // 
            // tarjetaMorososFranja
            // 
            this.tarjetaMorososFranja.Name = "tarjetaMorososFranja";
            this.tarjetaMorososFranja.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.tarjetaMorososFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarjetaMorososFranja.Size = new System.Drawing.Size(6, 88);
            this.tarjetaMorososFranja.TabIndex = 0;
            // 
            // tarjetaMorososTitulo
            // 
            this.tarjetaMorososTitulo.Name = "tarjetaMorososTitulo";
            this.tarjetaMorososTitulo.AutoSize = true;
            this.tarjetaMorososTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.tarjetaMorososTitulo.Location = new System.Drawing.Point(18, 10);
            this.tarjetaMorososTitulo.Text = "Morosos";
            this.tarjetaMorososTitulo.TabIndex = 1;
            // 
            // lblValMorosos
            // 
            this.lblValMorosos.Name = "lblValMorosos";
            this.lblValMorosos.AutoSize = true;
            this.lblValMorosos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValMorosos.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblValMorosos.Location = new System.Drawing.Point(16, 36);
            this.lblValMorosos.Text = "—";
            this.lblValMorosos.TabIndex = 2;
            // 
            // tarjetaIngresos
            // 
            this.tarjetaIngresos.Controls.Add(this.tarjetaIngresosFranja);
            this.tarjetaIngresos.Controls.Add(this.tarjetaIngresosTitulo);
            this.tarjetaIngresos.Controls.Add(this.lblValIngresos);
            this.tarjetaIngresos.Name = "tarjetaIngresos";
            this.tarjetaIngresos.BackColor = System.Drawing.Color.White;
            this.tarjetaIngresos.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.tarjetaIngresos.Size = new System.Drawing.Size(218, 88);
            this.tarjetaIngresos.TabIndex = 3;
            // 
            // tarjetaIngresosFranja
            // 
            this.tarjetaIngresosFranja.Name = "tarjetaIngresosFranja";
            this.tarjetaIngresosFranja.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.tarjetaIngresosFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarjetaIngresosFranja.Size = new System.Drawing.Size(6, 88);
            this.tarjetaIngresosFranja.TabIndex = 0;
            // 
            // tarjetaIngresosTitulo
            // 
            this.tarjetaIngresosTitulo.Name = "tarjetaIngresosTitulo";
            this.tarjetaIngresosTitulo.AutoSize = true;
            this.tarjetaIngresosTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.tarjetaIngresosTitulo.Location = new System.Drawing.Point(18, 10);
            this.tarjetaIngresosTitulo.Text = "Ingresos del mes";
            this.tarjetaIngresosTitulo.TabIndex = 1;
            // 
            // lblValIngresos
            // 
            this.lblValIngresos.Name = "lblValIngresos";
            this.lblValIngresos.AutoSize = true;
            this.lblValIngresos.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValIngresos.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.lblValIngresos.Location = new System.Drawing.Point(16, 36);
            this.lblValIngresos.Text = "—";
            this.lblValIngresos.TabIndex = 2;
            // 
            // tarjetaHoy
            // 
            this.tarjetaHoy.Controls.Add(this.tarjetaHoyFranja);
            this.tarjetaHoy.Controls.Add(this.tarjetaHoyTitulo);
            this.tarjetaHoy.Controls.Add(this.lblValHoy);
            this.tarjetaHoy.Name = "tarjetaHoy";
            this.tarjetaHoy.BackColor = System.Drawing.Color.White;
            this.tarjetaHoy.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.tarjetaHoy.Size = new System.Drawing.Size(218, 88);
            this.tarjetaHoy.TabIndex = 4;
            // 
            // tarjetaHoyFranja
            // 
            this.tarjetaHoyFranja.Name = "tarjetaHoyFranja";
            this.tarjetaHoyFranja.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.tarjetaHoyFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.tarjetaHoyFranja.Size = new System.Drawing.Size(6, 88);
            this.tarjetaHoyFranja.TabIndex = 0;
            // 
            // tarjetaHoyTitulo
            // 
            this.tarjetaHoyTitulo.Name = "tarjetaHoyTitulo";
            this.tarjetaHoyTitulo.AutoSize = true;
            this.tarjetaHoyTitulo.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.tarjetaHoyTitulo.Location = new System.Drawing.Point(18, 10);
            this.tarjetaHoyTitulo.Text = "Asistencias hoy";
            this.tarjetaHoyTitulo.TabIndex = 1;
            // 
            // lblValHoy
            // 
            this.lblValHoy.Name = "lblValHoy";
            this.lblValHoy.AutoSize = true;
            this.lblValHoy.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValHoy.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblValHoy.Location = new System.Drawing.Point(16, 36);
            this.lblValHoy.Text = "—";
            this.lblValHoy.TabIndex = 2;
            // 
            // tlpCuerpo
            // 
            this.tlpCuerpo.Controls.Add(this.pnlGrafico, 0, 0);
            this.tlpCuerpo.Controls.Add(this.tabsDashboard, 1, 0);
            this.tlpCuerpo.ColumnCount = 2;
            this.tlpCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCuerpo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpCuerpo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCuerpo.RowCount = 1;
            this.tlpCuerpo.Name = "tlpCuerpo";
            this.tlpCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCuerpo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpCuerpo.Padding = new System.Windows.Forms.Padding(16, 6, 16, 16);
            this.tlpCuerpo.Size = new System.Drawing.Size(1200, 558);
            this.tlpCuerpo.TabIndex = 2;
            // 
            // pnlGrafico
            // 
            this.pnlGrafico.Controls.Add(this.grafico);
            this.pnlGrafico.Name = "pnlGrafico";
            this.pnlGrafico.BackColor = System.Drawing.Color.White;
            this.pnlGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrafico.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlGrafico.Size = new System.Drawing.Size(456, 536);
            this.pnlGrafico.TabIndex = 0;
            // 
            // grafico
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "area";
            this.grafico.ChartAreas.Add(chartArea1);
            series1.ChartArea = "area";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.FromArgb(234, 88, 12);
            series1.CustomProperties = "PointWidth=0.6";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Ingresos";
            this.grafico.Series.Add(series1);
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            title1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            title1.Name = "Title1";
            title1.Text = "Ingresos al gimnasio - últimos 7 días";
            this.grafico.Titles.Add(title1);
            this.grafico.Name = "grafico";
            this.grafico.BackColor = System.Drawing.Color.White;
            this.grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafico.Size = new System.Drawing.Size(456, 536);
            this.grafico.TabIndex = 0;
            // 
            // tabsDashboard
            // 
            this.tabsDashboard.Controls.Add(this.tabMorosos);
            this.tabsDashboard.Controls.Add(this.tabPorVencer);
            this.tabsDashboard.Name = "tabsDashboard";
            this.tabsDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsDashboard.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tabsDashboard.SelectedIndex = 0;
            this.tabsDashboard.Size = new System.Drawing.Size(680, 536);
            this.tabsDashboard.TabIndex = 1;
            // 
            // tabMorosos
            // 
            this.tabMorosos.Controls.Add(this.gridMorosos);
            this.tabMorosos.Name = "tabMorosos";
            this.tabMorosos.Size = new System.Drawing.Size(672, 498);
            this.tabMorosos.Text = "Morosos";
            this.tabMorosos.UseVisualStyleBackColor = true;
            // 
            // gridMorosos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gridMorosos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridMorosos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gridMorosos.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridMorosos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colDni, 
                        this.colApellido, 
                        this.colNombre, 
                        this.colTelefono, 
                        this.colPlan, 
                        this.colVence, 
                        this.colDiasAtraso});
            this.gridMorosos.RowTemplate.Height = 30;
            this.gridMorosos.Name = "gridMorosos";
            this.gridMorosos.AllowUserToAddRows = false;
            this.gridMorosos.AllowUserToDeleteRows = false;
            this.gridMorosos.AllowUserToResizeRows = false;
            this.gridMorosos.AutoGenerateColumns = false;
            this.gridMorosos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMorosos.BackgroundColor = System.Drawing.Color.White;
            this.gridMorosos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMorosos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMorosos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridMorosos.ColumnHeadersHeight = 34;
            this.gridMorosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMorosos.EnableHeadersVisualStyles = false;
            this.gridMorosos.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridMorosos.MultiSelect = false;
            this.gridMorosos.ReadOnly = true;
            this.gridMorosos.RowHeadersVisible = false;
            this.gridMorosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMorosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMorosos.Size = new System.Drawing.Size(672, 498);
            this.gridMorosos.TabIndex = 0;
            // 
            // tabPorVencer
            // 
            this.tabPorVencer.Controls.Add(this.gridPorVencer);
            this.tabPorVencer.Name = "tabPorVencer";
            this.tabPorVencer.Size = new System.Drawing.Size(672, 498);
            this.tabPorVencer.Text = "Vencen en 7 días";
            this.tabPorVencer.UseVisualStyleBackColor = true;
            // 
            // gridPorVencer
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(24, 24, 27);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.gridPorVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.gridPorVencer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gridPorVencer.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPorVencer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        this.colDniPV, 
                        this.colApellidoPV, 
                        this.colNombrePV, 
                        this.colTelefonoPV, 
                        this.colPlanPV, 
                        this.colVencePV, 
                        this.colDiasRestantes});
            this.gridPorVencer.RowTemplate.Height = 30;
            this.gridPorVencer.Name = "gridPorVencer";
            this.gridPorVencer.AllowUserToAddRows = false;
            this.gridPorVencer.AllowUserToDeleteRows = false;
            this.gridPorVencer.AllowUserToResizeRows = false;
            this.gridPorVencer.AutoGenerateColumns = false;
            this.gridPorVencer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPorVencer.BackgroundColor = System.Drawing.Color.White;
            this.gridPorVencer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPorVencer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridPorVencer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridPorVencer.ColumnHeadersHeight = 34;
            this.gridPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPorVencer.EnableHeadersVisualStyles = false;
            this.gridPorVencer.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.gridPorVencer.MultiSelect = false;
            this.gridPorVencer.ReadOnly = true;
            this.gridPorVencer.RowHeadersVisible = false;
            this.gridPorVencer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPorVencer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPorVencer.Size = new System.Drawing.Size(672, 498);
            this.gridPorVencer.TabIndex = 0;
            // 
            // colDni
            // 
            dataGridViewCellStyle7.NullValue = "—";
            this.colDni.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDni.DataPropertyName = "dni";
            this.colDni.FillWeight = 14F;
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colApellido
            // 
            dataGridViewCellStyle8.NullValue = "—";
            this.colApellido.DefaultCellStyle = dataGridViewCellStyle8;
            this.colApellido.DataPropertyName = "apellido";
            this.colApellido.FillWeight = 18F;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            dataGridViewCellStyle9.NullValue = "—";
            this.colNombre.DefaultCellStyle = dataGridViewCellStyle9;
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.FillWeight = 18F;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colTelefono
            // 
            dataGridViewCellStyle10.NullValue = "—";
            this.colTelefono.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTelefono.DataPropertyName = "telefono";
            this.colTelefono.FillWeight = 18F;
            this.colTelefono.HeaderText = "Teléfono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.ReadOnly = true;
            // 
            // colPlan
            // 
            dataGridViewCellStyle11.NullValue = "—";
            this.colPlan.DefaultCellStyle = dataGridViewCellStyle11;
            this.colPlan.DataPropertyName = "nombre_plan";
            this.colPlan.FillWeight = 20F;
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
            // colDiasAtraso
            // 
            dataGridViewCellStyle13.NullValue = "—";
            this.colDiasAtraso.DefaultCellStyle = dataGridViewCellStyle13;
            this.colDiasAtraso.DataPropertyName = "dias_atraso";
            this.colDiasAtraso.FillWeight = 12F;
            this.colDiasAtraso.HeaderText = "Días de atraso";
            this.colDiasAtraso.Name = "colDiasAtraso";
            this.colDiasAtraso.ReadOnly = true;
            // 
            // colDniPV
            // 
            dataGridViewCellStyle14.NullValue = "—";
            this.colDniPV.DefaultCellStyle = dataGridViewCellStyle14;
            this.colDniPV.DataPropertyName = "dni";
            this.colDniPV.FillWeight = 14F;
            this.colDniPV.HeaderText = "DNI";
            this.colDniPV.Name = "colDniPV";
            this.colDniPV.ReadOnly = true;
            // 
            // colApellidoPV
            // 
            dataGridViewCellStyle15.NullValue = "—";
            this.colApellidoPV.DefaultCellStyle = dataGridViewCellStyle15;
            this.colApellidoPV.DataPropertyName = "apellido";
            this.colApellidoPV.FillWeight = 18F;
            this.colApellidoPV.HeaderText = "Apellido";
            this.colApellidoPV.Name = "colApellidoPV";
            this.colApellidoPV.ReadOnly = true;
            // 
            // colNombrePV
            // 
            dataGridViewCellStyle16.NullValue = "—";
            this.colNombrePV.DefaultCellStyle = dataGridViewCellStyle16;
            this.colNombrePV.DataPropertyName = "nombre";
            this.colNombrePV.FillWeight = 18F;
            this.colNombrePV.HeaderText = "Nombre";
            this.colNombrePV.Name = "colNombrePV";
            this.colNombrePV.ReadOnly = true;
            // 
            // colTelefonoPV
            // 
            dataGridViewCellStyle17.NullValue = "—";
            this.colTelefonoPV.DefaultCellStyle = dataGridViewCellStyle17;
            this.colTelefonoPV.DataPropertyName = "telefono";
            this.colTelefonoPV.FillWeight = 18F;
            this.colTelefonoPV.HeaderText = "Teléfono";
            this.colTelefonoPV.Name = "colTelefonoPV";
            this.colTelefonoPV.ReadOnly = true;
            // 
            // colPlanPV
            // 
            dataGridViewCellStyle18.NullValue = "—";
            this.colPlanPV.DefaultCellStyle = dataGridViewCellStyle18;
            this.colPlanPV.DataPropertyName = "nombre_plan";
            this.colPlanPV.FillWeight = 20F;
            this.colPlanPV.HeaderText = "Plan";
            this.colPlanPV.Name = "colPlanPV";
            this.colPlanPV.ReadOnly = true;
            // 
            // colVencePV
            // 
            dataGridViewCellStyle19.NullValue = "—";
            dataGridViewCellStyle19.Format = "dd/MM/yyyy";
            this.colVencePV.DefaultCellStyle = dataGridViewCellStyle19;
            this.colVencePV.DataPropertyName = "ultimo_vencimiento";
            this.colVencePV.FillWeight = 14F;
            this.colVencePV.HeaderText = "Vence";
            this.colVencePV.Name = "colVencePV";
            this.colVencePV.ReadOnly = true;
            // 
            // colDiasRestantes
            // 
            dataGridViewCellStyle20.NullValue = "—";
            this.colDiasRestantes.DefaultCellStyle = dataGridViewCellStyle20;
            this.colDiasRestantes.DataPropertyName = "dias_restantes";
            this.colDiasRestantes.FillWeight = 12F;
            this.colDiasRestantes.HeaderText = "Días restantes";
            this.colDiasRestantes.Name = "colDiasRestantes";
            this.colDiasRestantes.ReadOnly = true;
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpMarco);
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Control";
            this.Name = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMorosos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPorVencer)).EndInit();
            this.tabPorVencer.ResumeLayout(false);
            this.tabMorosos.ResumeLayout(false);
            this.tabsDashboard.ResumeLayout(false);
            this.pnlGrafico.ResumeLayout(false);
            this.pnlGrafico.PerformLayout();
            this.tlpCuerpo.ResumeLayout(false);
            this.tlpCuerpo.PerformLayout();
            this.tarjetaHoyFranja.ResumeLayout(false);
            this.tarjetaHoyFranja.PerformLayout();
            this.tarjetaHoy.ResumeLayout(false);
            this.tarjetaHoy.PerformLayout();
            this.tarjetaIngresosFranja.ResumeLayout(false);
            this.tarjetaIngresosFranja.PerformLayout();
            this.tarjetaIngresos.ResumeLayout(false);
            this.tarjetaIngresos.PerformLayout();
            this.tarjetaMorososFranja.ResumeLayout(false);
            this.tarjetaMorososFranja.PerformLayout();
            this.tarjetaMorosos.ResumeLayout(false);
            this.tarjetaMorosos.PerformLayout();
            this.tarjetaAlDiaFranja.ResumeLayout(false);
            this.tarjetaAlDiaFranja.PerformLayout();
            this.tarjetaAlDia.ResumeLayout(false);
            this.tarjetaAlDia.PerformLayout();
            this.tarjetaActivosFranja.ResumeLayout(false);
            this.tarjetaActivosFranja.PerformLayout();
            this.tarjetaActivos.ResumeLayout(false);
            this.tarjetaActivos.PerformLayout();
            this.flpTarjetas.ResumeLayout(false);
            this.flpTarjetas.PerformLayout();
            this.flpBotones.ResumeLayout(false);
            this.flpBotones.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.tlpMarco.ResumeLayout(false);
            this.tlpMarco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMarco;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnCuotas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.FlowLayoutPanel flpTarjetas;
        private System.Windows.Forms.Panel tarjetaActivos;
        private System.Windows.Forms.Panel tarjetaActivosFranja;
        private System.Windows.Forms.Label tarjetaActivosTitulo;
        private System.Windows.Forms.Label lblValActivos;
        private System.Windows.Forms.Panel tarjetaAlDia;
        private System.Windows.Forms.Panel tarjetaAlDiaFranja;
        private System.Windows.Forms.Label tarjetaAlDiaTitulo;
        private System.Windows.Forms.Label lblValAlDia;
        private System.Windows.Forms.Panel tarjetaMorosos;
        private System.Windows.Forms.Panel tarjetaMorososFranja;
        private System.Windows.Forms.Label tarjetaMorososTitulo;
        private System.Windows.Forms.Label lblValMorosos;
        private System.Windows.Forms.Panel tarjetaIngresos;
        private System.Windows.Forms.Panel tarjetaIngresosFranja;
        private System.Windows.Forms.Label tarjetaIngresosTitulo;
        private System.Windows.Forms.Label lblValIngresos;
        private System.Windows.Forms.Panel tarjetaHoy;
        private System.Windows.Forms.Panel tarjetaHoyFranja;
        private System.Windows.Forms.Label tarjetaHoyTitulo;
        private System.Windows.Forms.Label lblValHoy;
        private System.Windows.Forms.TableLayoutPanel tlpCuerpo;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.TabControl tabsDashboard;
        private System.Windows.Forms.TabPage tabMorosos;
        private System.Windows.Forms.DataGridView gridMorosos;
        private System.Windows.Forms.TabPage tabPorVencer;
        private System.Windows.Forms.DataGridView gridPorVencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVence;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDniPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombrePV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefonoPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencePV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasRestantes;
    }
}
