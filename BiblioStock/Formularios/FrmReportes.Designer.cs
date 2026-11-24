namespace BiblioStock.Formularios
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblDevueltos;
        private System.Windows.Forms.Label lblVencidos;
        private System.Windows.Forms.TableLayoutPanel tlpTabla;
        private System.Windows.Forms.FlowLayoutPanel flpFiltros;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnDevueltos;
        private System.Windows.Forms.Button btnVencidos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBibliotecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;

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
            tlpResumen = new TableLayoutPanel();
            lblTotal = new Label();
            lblActivos = new Label();
            lblDevueltos = new Label();
            lblVencidos = new Label();
            tlpTabla = new TableLayoutPanel();
            flpFiltros = new FlowLayoutPanel();
            btnTodos = new Button();
            btnActivos = new Button();
            btnDevueltos = new Button();
            btnVencidos = new Button();
            btnActualizar = new Button();
            dgvReportes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colRecurso = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colBibliotecario = new DataGridViewTextBoxColumn();
            colFechaPrestamo = new DataGridViewTextBoxColumn();
            colFechaDevolucion = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            tlpPrincipal.SuspendLayout();
            flpEncabezado.SuspendLayout();
            tlpResumen.SuspendLayout();
            tlpTabla.SuspendLayout();
            flpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.BackColor = Color.FromArgb(240, 243, 248);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrincipal.Controls.Add(flpEncabezado, 0, 0);
            tlpPrincipal.Controls.Add(tlpResumen, 0, 1);
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
            lblTitulo.Text = "Reportes de prestamos";
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
            lblSubtitulo.Text = "Resumen y detalle del estado de los prestamos registrados.";
            // 
            // tlpResumen
            // 
            tlpResumen.AutoSize = true;
            tlpResumen.ColumnCount = 4;
            tlpResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpResumen.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpResumen.Controls.Add(lblTotal, 0, 0);
            tlpResumen.Controls.Add(lblActivos, 1, 0);
            tlpResumen.Controls.Add(lblDevueltos, 2, 0);
            tlpResumen.Controls.Add(lblVencidos, 3, 0);
            tlpResumen.Dock = DockStyle.Fill;
            tlpResumen.Location = new Point(3, 3);
            tlpResumen.Margin = new Padding(0, 0, 0, 18);
            tlpResumen.Name = "tlpResumen";
            tlpResumen.RowCount = 1;
            tlpResumen.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tlpResumen.Size = new Size(1044, 64);
            tlpResumen.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.FromArgb(37, 99, 235);
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(3, 3);
            lblTotal.Margin = new Padding(0, 0, 16, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(250, 64);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de prestamos: 0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivos
            // 
            lblActivos.BackColor = Color.FromArgb(217, 119, 6);
            lblActivos.Dock = DockStyle.Fill;
            lblActivos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblActivos.ForeColor = Color.White;
            lblActivos.Location = new Point(3, 3);
            lblActivos.Margin = new Padding(0, 0, 16, 0);
            lblActivos.Name = "lblActivos";
            lblActivos.Size = new Size(250, 64);
            lblActivos.TabIndex = 1;
            lblActivos.Text = "Prestamos activos: 0";
            lblActivos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDevueltos
            // 
            lblDevueltos.BackColor = Color.FromArgb(22, 163, 74);
            lblDevueltos.Dock = DockStyle.Fill;
            lblDevueltos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDevueltos.ForeColor = Color.White;
            lblDevueltos.Location = new Point(3, 3);
            lblDevueltos.Margin = new Padding(0, 0, 16, 0);
            lblDevueltos.Name = "lblDevueltos";
            lblDevueltos.Size = new Size(250, 64);
            lblDevueltos.TabIndex = 2;
            lblDevueltos.Text = "Prestamos devueltos: 0";
            lblDevueltos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVencidos
            // 
            lblVencidos.BackColor = Color.FromArgb(220, 38, 38);
            lblVencidos.Dock = DockStyle.Fill;
            lblVencidos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblVencidos.ForeColor = Color.White;
            lblVencidos.Location = new Point(3, 3);
            lblVencidos.Margin = new Padding(0, 0, 0, 0);
            lblVencidos.Name = "lblVencidos";
            lblVencidos.Size = new Size(250, 64);
            lblVencidos.TabIndex = 3;
            lblVencidos.Text = "Prestamos vencidos: 0";
            lblVencidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTabla
            // 
            tlpTabla.BackColor = Color.White;
            tlpTabla.ColumnCount = 1;
            tlpTabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTabla.Controls.Add(flpFiltros, 0, 0);
            tlpTabla.Controls.Add(dgvReportes, 0, 1);
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
            // flpFiltros
            // 
            flpFiltros.AutoSize = true;
            flpFiltros.Controls.Add(btnTodos);
            flpFiltros.Controls.Add(btnActivos);
            flpFiltros.Controls.Add(btnDevueltos);
            flpFiltros.Controls.Add(btnVencidos);
            flpFiltros.Controls.Add(btnActualizar);
            flpFiltros.Dock = DockStyle.Fill;
            flpFiltros.Location = new Point(3, 3);
            flpFiltros.Margin = new Padding(0, 0, 0, 14);
            flpFiltros.Name = "flpFiltros";
            flpFiltros.Size = new Size(1000, 38);
            flpFiltros.TabIndex = 0;
            // 
            // btnTodos
            // 
            btnTodos.BackColor = Color.FromArgb(37, 99, 235);
            btnTodos.Cursor = Cursors.Hand;
            btnTodos.FlatAppearance.BorderSize = 0;
            btnTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 89, 211);
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTodos.ForeColor = Color.White;
            btnTodos.Location = new Point(3, 3);
            btnTodos.Margin = new Padding(0, 0, 12, 0);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(125, 38);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = false;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnActivos
            // 
            btnActivos.BackColor = Color.FromArgb(217, 119, 6);
            btnActivos.Cursor = Cursors.Hand;
            btnActivos.FlatAppearance.BorderSize = 0;
            btnActivos.FlatAppearance.MouseOverBackColor = Color.FromArgb(195, 107, 5);
            btnActivos.FlatStyle = FlatStyle.Flat;
            btnActivos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActivos.ForeColor = Color.White;
            btnActivos.Location = new Point(3, 3);
            btnActivos.Margin = new Padding(0, 0, 12, 0);
            btnActivos.Name = "btnActivos";
            btnActivos.Size = new Size(125, 38);
            btnActivos.TabIndex = 1;
            btnActivos.Text = "Activos";
            btnActivos.UseVisualStyleBackColor = false;
            btnActivos.Click += btnActivos_Click;
            // 
            // btnDevueltos
            // 
            btnDevueltos.BackColor = Color.FromArgb(22, 163, 74);
            btnDevueltos.Cursor = Cursors.Hand;
            btnDevueltos.FlatAppearance.BorderSize = 0;
            btnDevueltos.FlatAppearance.MouseOverBackColor = Color.FromArgb(19, 146, 66);
            btnDevueltos.FlatStyle = FlatStyle.Flat;
            btnDevueltos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDevueltos.ForeColor = Color.White;
            btnDevueltos.Location = new Point(3, 3);
            btnDevueltos.Margin = new Padding(0, 0, 12, 0);
            btnDevueltos.Name = "btnDevueltos";
            btnDevueltos.Size = new Size(125, 38);
            btnDevueltos.TabIndex = 2;
            btnDevueltos.Text = "Devueltos";
            btnDevueltos.UseVisualStyleBackColor = false;
            btnDevueltos.Click += btnDevueltos_Click;
            // 
            // btnVencidos
            // 
            btnVencidos.BackColor = Color.FromArgb(220, 38, 38);
            btnVencidos.Cursor = Cursors.Hand;
            btnVencidos.FlatAppearance.BorderSize = 0;
            btnVencidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(198, 34, 34);
            btnVencidos.FlatStyle = FlatStyle.Flat;
            btnVencidos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVencidos.ForeColor = Color.White;
            btnVencidos.Location = new Point(3, 3);
            btnVencidos.Margin = new Padding(0, 0, 12, 0);
            btnVencidos.Name = "btnVencidos";
            btnVencidos.Size = new Size(125, 38);
            btnVencidos.TabIndex = 3;
            btnVencidos.Text = "Vencidos";
            btnVencidos.UseVisualStyleBackColor = false;
            btnVencidos.Click += btnVencidos_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(107, 114, 128);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 102, 115);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(3, 3);
            btnActualizar.Margin = new Padding(0, 0, 12, 0);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(125, 38);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.AllowUserToResizeRows = false;
            dgvReportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReportes.AutoGenerateColumns = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReportes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.ColumnHeadersHeight = 40;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReportes.Columns.AddRange(new DataGridViewColumn[] {
                colCodigo,
                colUsuario,
                colRecurso,
                colTipo,
                colBibliotecario,
                colFechaPrestamo,
                colFechaDevolucion,
                colEstado});
            dgvReportes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.EnableHeadersVisualStyles = false;
            dgvReportes.GridColor = Color.FromArgb(229, 231, 235);
            dgvReportes.Location = new Point(3, 3);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowTemplate.Height = 32;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1000, 300);
            dgvReportes.TabIndex = 1;
            // 
            // estilos de dgvReportes
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
            colCodigo.FillWeight = 90F;
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "Codigo";
            colCodigo.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.DataPropertyName = "Usuario";
            colUsuario.FillWeight = 110F;
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "Usuario";
            colUsuario.ReadOnly = true;
            // 
            // colRecurso
            // 
            colRecurso.DataPropertyName = "Recurso";
            colRecurso.FillWeight = 120F;
            colRecurso.HeaderText = "Recurso";
            colRecurso.MinimumWidth = 6;
            colRecurso.Name = "Recurso";
            colRecurso.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.FillWeight = 55F;
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "Tipo";
            colTipo.ReadOnly = true;
            // 
            // colBibliotecario
            // 
            colBibliotecario.DataPropertyName = "Bibliotecario";
            colBibliotecario.FillWeight = 100F;
            colBibliotecario.HeaderText = "Bibliotecario";
            colBibliotecario.MinimumWidth = 6;
            colBibliotecario.Name = "Bibliotecario";
            colBibliotecario.ReadOnly = true;
            // 
            // colFechaPrestamo
            // 
            colFechaPrestamo.DataPropertyName = "FechaPrestamo";
            colFechaPrestamo.FillWeight = 85F;
            colFechaPrestamo.HeaderText = "Fecha prestamo";
            colFechaPrestamo.MinimumWidth = 6;
            colFechaPrestamo.Name = "FechaPrestamo";
            colFechaPrestamo.ReadOnly = true;
            // 
            // colFechaDevolucion
            // 
            colFechaDevolucion.DataPropertyName = "FechaDevolucion";
            colFechaDevolucion.FillWeight = 90F;
            colFechaDevolucion.HeaderText = "Fecha devolucion";
            colFechaDevolucion.MinimumWidth = 6;
            colFechaDevolucion.Name = "FechaDevolucion";
            colFechaDevolucion.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.DataPropertyName = "Estado";
            colEstado.FillWeight = 70F;
            colEstado.HeaderText = "Estado";
            colEstado.MinimumWidth = 6;
            colEstado.Name = "Estado";
            colEstado.ReadOnly = true;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1100, 720);
            Controls.Add(tlpPrincipal);
            MinimumSize = new Size(820, 560);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Reportes de prestamos";
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            flpFiltros.ResumeLayout(false);
            flpFiltros.PerformLayout();
            tlpTabla.ResumeLayout(false);
            tlpTabla.PerformLayout();
            tlpResumen.ResumeLayout(false);
            tlpResumen.PerformLayout();
            flpEncabezado.ResumeLayout(false);
            flpEncabezado.PerformLayout();
            tlpPrincipal.ResumeLayout(false);
            tlpPrincipal.PerformLayout();
            ResumeLayout(false);
        }
    }
}