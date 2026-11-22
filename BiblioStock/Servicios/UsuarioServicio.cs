using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class UsuarioServicio
    {
        private UsuarioRepositorio repositorio;
        private PrestamoRepositorio prestamos;

        public UsuarioServicio()
        {
            repositorio = new UsuarioRepositorio();
            prestamos = new PrestamoRepositorio();
        }

        // Registrar un usuario
        public string RegistrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                return "No se recibieron los datos del usuario.";

            if (!usuario.Validar())
                return "Los datos del usuario no son validos.";

            List<Usuario> usuarios = repositorio.ObtenerTodos();

            foreach (Usuario elemento in usuarios)
            {
                if (elemento.Identificacion == usuario.Identificacion)
                    return "Ya existe un usuario con esa identificacion.";
            }

            repositorio.Guardar(usuario);

            return "Usuario registrado correctamente.";
        }

        // Actualizar un usuario
        public string ActualizarUsuario(Usuario usuario)
        {
            if (usuario == null)
                return "No se recibieron los datos del usuario.";

            if (!usuario.Validar())
                return "Los datos del usuario no son validos.";

            List<Usuario> usuarios = repositorio.ObtenerTodos();

            bool encontrado = false;

            foreach (Usuario elemento in usuarios)
            {
                if (elemento.Identificacion == usuario.Identificacion)
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
                return "El usuario no esta registrado.";

            repositorio.Guardar(usuario);

            return "Usuario actualizado correctamente.";
        }

        // Consultar todos los usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return repositorio.ObtenerTodos();
        }

        // Buscar un usuario por identificacion
        public Usuario BuscarUsuario(string identificacion)
        {
            List<Usuario> usuarios = repositorio.ObtenerTodos();

            foreach (Usuario elemento in usuarios)
            {
                if (elemento.Identificacion == identificacion)
                    return elemento;
            }

            return null;
        }

        // Eliminar un usuario
        public string EliminarUsuario(string identificacion)
        {
            Usuario usuario = BuscarUsuario(identificacion);

            if (usuario == null)
                return "No se encontro el usuario.";

            PrestamoRepositorio repositorioPrestamos = new PrestamoRepositorio();
            List<Prestamo> prestamos = repositorioPrestamos.ObtenerTodos();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Usuario != null &&
                    prestamo.Usuario.Identificacion == identificacion)
                {
                    return "No se puede eliminar el usuario porque tiene prestamos asociados.";
                }
            }

            repositorio.Eliminar(identificacion);

            return "Usuario eliminado correctamente.";
        }
    }
}

