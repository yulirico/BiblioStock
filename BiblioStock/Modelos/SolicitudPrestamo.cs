using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class SolicitudPrestamo
    {
        public string Codigo { get; set; }
        public Usuario Usuario { get; set; }
        public Libro Libro { get; set; }
        public DateTime FechaSolicitud { get; set; }

        public SolicitudPrestamo(
            string codigo,
            Usuario usuario,
            Libro libro)
        {
            Codigo = codigo;
            Usuario = usuario;
            Libro = libro;
            FechaSolicitud = DateTime.Now;
        }
    }
}

