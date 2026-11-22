using BiblioStock.Interfaces;
using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Persistencia
{
    public class BibliotecarioRepositorio : IRepositorio<Bibliotecario>
    {
        private ArchivoTexto archivo;

        public BibliotecarioRepositorio()
        {
            archivo = new ArchivoTexto("bibliotecarios.txt");
        }

        public List<Bibliotecario> ObtenerTodos()
        {
            List<Bibliotecario> bibliotecarios =
                new List<Bibliotecario>();

            List<string> registros = archivo.LeerArchivo();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 5)
                {
                    Bibliotecario bibliotecario = new Bibliotecario(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3],
                        datos[4]
                    );

                    bibliotecarios.Add(bibliotecario);
                }
            }

            return bibliotecarios;
        }

        public void Guardar(Bibliotecario bibliotecario)
        {
            List<Bibliotecario> bibliotecarios = ObtenerTodos();

            bool encontrado = false;

            for (int i = 0; i < bibliotecarios.Count; i++)
            {
                if (bibliotecarios[i].Identificacion ==
                    bibliotecario.Identificacion)
                {
                    bibliotecarios[i] = bibliotecario;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                bibliotecarios.Add(bibliotecario);
            }

            List<string> registros = new List<string>();

            foreach (Bibliotecario elemento in bibliotecarios)
            {
                string registro =
                    elemento.Identificacion + "|" +
                    elemento.Nombre + "|" +
                    elemento.Correo + "|" +
                    elemento.Usuario + "|" +
                    elemento.Contrasena;

                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        public bool Eliminar(string codigo)
        {
            List<Bibliotecario> bibliotecarios = ObtenerTodos();

            bool eliminado = false;

            for (int i = 0; i < bibliotecarios.Count; i++)
            {
                if (bibliotecarios[i].Identificacion == codigo)
                {
                    bibliotecarios.RemoveAt(i);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                List<string> registros = new List<string>();

                foreach (Bibliotecario elemento in bibliotecarios)
                {
                    string registro =
                        elemento.Identificacion + "|" +
                        elemento.Nombre + "|" +
                        elemento.Correo + "|" +
                        elemento.Usuario + "|" +
                        elemento.Contrasena;

                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminado;
        }
    }
}

