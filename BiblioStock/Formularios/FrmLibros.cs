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
using BiblioStock.Patrones;

namespace BiblioStock.Formularios
{
    public partial class FrmLibros : Form
    {
        private LibroServicio servicio;
        private FactoryRecurso factory;

        public FrmLibros()
        {
            InitializeComponent();

            servicio = new LibroServicio();
            factory = new FactoryRecurso();

            CargarLibros();
        }

        private void CargarLibros()
        {
            List<Libro> lista = servicio.ObtenerLibros();

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = lista;
        }

        private Libro ObtenerDatosFormulario()
        {
            int paginas;

            if (!int.TryParse(txtPaginas.Text, out paginas))
            {
                MessageBox.Show("Ingrese un numero de paginas valido.");
                txtPaginas.Focus();
                return null;
            }

            Libro libro = factory.CrearLibro(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDescripcion.Text.Trim(),
                txtAutor.Text.Trim(),
                txtEditorial.Text.Trim(),
                txtISBN.Text.Trim(),
                paginas
            );

            return libro;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Libro libro = ObtenerDatosFormulario();

            if (libro == null)
                return;

            string resultado = servicio.RegistrarLibro(libro);

            MessageBox.Show(resultado);

            if (resultado == "Libro registrado correctamente.")
            {
                CargarLibros();
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Libro libro = ObtenerDatosFormulario();

            if (libro == null)
                return;

            string resultado = servicio.ActualizarLibro(libro);

            MessageBox.Show(resultado);

            if (resultado == "Libro actualizado correctamente.")
            {
                CargarLibros();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Seleccione un libro para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Esta seguro de eliminar este libro?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                string resultado = servicio.EliminarLibro(codigo);

                MessageBox.Show(resultado);

                if (resultado == "Libro eliminado correctamente.")
                {
                    CargarLibros();
                    LimpiarCampos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese el codigo del libro.");
                return;
            }

            Libro libro = servicio.BuscarLibro(codigo);

            if (libro == null)
            {
                MessageBox.Show("No se encontro el libro.");
                return;
            }

            MostrarDatos(libro);
        }

        private void dgvLibros_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Libro libro =
                    dgvLibros.Rows[e.RowIndex].DataBoundItem as Libro;

                if (libro != null)
                    MostrarDatos(libro);
            }
        }

        private void MostrarDatos(Libro libro)
        {
            txtCodigo.Text = libro.Codigo;
            txtNombre.Text = libro.Nombre;
            txtDescripcion.Text = libro.Descripcion;
            txtAutor.Text = libro.Autor;
            txtEditorial.Text = libro.Editorial;
            txtISBN.Text = libro.ISBN;
            txtPaginas.Text = libro.Paginas.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtISBN.Clear();
            txtPaginas.Clear();
            txtBuscar.Clear();

            txtCodigo.Focus();

            dgvLibros.ClearSelection();
        }
    }
}

