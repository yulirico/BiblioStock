using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioStock.Modelos;

namespace BiblioStock.Patrones
{
    public class SesionBibliotecario
    {
        private static SesionBibliotecario instancia;

        public Bibliotecario BibliotecarioActual { get; private set; }

        private SesionBibliotecario()
        {
            BibliotecarioActual = null;
        }

        public static SesionBibliotecario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new SesionBibliotecario();
                }

                return instancia;
            }
        }

        public void IniciarSesion(Bibliotecario bibliotecario)
        {
            BibliotecarioActual = bibliotecario;
        }

        public void CerrarSesion()
        {
            BibliotecarioActual = null;
        }

        public bool HaySesionActiva()
        {
            return BibliotecarioActual != null;
        }
    }
}
