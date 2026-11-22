using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class AutenticacionServicio
    {
        private BibliotecarioRepositorio repositorio;

        public AutenticacionServicio()
        {
            repositorio = new BibliotecarioRepositorio();
        }

        public Bibliotecario IniciarSesion(string usuario,string contrasena)
        {
            List<Bibliotecario> bibliotecarios = repositorio.ObtenerTodos();

            foreach (Bibliotecario bibliotecario in bibliotecarios)
            {
                if (bibliotecario.Usuario == usuario && bibliotecario.Contrasena == contrasena)

                {
                    return bibliotecario;
                }
            }

            return null;
        }

        public List<Bibliotecario> ObtenerBibliotecarios()
        {
            return repositorio.ObtenerTodos();
        }
    }
}

