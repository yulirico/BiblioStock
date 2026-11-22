
namespace BiblioStock.Formularios
{
    partial class FrmInventario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBuscar;

        private System.Windows.Forms.TextBox txtBuscar;

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.DataGridView dgvInventario;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();

            this.txtBuscar = new System.Windows.Forms.TextBox();

            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();

            this.dgvInventario = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();

            // FORMULARIO
            this.Text = "Inventario general";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // TITULO
            this.lblTitulo.Text = "INVENTARIO GENERAL";
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);

            // SUBTITULO
            this.lblSubtitulo.Text =
                "Consulta los libros y equipos registrados en la biblioteca.";
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 65);
            this.lblSubtitulo.Size = new System.Drawing.Size(600, 25);

            // BUSCAR
            this.lblBuscar.Text = "Buscar recurso por codigo:";
            this.lblBuscar.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.Location = new System.Drawing.Point(30, 120);
            this.lblBuscar.Size = new System.Drawing.Size(250, 25);

            this.txtBuscar.Location = new System.Drawing.Point(30, 150);
            this.txtBuscar.Size = new System.Drawing.Size(300, 30);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);

            // BOTON BUSCAR
            ConfigurarBoton(
                this.btnBuscar,
                "Buscar",
                350,
                148,
                System.Drawing.Color.FromArgb(37, 99, 235)
            );

            this.btnBuscar.Click +=
                new System.EventHandler(this.btnBuscar_Click);

            // BOTON MOSTRAR TODOS
            ConfigurarBoton(
                this.btnMostrarTodos,
                "Mostrar todos",
                490,
                148,
                System.Drawing.Color.FromArgb(107, 114, 128)
            );

            this.btnMostrarTodos.Click +=
                new System.EventHandler(this.btnMostrarTodos_Click);

            // BOTON ACTUALIZAR
            ConfigurarBoton(
                this.btnActualizar,
                "Actualizar",
                650,
                148,
                System.Drawing.Color.FromArgb(22, 163, 74)
            );

            this.btnActualizar.Click +=
                new System.EventHandler(this.btnActualizar_Click);

            // TABLA
            this.dgvInventario.Location = new System.Drawing.Point(30, 220);
            this.dgvInventario.Size = new System.Drawing.Size(1020, 400);
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.AutoSizeRowsMode =
                System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;

            // AGREGAR CONTROLES
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvInventario);

            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarBoton(
            System.Windows.Forms.Button boton,
            string texto,
            int x,
            int y,
            System.Drawing.Color color)
        {
            boton.Text = texto;
            boton.Location = new System.Drawing.Point(x, y);
            boton.Size = new System.Drawing.Size(130, 38);
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
