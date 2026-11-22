using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class InventarioServicio
    {
        private LibroRepositorio libros;
        private EquipoRepositorio equipos;

        public InventarioServicio()
        {
            libros = new LibroRepositorio();
            equipos = new EquipoRepositorio();
        }

        public List<Recurso> ObtenerInventario()
        {
            List<Recurso> inventario = new List<Recurso>();

            List<Libro> listaLibros = libros.ObtenerTodos();
            List<Equipo> listaEquipos = equipos.ObtenerTodos();

            foreach (Libro libro in listaLibros)
            {
                inventario.Add(libro);
            }

            foreach (Equipo equipo in listaEquipos)
            {
                inventario.Add(equipo);
            }

            return inventario;
        }

        public Recurso BuscarRecurso(string codigo)
        {
            List<Recurso> inventario = ObtenerInventario();

            foreach (Recurso recurso in inventario)
            {
                if (recurso.Codigo == codigo)
                    return recurso;
            }

            return null;
        }

        public int ObtenerCantidadRecursos()
        {
            return ObtenerInventario().Count;
        }

        public int ObtenerCantidadDisponibles()
        {
            int cantidad = 0;

            List<Recurso> inventario = ObtenerInventario();

            foreach (Recurso recurso in inventario)
            {
                if (recurso.Disponible)
                    cantidad++;
            }

            return cantidad;
        }

        public int ObtenerCantidadPrestados()
        {
            int cantidad = 0;

            List<Recurso> inventario = ObtenerInventario();

            foreach (Recurso recurso in inventario)
            {
                if (!recurso.Disponible)
                    cantidad++;
            }

            return cantidad;
        }
    }
}

