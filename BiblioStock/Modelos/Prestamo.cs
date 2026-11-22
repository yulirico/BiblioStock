using BiblioStock.Modelos;
using BiblioStock.Interfaces;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class Prestamo : IValidable
    {
        public string Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public Recurso Recurso { get; set; }
        public Bibliotecario Bibliotecario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        public Prestamo(
            string codigo,
            Usuario usuario,
            Recurso recurso,
            Bibliotecario bibliotecario,
            DateTime fechaPrestamo,
            DateTime fechaDevolucion)
        {
            Codigo = codigo;
            Usuario = usuario;
            Recurso = recurso;
            Bibliotecario = bibliotecario;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
            Devuelto = false;
        }

        public bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                return false;

            if (Usuario == null)
                return false;

            if (Recurso == null)
                return false;

            if (Bibliotecario == null)
                return false;

            if (!Usuario.Validar())
                return false;

            if (!Recurso.Validar())
                return false;

            if (!Bibliotecario.Validar())
                return false;

            if (FechaDevolucion.Date < FechaPrestamo.Date)
                return false;

            return true;
        }
    }
}

