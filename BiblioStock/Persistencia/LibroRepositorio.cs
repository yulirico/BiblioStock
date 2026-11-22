using BiblioStock.Interfaces;
using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Persistencia
{
    public class LibroRepositorio : IRepositorio<Libro>
    {
        private ArchivoTexto archivo;

        public LibroRepositorio()
        {
            archivo = new ArchivoTexto("libros.txt");
        }

        public List<Libro> ObtenerTodos()
        {
            List<Libro> libros = new List<Libro>();

            List<string> registros = archivo.LeerArchivo();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 8)
                {
                    Libro libro = new Libro(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[4],
                        datos[5],
                        datos[6],
                        int.Parse(datos[7])
                    );

                    libro.Disponible = bool.Parse(datos[3]);

                    libros.Add(libro);
                }
            }

            return libros;
        }

        public void Guardar(Libro libro)
        {
            List<Libro> libros = ObtenerTodos();

            bool encontrado = false;

            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].Codigo == libro.Codigo)
                {
                    libros[i] = libro;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                libros.Add(libro);
            }

            List<string> registros = new List<string>();

            foreach (Libro elemento in libros)
            {
                string registro =
                    elemento.Codigo + "|" +
                    elemento.Nombre + "|" +
                    elemento.Descripcion + "|" +
                    elemento.Disponible + "|" +
                    elemento.Autor + "|" +
                    elemento.Editorial + "|" +
                    elemento.ISBN + "|" +
                    elemento.Paginas;

                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        public bool Eliminar(string codigo)
        {
            List<Libro> libros = ObtenerTodos();

            bool eliminado = false;

            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].Codigo == codigo)
                {
                    libros.RemoveAt(i);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                List<string> registros = new List<string>();

                foreach (Libro elemento in libros)
                {
                    string registro =
                        elemento.Codigo + "|" +
                        elemento.Nombre + "|" +
                        elemento.Descripcion + "|" +
                        elemento.Disponible + "|" +
                        elemento.Autor + "|" +
                        elemento.Editorial + "|" +
                        elemento.ISBN + "|" +
                        elemento.Paginas;

                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminado;
        }
    }
}

