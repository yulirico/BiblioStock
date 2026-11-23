using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioStock.Modelos;

namespace BiblioStock.Patrones
{
    public class FactoryRecurso
    {
        // Crear un libro
        public Libro CrearLibro(
            string codigo,
            string nombre,
            string descripcion,
            string autor,
            string editorial,
            string isbn,
            int paginas)
        {
            Libro libro = new Libro(
                codigo,
                nombre,
                descripcion,
                autor,
                editorial,
                isbn,
                paginas
            );

            return libro;
        }

        // Crear un equipo
        public Equipo CrearEquipo(
            string codigo,
            string nombre,
            string descripcion,
            string marca,
            string modelo,
            string numeroSerie)
        {
            Equipo equipo = new Equipo(
                codigo,
                nombre,
                descripcion,
                marca,
                modelo,
                numeroSerie
            );

            return equipo;
        }
    }
}

