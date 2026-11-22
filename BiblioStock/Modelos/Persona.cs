using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiblioStock.Modelos
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Persona(string identificacion, string nombre, string correo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Correo = correo;
        }

        public virtual string ObtenerInformacion()
        {
            return Identificacion + " - " + Nombre + " - " + Correo;
        }
    }
}

