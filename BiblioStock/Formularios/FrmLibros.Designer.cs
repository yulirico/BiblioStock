
namespace BiblioStock.Formularios
{
    partial class FrmLibros
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.Label lblBuscar;

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvLibros;

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
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();

            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();

            this.dgvLibros = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();

            // FrmLibros
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiblioStock - Gestion de libros";

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(24, 42, 72);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Text = "Gestion de libros";

            // Etiquetas
            ConfigurarEtiqueta(this.lblCodigo, "Codigo", 35, 95);
            ConfigurarEtiqueta(this.lblNombre, "Titulo", 35, 160);
            ConfigurarEtiqueta(this.lblDescripcion, "Descripcion", 35, 225);
            ConfigurarEtiqueta(this.lblAutor, "Autor", 35, 290);
            ConfigurarEtiqueta(this.lblEditorial, "Editorial", 35, 355);
            ConfigurarEtiqueta(this.lblISBN, "ISBN", 35, 420);
            ConfigurarEtiqueta(this.lblPaginas, "Numero de paginas", 35, 485);

            // Campos
            ConfigurarCampo(this.txtCodigo, 190, 92);
            ConfigurarCampo(this.txtNombre, 190, 157);
            ConfigurarCampo(this.txtDescripcion, 190, 222);
            ConfigurarCampo(this.txtAutor, 190, 287);
            ConfigurarCampo(this.txtEditorial, 190, 352);
            ConfigurarCampo(this.txtISBN, 190, 417);
            ConfigurarCampo(this.txtPaginas, 190, 482);

            // Busqueda
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(560, 35);
            this.lblBuscar.Text = "Buscar libro por codigo:";

            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(750, 32);
            this.txtBuscar.Size = new System.Drawing.Size(180, 27);

            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(945, 30);
            this.btnBuscar.Size = new System.Drawing.Size(100, 32);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // Botones
            ConfigurarBoton(this.btnRegistrar, "Registrar", 35, 550);
            ConfigurarBoton(this.btnActualizar, "Actualizar", 150, 550);
            ConfigurarBoton(this.btnEliminar, "Eliminar", 265, 550);
            ConfigurarBoton(this.btnLimpiar, "Limpiar", 380, 550);

            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // dgvLibros
            this.dgvLibros.Location = new System.Drawing.Point(560, 85);
            this.dgvLibros.Size = new System.Drawing.Size(490, 560);
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.AutoGenerateColumns = true;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);

            // Agregar controles
            this.Controls.Add(this.lblTitulo);

            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblPaginas);

            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtPaginas);

            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);

            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);

            this.Controls.Add(this.dgvLibros);

            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
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
