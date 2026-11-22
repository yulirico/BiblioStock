using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioStock.Modelos;
using BiblioStock.Servicios;

namespace BiblioStock.Formularios
{
    public partial class FrmReportes : Form
    {
        private ReporteServicio servicio;

        public FrmReportes()
        {
            InitializeComponent();

            servicio = new ReporteServicio();

            ActualizarResumen();
            CargarTodos();
        }

        // ACTUALIZAR LOS CONTADORES
        private void ActualizarResumen()
        {
            lblTotal.Text =
                "Total de prestamos: " +
                servicio.ObtenerTotalPrestamos();

            lblActivos.Text =
                "Prestamos activos: " +
                servicio.ObtenerTotalActivos();

            lblDevueltos.Text =
                "Prestamos devueltos: " +
                servicio.ObtenerTotalDevueltos();

            lblVencidos.Text =
                "Prestamos vencidos: " +
                servicio.ObtenerTotalVencidos();
        }

        // MOSTRAR LOS DATOS EN LA TABLA
        private void MostrarPrestamos(List<Prestamo> prestamos)
        {
            var lista = prestamos.Select(p => new
            {
                Codigo = p.Codigo,
                Usuario = p.Usuario != null
                    ? p.Usuario.Nombre : "Sin usuario",
                Recurso = p.Recurso != null
                    ? p.Recurso.Nombre : "Sin recurso",
                Tipo = p.Recurso is Libro ? "Libro" : "Equipo",
                Bibliotecario = p.Bibliotecario != null
                    ? p.Bibliotecario.Nombre : "Sin bibliotecario",
                FechaPrestamo = p.FechaPrestamo.ToShortDateString(),
                FechaDevolucion = p.FechaDevolucion.ToShortDateString(),
                Estado = p.Devuelto ? "Devuelto" :
                    (p.FechaDevolucion.Date < DateTime.Today
                        ? "Vencido" : "Activo")
            }).ToList();

            dgvReportes.DataSource = null;
            dgvReportes.DataSource = lista;
        }

        // MOSTRAR TODOS LOS PRESTAMOS
        private void CargarTodos()
        {
            MostrarPrestamos(servicio.ObtenerTodosLosPrestamos());
        }

        // BOTON TODOS
        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarTodos();
        }

        // BOTON ACTIVOS
        private void btnActivos_Click(object sender, EventArgs e)
        {
            MostrarPrestamos(servicio.ObtenerPrestamosActivos());
        }

        // BOTON DEVUELTOS
        private void btnDevueltos_Click(object sender, EventArgs e)
        {
            MostrarPrestamos(servicio.ObtenerPrestamosDevueltos());
        }

        // BOTON VENCIDOS
        private void btnVencidos_Click(object sender, EventArgs e)
        {
            MostrarPrestamos(servicio.ObtenerPrestamosVencidos());
        }

        // ACTUALIZAR REPORTES
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarResumen();
            CargarTodos();

            MessageBox.Show(
                "Los reportes se actualizaron correctamente.",
                "Reportes",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

