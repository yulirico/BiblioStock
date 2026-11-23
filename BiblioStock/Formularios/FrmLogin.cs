using BiblioStock.Modelos;
using BiblioStock.Servicios;
using BiblioStock.Patrones;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BiblioStock.Formularios
{
    public partial class FrmLogin : Form
    {
        private AutenticacionServicio autenticacion;
        private BibliotecarioServicio servicioBibliotecarios;

        public FrmLogin()
        {
            InitializeComponent();

            autenticacion = new AutenticacionServicio();
            servicioBibliotecarios = new BibliotecarioServicio();

            CargarBibliotecarios();
        }

        private void CargarBibliotecarios()
        {
            List<Bibliotecario> bibliotecarios =
                servicioBibliotecarios.ObtenerBibliotecarios();

            cmbBibliotecarios.DataSource = null;
            cmbBibliotecarios.DisplayMember = "Nombre";
            cmbBibliotecarios.ValueMember = "Identificacion";
            cmbBibliotecarios.DataSource = bibliotecarios;

            if (bibliotecarios.Count == 0)
            {
                lblMensaje.Text =
                    "No hay bibliotecarios registrados.";
                btnIngresar.Enabled = false;
            }
            else
            {
                lblMensaje.Text =
                    "Seleccione su nombre e ingrese su contrasena.";
                btnIngresar.Enabled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Bibliotecario seleccionado =
                cmbBibliotecarios.SelectedItem as Bibliotecario;

            string contrasena = txtContrasena.Text;

            if (seleccionado == null ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Seleccione un bibliotecario e ingrese la contrasena.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Bibliotecario bibliotecario =
                autenticacion.IniciarSesion(
                    seleccionado.Usuario,
                    contrasena
                );

            if (bibliotecario != null)
            {
                // Guardar bibliotecario en la sesion Singleton
                SesionBibliotecario.Instancia.IniciarSesion(bibliotecario);

                MessageBox.Show(
                    "Bienvenido, " + bibliotecario.Nombre,
                    "Acceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                FrmPrincipal principal = new FrmPrincipal();

                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "La contrasena ingresada es incorrecta.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}



