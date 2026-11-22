using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using BiblioStock.Modelos;
using BiblioStock.Servicios;

namespace BiblioStock.Formularios
{
    public partial class FrmInventario : Form
    {
        private InventarioServicio servicio;

        public FrmInventario()
        {
            InitializeComponent();

            servicio = new InventarioServicio();

            CargarInventario();
        }

        // CARGAR TODOS LOS RECURSOS
        private void CargarInventario()
        {
            List<Recurso> recursos = servicio.ObtenerInventario();

            MostrarRecursos(recursos);
        }

        // MOSTRAR LOS RECURSOS EN LA TABLA
        private void MostrarRecursos(List<Recurso> recursos)
        {
            var lista = recursos.Select(r => new
            {
                Codigo = r.Codigo,
                Nombre = r.Nombre,
                Descripcion = r.Descripcion,
                Tipo = r is Libro ? "Libro" : "Equipo",
                Estado = r.Disponible ? "Disponible" : "Prestado"
            }).ToList();

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = lista;
        }

        // BUSCAR RECURSO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese el codigo del recurso.");
                return;
            }

            Recurso recurso = servicio.BuscarRecurso(codigo);

            if (recurso == null)
            {
                MessageBox.Show("No se encontro el recurso.");
                return;
            }

            List<Recurso> resultado = new List<Recurso>();
            resultado.Add(recurso);

            MostrarRecursos(resultado);
        }

        // MOSTRAR TODOS LOS RECURSOS
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            CargarInventario();
        }

        // ACTUALIZAR INVENTARIO
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            CargarInventario();

            MessageBox.Show(
                "Inventario actualizado correctamente.",
                "Inventario",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

