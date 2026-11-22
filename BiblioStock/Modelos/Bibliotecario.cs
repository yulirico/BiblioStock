using BiblioStock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
        public class Bibliotecario : Persona, IValidable
        {
            public string Usuario { get; set; }
            public string Contrasena { get; set; }

            public Bibliotecario(
                string identificacion,
                string nombre,
                string correo,
                string usuario,
                string contrasena)
                : base(identificacion, nombre, correo)
            {
                Usuario = usuario;
                Contrasena = contrasena;
            }

            public override string ObtenerInformacion()
            {
                return base.ObtenerInformacion() + " - Bibliotecario";
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

                if (string.IsNullOrWhiteSpace(Usuario))
                    return false;

                if (string.IsNullOrWhiteSpace(Contrasena))
                    return false;

                return true;
            }
        }
}


