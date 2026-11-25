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

            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            int prestamosActivos = 0;

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Usuario.Identificacion ==
                    prestamo.Usuario.Identificacion &&
                    !elemento.Devuelto)
                {
                    prestamosActivos++;
                }
            }

            if (prestamosActivos >= 3)
            {
                return "El usuario ya tiene tres prestamos activos. " +
                       "Debe devolver un recurso antes de solicitar otro.";
            }

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Codigo == prestamo.Codigo)
                    return "Ya existe un prestamo con ese codigo.";
            }

            Recurso recurso = ObtenerRecurso(
                prestamo.Recurso.Codigo,
                prestamo.Recurso.GetType().Name
            );

            if (recurso == null)
                return "El recurso no esta registrado.";

            if (!recurso.Disponible)
                return "El recurso no esta disponible.";

            if (recurso is Libro)
            {
                DateTime fechaMaxima =
                    prestamo.FechaPrestamo.Date.AddDays(14);

                if (prestamo.FechaDevolucion.Date > fechaMaxima)
                {
                    return "El plazo maximo para prestar un libro es de 14 dias.";
                }
            }

            prestamo.Recurso = recurso;

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

            prestamos.Guardar(prestamo);

            recurso.Disponible = false;

            GuardarRecurso(recurso);

            if (recurso is Libro)
            {
                solicitudes.AtenderSolicitudPorLibro(
                    recurso.Codigo
                );
            }

            return "Prestamo registrado correctamente.";
        }


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

            prestamoEncontrado.Devuelto = true;

            prestamoEncontrado.Recurso.Disponible = true;

            GuardarRecurso(prestamoEncontrado.Recurso);

            prestamos.Guardar(prestamoEncontrado);

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

        public string RegistrarSolicitud(SolicitudPrestamo solicitud)
        {
            return solicitudes.RegistrarSolicitud(solicitud);
        }

        public List<SolicitudPrestamo> ObtenerSolicitudes()
        {
            return solicitudes.ObtenerSolicitudes();
        }
    }
}

