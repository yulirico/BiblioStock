namespace BiblioStock.Formularios
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
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
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;

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
            lblIdentificacion = new Label();
            txtIdentificacion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
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
            dgvUsuarios = new DataGridView();
            colIdentificacion = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            tlpPrincipal.SuspendLayout();
            flpEncabezado.SuspendLayout();
            tlpCampos.SuspendLayout();
            flpBotones.SuspendLayout();
            tlpTabla.SuspendLayout();
            tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            lblTitulo.Text = "Gestion de usuarios";
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
            lblSubtitulo.Text = "Registra, actualiza y consulta los usuarios de la biblioteca.";
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
            tlpCampos.Controls.Add(lblIdentificacion, 0, 0);
            tlpCampos.Controls.Add(txtIdentificacion, 0, 1);
            tlpCampos.Controls.Add(lblNombre, 1, 0);
            tlpCampos.Controls.Add(txtNombre, 1, 1);
            tlpCampos.Controls.Add(lblCorreo, 2, 0);
            tlpCampos.Controls.Add(txtCorreo, 2, 1);
            tlpCampos.Controls.Add(lblTelefono, 3, 0);
            tlpCampos.Controls.Add(txtTelefono, 3, 1);
            tlpCampos.Controls.Add(flpBotones, 0, 2);
            tlpCampos.SetColumnSpan(flpBotones, 4);
            tlpCampos.Dock = DockStyle.Fill;
            tlpCampos.Location = new Point(3, 3);
            tlpCampos.Margin = new Padding(0, 0, 0, 18);
            tlpCampos.Name = "tlpCampos";
            tlpCampos.Padding = new Padding(22, 18, 22, 14);
            tlpCampos.RowCount = 3;
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpCampos.Size = new Size(1044, 200);
            tlpCampos.TabIndex = 1;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.Anchor = AnchorStyles.Left;
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblIdentificacion.ForeColor = Color.FromArgb(55, 65, 81);
            lblIdentificacion.Location = new Point(3, 3);
            lblIdentificacion.Margin = new Padding(0, 0, 0, 4);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(80, 23);
            lblIdentificacion.TabIndex = 0;
            lblIdentificacion.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.BorderStyle = BorderStyle.FixedSingle;
            txtIdentificacion.Dock = DockStyle.Fill;
            txtIdentificacion.Font = new Font("Segoe UI", 10F);
            txtIdentificacion.Location = new Point(3, 3);
            txtIdentificacion.Margin = new Padding(0, 0, 14, 12);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(150, 27);
            txtIdentificacion.TabIndex = 1;
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
            lblNombre.Text = "Nombre completo";
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
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.Left;
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCorreo.ForeColor = Color.FromArgb(55, 65, 81);
            lblCorreo.Location = new Point(3, 3);
            lblCorreo.Margin = new Padding(0, 0, 0, 4);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(80, 23);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo electronico";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Dock = DockStyle.Fill;
            txtCorreo.Font = new Font("Segoe UI", 10F);
            txtCorreo.Location = new Point(3, 3);
            txtCorreo.Margin = new Padding(0, 0, 14, 12);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 27);
            txtCorreo.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Left;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(55, 65, 81);
            lblTelefono.Location = new Point(3, 3);
            lblTelefono.Margin = new Padding(0, 0, 0, 4);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(80, 23);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Font = new Font("Segoe UI", 10F);
            txtTelefono.Location = new Point(3, 3);
            txtTelefono.Margin = new Padding(0, 0, 14, 12);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 27);
            txtTelefono.TabIndex = 7;
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
            flpBotones.TabIndex = 8;
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
            tlpTabla.Controls.Add(dgvUsuarios, 0, 1);
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
            lblBuscar.Text = "Buscar por identificacion:";
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
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 40;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] {
                colIdentificacion,
                colNombre,
                colCorreo,
                colTelefono});
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(229, 231, 235);
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1000, 300);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // estilos de dgvUsuarios
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
            // colIdentificacion
            // 
            colIdentificacion.DataPropertyName = "Identificacion";
            colIdentificacion.FillWeight = 80F;
            colIdentificacion.HeaderText = "Identificacion";
            colIdentificacion.MinimumWidth = 6;
            colIdentificacion.Name = "Identificacion";
            colIdentificacion.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.FillWeight = 130F;
            colNombre.HeaderText = "Nombre completo";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "Nombre";
            colNombre.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.DataPropertyName = "Correo";
            colCorreo.FillWeight = 130F;
            colCorreo.HeaderText = "Correo electronico";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "Correo";
            colCorreo.ReadOnly = true;
            // 
            // colTelefono
            // 
            colTelefono.DataPropertyName = "Telefono";
            colTelefono.FillWeight = 80F;
            colTelefono.HeaderText = "Telefono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "Telefono";
            colTelefono.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1100, 720);
            Controls.Add(tlpPrincipal);
            MinimumSize = new Size(820, 560);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Gestion de usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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