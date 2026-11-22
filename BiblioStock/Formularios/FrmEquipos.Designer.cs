
namespace BiblioStock.Formularios
{
    partial class FrmEquipos
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblNumeroSerie;
        private System.Windows.Forms.Label lblBuscar;

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvEquipos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblNumeroSerie = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();

            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.dgvEquipos = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();

            // FrmEquipos
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioStock - Gestion de equipos";

            // Titulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 42, 72);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Text = "Gestion de equipos";

            // Etiquetas
            ConfigurarEtiqueta(this.lblCodigo, "Codigo", 35, 95);
            ConfigurarEtiqueta(this.lblNombre, "Nombre", 35, 160);
            ConfigurarEtiqueta(this.lblDescripcion, "Descripcion", 35, 225);
            ConfigurarEtiqueta(this.lblMarca, "Marca", 35, 290);
            ConfigurarEtiqueta(this.lblModelo, "Modelo", 35, 355);
            ConfigurarEtiqueta(this.lblNumeroSerie, "Numero de serie", 35, 420);

            // Campos
            ConfigurarCampo(this.txtCodigo, 190, 92);
            ConfigurarCampo(this.txtNombre, 190, 157);
            ConfigurarCampo(this.txtDescripcion, 190, 222);
            ConfigurarCampo(this.txtMarca, 190, 287);
            ConfigurarCampo(this.txtModelo, 190, 352);
            ConfigurarCampo(this.txtNumeroSerie, 190, 417);

            // Busqueda
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(560, 35);
            this.lblBuscar.Text = "Buscar equipo por codigo:";

            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(750, 32);
            this.txtBuscar.Size = new System.Drawing.Size(180, 27);

            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(945, 30);
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // Botones
            ConfigurarBoton(this.btnRegistrar, "Registrar", 35, 500);
            ConfigurarBoton(this.btnActualizar, "Actualizar", 150, 500);
            ConfigurarBoton(this.btnEliminar, "Eliminar", 265, 500);
            ConfigurarBoton(this.btnLimpiar, "Limpiar", 380, 500);

            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // dgvEquipos
            this.dgvEquipos.Location = new System.Drawing.Point(560, 85);
            this.dgvEquipos.Size = new System.Drawing.Size(490, 560);
            this.dgvEquipos.BackgroundColor = System.Drawing.Color.White;
            this.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.MultiSelect = false;
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.RowHeadersVisible = false;
            this.dgvEquipos.AutoGenerateColumns = true;
            this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);

            // Agregar controles
            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNumeroSerie);

            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtNumeroSerie);

            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);

            this.Controls.Add(this.dgvEquipos);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarEtiqueta(
            System.Windows.Forms.Label etiqueta,
            string texto,
            int x,
            int y)
        {
            etiqueta.AutoSize = true;
            etiqueta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            etiqueta.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            etiqueta.Location = new System.Drawing.Point(x, y);
            etiqueta.Text = texto;
        }

        private void ConfigurarCampo(
            System.Windows.Forms.TextBox campo,
            int x,
            int y)
        {
            campo.Font = new System.Drawing.Font("Segoe UI", 10F);
            campo.Location = new System.Drawing.Point(x, y);
            campo.Size = new System.Drawing.Size(300, 27);
        }

        private void ConfigurarBoton(
            System.Windows.Forms.Button boton,
            string texto,
            int x,
            int y)
        {
            boton.Text = texto;
            boton.Location = new System.Drawing.Point(x, y);
            boton.Size = new System.Drawing.Size(105, 42);
            boton.BackColor = System.Drawing.Color.FromArgb(24, 42, 72);
            boton.ForeColor = System.Drawing.Color.White;
            boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            boton.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
