using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class LibroServicio
    {
        private LibroRepositorio repositorio;
        private PrestamoRepositorio prestamos;

        public LibroServicio()
        {
            repositorio = new LibroRepositorio();
            prestamos = new PrestamoRepositorio();
        }

        // Registrar un libro
        public string RegistrarLibro(Libro libro)
        {
            if (libro == null)
                return "No se recibieron los datos del libro.";

            if (!libro.Validar())
                return "Los datos del libro no son validos.";

            List<Libro> libros = repositorio.ObtenerTodos();

            foreach (Libro elemento in libros)
            {
                if (elemento.Codigo == libro.Codigo)
                    return "Ya existe un libro con ese codigo.";
            }

            repositorio.Guardar(libro);

            return "Libro registrado correctamente.";
        }

        // Actualizar un libro
        public string ActualizarLibro(Libro libro)
        {
            if (libro == null)
                return "No se recibieron los datos del libro.";

            if (!libro.Validar())
                return "Los datos del libro no son validos.";

            List<Libro> libros = repositorio.ObtenerTodos();

            Libro libroEncontrado = null;

            foreach (Libro elemento in libros)
            {
                if (elemento.Codigo == libro.Codigo)
                {
                    libroEncontrado = elemento;
                    break;
                }
            }

            if (libroEncontrado == null)
                return "El libro no esta registrado.";

            // Conservar la disponibilidad actual
            libro.Disponible = libroEncontrado.Disponible;

            repositorio.Guardar(libro);

            return "Libro actualizado correctamente.";
        }

        // Consultar todos los libros
        public List<Libro> ObtenerLibros()
        {
            return repositorio.ObtenerTodos();
        }

        // Buscar un libro por codigo
        public Libro BuscarLibro(string codigo)
        {
            List<Libro> libros = repositorio.ObtenerTodos();

            foreach (Libro elemento in libros)
            {
                if (elemento.Codigo == codigo)
                    return elemento;
            }

            return null;
        }

        // Eliminar un libro
        public string EliminarLibro(string codigo)
        {
            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Recurso != null &&
                    elemento.Recurso.Codigo == codigo &&
                    elemento.Recurso is Libro)
                {
                    return "No se puede eliminar el libro porque tiene historial de prestamos.";
                }
            }

            bool eliminado = repositorio.Eliminar(codigo);

            if (eliminado)
                return "Libro eliminado correctamente.";

            return "No se encontro el libro.";
        }
    }
}

