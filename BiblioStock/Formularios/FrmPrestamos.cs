using BiblioStock.Modelos;
using BiblioStock.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioStock.Formularios
{
    public partial class FrmPrestamos : Form
    {
        private PrestamoServicio servicio;
        private UsuarioServicio usuarioServicio;
        private InventarioServicio inventarioServicio;
        private ReporteServicio reporteServicio;

        private Bibliotecario bibliotecarioActual;

        public FrmPrestamos(Bibliotecario bibliotecario)
        {
            InitializeComponent();

            bibliotecarioActual = bibliotecario;

            servicio = new PrestamoServicio();
            usuarioServicio = new UsuarioServicio();
            inventarioServicio = new InventarioServicio();
            reporteServicio = new ReporteServicio();

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(7);

            CargarUsuarios();
            CargarRecursos();
            CargarPrestamos();
        }

        // CARGAR USUARIOS
        private void CargarUsuarios()
        {
            cmbUsuarios.DataSource = null;
            cmbUsuarios.DataSource = usuarioServicio.ObtenerUsuarios();
            cmbUsuarios.DisplayMember = "Nombre";
        }

        // CARGAR RECURSOS DISPONIBLES
        private void CargarRecursos()
        {
            List<Recurso> recursos =
                inventarioServicio.ObtenerInventario();

            List<Recurso> disponibles =
                recursos.Where(r => r.Disponible).ToList();

            cmbRecursos.DataSource = null;
            cmbRecursos.DataSource = disponibles;
            cmbRecursos.DisplayMember = "Nombre";
        }

        // CARGAR PRESTAMOS
        private void CargarPrestamos()
        {
            var prestamos = reporteServicio.ObtenerTodosLosPrestamos();

            var lista = prestamos.Select(p => new
            {
                Codigo = p.Codigo,
                Usuario = p.Usuario.Nombre,
                Recurso = p.Recurso.Nombre,
                Tipo = p.Recurso is Libro ? "Libro" : "Equipo",
                FechaPrestamo = p.FechaPrestamo.ToShortDateString(),
                FechaDevolucion = p.FechaDevolucion.ToShortDateString(),
                Estado = p.Devuelto ? "Devuelto" : "Activo"
            }).ToList();

            dgvPrestamos.DataSource = null;
            dgvPrestamos.DataSource = lista;
        }

        // REGISTRAR PRESTAMO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            if (cmbRecursos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un recurso disponible.");
                return;
            }

            if (bibliotecarioActual == null)
            {
                MessageBox.Show("No se encontro el bibliotecario actual.");
                return;
            }

            if (dtpFechaDevolucion.Value.Date <
                dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolucion no puede ser anterior al prestamo.");
                return;
            }

            Usuario usuario = cmbUsuarios.SelectedItem as Usuario;
            Recurso recurso = cmbRecursos.SelectedItem as Recurso;

            string codigo = "PRE-" +
                DateTime.Now.ToString("yyyyMMddHHmmss");

            Prestamo prestamo = new Prestamo(
                codigo,
                usuario,
                recurso,
                bibliotecarioActual,
                dtpFechaPrestamo.Value.Date,
                dtpFechaDevolucion.Value.Date
            );

            string resultado = servicio.RegistrarPrestamo(prestamo);

            MessageBox.Show(resultado);

            if (resultado.ToLower().Contains("correctamente"))
            {
                CargarPrestamos();
                CargarRecursos();
                LimpiarCampos();
            }
        }

        // REGISTRAR DEVOLUCION
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoPrestamo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Seleccione un prestamo de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea registrar la devolucion de este recurso?",
                "Confirmar devolucion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                string resultado =
                    servicio.RegistrarDevolucion(codigo);

                MessageBox.Show(resultado);

                if (resultado.ToLower().Contains("correctamente"))
                {
                    CargarPrestamos();
                    CargarRecursos();
                    LimpiarCampos();
                }
            }
        }

        // SELECCIONAR PRESTAMO DE LA TABLA
        private void dgvPrestamos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigoPrestamo.Text =
                    dgvPrestamos.Rows[e.RowIndex]
                    .Cells["Codigo"].Value.ToString();
            }
        }

        // LIMPIAR CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigoPrestamo.Clear();

            if (cmbUsuarios.Items.Count > 0)
                cmbUsuarios.SelectedIndex = 0;

            if (cmbRecursos.Items.Count > 0)
                cmbRecursos.SelectedIndex = 0;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(7);

            dgvPrestamos.ClearSelection();
        }
    }
}

