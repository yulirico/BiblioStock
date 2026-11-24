namespace BiblioStock.Formularios
{
    partial class FrmEquipos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tlpTabla;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDisponible;

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
            tlpPrincipal = new TableLayoutPanel();
            flpEncabezado = new FlowLayoutPanel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            tlpCampos = new TableLayoutPanel();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblNumeroSerie = new Label();
            txtNumeroSerie = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            flpBotones = new FlowLayoutPanel();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            tlpTabla = new TableLayoutPanel();
            tlpBusqueda = new TableLayoutPanel();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvEquipos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colNumeroSerie = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colDisponible = new DataGridViewCheckBoxColumn();
            tlpPrincipal.SuspendLayout();
            flpEncabezado.SuspendLayout();
            tlpCampos.SuspendLayout();
            flpBotones.SuspendLayout();
            tlpTabla.SuspendLayout();
            tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(240, 243, 248);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(flpEncabezado, 0, 0);
            tlpPrincipal.Controls.Add(tlpCampos, 0, 1);
            tlpPrincipal.Controls.Add(tlpTabla, 0, 2);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(3, 3);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Padding = new Padding(28, 22, 28, 22);
            tlpPrincipal.RowCount = 3;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.AutoSize));
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
            lblTitulo.Text = "Gestion de equipos";
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
            lblSubtitulo.Text = "Registra, actualiza y consulta los equipos tecnologicos de la biblioteca.";
            // 
            // tlpCampos
            // 
            tlpCampos.AutoSize = true;
            tlpCampos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpCampos.BackColor = Color.White;
            tlpCampos.ColumnCount = 4;
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCampos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCampos.Controls.Add(lblCodigo, 0, 0);
            tlpCampos.Controls.Add(txtCodigo, 0, 1);
            tlpCampos.Controls.Add(lblNombre, 1, 0);
            tlpCampos.Controls.Add(txtNombre, 1, 1);
            tlpCampos.Controls.Add(lblMarca, 2, 0);
            tlpCampos.Controls.Add(txtMarca, 2, 1);
            tlpCampos.Controls.Add(lblModelo, 3, 0);
            tlpCampos.Controls.Add(txtModelo, 3, 1);
            tlpCampos.Controls.Add(lblNumeroSerie, 0, 2);
            tlpCampos.Controls.Add(txtNumeroSerie, 0, 3);
            tlpCampos.Controls.Add(lblDescripcion, 1, 2);
            tlpCampos.Controls.Add(txtDescripcion, 1, 3);
            tlpCampos.Controls.Add(flpBotones, 0, 4);
            tlpCampos.SetColumnSpan(lblDescripcion, 3);
            tlpCampos.SetColumnSpan(txtDescripcion, 3);
            tlpCampos.SetColumnSpan(flpBotones, 4);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 3);
            tlpCampos.Margin = new Padding(0, 0, 0, 18);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.Padding = new Padding(22, 18, 22, 14);
            tlpCampos.RowCount = 5;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.Size = new Size(1044, 200);
            tlpCampos.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Left;
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(55, 65, 81);
            lblCodigo.Location = new Point(3, 3);
            lblCodigo.Margin = new Padding(0, 0, 0, 4);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(80, 23);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Dock = DockStyle.Fill;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(3, 3);
            txtCodigo.Margin = new Padding(0, 0, 14, 12);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Left;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(55, 65, 81);
            lblNombre.Location = new Point(3, 3);
            lblNombre.Margin = new Padding(0, 0, 0, 4);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Dock = DockStyle.Fill;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(3, 3);
            txtNombre.Margin = new Padding(0, 0, 14, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Left;
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMarca.ForeColor = Color.FromArgb(55, 65, 81);
            lblMarca.Location = new Point(3, 3);
            lblMarca.Margin = new Padding(0, 0, 0, 4);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(80, 23);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Dock = DockStyle.Fill;
            txtMarca.Font = new Font("Segoe UI", 10F);
            txtMarca.Location = new Point(3, 3);
            txtMarca.Margin = new Padding(0, 0, 14, 12);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(150, 27);
            txtMarca.TabIndex = 5;
            // 
            // lblModelo
            // 
            lblModelo.Anchor = AnchorStyles.Left;
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblModelo.ForeColor = Color.FromArgb(55, 65, 81);
            lblModelo.Location = new Point(3, 3);
            lblModelo.Margin = new Padding(0, 0, 0, 4);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(80, 23);
            lblModelo.TabIndex = 6;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.BorderStyle = BorderStyle.FixedSingle;
            txtModelo.Dock = DockStyle.Fill;
            txtModelo.Font = new Font("Segoe UI", 10F);
            txtModelo.Location = new Point(3, 3);
            txtModelo.Margin = new Padding(0, 0, 14, 12);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(150, 27);
            txtModelo.TabIndex = 7;
            // 
            // lblNumeroSerie
            // 
            lblNumeroSerie.Anchor = AnchorStyles.Left;
            lblNumeroSerie.AutoSize = true;
            lblNumeroSerie.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNumeroSerie.ForeColor = Color.FromArgb(55, 65, 81);
            lblNumeroSerie.Location = new Point(3, 3);
            lblNumeroSerie.Margin = new Padding(0, 0, 0, 4);
            lblNumeroSerie.Name = "lblNumeroSerie";
            lblNumeroSerie.Size = new Size(80, 23);
            lblNumeroSerie.TabIndex = 8;
            lblNumeroSerie.Text = "Numero de serie";
            // 
            // txtNumeroSerie
            // 
            txtNumeroSerie.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroSerie.Dock = DockStyle.Fill;
            txtNumeroSerie.Font = new Font("Segoe UI", 10F);
            txtNumeroSerie.Location = new Point(3, 3);
            txtNumeroSerie.Margin = new Padding(0, 0, 14, 12);
            txtNumeroSerie.Name = "txtNumeroSerie";
            txtNumeroSerie.Size = new Size(150, 27);
            txtNumeroSerie.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Left;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(55, 65, 81);
            lblDescripcion.Location = new Point(3, 3);
            lblDescripcion.Margin = new Padding(0, 0, 0, 4);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 23);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(3, 3);
            txtDescripcion.Margin = new Padding(0, 0, 14, 12);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 27);
            txtDescripcion.TabIndex = 11;
            // 
            // flpBotones
            // 
            flpBotones.AutoSize = true;
            flpBotones.Controls.Add(btnRegistrar);
            flpBotones.Controls.Add(btnActualizar);
            flpBotones.Controls.Add(btnEliminar);
            flpBotones.Controls.Add(btnLimpiar);
            flpBotones.Dock = DockStyle.Fill;
            flpBotones.Location = new Point(3, 3);
            flpBotones.Margin = new Padding(0, 4, 0, 0);
            flpBotones.Name = "flpBotones";
            flpBotones.Size = new Size(1000, 42);
            flpBotones.TabIndex = 12;
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
            btnRegistrar.Size = new Size(125, 38);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(22, 163, 74);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 146, 66);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(3, 3);
            btnActualizar.Margin = new Padding(0, 0, 12, 0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 38);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 34, 34);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(3, 3);
            btnEliminar.Margin = new Padding(0, 0, 12, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnLimpiar.Size = new Size(125, 38);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tlpTabla
            // 
            tlpTabla.BackColor = Color.White;
            tlpTabla.ColumnCount = 1;
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabla.Controls.Add(tlpBusqueda, 0, 0);
            tlpTabla.Controls.Add(dgvEquipos, 0, 1);
            tlpTabla.Dock = DockStyle.Fill;
            tlpTabla.Location = new Point(3, 3);
            tlpTabla.Margin = new Padding(0);
            tlpTabla.Name = "tlpTabla";
            tlpTabla.Padding = new Padding(22, 18, 22, 18);
            tlpTabla.RowCount = 2;
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpTabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTabla.Size = new Size(1044, 400);
            tlpTabla.TabIndex = 2;
            // 
            // tlpBusqueda
            // 
            tlpBusqueda.AutoSize = true;
            tlpBusqueda.ColumnCount = 4;
            tlpBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlpBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlpBusqueda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tlpBusqueda.Controls.Add(lblBuscar, 0, 0);
            tlpBusqueda.Controls.Add(txtBuscar, 1, 0);
            tlpBusqueda.Controls.Add(btnBuscar, 2, 0);
            tlpBusqueda.Dock = DockStyle.Fill;
            tlpBusqueda.Location = new Point(3, 3);
            tlpBusqueda.Margin = new Padding(0, 0, 0, 14);
            tlpBusqueda.Name = "tlpBusqueda";
            tlpBusqueda.RowCount = 1;
            tlpBusqueda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpBusqueda.Size = new Size(1000, 38);
            tlpBusqueda.TabIndex = 0;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.Left;
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(55, 65, 81);
            lblBuscar.Location = new Point(3, 3);
            lblBuscar.Margin = new Padding(0, 0, 0, 4);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(80, 23);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar equipo por codigo:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.Location = new Point(3, 3);
            txtBuscar.Margin = new Padding(0, 0, 10, 0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.BackColor = Color.FromArgb(37, 99, 235);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 89, 211);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(3, 3);
            btnBuscar.Margin = new Padding(0, 0, 10, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 34);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.AllowUserToAddRows = false;
            dgvEquipos.AllowUserToDeleteRows = false;
            dgvEquipos.AllowUserToResizeRows = false;
            dgvEquipos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvEquipos.AutoGenerateColumns = false;
            dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEquipos.BackgroundColor = Color.White;
            dgvEquipos.BorderStyle = BorderStyle.None;
            dgvEquipos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEquipos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipos.ColumnHeadersHeight = 40;
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEquipos.Columns.AddRange(new DataGridViewColumn[] {
                colCodigo,
                colNombre,
                colMarca,
                colModelo,
                colNumeroSerie,
                colDescripcion,
                colDisponible});
            dgvEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEquipos.Dock = DockStyle.Fill;
            dgvEquipos.EnableHeadersVisualStyles = false;
            dgvEquipos.GridColor = Color.FromArgb(229, 231, 235);
            dgvEquipos.Location = new Point(3, 3);
            dgvEquipos.MultiSelect = false;
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.ReadOnly = true;
            dgvEquipos.RowHeadersVisible = false;
            dgvEquipos.RowTemplate.Height = 32;
            dgvEquipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipos.Size = new Size(1000, 300);
            dgvEquipos.TabIndex = 1;
            dgvEquipos.CellClick += dgvEquipos_CellClick;
            // 
            // estilos de dgvEquipos
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
            // colCodigo
            // 
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.FillWeight = 80F;
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "Codigo";
            colCodigo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.FillWeight = 130F;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "Nombre";
            colNombre.ReadOnly = true;
            // 
            // colMarca
            // 
            colMarca.DataPropertyName = "Marca";
            colMarca.FillWeight = 100F;
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "Marca";
            colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            colModelo.DataPropertyName = "Modelo";
            colModelo.FillWeight = 100F;
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "Modelo";
            colModelo.ReadOnly = true;
            // 
            // colNumeroSerie
            // 
            colNumeroSerie.DataPropertyName = "NumeroSerie";
            colNumeroSerie.FillWeight = 110F;
            colNumeroSerie.HeaderText = "Numero de serie";
            colNumeroSerie.MinimumWidth = 6;
            colNumeroSerie.Name = "NumeroSerie";
            colNumeroSerie.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.DataPropertyName = "Descripcion";
            colDescripcion.FillWeight = 150F;
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "Descripcion";
            colDescripcion.ReadOnly = true;
            // 
            // colDisponible
            // 
            colDisponible.DataPropertyName = "Disponible";
            colDisponible.FillWeight = 70F;
            colDisponible.HeaderText = "Disponible";
            colDisponible.MinimumWidth = 6;
            colDisponible.Name = "Disponible";
            colDisponible.ReadOnly = true;
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1100, 720);
            Controls.Add(tlpPrincipal);
            MinimumSize = new Size(820, 560);
            Name = "FrmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Gestion de equipos";
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            tlpBusqueda.ResumeLayout(false);
            tlpBusqueda.PerformLayout();
            tlpTabla.ResumeLayout(false);
            tlpTabla.PerformLayout();
            flpBotones.ResumeLayout(false);
            flpBotones.PerformLayout();
            tlpCampos.ResumeLayout(false);
            tlpCampos.PerformLayout();
            flpEncabezado.ResumeLayout(false);
            flpEncabezado.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }
    }
}
