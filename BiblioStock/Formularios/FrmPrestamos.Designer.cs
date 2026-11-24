namespace BiblioStock.Formularios
{
    partial class FrmPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpCuerpo;
        private System.Windows.Forms.TableLayoutPanel tlpIzquierda;
        private System.Windows.Forms.TableLayoutPanel tlpPrestamo;
        private System.Windows.Forms.Label lblSeccionPrestamo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.ComboBox cmbRecursos;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblCodigoPrestamo;
        private System.Windows.Forms.TextBox txtCodigoPrestamo;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesPrestamo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tlpSolicitud;
        private System.Windows.Forms.Label lblSeccionSolicitud;
        private System.Windows.Forms.Label lblLibroSolicitud;
        private System.Windows.Forms.ComboBox cmbLibrosSolicitud;
        private System.Windows.Forms.FlowLayoutPanel flpBotonesSolicitud;
        private System.Windows.Forms.Button btnRegistrarSolicitud;
        private System.Windows.Forms.TableLayoutPanel tlpDerecha;
        private System.Windows.Forms.TableLayoutPanel tlpTablaPrestamos;
        private System.Windows.Forms.Label lblListaPrestamos;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.TableLayoutPanel tlpTablaSolicitudes;
        private System.Windows.Forms.Label lblSolicitudes;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrestamoEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSolicitudFecha;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tlpPrincipal = new TableLayoutPanel();
            flpEncabezado = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            tlpCuerpo = new TableLayoutPanel();
            tlpIzquierda = new TableLayoutPanel();
            tlpPrestamo = new TableLayoutPanel();
            lblSeccionPrestamo = new Label();
            lblUsuario = new Label();
            cmbUsuarios = new ComboBox();
            lblRecurso = new Label();
            cmbRecursos = new ComboBox();
            lblFechaPrestamo = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaDevolucion = new Label();
            dtpFechaDevolucion = new DateTimePicker();
            lblCodigoPrestamo = new Label();
            txtCodigoPrestamo = new TextBox();
            flpBotonesPrestamo = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnDevolver = new Button();
            btnLimpiar = new Button();
            tlpSolicitud = new TableLayoutPanel();
            lblSeccionSolicitud = new Label();
            lblLibroSolicitud = new Label();
            cmbLibrosSolicitud = new ComboBox();
            flpBotonesSolicitud = new FlowLayoutPanel();
            btnRegistrarSolicitud = new Button();
            tlpDerecha = new TableLayoutPanel();
            tlpTablaPrestamos = new TableLayoutPanel();
            lblListaPrestamos = new Label();
            dgvPrestamos = new DataGridView();
            tlpTablaSolicitudes = new TableLayoutPanel();
            lblSolicitudes = new Label();
            dgvSolicitudes = new DataGridView();
            colPrestamoCodigo = new DataGridViewTextBoxColumn();
            colPrestamoUsuario = new DataGridViewTextBoxColumn();
            colPrestamoRecurso = new DataGridViewTextBoxColumn();
            colPrestamoTipo = new DataGridViewTextBoxColumn();
            colPrestamoFecha = new DataGridViewTextBoxColumn();
            colPrestamoDevolucion = new DataGridViewTextBoxColumn();
            colPrestamoEstado = new DataGridViewTextBoxColumn();
            colSolicitudCodigo = new DataGridViewTextBoxColumn();
            colSolicitudUsuario = new DataGridViewTextBoxColumn();
            colSolicitudIdentificacion = new DataGridViewTextBoxColumn();
            colSolicitudLibro = new DataGridViewTextBoxColumn();
            colSolicitudFecha = new DataGridViewTextBoxColumn();
            tlpPrincipal.SuspendLayout();
            flpEncabezado.SuspendLayout();
            tlpCuerpo.SuspendLayout();
            tlpIzquierda.SuspendLayout();
            tlpPrestamo.SuspendLayout();
            flpBotonesPrestamo.SuspendLayout();
            tlpSolicitud.SuspendLayout();
            flpBotonesSolicitud.SuspendLayout();
            tlpDerecha.SuspendLayout();
            tlpTablaPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            tlpTablaSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(240, 243, 248);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(flpEncabezado, 0, 0);
            tlpPrincipal.Controls.Add(tlpCuerpo, 0, 1);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(3, 3);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(28, 22, 28, 22);
            tlpPrincipal.RowCount = 2;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1100, 720);
            tlpPrincipal.TabIndex = 0;
            // 
            // flpEncabezado
            // 
            flpEncabezado.AutoSize = true;
            flpEncabezado.Controls.Add(lblTitulo);
            flpEncabezado.Controls.Add(lblSubtitulo);
            flpEncabezado.Dock = DockStyle.Fill;
            flpEncabezado.FlowDirection = FlowDirection.TopDown;
            flpEncabezado.Location = new Point(3, 3);
            flpEncabezado.Margin = new Padding(0, 0, 0, 14);
            flpEncabezado.Name = "flpEncabezado";
            flpEncabezado.Size = new Size(1044, 78);
            flpEncabezado.TabIndex = 0;
            flpEncabezado.WrapContents = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(35, 50, 75);
            lblTitulo.Location = new Point(3, 3);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestion de prestamos";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitulo.Location = new Point(3, 3);
            lblSubtitulo.Margin = new Padding(2, 2, 0, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 23);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Registra prestamos y devoluciones, y administra la lista de espera de los libros.";
            // 
            // tlpCuerpo
            // 
            tlpCuerpo.ColumnCount = 2;
            tlpCuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            tlpCuerpo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            tlpCuerpo.Controls.Add(tlpIzquierda, 0, 0);
            tlpCuerpo.Controls.Add(tlpDerecha, 1, 0);
            tlpCuerpo.Dock = DockStyle.Fill;
            tlpCuerpo.Location = new Point(3, 3);
            tlpCuerpo.Margin = new Padding(0);
            tlpCuerpo.Name = "tlpCuerpo";
            tlpCuerpo.RowCount = 1;
            tlpCuerpo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCuerpo.Size = new Size(1044, 600);
            tlpCuerpo.TabIndex = 1;
            // 
            // tlpIzquierda
            // 
            tlpIzquierda.AutoScroll = true;
            tlpIzquierda.ColumnCount = 1;
            tlpIzquierda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpIzquierda.Controls.Add(tlpPrestamo, 0, 0);
            tlpIzquierda.Controls.Add(tlpSolicitud, 0, 1);
            tlpIzquierda.Dock = DockStyle.Fill;
            tlpIzquierda.Location = new Point(3, 3);
            tlpIzquierda.Margin = new Padding(0, 0, 18, 0);
            tlpIzquierda.Name = "tlpIzquierda";
            tlpIzquierda.RowCount = 2;
            tlpIzquierda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpIzquierda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpIzquierda.Size = new Size(390, 600);
            tlpIzquierda.TabIndex = 0;
            // 
            // tlpPrestamo
            // 
            tlpPrestamo.AutoSize = true;
            tlpPrestamo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpPrestamo.BackColor = Color.White;
            tlpPrestamo.ColumnCount = 2;
            tlpPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrestamo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPrestamo.Controls.Add(lblSeccionPrestamo, 0, 0);
            tlpPrestamo.Controls.Add(lblUsuario, 0, 1);
            tlpPrestamo.Controls.Add(cmbUsuarios, 0, 2);
            tlpPrestamo.Controls.Add(lblRecurso, 0, 3);
            tlpPrestamo.Controls.Add(cmbRecursos, 0, 4);
            tlpPrestamo.Controls.Add(lblFechaPrestamo, 0, 5);
            tlpPrestamo.Controls.Add(dtpFechaPrestamo, 0, 6);
            tlpPrestamo.Controls.Add(lblFechaDevolucion, 1, 5);
            tlpPrestamo.Controls.Add(dtpFechaDevolucion, 1, 6);
            tlpPrestamo.Controls.Add(lblCodigoPrestamo, 0, 7);
            tlpPrestamo.Controls.Add(txtCodigoPrestamo, 0, 8);
            tlpPrestamo.Controls.Add(flpBotonesPrestamo, 0, 9);
            tlpPrestamo.SetColumnSpan(lblSeccionPrestamo, 2);
            tlpPrestamo.SetColumnSpan(lblUsuario, 2);
            tlpPrestamo.SetColumnSpan(cmbUsuarios, 2);
            tlpPrestamo.SetColumnSpan(lblRecurso, 2);
            tlpPrestamo.SetColumnSpan(cmbRecursos, 2);
            tlpPrestamo.SetColumnSpan(lblCodigoPrestamo, 2);
            tlpPrestamo.SetColumnSpan(txtCodigoPrestamo, 2);
            tlpPrestamo.SetColumnSpan(flpBotonesPrestamo, 2);
            tlpPrestamo.Dock = DockStyle.Fill;
            tlpPrestamo.Location = new Point(3, 3);
            tlpPrestamo.Margin = new Padding(0, 0, 0, 18);
            tlpPrestamo.Name = "tlpPrestamo";
            tlpPrestamo.Padding = new Padding(22, 18, 22, 14);
            tlpPrestamo.RowCount = 10;
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpPrestamo.Size = new Size(1044, 200);
            tlpPrestamo.TabIndex = 0;
            // 
            // lblSeccionPrestamo
            // 
            lblSeccionPrestamo.Anchor = AnchorStyles.Left;
            lblSeccionPrestamo.AutoSize = true;
            lblSeccionPrestamo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeccionPrestamo.ForeColor = Color.FromArgb(35, 50, 75);
            lblSeccionPrestamo.Location = new Point(3, 3);
            lblSeccionPrestamo.Margin = new Padding(0, 0, 0, 10);
            lblSeccionPrestamo.Name = "lblSeccionPrestamo";
            lblSeccionPrestamo.Size = new Size(200, 28);
            lblSeccionPrestamo.TabIndex = 0;
            lblSeccionPrestamo.Text = "Registrar prestamo";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Left;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(55, 65, 81);
            lblUsuario.Location = new Point(3, 3);
            lblUsuario.Margin = new Padding(0, 0, 0, 4);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.Dock = DockStyle.Fill;
            cmbUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarios.Font = new Font("Segoe UI", 10F);
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(3, 3);
            cmbUsuarios.Margin = new Padding(0, 0, 14, 12);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(150, 28);
            cmbUsuarios.TabIndex = 2;
            // 
            // lblRecurso
            // 
            lblRecurso.Anchor = AnchorStyles.Left;
            lblRecurso.AutoSize = true;
            lblRecurso.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRecurso.ForeColor = Color.FromArgb(55, 65, 81);
            lblRecurso.Location = new Point(3, 3);
            lblRecurso.Margin = new Padding(0, 0, 0, 4);
            lblRecurso.Name = "lblRecurso";
            lblRecurso.Size = new Size(80, 23);
            lblRecurso.TabIndex = 3;
            lblRecurso.Text = "Recurso";
            // 
            // cmbRecursos
            // 
            cmbRecursos.Dock = DockStyle.Fill;
            cmbRecursos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecursos.Font = new Font("Segoe UI", 10F);
            cmbRecursos.FormattingEnabled = true;
            cmbRecursos.Location = new Point(3, 3);
            cmbRecursos.Margin = new Padding(0, 0, 14, 12);
            cmbRecursos.Name = "cmbRecursos";
            cmbRecursos.Size = new Size(150, 28);
            cmbRecursos.TabIndex = 4;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.Anchor = AnchorStyles.Left;
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFechaPrestamo.ForeColor = Color.FromArgb(55, 65, 81);
            lblFechaPrestamo.Location = new Point(3, 3);
            lblFechaPrestamo.Margin = new Padding(0, 0, 0, 4);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(80, 23);
            lblFechaPrestamo.TabIndex = 5;
            lblFechaPrestamo.Text = "Fecha del prestamo";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Dock = DockStyle.Fill;
            dtpFechaPrestamo.Font = new Font("Segoe UI", 10F);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(3, 3);
            dtpFechaPrestamo.Margin = new Padding(0, 0, 14, 12);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(150, 27);
            dtpFechaPrestamo.TabIndex = 6;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.Anchor = AnchorStyles.Left;
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFechaDevolucion.ForeColor = Color.FromArgb(55, 65, 81);
            lblFechaDevolucion.Location = new Point(3, 3);
            lblFechaDevolucion.Margin = new Padding(0, 0, 0, 4);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(80, 23);
            lblFechaDevolucion.TabIndex = 7;
            lblFechaDevolucion.Text = "Fecha limite de devolucion";
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Dock = DockStyle.Fill;
            dtpFechaDevolucion.Font = new Font("Segoe UI", 10F);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(3, 3);
            dtpFechaDevolucion.Margin = new Padding(0, 0, 14, 12);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(150, 27);
            dtpFechaDevolucion.TabIndex = 8;
            // 
            // lblCodigoPrestamo
            // 
            lblCodigoPrestamo.Anchor = AnchorStyles.Left;
            lblCodigoPrestamo.AutoSize = true;
            lblCodigoPrestamo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCodigoPrestamo.ForeColor = Color.FromArgb(55, 65, 81);
            lblCodigoPrestamo.Location = new Point(3, 3);
            lblCodigoPrestamo.Margin = new Padding(0, 0, 0, 4);
            lblCodigoPrestamo.Name = "lblCodigoPrestamo";
            lblCodigoPrestamo.Size = new Size(80, 23);
            lblCodigoPrestamo.TabIndex = 9;
            lblCodigoPrestamo.Text = "Codigo del prestamo";
            // 
            // txtCodigoPrestamo
            // 
            txtCodigoPrestamo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoPrestamo.Dock = DockStyle.Fill;
            txtCodigoPrestamo.Font = new Font("Segoe UI", 10F);
            txtCodigoPrestamo.Location = new Point(3, 3);
            txtCodigoPrestamo.Margin = new Padding(0, 0, 14, 12);
            txtCodigoPrestamo.Name = "txtCodigoPrestamo";
            txtCodigoPrestamo.ReadOnly = true;
            txtCodigoPrestamo.Size = new Size(150, 27);
            txtCodigoPrestamo.TabIndex = 10;
            // 
            // flpBotonesPrestamo
            // 
            flpBotonesPrestamo.AutoSize = true;
            flpBotonesPrestamo.Controls.Add(btnRegistrar);
            flpBotonesPrestamo.Controls.Add(btnDevolver);
            flpBotonesPrestamo.Controls.Add(btnLimpiar);
            flpBotonesPrestamo.Dock = DockStyle.Fill;
            flpBotonesPrestamo.Location = new Point(3, 3);
            flpBotonesPrestamo.Margin = new Padding(0, 4, 0, 0);
            flpBotonesPrestamo.Name = "flpBotonesPrestamo";
            flpBotonesPrestamo.Size = new Size(330, 42);
            flpBotonesPrestamo.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(37, 99, 235);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 89, 211);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(3, 3);
            btnRegistrar.Margin = new Padding(0, 0, 12, 0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(160, 38);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar prestamo";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.BackColor = Color.FromArgb(22, 163, 74);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 146, 66);
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(3, 3);
            btnDevolver.Margin = new Padding(0, 0, 12, 0);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(170, 38);
            btnDevolver.TabIndex = 1;
            btnDevolver.Text = "Registrar devolucion";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(107, 114, 128);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 102, 115);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(3, 3);
            btnLimpiar.Margin = new Padding(0, 0, 12, 0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 38);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tlpSolicitud
            // 
            tlpSolicitud.AutoSize = true;
            tlpSolicitud.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpSolicitud.BackColor = Color.White;
            tlpSolicitud.ColumnCount = 1;
            tlpSolicitud.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSolicitud.Controls.Add(lblSeccionSolicitud, 0, 0);
            tlpSolicitud.Controls.Add(lblLibroSolicitud, 0, 1);
            tlpSolicitud.Controls.Add(cmbLibrosSolicitud, 0, 2);
            tlpSolicitud.Controls.Add(flpBotonesSolicitud, 0, 3);
            tlpSolicitud.Dock = DockStyle.Fill;
            tlpSolicitud.Location = new Point(3, 3);
            tlpSolicitud.Margin = new Padding(0);
            tlpSolicitud.Name = "tlpSolicitud";
            tlpSolicitud.Padding = new Padding(22, 18, 22, 14);
            tlpSolicitud.RowCount = 4;
            tlpSolicitud.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpSolicitud.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpSolicitud.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpSolicitud.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpSolicitud.Size = new Size(1044, 200);
            tlpSolicitud.TabIndex = 1;
            // 
            // lblSeccionSolicitud
            // 
            lblSeccionSolicitud.Anchor = AnchorStyles.Left;
            lblSeccionSolicitud.AutoSize = true;
            lblSeccionSolicitud.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeccionSolicitud.ForeColor = Color.FromArgb(35, 50, 75);
            lblSeccionSolicitud.Location = new Point(3, 3);
            lblSeccionSolicitud.Margin = new Padding(0, 0, 0, 10);
            lblSeccionSolicitud.Name = "lblSeccionSolicitud";
            lblSeccionSolicitud.Size = new Size(200, 28);
            lblSeccionSolicitud.TabIndex = 0;
            lblSeccionSolicitud.Text = "Solicitar un libro prestado";
            // 
            // lblLibroSolicitud
            // 
            lblLibroSolicitud.Anchor = AnchorStyles.Left;
            lblLibroSolicitud.AutoSize = true;
            lblLibroSolicitud.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLibroSolicitud.ForeColor = Color.FromArgb(55, 65, 81);
            lblLibroSolicitud.Location = new Point(3, 3);
            lblLibroSolicitud.Margin = new Padding(0, 0, 0, 4);
            lblLibroSolicitud.Name = "lblLibroSolicitud";
            lblLibroSolicitud.Size = new Size(80, 23);
            lblLibroSolicitud.TabIndex = 1;
            lblLibroSolicitud.Text = "Libro que desea solicitar";
            // 
            // cmbLibrosSolicitud
            // 
            cmbLibrosSolicitud.Dock = DockStyle.Fill;
            cmbLibrosSolicitud.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLibrosSolicitud.Font = new Font("Segoe UI", 10F);
            cmbLibrosSolicitud.FormattingEnabled = true;
            cmbLibrosSolicitud.Location = new Point(3, 3);
            cmbLibrosSolicitud.Margin = new Padding(0, 0, 14, 12);
            cmbLibrosSolicitud.Name = "cmbLibrosSolicitud";
            cmbLibrosSolicitud.Size = new Size(150, 28);
            cmbLibrosSolicitud.TabIndex = 2;
            // 
            // flpBotonesSolicitud
            // 
            flpBotonesSolicitud.AutoSize = true;
            flpBotonesSolicitud.Controls.Add(btnRegistrarSolicitud);
            flpBotonesSolicitud.Dock = DockStyle.Fill;
            flpBotonesSolicitud.Location = new Point(3, 3);
            flpBotonesSolicitud.Margin = new Padding(0, 4, 0, 0);
            flpBotonesSolicitud.Name = "flpBotonesSolicitud";
            flpBotonesSolicitud.Size = new Size(330, 42);
            flpBotonesSolicitud.TabIndex = 3;
            // 
            // btnRegistrarSolicitud
            // 
            btnRegistrarSolicitud.BackColor = Color.FromArgb(124, 58, 237);
            btnRegistrarSolicitud.Cursor = Cursors.Hand;
            btnRegistrarSolicitud.FlatAppearance.BorderSize = 0;
            btnRegistrarSolicitud.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 52, 213);
            btnRegistrarSolicitud.FlatStyle = FlatStyle.Flat;
            btnRegistrarSolicitud.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRegistrarSolicitud.ForeColor = Color.White;
            btnRegistrarSolicitud.Location = new Point(3, 3);
            btnRegistrarSolicitud.Margin = new Padding(0, 0, 12, 0);
            btnRegistrarSolicitud.Name = "btnRegistrarSolicitud";
            btnRegistrarSolicitud.Size = new Size(170, 38);
            btnRegistrarSolicitud.TabIndex = 0;
            btnRegistrarSolicitud.Text = "Registrar solicitud";
            btnRegistrarSolicitud.UseVisualStyleBackColor = false;
            btnRegistrarSolicitud.Click += btnRegistrarSolicitud_Click;
            // 
            // tlpDerecha
            // 
            tlpDerecha.ColumnCount = 1;
            tlpDerecha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpDerecha.Controls.Add(tlpTablaPrestamos, 0, 0);
            tlpDerecha.Controls.Add(tlpTablaSolicitudes, 0, 1);
            tlpDerecha.Dock = DockStyle.Fill;
            tlpDerecha.Location = new Point(3, 3);
            tlpDerecha.Margin = new Padding(0);
            tlpDerecha.Name = "tlpDerecha";
            tlpDerecha.RowCount = 2;
            tlpDerecha.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlpDerecha.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlpDerecha.Size = new Size(640, 600);
            tlpDerecha.TabIndex = 1;
            // 
            // tlpTablaPrestamos
            // 
            tlpTablaPrestamos.BackColor = Color.White;
            tlpTablaPrestamos.ColumnCount = 1;
            tlpTablaPrestamos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTablaPrestamos.Controls.Add(lblListaPrestamos, 0, 0);
            tlpTablaPrestamos.Controls.Add(dgvPrestamos, 0, 1);
            tlpTablaPrestamos.Dock = DockStyle.Fill;
            tlpTablaPrestamos.Location = new Point(3, 3);
            tlpTablaPrestamos.Margin = new Padding(0, 0, 0, 18);
            tlpTablaPrestamos.Name = "tlpTablaPrestamos";
            tlpTablaPrestamos.Padding = new Padding(22, 18, 22, 18);
            tlpTablaPrestamos.RowCount = 2;
            tlpTablaPrestamos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpTablaPrestamos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTablaPrestamos.Size = new Size(1044, 400);
            tlpTablaPrestamos.TabIndex = 0;
            // 
            // lblListaPrestamos
            // 
            lblListaPrestamos.Anchor = AnchorStyles.Left;
            lblListaPrestamos.AutoSize = true;
            lblListaPrestamos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblListaPrestamos.ForeColor = Color.FromArgb(35, 50, 75);
            lblListaPrestamos.Location = new Point(3, 3);
            lblListaPrestamos.Margin = new Padding(0, 0, 0, 10);
            lblListaPrestamos.Name = "lblListaPrestamos";
            lblListaPrestamos.Size = new Size(200, 28);
            lblListaPrestamos.TabIndex = 0;
            lblListaPrestamos.Text = "Prestamos registrados";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.AllowUserToResizeRows = false;
            dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvPrestamos.AutoGenerateColumns = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.BackgroundColor = Color.White;
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeight = 40;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] {
                colPrestamoCodigo,
                colPrestamoUsuario,
                colPrestamoRecurso,
                colPrestamoTipo,
                colPrestamoFecha,
                colPrestamoDevolucion,
                colPrestamoEstado});
            dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.GridColor = Color.FromArgb(229, 231, 235);
            dgvPrestamos.Location = new Point(3, 3);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.RowTemplate.Height = 32;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(590, 200);
            dgvPrestamos.TabIndex = 1;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            // 
            // estilos de dgvPrestamos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 42, 72);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(24, 42, 72);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            // 
            // colPrestamoCodigo
            // 
            colPrestamoCodigo.DataPropertyName = "Codigo";
            colPrestamoCodigo.FillWeight = 90F;
            colPrestamoCodigo.HeaderText = "Codigo";
            colPrestamoCodigo.MinimumWidth = 6;
            colPrestamoCodigo.Name = "Codigo";
            colPrestamoCodigo.ReadOnly = true;
            // 
            // colPrestamoUsuario
            // 
            colPrestamoUsuario.DataPropertyName = "Usuario";
            colPrestamoUsuario.FillWeight = 110F;
            colPrestamoUsuario.HeaderText = "Usuario";
            colPrestamoUsuario.MinimumWidth = 6;
            colPrestamoUsuario.Name = "Usuario";
            colPrestamoUsuario.ReadOnly = true;
            // 
            // colPrestamoRecurso
            // 
            colPrestamoRecurso.DataPropertyName = "Recurso";
            colPrestamoRecurso.FillWeight = 120F;
            colPrestamoRecurso.HeaderText = "Recurso";
            colPrestamoRecurso.MinimumWidth = 6;
            colPrestamoRecurso.Name = "Recurso";
            colPrestamoRecurso.ReadOnly = true;
            // 
            // colPrestamoTipo
            // 
            colPrestamoTipo.DataPropertyName = "Tipo";
            colPrestamoTipo.FillWeight = 55F;
            colPrestamoTipo.HeaderText = "Tipo";
            colPrestamoTipo.MinimumWidth = 6;
            colPrestamoTipo.Name = "Tipo";
            colPrestamoTipo.ReadOnly = true;
            // 
            // colPrestamoFecha
            // 
            colPrestamoFecha.DataPropertyName = "FechaPrestamo";
            colPrestamoFecha.FillWeight = 85F;
            colPrestamoFecha.HeaderText = "Fecha prestamo";
            colPrestamoFecha.MinimumWidth = 6;
            colPrestamoFecha.Name = "FechaPrestamo";
            colPrestamoFecha.ReadOnly = true;
            // 
            // colPrestamoDevolucion
            // 
            colPrestamoDevolucion.DataPropertyName = "FechaDevolucion";
            colPrestamoDevolucion.FillWeight = 90F;
            colPrestamoDevolucion.HeaderText = "Fecha devolucion";
            colPrestamoDevolucion.MinimumWidth = 6;
            colPrestamoDevolucion.Name = "FechaDevolucion";
            colPrestamoDevolucion.ReadOnly = true;
            // 
            // colPrestamoEstado
            // 
            colPrestamoEstado.DataPropertyName = "Estado";
            colPrestamoEstado.FillWeight = 70F;
            colPrestamoEstado.HeaderText = "Estado";
            colPrestamoEstado.MinimumWidth = 6;
            colPrestamoEstado.Name = "Estado";
            colPrestamoEstado.ReadOnly = true;
            // 
            // tlpTablaSolicitudes
            // 
            tlpTablaSolicitudes.BackColor = Color.White;
            tlpTablaSolicitudes.ColumnCount = 1;
            tlpTablaSolicitudes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTablaSolicitudes.Controls.Add(lblSolicitudes, 0, 0);
            tlpTablaSolicitudes.Controls.Add(dgvSolicitudes, 0, 1);
            tlpTablaSolicitudes.Dock = DockStyle.Fill;
            tlpTablaSolicitudes.Location = new Point(3, 3);
            tlpTablaSolicitudes.Margin = new Padding(0);
            tlpTablaSolicitudes.Name = "tlpTablaSolicitudes";
            tlpTablaSolicitudes.Padding = new Padding(22, 18, 22, 18);
            tlpTablaSolicitudes.RowCount = 2;
            tlpTablaSolicitudes.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpTablaSolicitudes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTablaSolicitudes.Size = new Size(1044, 400);
            tlpTablaSolicitudes.TabIndex = 1;
            // 
            // lblSolicitudes
            // 
            lblSolicitudes.Anchor = AnchorStyles.Left;
            lblSolicitudes.AutoSize = true;
            lblSolicitudes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSolicitudes.ForeColor = Color.FromArgb(35, 50, 75);
            lblSolicitudes.Location = new Point(3, 3);
            lblSolicitudes.Margin = new Padding(0, 0, 0, 10);
            lblSolicitudes.Name = "lblSolicitudes";
            lblSolicitudes.Size = new Size(200, 28);
            lblSolicitudes.TabIndex = 0;
            lblSolicitudes.Text = "Solicitudes pendientes";
            // 
            // dgvSolicitudes
            // 
            dgvSolicitudes.AllowUserToAddRows = false;
            dgvSolicitudes.AllowUserToDeleteRows = false;
            dgvSolicitudes.AllowUserToResizeRows = false;
            dgvSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSolicitudes.AutoGenerateColumns = false;
            dgvSolicitudes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSolicitudes.BackgroundColor = Color.White;
            dgvSolicitudes.BorderStyle = BorderStyle.None;
            dgvSolicitudes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSolicitudes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSolicitudes.ColumnHeadersHeight = 40;
            dgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSolicitudes.Columns.AddRange(new DataGridViewColumn[] {
                colSolicitudCodigo,
                colSolicitudUsuario,
                colSolicitudIdentificacion,
                colSolicitudLibro,
                colSolicitudFecha});
            dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSolicitudes.Dock = DockStyle.Fill;
            dgvSolicitudes.EnableHeadersVisualStyles = false;
            dgvSolicitudes.GridColor = Color.FromArgb(229, 231, 235);
            dgvSolicitudes.Location = new Point(3, 3);
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.Name = "dgvSolicitudes";
            dgvSolicitudes.ReadOnly = true;
            dgvSolicitudes.RowHeadersVisible = false;
            dgvSolicitudes.RowTemplate.Height = 32;
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.Size = new Size(590, 200);
            dgvSolicitudes.TabIndex = 1;
            // 
            // estilos de dgvSolicitudes
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(24, 42, 72);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(24, 42, 72);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 250, 252);
            // 
            // colSolicitudCodigo
            // 
            colSolicitudCodigo.DataPropertyName = "Codigo";
            colSolicitudCodigo.FillWeight = 110F;
            colSolicitudCodigo.HeaderText = "Codigo";
            colSolicitudCodigo.MinimumWidth = 6;
            colSolicitudCodigo.Name = "Codigo";
            colSolicitudCodigo.ReadOnly = true;
            // 
            // colSolicitudUsuario
            // 
            colSolicitudUsuario.DataPropertyName = "Usuario";
            colSolicitudUsuario.FillWeight = 110F;
            colSolicitudUsuario.HeaderText = "Usuario";
            colSolicitudUsuario.MinimumWidth = 6;
            colSolicitudUsuario.Name = "Usuario";
            colSolicitudUsuario.ReadOnly = true;
            // 
            // colSolicitudIdentificacion
            // 
            colSolicitudIdentificacion.DataPropertyName = "Identificacion";
            colSolicitudIdentificacion.FillWeight = 90F;
            colSolicitudIdentificacion.HeaderText = "Identificacion";
            colSolicitudIdentificacion.MinimumWidth = 6;
            colSolicitudIdentificacion.Name = "Identificacion";
            colSolicitudIdentificacion.ReadOnly = true;
            // 
            // colSolicitudLibro
            // 
            colSolicitudLibro.DataPropertyName = "Libro";
            colSolicitudLibro.FillWeight = 120F;
            colSolicitudLibro.HeaderText = "Libro";
            colSolicitudLibro.MinimumWidth = 6;
            colSolicitudLibro.Name = "Libro";
            colSolicitudLibro.ReadOnly = true;
            // 
            // colSolicitudFecha
            // 
            colSolicitudFecha.DataPropertyName = "FechaSolicitud";
            colSolicitudFecha.FillWeight = 100F;
            colSolicitudFecha.HeaderText = "Fecha solicitud";
            colSolicitudFecha.MinimumWidth = 6;
            colSolicitudFecha.Name = "FechaSolicitud";
            colSolicitudFecha.ReadOnly = true;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1100, 720);
            Controls.Add(tlpPrincipal);
            MinimumSize = new Size(820, 560);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Gestion de prestamos";
            ((System.ComponentModel.ISupportInitialize)dgvSolicitudes).EndInit();
            tlpTablaSolicitudes.ResumeLayout(false);
            tlpTablaSolicitudes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            tlpTablaPrestamos.ResumeLayout(false);
            tlpTablaPrestamos.PerformLayout();
            tlpDerecha.ResumeLayout(false);
            tlpDerecha.PerformLayout();
            flpBotonesSolicitud.ResumeLayout(false);
            flpBotonesSolicitud.PerformLayout();
            tlpSolicitud.ResumeLayout(false);
            tlpSolicitud.PerformLayout();
            flpBotonesPrestamo.ResumeLayout(false);
            flpBotonesPrestamo.PerformLayout();
            tlpPrestamo.ResumeLayout(false);
            tlpPrestamo.PerformLayout();
            tlpIzquierda.ResumeLayout(false);
            tlpIzquierda.PerformLayout();
            tlpCuerpo.ResumeLayout(false);
            tlpCuerpo.PerformLayout();
            flpEncabezado.ResumeLayout(false);
            flpEncabezado.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }
    }
}
