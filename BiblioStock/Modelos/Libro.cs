using BiblioStock.Interfaces;
using BiblioStock.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class Libro : Recurso, IValidable
    {
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string ISBN { get; set; }
        public int Paginas { get; set; }

        public Libro(
            string codigo,
            string nombre,
            string descripcion,
            string autor,
            string editorial,
            string isbn,
            int paginas)
            : base(codigo, nombre, descripcion)
        {
            Autor = autor;
            Editorial = editorial;
            ISBN = isbn;
            Paginas = paginas;
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() +
                " - " + Autor + " - " + Editorial;
        }

        public override bool Validar()
        {
            if (!base.Validar())
                return false;

            if (string.IsNullOrWhiteSpace(Autor))
                return false;

            if (string.IsNullOrWhiteSpace(Editorial))
                return false;

            if (Paginas <= 0)
                return false;

            return true;
        }
    }
}


