namespace BiblioStock.Formularios
{
    partial class FrmLibros
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
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtPaginas;
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
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
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
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblEditorial = new Label();
            txtEditorial = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblPaginas = new Label();
            txtPaginas = new TextBox();
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
            dgvLibros = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colAutor = new DataGridViewTextBoxColumn();
            colEditorial = new DataGridViewTextBoxColumn();
            colISBN = new DataGridViewTextBoxColumn();
            colPaginas = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colDisponible = new DataGridViewCheckBoxColumn();
            tlpPrincipal.SuspendLayout();
            flpEncabezado.SuspendLayout();
            tlpCampos.SuspendLayout();
            flpBotones.SuspendLayout();
            tlpTabla.SuspendLayout();
            tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
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
            lblTitulo.Text = "Gestion de libros";
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
            lblSubtitulo.Text = "Registra, actualiza y consulta los libros de la biblioteca.";
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
            tlpCampos.Controls.Add(lblAutor, 2, 0);
            tlpCampos.Controls.Add(txtAutor, 2, 1);
            tlpCampos.Controls.Add(lblEditorial, 3, 0);
            tlpCampos.Controls.Add(txtEditorial, 3, 1);
            tlpCampos.Controls.Add(lblISBN, 0, 2);
            tlpCampos.Controls.Add(txtISBN, 0, 3);
            tlpCampos.Controls.Add(lblPaginas, 1, 2);
            tlpCampos.Controls.Add(txtPaginas, 1, 3);
            tlpCampos.Controls.Add(lblDescripcion, 2, 2);
            tlpCampos.Controls.Add(txtDescripcion, 2, 3);
            tlpCampos.Controls.Add(flpBotones, 0, 4);
            tlpCampos.SetColumnSpan(lblDescripcion, 2);
            tlpCampos.SetColumnSpan(txtDescripcion, 2);
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
            lblNombre.Text = "Titulo";
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
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Left;
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAutor.ForeColor = Color.FromArgb(55, 65, 81);
            lblAutor.Location = new Point(3, 3);
            lblAutor.Margin = new Padding(0, 0, 0, 4);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(80, 23);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.BorderStyle = BorderStyle.FixedSingle;
            txtAutor.Dock = DockStyle.Fill;
            txtAutor.Font = new Font("Segoe UI", 10F);
            txtAutor.Location = new Point(3, 3);
            txtAutor.Margin = new Padding(0, 0, 14, 12);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 27);
            txtAutor.TabIndex = 5;
            // 
            // lblEditorial
            // 
            lblEditorial.Anchor = AnchorStyles.Left;
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEditorial.ForeColor = Color.FromArgb(55, 65, 81);
            lblEditorial.Location = new Point(3, 3);
            lblEditorial.Margin = new Padding(0, 0, 0, 4);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(80, 23);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial";
            // 
            // txtEditorial
            // 
            txtEditorial.BorderStyle = BorderStyle.FixedSingle;
            txtEditorial.Dock = DockStyle.Fill;
            txtEditorial.Font = new Font("Segoe UI", 10F);
            txtEditorial.Location = new Point(3, 3);
            txtEditorial.Margin = new Padding(0, 0, 14, 12);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(150, 27);
            txtEditorial.TabIndex = 7;
            // 
            // lblISBN
            // 
            lblISBN.Anchor = AnchorStyles.Left;
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblISBN.ForeColor = Color.FromArgb(55, 65, 81);
            lblISBN.Location = new Point(3, 3);
            lblISBN.Margin = new Padding(0, 0, 0, 4);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(80, 23);
            lblISBN.TabIndex = 8;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Dock = DockStyle.Fill;
            txtISBN.Font = new Font("Segoe UI", 10F);
            txtISBN.Location = new Point(3, 3);
            txtISBN.Margin = new Padding(0, 0, 14, 12);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(150, 27);
            txtISBN.TabIndex = 9;
            // 
            // lblPaginas
            // 
            lblPaginas.Anchor = AnchorStyles.Left;
            lblPaginas.AutoSize = true;
            lblPaginas.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaginas.ForeColor = Color.FromArgb(55, 65, 81);
            lblPaginas.Location = new Point(3, 3);
            lblPaginas.Margin = new Padding(0, 0, 0, 4);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(80, 23);
            lblPaginas.TabIndex = 10;
            lblPaginas.Text = "Numero de paginas";
            // 
            // txtPaginas
            // 
            txtPaginas.BorderStyle = BorderStyle.FixedSingle;
            txtPaginas.Dock = DockStyle.Fill;
            txtPaginas.Font = new Font("Segoe UI", 10F);
            txtPaginas.Location = new Point(3, 3);
            txtPaginas.Margin = new Padding(0, 0, 14, 12);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(150, 27);
            txtPaginas.TabIndex = 11;
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
            lblDescripcion.TabIndex = 12;
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
            txtDescripcion.TabIndex = 13;
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
            flpBotones.TabIndex = 14;
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
            tlpTabla.Controls.Add(dgvLibros, 0, 1);
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
            lblBuscar.Text = "Buscar libro por codigo:";
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
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AllowUserToResizeRows = false;
            dgvLibros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvLibros.AutoGenerateColumns = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.BorderStyle = BorderStyle.None;
            dgvLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLibros.ColumnHeadersHeight = 40;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] {
                colCodigo,
                colTitulo,
                colAutor,
                colEditorial,
                colISBN,
                colPaginas,
                colDescripcion,
                colDisponible});
            dgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.EnableHeadersVisualStyles = false;
            dgvLibros.GridColor = Color.FromArgb(229, 231, 235);
            dgvLibros.Location = new Point(3, 3);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowHeadersVisible = false;
            dgvLibros.RowTemplate.Height = 32;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(1000, 300);
            dgvLibros.TabIndex = 1;
            dgvLibros.CellClick += dgvLibros_CellClick;
            // 
            // estilos de dgvLibros
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
            // colTitulo
            // 
            colTitulo.DataPropertyName = "Nombre";
            colTitulo.FillWeight = 130F;
            colTitulo.HeaderText = "Titulo";
            colTitulo.MinimumWidth = 6;
            colTitulo.Name = "Nombre";
            colTitulo.ReadOnly = true;
            // 
            // colAutor
            // 
            colAutor.DataPropertyName = "Autor";
            colAutor.FillWeight = 110F;
            colAutor.HeaderText = "Autor";
            colAutor.MinimumWidth = 6;
            colAutor.Name = "Autor";
            colAutor.ReadOnly = true;
            // 
            // colEditorial
            // 
            colEditorial.DataPropertyName = "Editorial";
            colEditorial.FillWeight = 100F;
            colEditorial.HeaderText = "Editorial";
            colEditorial.MinimumWidth = 6;
            colEditorial.Name = "Editorial";
            colEditorial.ReadOnly = true;
            // 
            // colISBN
            // 
            colISBN.DataPropertyName = "ISBN";
            colISBN.FillWeight = 100F;
            colISBN.HeaderText = "ISBN";
            colISBN.MinimumWidth = 6;
            colISBN.Name = "ISBN";
            colISBN.ReadOnly = true;
            // 
            // colPaginas
            // 
            colPaginas.DataPropertyName = "Paginas";
            colPaginas.FillWeight = 60F;
            colPaginas.HeaderText = "Paginas";
            colPaginas.MinimumWidth = 6;
            colPaginas.Name = "Paginas";
            colPaginas.ReadOnly = true;
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
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1100, 720);
            Controls.Add(tlpPrincipal);
            MinimumSize = new Size(820, 560);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Gestion de libros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
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
