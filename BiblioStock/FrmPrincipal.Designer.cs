namespace BiblioStock.Formularios
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnEquipos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblNombreBibliotecario;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblBienvenida;

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
            pnlMenu = new Panel();
            lblTitulo = new Label();
            btnInicio = new Button();
            btnLibros = new Button();
            btnEquipos = new Button();
            btnUsuarios = new Button();
            btnPrestamos = new Button();
            btnInventario = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            pnlEncabezado = new Panel();
            lblNombreBibliotecario = new Label();
            pnlContenido = new Panel();
            lblBienvenida = new Label();
            pnlMenu.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(24, 42, 72);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnInventario);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnEquipos);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 750);
            pnlMenu.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 90);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOSTOCK";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(24, 42, 72);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10.5F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 90);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(28, 0, 0, 0);
            btnInicio.Size = new Size(230, 52);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = Color.FromArgb(24, 42, 72);
            btnLibros.Cursor = Cursors.Hand;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnLibros.FlatStyle = FlatStyle.Flat;
            btnLibros.Font = new Font("Segoe UI", 10.5F);
            btnLibros.ForeColor = Color.White;
            btnLibros.Location = new Point(0, 142);
            btnLibros.Name = "btnLibros";
            btnLibros.Padding = new Padding(28, 0, 0, 0);
            btnLibros.Size = new Size(230, 52);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.UseVisualStyleBackColor = false;
            // 
            // btnEquipos
            // 
            btnEquipos.BackColor = Color.FromArgb(24, 42, 72);
            btnEquipos.Cursor = Cursors.Hand;
            btnEquipos.Dock = DockStyle.Top;
            btnEquipos.FlatAppearance.BorderSize = 0;
            btnEquipos.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnEquipos.FlatStyle = FlatStyle.Flat;
            btnEquipos.Font = new Font("Segoe UI", 10.5F);
            btnEquipos.ForeColor = Color.White;
            btnEquipos.Location = new Point(0, 194);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Padding = new Padding(28, 0, 0, 0);
            btnEquipos.Size = new Size(230, 52);
            btnEquipos.TabIndex = 3;
            btnEquipos.Text = "Equipos";
            btnEquipos.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipos.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(24, 42, 72);
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10.5F);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 246);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(28, 0, 0, 0);
            btnUsuarios.Size = new Size(230, 52);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.FromArgb(24, 42, 72);
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 10.5F);
            btnPrestamos.ForeColor = Color.White;
            btnPrestamos.Location = new Point(0, 298);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Padding = new Padding(28, 0, 0, 0);
            btnPrestamos.Size = new Size(230, 52);
            btnPrestamos.TabIndex = 5;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(24, 42, 72);
            btnInventario.Cursor = Cursors.Hand;
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 10.5F);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(0, 350);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(28, 0, 0, 0);
            btnInventario.Size = new Size(230, 52);
            btnInventario.TabIndex = 6;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(24, 42, 72);
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 64, 104);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 10.5F);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 402);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(28, 0, 0, 0);
            btnReportes.Size = new Size(230, 52);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(150, 40, 50);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 50, 62);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 694);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(230, 56);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = Color.White;
            pnlEncabezado.Controls.Add(lblNombreBibliotecario);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(230, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(970, 75);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblNombreBibliotecario
            // 
            lblNombreBibliotecario.Dock = DockStyle.Right;
            lblNombreBibliotecario.Font = new Font("Segoe UI", 11F);
            lblNombreBibliotecario.ForeColor = Color.FromArgb(45, 55, 72);
            lblNombreBibliotecario.Location = new Point(590, 0);
            lblNombreBibliotecario.Name = "lblNombreBibliotecario";
            lblNombreBibliotecario.Padding = new Padding(0, 0, 28, 0);
            lblNombreBibliotecario.Size = new Size(380, 75);
            lblNombreBibliotecario.TabIndex = 0;
            lblNombreBibliotecario.Text = "Bibliotecario";
            lblNombreBibliotecario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.FromArgb(240, 243, 248);
            pnlContenido.Controls.Add(lblBienvenida);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(230, 75);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Padding = new Padding(30);
            pnlContenido.Size = new Size(970, 675);
            pnlContenido.TabIndex = 2;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(35, 50, 75);
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(910, 70);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Panel principal";
            lblBienvenida.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 243, 248);
            ClientSize = new Size(1200, 750);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEncabezado);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiblioStock - Panel principal";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlEncabezado.ResumeLayout(false);
            pnlContenido.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

