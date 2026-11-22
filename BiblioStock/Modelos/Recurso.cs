using BiblioStock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class Recurso : IValidable
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }

        public Recurso(string codigo, string nombre, string descripcion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Disponible = true;
        }

        public virtual string ObtenerInformacion()
        {
            return Codigo + " - " + Nombre + " - " + Descripcion;
        }

        public virtual bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Codigo))
                return false;

            if (string.IsNullOrWhiteSpace(Nombre))
                return false;

            return true;
        }
    }
}

