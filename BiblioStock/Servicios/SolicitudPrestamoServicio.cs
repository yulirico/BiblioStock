using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioStock.Estructuras;
using BiblioStock.Modelos;
using BiblioStock.Persistencia;

namespace BiblioStock.Servicios
{
    public class SolicitudPrestamoServicio
    {
        private Cola<SolicitudPrestamo> solicitudes;
        private SolicitudPrestamoRepositorio repositorio;

        public SolicitudPrestamoServicio()
        {
            solicitudes = new Cola<SolicitudPrestamo>();
            repositorio = new SolicitudPrestamoRepositorio();

            // Recuperar las solicitudes guardadas
            List<SolicitudPrestamo> lista =
                repositorio.ObtenerTodos();

            foreach (SolicitudPrestamo solicitud in lista)
            {
                solicitudes.Encolar(solicitud);
            }
        }

        // Registrar una nueva solicitud
        public string RegistrarSolicitud(SolicitudPrestamo solicitud)
        {
            if (solicitud == null)
                return "La solicitud no contiene informacion.";

            if (solicitud.Usuario == null || solicitud.Libro == null)
                return "Faltan datos de la solicitud.";

            if (!solicitud.Usuario.Validar() ||
                !solicitud.Libro.Validar())
            {
                return "Los datos de la solicitud no son validos.";
            }

            if (!solicitud.Libro.Disponible)
            {
                // El libro ya esta prestado, se permite solicitar turno
            }
            else
            {
                return "El libro esta disponible. Puede registrarse un prestamo directamente.";
            }

            List<SolicitudPrestamo> lista =
                solicitudes.ObtenerElementos();

            foreach (SolicitudPrestamo elemento in lista)
            {
                if (elemento.Codigo == solicitud.Codigo)
                    return "Ya existe una solicitud con ese codigo.";

                if (elemento.Usuario.Identificacion ==
                    solicitud.Usuario.Identificacion &&
                    elemento.Libro.Codigo == solicitud.Libro.Codigo)
                {
                    return "El usuario ya tiene una solicitud para este libro.";
                }
            }

            // Agregar a la cola y guardar
            solicitudes.Encolar(solicitud);
            repositorio.Guardar(solicitud);

            return "Solicitud registrada correctamente.";
        }

        // Consultar la primera solicitud de toda la cola
        public SolicitudPrestamo? VerPrimeraSolicitud()
        {
            return solicitudes.VerPrimero();
        }

        // Consultar la cantidad de solicitudes
        public int ObtenerCantidadSolicitudes()
        {
            return solicitudes.Contar();
        }

        // Obtener todas las solicitudes
        public List<SolicitudPrestamo> ObtenerSolicitudes()
        {
            return solicitudes.ObtenerElementos();
        }

        // Comprobar si existen solicitudes
        public bool HaySolicitudes()
        {
            return !solicitudes.EstaVacia();
        }

        // Consultar solicitudes de un libro específico
        public List<SolicitudPrestamo> ObtenerSolicitudesPorLibro(
            string codigoLibro)
        {
            List<SolicitudPrestamo> resultado =
                new List<SolicitudPrestamo>();

            List<SolicitudPrestamo> lista =
                solicitudes.ObtenerElementos();

            foreach (SolicitudPrestamo solicitud in lista)
            {
                if (solicitud.Libro.Codigo == codigoLibro)
                {
                    resultado.Add(solicitud);
                }
            }

            return resultado;
        }

        // Consultar el primer turno de un libro sin retirarlo
        public SolicitudPrestamo? VerPrimeraSolicitudPorLibro(
            string codigoLibro)
        {
            List<SolicitudPrestamo> lista =
                solicitudes.ObtenerElementos();

            foreach (SolicitudPrestamo solicitud in lista)
            {
                if (solicitud.Libro.Codigo == codigoLibro)
                {
                    return solicitud;
                }
            }

            return null;
        }

        // Atender una solicitud específica
        public bool AtenderSolicitudPorLibro(string codigoLibro)
        {
            SolicitudPrestamo? solicitud =
                VerPrimeraSolicitudPorLibro(codigoLibro);

            if (solicitud == null)
                return false;

            bool eliminada = solicitudes.Eliminar(solicitud);

            if (eliminada)
            {
                repositorio.Eliminar(solicitud.Codigo);
            }

            return eliminada;
        }
    }
}

