namespace BiblioStock.Formularios
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreBibliotecario;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrarSesion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.Panel();

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreBibliotecario = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();

            this.btnInicio = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnEquipos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();

            this.pnlMenu.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();

            // FrmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "BiblioStock - Panel principal";
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(24, 42, 72);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Width = 230;
            this.pnlMenu.Controls.Add(this.lblTitulo);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.btnLibros);
            this.pnlMenu.Controls.Add(this.btnEquipos);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnPrestamos);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);

            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 25);
            this.lblTitulo.Size = new System.Drawing.Size(200, 55);
            this.lblTitulo.Text = "BIBLIOSTOCK";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlEncabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.White;
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Height = 75;
            this.pnlEncabezado.Controls.Add(this.lblNombreBibliotecario);

            // lblNombreBibliotecario
            this.lblNombreBibliotecario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNombreBibliotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblNombreBibliotecario.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNombreBibliotecario.Text = "Bibliotecario";
            this.lblNombreBibliotecario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombreBibliotecario.Width = 350;

            // pnlContenido
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(30);
            this.pnlContenido.Controls.Add(this.lblBienvenida);

            // lblBienvenida
            this.lblBienvenida.AutoSize = false;
            this.lblBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(35, 50, 75);
            this.lblBienvenida.Height = 70;
            this.lblBienvenida.Text = "Panel principal";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Botones del menu
            ConfigurarBoton(this.btnInicio, "Inicio", 110);
            ConfigurarBoton(this.btnLibros, "Libros", 170);
            ConfigurarBoton(this.btnEquipos, "Equipos", 230);
            ConfigurarBoton(this.btnUsuarios, "Usuarios", 290);
            ConfigurarBoton(this.btnPrestamos, "Prestamos", 350);
            ConfigurarBoton(this.btnInventario, "Inventario", 410);
            ConfigurarBoton(this.btnReportes, "Reportes", 470);

            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(170, 45, 55);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Location = new System.Drawing.Point(15, 650);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 45);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;

            // Agregar paneles
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlMenu);

            this.pnlMenu.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void ConfigurarBoton(
            System.Windows.Forms.Button boton,
            string texto,
            int posicionY)
        {
            boton.Text = texto;
            boton.BackColor = System.Drawing.Color.FromArgb(24, 42, 72);
            boton.ForeColor = System.Drawing.Color.White;
            boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new System.Drawing.Font("Segoe UI", 10F);
            boton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            boton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            boton.Location = new System.Drawing.Point(15, posicionY);
            boton.Size = new System.Drawing.Size(200, 48);
            boton.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}

