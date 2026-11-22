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
    public partial class FrmUsuarios : Form
    {
        private UsuarioServicio servicio;

        public FrmUsuarios()
        {
            InitializeComponent();

            servicio = new UsuarioServicio();

            CargarUsuarios();
        }

        // CARGAR USUARIOS EN LA TABLA
        private void CargarUsuarios()
        {
            List<Usuario> lista = servicio.ObtenerUsuarios();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = lista;
        }

        // OBTENER DATOS DEL FORMULARIO
        private Usuario ObtenerDatosFormulario()
        {
            Usuario usuario = new Usuario(
                txtIdentificacion.Text.Trim(),
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim()
            );

            return usuario;
        }

        // REGISTRAR USUARIO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerDatosFormulario();

            string resultado = servicio.RegistrarUsuario(usuario);

            MessageBox.Show(resultado);

            if (resultado == "Usuario registrado correctamente.")
            {
                CargarUsuarios();
                LimpiarCampos();
            }
        }

        // ACTUALIZAR USUARIO
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerDatosFormulario();

            string resultado = servicio.ActualizarUsuario(usuario);

            MessageBox.Show(resultado);

            if (resultado == "Usuario actualizado correctamente.")
            {
                CargarUsuarios();
                LimpiarCampos();
            }
        }

        // ELIMINAR USUARIO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Esta seguro de eliminar este usuario?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                string resultado =
                    servicio.EliminarUsuario(identificacion);

                MessageBox.Show(resultado);

                if (resultado == "Usuario eliminado correctamente.")
                {
                    CargarUsuarios();
                    LimpiarCampos();
                }
            }
        }

        // BUSCAR USUARIO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string identificacion = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(identificacion))
            {
                MessageBox.Show("Ingrese la identificacion del usuario.");
                return;
            }

            Usuario usuario = servicio.BuscarUsuario(identificacion);

            if (usuario == null)
            {
                MessageBox.Show("No se encontro el usuario.");
                return;
            }

            MostrarDatos(usuario);
        }

        // SELECCIONAR USUARIO DE LA TABLA
        private void dgvUsuarios_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Usuario usuario =
                    dgvUsuarios.Rows[e.RowIndex].DataBoundItem as Usuario;

                if (usuario != null)
                    MostrarDatos(usuario);
            }
        }

        // MOSTRAR DATOS EN LOS CAMPOS
        private void MostrarDatos(Usuario usuario)
        {
            txtIdentificacion.Text = usuario.Identificacion;
            txtNombre.Text = usuario.Nombre;
            txtCorreo.Text = usuario.Correo;
            txtTelefono.Text = usuario.Telefono;
        }

        // LIMPIAR CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();

            txtIdentificacion.Focus();

            dgvUsuarios.ClearSelection();
        }
    }
}

