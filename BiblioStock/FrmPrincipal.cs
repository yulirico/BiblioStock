using BiblioStock.Formularios;
using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Windows.Forms;
using BiblioStock.Servicios;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using BiblioStock.Patrones;

namespace BiblioStock.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private Bibliotecario bibliotecarioActual;

        public FrmPrincipal()
        {
            InitializeComponent();

            bibliotecarioActual = SesionBibliotecario.Instancia.BibliotecarioActual;

            // Eventos de los botones
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnInicio.Click += btnInicio_Click;
            btnLibros.Click += btnLibros_Click;
            btnEquipos.Click += btnEquipos_Click;
            btnUsuarios.Click += btnUsuarios_Click;
            btnPrestamos.Click += btnPrestamos_Click;
            btnInventario.Click += btnInventario_Click;
            btnReportes.Click += btnReportes_Click;

            if (bibliotecarioActual != null)
            {
                lblNombreBibliotecario.Text =
                    "Bienvenido, " + bibliotecarioActual.Nombre;
            }

            MostrarInicio();
        }

        // Limpiar el contenido del panel
        private void LimpiarContenido()
        {
            foreach (Control control in pnlContenido.Controls)
            {
                if (control is Form formulario)
                {
                    formulario.Close();
                    formulario.Dispose();
                }
            }

            pnlContenido.Controls.Clear();
        }

        // Abrir un formulario dentro del panel principal
        private void AbrirFormulario(Form formulario)
        {
            LimpiarContenido();

            pnlContenido.Padding = new Padding(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlContenido.Controls.Add(formulario);

            formulario.Show();
        }

        // Mostrar pantalla de inicio

        private void MostrarInicio()
        {
            LimpiarContenido();

            pnlContenido.Padding = new Padding(30);
            pnlContenido.AutoScroll = true;

            InventarioServicio inventario = new InventarioServicio();
            UsuarioServicio usuarios = new UsuarioServicio();
            ReporteServicio reportes = new ReporteServicio();

            int totalRecursos = inventario.ObtenerCantidadRecursos();
            int disponibles = inventario.ObtenerCantidadDisponibles();
            int totalUsuarios = usuarios.ObtenerUsuarios().Count;
            int totalPrestamos = reportes.ObtenerTotalPrestamos();

            // Titulo
            Label titulo = new Label();
            titulo.Text = "¡Bienvenido a BiblioStock!";
            titulo.Font = new Font("Segoe UI", 23, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(35, 50, 75);
            titulo.Dock = DockStyle.Top;
            titulo.Height = 55;

            // Subtitulo
            Label subtitulo = new Label();
            subtitulo.Text = "Resumen general del sistema de gestion bibliotecaria";
            subtitulo.Font = new Font("Segoe UI", 11);
            subtitulo.ForeColor = Color.Gray;
            subtitulo.Dock = DockStyle.Top;
            subtitulo.Height = 40;

            // Panel de tarjetas
            FlowLayoutPanel tarjetas = new FlowLayoutPanel();
            tarjetas.Dock = DockStyle.Top;
            tarjetas.Height = 160;
            tarjetas.Padding = new Padding(0, 10, 0, 10);
            tarjetas.WrapContents = true;
            tarjetas.AutoScroll = false;

            tarjetas.Controls.Add(CrearTarjeta(
                "Recursos registrados", totalRecursos, Color.FromArgb(37, 99, 235)));

            tarjetas.Controls.Add(CrearTarjeta(
                "Recursos disponibles", disponibles, Color.FromArgb(22, 163, 74)));

            tarjetas.Controls.Add(CrearTarjeta(
                "Usuarios registrados", totalUsuarios, Color.FromArgb(147, 51, 234)));

            tarjetas.Controls.Add(CrearTarjeta(
                "Prestamos registrados", totalPrestamos, Color.FromArgb(217, 119, 6)));

            // Panel informativo
            Panel panelInfo = new Panel();
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Height = 150;
            panelInfo.BackColor = Color.White;
            panelInfo.Padding = new Padding(20);

            Label tituloInfo = new Label();
            tituloInfo.Text = "Administracion bibliotecaria";
            tituloInfo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tituloInfo.ForeColor = Color.FromArgb(35, 50, 75);
            tituloInfo.Dock = DockStyle.Top;
            tituloInfo.Height = 35;

            Label textoInfo = new Label();
            textoInfo.Text =
                "Desde el menu lateral puedes gestionar los libros, equipos " +
                "tecnologicos, usuarios, prestamos, inventario y reportes.\n\n" +
                "Selecciona una opcion para comenzar a trabajar.";
            textoInfo.Font = new Font("Segoe UI", 10);
            textoInfo.ForeColor = Color.FromArgb(80, 80, 80);
            textoInfo.Dock = DockStyle.Fill;

            panelInfo.Controls.Add(textoInfo);
            panelInfo.Controls.Add(tituloInfo);

            // Agregar elementos al panel principal
            pnlContenido.Controls.Add(panelInfo);
            pnlContenido.Controls.Add(tarjetas);
            pnlContenido.Controls.Add(subtitulo);
            pnlContenido.Controls.Add(titulo);
        }

        private Panel CrearTarjeta(string titulo, int cantidad, Color color)
        {
            Panel tarjeta = new Panel();

            tarjeta.Size = new Size(220, 115);
            tarjeta.BackColor = Color.White;
            tarjeta.Margin = new Padding(0, 0, 20, 15);
            tarjeta.Padding = new Padding(15);

            Label lblTitulo = new Label();
            lblTitulo.Text = titulo;
            lblTitulo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(80, 80, 80);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 35;

            Label lblCantidad = new Label();
            lblCantidad.Text = cantidad.ToString();
            lblCantidad.Font = new Font("Segoe UI", 25, FontStyle.Bold);
            lblCantidad.ForeColor = color;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.TextAlign = ContentAlignment.MiddleLeft;

            tarjeta.Controls.Add(lblCantidad);
            tarjeta.Controls.Add(lblTitulo);

            return tarjeta;
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEquipos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInventario());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar la sesion?",
                "Cerrar sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                FrmLogin login = new FrmLogin();
                login.Show();

                this.Close();
            }
        }
    }
}


