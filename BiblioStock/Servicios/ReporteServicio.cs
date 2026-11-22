using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class ReporteServicio
    {
        private PrestamoRepositorio repositorio;

        public ReporteServicio()
        {
            repositorio = new PrestamoRepositorio();
        }

        public List<Prestamo> ObtenerTodosLosPrestamos()
        {
            return repositorio.ObtenerTodos();
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            List<Prestamo> resultado = new List<Prestamo>();
            List<Prestamo> prestamos = repositorio.ObtenerTodos();

            foreach (Prestamo prestamo in prestamos)
            {
                if (!prestamo.Devuelto)
                    resultado.Add(prestamo);
            }

            return resultado;
        }

        public List<Prestamo> ObtenerPrestamosDevueltos()
        {
            List<Prestamo> resultado = new List<Prestamo>();
            List<Prestamo> prestamos = repositorio.ObtenerTodos();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Devuelto)
                    resultado.Add(prestamo);
            }

            return resultado;
        }

        public List<Prestamo> ObtenerPrestamosVencidos()
        {
            List<Prestamo> resultado = new List<Prestamo>();
            List<Prestamo> prestamos = repositorio.ObtenerTodos();

            foreach (Prestamo prestamo in prestamos)
            {
                if (!prestamo.Devuelto &&
                    prestamo.FechaDevolucion.Date < DateTime.Today)
                {
                    resultado.Add(prestamo);
                }
            }

            return resultado;
        }

        public int ObtenerTotalPrestamos()
        {
            return ObtenerTodosLosPrestamos().Count;
        }

        public int ObtenerTotalActivos()
        {
            return ObtenerPrestamosActivos().Count;
        }

        public int ObtenerTotalDevueltos()
        {
            return ObtenerPrestamosDevueltos().Count;
        }

        public int ObtenerTotalVencidos()
        {
            return ObtenerPrestamosVencidos().Count;
        }
    }
}

