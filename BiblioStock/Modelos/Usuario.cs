using BiblioStock.Interfaces;
using BiblioStock.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class Usuario : Persona, IValidable
    {
        public string Telefono { get; set; }

        public Usuario(
            string identificacion,
            string nombre,
            string correo,
            string telefono)
            : base(identificacion, nombre, correo)
        {
            Telefono = telefono;
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() + " - " + Telefono;
        }

        public bool Validar()
        {
            if (string.IsNullOrWhiteSpace(Identificacion))
                return false;

            if (string.IsNullOrWhiteSpace(Nombre))
                return false;

            if (string.IsNullOrWhiteSpace(Correo))
                return false;

            if (!Correo.Contains("@"))
                return false;

            if (string.IsNullOrWhiteSpace(Telefono))
                return false;

            return true;
        }
    }
}


