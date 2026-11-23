using BiblioStock.Modelos;
using BiblioStock.Servicios;
using BiblioStock.Patrones;
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
    public partial class FrmEquipos : Form
    {
        private EquipoServicio servicio;
        private FactoryRecurso factory;

        public FrmEquipos()
        {
            InitializeComponent();

            servicio = new EquipoServicio();
            factory = new FactoryRecurso();

            CargarEquipos();
        }

        private void CargarEquipos()
        {
            List<Equipo> lista = servicio.ObtenerEquipos();

            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = lista;
        }

        private Equipo ObtenerDatosFormulario()
        {
            Equipo equipo = factory.CrearEquipo(
                txtCodigo.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDescripcion.Text.Trim(),
                txtMarca.Text.Trim(),
                txtModelo.Text.Trim(),
                txtNumeroSerie.Text.Trim()
            );

            return equipo;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Equipo equipo = ObtenerDatosFormulario();

            string resultado = servicio.RegistrarEquipo(equipo);

            MessageBox.Show(resultado);

            if (resultado == "Equipo registrado correctamente.")
            {
                CargarEquipos();
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Equipo equipo = ObtenerDatosFormulario();

            string resultado = servicio.ActualizarEquipo(equipo);

            MessageBox.Show(resultado);

            if (resultado == "Equipo actualizado correctamente.")
            {
                CargarEquipos();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Seleccione un equipo para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Esta seguro de eliminar este equipo?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                string resultado = servicio.EliminarEquipo(codigo);

                MessageBox.Show(resultado);

                if (resultado == "Equipo eliminado correctamente.")
                {
                    CargarEquipos();
                    LimpiarCampos();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese el codigo del equipo.");
                return;
            }

            Equipo equipo = servicio.BuscarEquipo(codigo);

            if (equipo == null)
            {
                MessageBox.Show("No se encontro el equipo.");
                return;
            }

            MostrarDatos(equipo);
        }

        private void dgvEquipos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Equipo equipo =
                    dgvEquipos.Rows[e.RowIndex].DataBoundItem as Equipo;

                if (equipo != null)
                    MostrarDatos(equipo);
            }
        }

        private void MostrarDatos(Equipo equipo)
        {
            txtCodigo.Text = equipo.Codigo;
            txtNombre.Text = equipo.Nombre;
            txtDescripcion.Text = equipo.Descripcion;
            txtMarca.Text = equipo.Marca;
            txtModelo.Text = equipo.Modelo;
            txtNumeroSerie.Text = equipo.NumeroSerie;
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
            txtMarca.Clear();
            txtModelo.Clear();
            txtNumeroSerie.Clear();
            txtBuscar.Clear();

            txtCodigo.Focus();
            dgvEquipos.ClearSelection();
        }
    }
}

