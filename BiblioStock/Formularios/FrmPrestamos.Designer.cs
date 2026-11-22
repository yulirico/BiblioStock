
namespace BiblioStock.Formularios
{
    partial class FrmPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRecurso;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblCodigoPrestamo;

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbRecursos;

        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;

        private System.Windows.Forms.TextBox txtCodigoPrestamo;

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvPrestamos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRecurso = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblCodigoPrestamo = new System.Windows.Forms.Label();

            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbRecursos = new System.Windows.Forms.ComboBox();

            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();

            this.txtCodigoPrestamo = new System.Windows.Forms.TextBox();

            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.dgvPrestamos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();

            // FORMULARIO
            this.Text = "Gestion de prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1150, 760);
            this.MinimumSize = new System.Drawing.Size(1150, 760);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // TITULO
            this.lblTitulo.Text = "GESTION DE PRESTAMOS";
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);

            // ETIQUETAS
            ConfigurarEtiqueta(this.lblUsuario, "Usuario:", 30, 95);
            ConfigurarEtiqueta(this.lblRecurso, "Recurso:", 30, 165);
            ConfigurarEtiqueta(this.lblFechaPrestamo, "Fecha del prestamo:", 30, 235);
            ConfigurarEtiqueta(this.lblFechaDevolucion, "Fecha limite de devolucion:", 30, 305);
            ConfigurarEtiqueta(this.lblCodigoPrestamo, "Codigo del prestamo:", 30, 390);

            // COMBOBOX USUARIOS
            this.cmbUsuarios.Location = new System.Drawing.Point(30, 120);
            this.cmbUsuarios.Size = new System.Drawing.Size(350, 30);
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);

            // COMBOBOX RECURSOS
            this.cmbRecursos.Location = new System.Drawing.Point(30, 190);
            this.cmbRecursos.Size = new System.Drawing.Size(350, 30);
            this.cmbRecursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecursos.Font = new System.Drawing.Font("Segoe UI", 10F);

            // FECHA PRESTAMO
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(30, 260);
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(350, 30);
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // FECHA DEVOLUCION
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(30, 330);
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(350, 30);
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // CODIGO PRESTAMO
            this.txtCodigoPrestamo.Location = new System.Drawing.Point(30, 415);
            this.txtCodigoPrestamo.Size = new System.Drawing.Size(350, 30);
            this.txtCodigoPrestamo.ReadOnly = true;
            this.txtCodigoPrestamo.Font = new System.Drawing.Font("Segoe UI", 10F);

            // BOTONES
            ConfigurarBoton(this.btnRegistrar, "Registrar prestamo",
                30, 475, System.Drawing.Color.FromArgb(37, 99, 235));

            ConfigurarBoton(this.btnDevolver, "Registrar devolucion",
                200, 475, System.Drawing.Color.FromArgb(22, 163, 74));

            ConfigurarBoton(this.btnLimpiar, "Limpiar",
                30, 530, System.Drawing.Color.FromArgb(107, 114, 128));

            this.btnRegistrar.Size = new System.Drawing.Size(155, 40);
            this.btnDevolver.Size = new System.Drawing.Size(180, 40);

            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // TABLA DE PRESTAMOS
            this.dgvPrestamos.Location = new System.Drawing.Point(420, 100);
            this.dgvPrestamos.Size = new System.Drawing.Size(680, 540);
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestamos.RowHeadersVisible = false;

            this.dgvPrestamos.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.dgvPrestamos_CellClick);

            // AGREGAR CONTROLES
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblRecurso);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblCodigoPrestamo);

            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.cmbRecursos);

            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.dtpFechaDevolucion);

            this.Controls.Add(this.txtCodigoPrestamo);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnLimpiar);

            this.Controls.Add(this.dgvPrestamos);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarEtiqueta(
            System.Windows.Forms.Label etiqueta,
            string texto, int x, int y)
        {
            etiqueta.Text = texto;
            etiqueta.Location = new System.Drawing.Point(x, y);
            etiqueta.Size = new System.Drawing.Size(350, 22);
            etiqueta.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            etiqueta.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
        }

        private void ConfigurarBoton(
            System.Windows.Forms.Button boton,
            string texto, int x, int y,
            System.Drawing.Color color)
        {
            boton.Text = texto;
            boton.Location = new System.Drawing.Point(x, y);
            boton.Size = new System.Drawing.Size(150, 40);
            boton.BackColor = color;
            boton.ForeColor = System.Drawing.Color.White;
            boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            boton.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
