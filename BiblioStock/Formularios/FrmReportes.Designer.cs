
namespace BiblioStock.Formularios
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblDevueltos;
        private System.Windows.Forms.Label lblVencidos;

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnActivos;
        private System.Windows.Forms.Button btnDevueltos;
        private System.Windows.Forms.Button btnVencidos;
        private System.Windows.Forms.Button btnActualizar;

        private System.Windows.Forms.DataGridView dgvReportes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblDevueltos = new System.Windows.Forms.Label();
            this.lblVencidos = new System.Windows.Forms.Label();

            this.btnTodos = new System.Windows.Forms.Button();
            this.btnActivos = new System.Windows.Forms.Button();
            this.btnDevueltos = new System.Windows.Forms.Button();
            this.btnVencidos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();

            this.dgvReportes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();

            // FORMULARIO
            this.Text = "Reportes de prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1150, 760);
            this.MinimumSize = new System.Drawing.Size(1150, 760);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // TITULO
            this.lblTitulo.Text = "REPORTES DE PRESTAMOS";
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Size = new System.Drawing.Size(600, 40);

            // RESUMEN
            ConfigurarResumen(this.lblTotal, "Total de prestamos: 0", 30, 90,
                System.Drawing.Color.FromArgb(37, 99, 235));

            ConfigurarResumen(this.lblActivos, "Prestamos activos: 0", 300, 90,
                System.Drawing.Color.FromArgb(217, 119, 6));

            ConfigurarResumen(this.lblDevueltos, "Prestamos devueltos: 0", 570, 90,
                System.Drawing.Color.FromArgb(22, 163, 74));

            ConfigurarResumen(this.lblVencidos, "Prestamos vencidos: 0", 840, 90,
                System.Drawing.Color.FromArgb(220, 38, 38));

            // BOTON TODOS
            ConfigurarBoton(this.btnTodos, "Todos", 30, 165,
                System.Drawing.Color.FromArgb(37, 99, 235));

            this.btnTodos.Click +=
                new System.EventHandler(this.btnTodos_Click);

            // BOTON ACTIVOS
            ConfigurarBoton(this.btnActivos, "Activos", 175, 165,
                System.Drawing.Color.FromArgb(217, 119, 6));

            this.btnActivos.Click +=
                new System.EventHandler(this.btnActivos_Click);

            // BOTON DEVUELTOS
            ConfigurarBoton(this.btnDevueltos, "Devueltos", 320, 165,
                System.Drawing.Color.FromArgb(22, 163, 74));

            this.btnDevueltos.Click +=
                new System.EventHandler(this.btnDevueltos_Click);

            // BOTON VENCIDOS
            ConfigurarBoton(this.btnVencidos, "Vencidos", 465, 165,
                System.Drawing.Color.FromArgb(220, 38, 38));

            this.btnVencidos.Click +=
                new System.EventHandler(this.btnVencidos_Click);

            // BOTON ACTUALIZAR
            ConfigurarBoton(this.btnActualizar, "Actualizar", 610, 165,
                System.Drawing.Color.FromArgb(107, 114, 128));

            this.btnActualizar.Click +=
                new System.EventHandler(this.btnActualizar_Click);

            // TABLA
            this.dgvReportes.Location = new System.Drawing.Point(30, 235);
            this.dgvReportes.Size = new System.Drawing.Size(1070, 430);
            this.dgvReportes.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.MultiSelect = false;
            this.dgvReportes.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.RowHeadersVisible = false;

            // AGREGAR CONTROLES
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblActivos);
            this.Controls.Add(this.lblDevueltos);
            this.Controls.Add(this.lblVencidos);

            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnActivos);
            this.Controls.Add(this.btnDevueltos);
            this.Controls.Add(this.btnVencidos);
            this.Controls.Add(this.btnActualizar);

            this.Controls.Add(this.dgvReportes);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ConfigurarResumen(
            System.Windows.Forms.Label etiqueta,
            string texto,
            int x,
            int y,
            System.Drawing.Color color)
        {
            etiqueta.Text = texto;
            etiqueta.Location = new System.Drawing.Point(x, y);
            etiqueta.Size = new System.Drawing.Size(250, 45);
            etiqueta.BackColor = color;
            etiqueta.ForeColor = System.Drawing.Color.White;
            etiqueta.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            etiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            boton.Size = new System.Drawing.Size(130, 40);
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
