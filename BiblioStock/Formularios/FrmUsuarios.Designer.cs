
namespace BiblioStock.Formularios
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblBuscar;

        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvUsuarios;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();

            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.dgvUsuarios = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();

            // FORMULARIO
            this.Text = "Gestion de usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1100, 720);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.MinimumSize = new System.Drawing.Size(1100, 720);

            // TITULO
            this.lblTitulo.Text = "GESTION DE USUARIOS";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);

            // ETIQUETAS
            ConfigurarEtiqueta(this.lblIdentificacion, "Identificacion:", 30, 100);
            ConfigurarEtiqueta(this.lblNombre, "Nombre completo:", 30, 180);
            ConfigurarEtiqueta(this.lblCorreo, "Correo electronico:", 30, 260);
            ConfigurarEtiqueta(this.lblTelefono, "Telefono:", 30, 340);
            ConfigurarEtiqueta(this.lblBuscar, "Buscar por identificacion:", 30, 470);

            // CAMPOS
            ConfigurarCampo(this.txtIdentificacion, 30, 125);
            ConfigurarCampo(this.txtNombre, 30, 205);
            ConfigurarCampo(this.txtCorreo, 30, 285);
            ConfigurarCampo(this.txtTelefono, 30, 365);
            ConfigurarCampo(this.txtBuscar, 30, 495);

            // BOTONES
            ConfigurarBoton(this.btnRegistrar, "Registrar", 30, 410,
                System.Drawing.Color.FromArgb(37, 99, 235));
            ConfigurarBoton(this.btnActualizar, "Actualizar", 155, 410,
                System.Drawing.Color.FromArgb(22, 163, 74));
            ConfigurarBoton(this.btnEliminar, "Eliminar", 30, 545,
                System.Drawing.Color.FromArgb(220, 38, 38));
            ConfigurarBoton(this.btnLimpiar, "Limpiar", 155, 545,
                System.Drawing.Color.FromArgb(107, 114, 128));
            ConfigurarBoton(this.btnBuscar, "Buscar", 250, 493,
                System.Drawing.Color.FromArgb(37, 99, 235));

            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // TABLA
            this.dgvUsuarios.Location = new System.Drawing.Point(430, 100);
            this.dgvUsuarios.Size = new System.Drawing.Size(630, 520);
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            // AGREGAR CONTROLES
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblBuscar);

            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtBuscar);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);

            this.Controls.Add(this.dgvUsuarios);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
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

        private void ConfigurarCampo(
            System.Windows.Forms.TextBox campo, int x, int y)
        {
            campo.Location = new System.Drawing.Point(x, y);
            campo.Size = new System.Drawing.Size(350, 30);
            campo.Font = new System.Drawing.Font("Segoe UI", 10F);
        }

        private void ConfigurarBoton(
            System.Windows.Forms.Button boton,
            string texto, int x, int y,
            System.Drawing.Color color)
        {
            boton.Text = texto;
            boton.Location = new System.Drawing.Point(x, y);
            boton.Size = new System.Drawing.Size(110, 38);
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
