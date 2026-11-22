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
    public class PrestamoRepositorio : IRepositorio<Prestamo>
    {
        private ArchivoTexto archivo;

        private UsuarioRepositorio usuarios;
        private LibroRepositorio libros;
        private EquipoRepositorio equipos;
        private BibliotecarioRepositorio bibliotecarios;

        public PrestamoRepositorio()
        {
            archivo = new ArchivoTexto("prestamos.txt");

            usuarios = new UsuarioRepositorio();
            libros = new LibroRepositorio();
            equipos = new EquipoRepositorio();
            bibliotecarios = new BibliotecarioRepositorio();
        }

        public List<Prestamo> ObtenerTodos()
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            List<string> registros = archivo.LeerArchivo();

            List<Usuario> listaUsuarios = usuarios.ObtenerTodos();
            List<Libro> listaLibros = libros.ObtenerTodos();
            List<Equipo> listaEquipos = equipos.ObtenerTodos();

            List<Bibliotecario> listaBibliotecarios =
                bibliotecarios.ObtenerTodos();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 8)
                {
                    Usuario usuario = null;
                    Recurso recurso = null;
                    Bibliotecario bibliotecario = null;

                    // Buscar el usuario
                    foreach (Usuario elemento in listaUsuarios)
                    {
                        if (elemento.Identificacion == datos[1])
                        {
                            usuario = elemento;
                            break;
                        }
                    }

                    // Buscar el recurso
                    if (datos[3] == "Libro")
                    {
                        foreach (Libro elemento in listaLibros)
                        {
                            if (elemento.Codigo == datos[2])
                            {
                                recurso = elemento;
                                break;
                            }
                        }
                    }
                    else if (datos[3] == "Equipo")
                    {
                        foreach (Equipo elemento in listaEquipos)
                        {
                            if (elemento.Codigo == datos[2])
                            {
                                recurso = elemento;
                                break;
                            }
                        }
                    }

                    // Buscar el bibliotecario
                    foreach (Bibliotecario elemento in listaBibliotecarios)
                    {
                        if (elemento.Identificacion == datos[7])
                        {
                            bibliotecario = elemento;
                            break;
                        }
                    }

                    // Crear el prestamo si existen las relaciones
                    if (usuario != null &&
                        recurso != null &&
                        bibliotecario != null)
                    {
                        Prestamo prestamo = new Prestamo(
                            datos[0],
                            usuario,
                            recurso,
                            bibliotecario,
                            DateTime.Parse(datos[4]),
                            DateTime.Parse(datos[5])
                        );

                        prestamo.Devuelto = bool.Parse(datos[6]);

                        prestamos.Add(prestamo);
                    }
                }
            }

            return prestamos;
        }

        public void Guardar(Prestamo prestamo)
        {
            List<Prestamo> prestamos = ObtenerTodos();

            bool encontrado = false;

            for (int i = 0; i < prestamos.Count; i++)
            {
                if (prestamos[i].Codigo == prestamo.Codigo)
                {
                    prestamos[i] = prestamo;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                prestamos.Add(prestamo);
            }

            List<string> registros = new List<string>();

            foreach (Prestamo elemento in prestamos)
            {
                string registro = ConvertirARegistro(elemento);
                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        public bool Eliminar(string codigo)
        {
            List<Prestamo> prestamos = ObtenerTodos();

            bool eliminado = false;

            for (int i = 0; i < prestamos.Count; i++)
            {
                if (prestamos[i].Codigo == codigo)
                {
                    prestamos.RemoveAt(i);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                List<string> registros = new List<string>();

                foreach (Prestamo elemento in prestamos)
                {
                    string registro = ConvertirARegistro(elemento);
                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminado;
        }

        private string ConvertirARegistro(Prestamo prestamo)
        {
            return prestamo.Codigo + "|" +
                prestamo.Usuario.Identificacion + "|" +
                prestamo.Recurso.Codigo + "|" +
                prestamo.Recurso.GetType().Name + "|" +
                prestamo.FechaPrestamo.ToString("yyyy-MM-dd") + "|" +
                prestamo.FechaDevolucion.ToString("yyyy-MM-dd") + "|" +
                prestamo.Devuelto + "|" +
                prestamo.Bibliotecario.Identificacion;
        }
    }
}

