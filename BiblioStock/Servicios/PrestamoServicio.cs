using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class PrestamoServicio
    {
        private PrestamoRepositorio prestamos;
        private UsuarioRepositorio usuarios;
        private LibroRepositorio libros;
        private EquipoRepositorio equipos;
        private BibliotecarioRepositorio bibliotecarios;
        private SolicitudPrestamoServicio solicitudes;

        public PrestamoServicio()
        {
            prestamos = new PrestamoRepositorio();
            usuarios = new UsuarioRepositorio();
            libros = new LibroRepositorio();
            equipos = new EquipoRepositorio();
            bibliotecarios = new BibliotecarioRepositorio();

            solicitudes = new SolicitudPrestamoServicio();
        }

        // Registrar un nuevo prestamo
        public string RegistrarPrestamo(Prestamo prestamo)
        {
            if (prestamo == null)
                return "El prestamo no contiene informacion.";

            if (prestamo.Usuario == null ||
                prestamo.Bibliotecario == null ||
                prestamo.Recurso == null)
            {
                return "Faltan datos del prestamo.";
            }

            // Comprobar que el usuario exista
            bool usuarioExiste = false;

            List<Usuario> listaUsuarios = usuarios.ObtenerTodos();

            foreach (Usuario elemento in listaUsuarios)
            {
                if (elemento.Identificacion ==
                    prestamo.Usuario.Identificacion)
                {
                    usuarioExiste = true;
                    prestamo.Usuario = elemento;
                    break;
                }
            }

            if (!usuarioExiste)
                return "El usuario no esta registrado.";

            // Comprobar que el bibliotecario exista
            bool bibliotecarioExiste = false;

            List<Bibliotecario> listaBibliotecarios =
                bibliotecarios.ObtenerTodos();

            foreach (Bibliotecario elemento in listaBibliotecarios)
            {
                if (elemento.Identificacion ==
                    prestamo.Bibliotecario.Identificacion)
                {
                    bibliotecarioExiste = true;
                    prestamo.Bibliotecario = elemento;
                    break;
                }
            }

            if (!bibliotecarioExiste)
                return "El bibliotecario no esta registrado.";

            // Comprobar que el codigo no este repetido
            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Codigo == prestamo.Codigo)
                    return "Ya existe un prestamo con ese codigo.";
            }

            // Recuperar el recurso actualizado
            Recurso recurso = ObtenerRecurso(
                prestamo.Recurso.Codigo,
                prestamo.Recurso.GetType().Name
            );

            if (recurso == null)
                return "El recurso no esta registrado.";

            if (!recurso.Disponible)
                return "El recurso no esta disponible.";

            prestamo.Recurso = recurso;

            // Comprobar si hay solicitudes pendientes para el libro
            if (recurso is Libro)
            {
                SolicitudPrestamo? primeraSolicitud =
                    solicitudes.VerPrimeraSolicitudPorLibro(
                        recurso.Codigo
                    );

                if (primeraSolicitud != null &&
                    primeraSolicitud.Usuario.Identificacion !=
                    prestamo.Usuario.Identificacion)
                {
                    return "El libro tiene una solicitud pendiente. " +
                           "El primer usuario en espera es: " +
                           primeraSolicitud.Usuario.Nombre;
                }
            }

            if (!prestamo.Validar())
                return "Los datos del prestamo no son validos.";

            // Guardar el prestamo
            prestamos.Guardar(prestamo);

            // Cambiar la disponibilidad del recurso
            recurso.Disponible = false;

            GuardarRecurso(recurso);

            // Retirar la solicitud si el recurso es un libro
            if (recurso is Libro)
            {
                solicitudes.AtenderSolicitudPorLibro(
                    recurso.Codigo
                );
            }

            return "Prestamo registrado correctamente.";
        }


        // Registrar la devolucion de un recurso
        public string RegistrarDevolucion(string codigoPrestamo)
        {
            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            Prestamo prestamoEncontrado = null;

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Codigo == codigoPrestamo)
                {
                    prestamoEncontrado = elemento;
                    break;
                }
            }

            if (prestamoEncontrado == null)
                return "No se encontro el prestamo.";

            if (prestamoEncontrado.Devuelto)
                return "Este recurso ya fue devuelto.";

            // Actualizar el estado del prestamo
            prestamoEncontrado.Devuelto = true;

            // Actualizar la disponibilidad del recurso
            prestamoEncontrado.Recurso.Disponible = true;

            GuardarRecurso(prestamoEncontrado.Recurso);

            // Guardar los cambios del prestamo
            prestamos.Guardar(prestamoEncontrado);

            // Comprobar si hay solicitudes pendientes para el libro
            if (prestamoEncontrado.Recurso is Libro)
            {
                Libro libroDevuelto = (Libro)prestamoEncontrado.Recurso;

                SolicitudPrestamo? primeraSolicitud =
                    solicitudes.VerPrimeraSolicitudPorLibro(
                        libroDevuelto.Codigo
                    );

                if (primeraSolicitud != null)
                {
                    return "Devolucion registrada correctamente. " +
                           "Hay un usuario esperando este libro: " +
                           primeraSolicitud.Usuario.Nombre +
                           ". Identificacion: " +
                           primeraSolicitud.Usuario.Identificacion +
                           ". Debe atenderse su solicitud.";
                }
            }

            return "Devolucion registrada correctamente.";
        }


        // Buscar un libro o equipo
        private Recurso ObtenerRecurso(string codigo, string tipo)
        {
            if (tipo == "Libro")
            {
                List<Libro> listaLibros = libros.ObtenerTodos();

                foreach (Libro elemento in listaLibros)
                {
                    if (elemento.Codigo == codigo)
                        return elemento;
                }
            }

            if (tipo == "Equipo")
            {
                List<Equipo> listaEquipos = equipos.ObtenerTodos();

                foreach (Equipo elemento in listaEquipos)
                {
                    if (elemento.Codigo == codigo)
                        return elemento;
                }
            }

            return null;
        }

        // Guardar los cambios de disponibilidad
        private void GuardarRecurso(Recurso recurso)
        {
            if (recurso is Libro)
            {
                libros.Guardar((Libro)recurso);
            }
            else if (recurso is Equipo)
            {
                equipos.Guardar((Equipo)recurso);
            }
        }

        // Registrar una solicitud de prestamo
        public string RegistrarSolicitud(SolicitudPrestamo solicitud)
        {
            return solicitudes.RegistrarSolicitud(solicitud);
        }

        // Obtener todas las solicitudes pendientes
        public List<SolicitudPrestamo> ObtenerSolicitudes()
        {
            return solicitudes.ObtenerSolicitudes();
        }
    }
}

