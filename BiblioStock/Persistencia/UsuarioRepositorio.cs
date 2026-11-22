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
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        private ArchivoTexto archivo;

        public UsuarioRepositorio()
        {
            archivo = new ArchivoTexto("usuarios.txt");
        }

        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            List<string> registros = archivo.LeerArchivo();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 4)
                {
                    Usuario usuario = new Usuario(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[3]
                    );

                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }

        public void Guardar(Usuario usuario)
        {
            List<Usuario> usuarios = ObtenerTodos();

            bool encontrado = false;

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Identificacion == usuario.Identificacion)
                {
                    usuarios[i] = usuario;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                usuarios.Add(usuario);
            }

            List<string> registros = new List<string>();

            foreach (Usuario elemento in usuarios)
            {
                string registro =
                    elemento.Identificacion + "|" +
                    elemento.Nombre + "|" +
                    elemento.Correo + "|" +
                    elemento.Telefono;

                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        public bool Eliminar(string codigo)
        {
            List<Usuario> usuarios = ObtenerTodos();

            bool eliminado = false;

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Identificacion == codigo)
                {
                    usuarios.RemoveAt(i);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                List<string> registros = new List<string>();

                foreach (Usuario elemento in usuarios)
                {
                    string registro =
                        elemento.Identificacion + "|" +
                        elemento.Nombre + "|" +
                        elemento.Correo + "|" +
                        elemento.Telefono;

                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminado;
        }
    }
}

