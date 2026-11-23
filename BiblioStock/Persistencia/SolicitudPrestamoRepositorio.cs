using BiblioStock.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Persistencia
{
    public class SolicitudPrestamoRepositorio
    {
        private ArchivoTexto archivo;
        private UsuarioRepositorio usuarios;
        private LibroRepositorio libros;

        public SolicitudPrestamoRepositorio()
        {
            archivo = new ArchivoTexto("solicitudes.txt");
            usuarios = new UsuarioRepositorio();
            libros = new LibroRepositorio();
        }

        // Obtener todas las solicitudes guardadas
        public List<SolicitudPrestamo> ObtenerTodos()
        {
            List<SolicitudPrestamo> solicitudes =
                new List<SolicitudPrestamo>();

            List<Usuario> listaUsuarios = usuarios.ObtenerTodos();
            List<Libro> listaLibros = libros.ObtenerTodos();

            List<string> registros = archivo.LeerArchivo();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 4)
                {
                    Usuario usuarioEncontrado = null;
                    Libro libroEncontrado = null;

                    foreach (Usuario usuario in listaUsuarios)
                    {
                        if (usuario.Identificacion == datos[1])
                        {
                            usuarioEncontrado = usuario;
                            break;
                        }
                    }

                    foreach (Libro libro in listaLibros)
                    {
                        if (libro.Codigo == datos[2])
                        {
                            libroEncontrado = libro;
                            break;
                        }
                    }

                    DateTime fecha;

                    bool fechaValida = DateTime.TryParse(
                        datos[3],
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.RoundtripKind,
                        out fecha
                    );

                    if (usuarioEncontrado != null &&
                        libroEncontrado != null &&
                        fechaValida)
                    {
                        SolicitudPrestamo solicitud =
                            new SolicitudPrestamo(
                                datos[0],
                                usuarioEncontrado,
                                libroEncontrado
                            );

                        solicitud.FechaSolicitud = fecha;

                        solicitudes.Add(solicitud);
                    }
                }
            }

            return solicitudes;
        }

        // Guardar una solicitud
        public void Guardar(SolicitudPrestamo solicitud)
        {
            List<SolicitudPrestamo> solicitudes = ObtenerTodos();

            bool encontrada = false;

            for (int i = 0; i < solicitudes.Count; i++)
            {
                if (solicitudes[i].Codigo == solicitud.Codigo)
                {
                    solicitudes[i] = solicitud;
                    encontrada = true;
                    break;
                }
            }

            if (!encontrada)
            {
                solicitudes.Add(solicitud);
            }

            List<string> registros = new List<string>();

            foreach (SolicitudPrestamo elemento in solicitudes)
            {
                string registro =
                    elemento.Codigo + "|" +
                    elemento.Usuario.Identificacion + "|" +
                    elemento.Libro.Codigo + "|" +
                    elemento.FechaSolicitud.ToString(
                        "O",
                        CultureInfo.InvariantCulture
                    );

                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        // Eliminar una solicitud por su codigo
        public bool Eliminar(string codigo)
        {
            List<SolicitudPrestamo> solicitudes = ObtenerTodos();

            bool eliminada = false;

            for (int i = 0; i < solicitudes.Count; i++)
            {
                if (solicitudes[i].Codigo == codigo)
                {
                    solicitudes.RemoveAt(i);
                    eliminada = true;
                    break;
                }
            }

            if (eliminada)
            {
                List<string> registros = new List<string>();

                foreach (SolicitudPrestamo elemento in solicitudes)
                {
                    string registro =
                        elemento.Codigo + "|" +
                        elemento.Usuario.Identificacion + "|" +
                        elemento.Libro.Codigo + "|" +
                        elemento.FechaSolicitud.ToString(
                            "O",
                            CultureInfo.InvariantCulture
                        );

                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminada;
        }
    }
}

