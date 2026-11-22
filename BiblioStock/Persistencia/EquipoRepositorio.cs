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
    public class EquipoRepositorio : IRepositorio<Equipo>
    {
        private ArchivoTexto archivo;

        public EquipoRepositorio()
        {
            archivo = new ArchivoTexto("equipos.txt");
        }

        public List<Equipo> ObtenerTodos()
        {
            List<Equipo> equipos = new List<Equipo>();

            List<string> registros = archivo.LeerArchivo();

            foreach (string registro in registros)
            {
                string[] datos = registro.Split('|');

                if (datos.Length == 7)
                {
                    Equipo equipo = new Equipo(
                        datos[0],
                        datos[1],
                        datos[2],
                        datos[4],
                        datos[5],
                        datos[6]
                    );

                    equipo.Disponible = bool.Parse(datos[3]);

                    equipos.Add(equipo);
                }
            }

            return equipos;
        }

        public void Guardar(Equipo equipo)
        {
            List<Equipo> equipos = ObtenerTodos();

            bool encontrado = false;

            for (int i = 0; i < equipos.Count; i++)
            {
                if (equipos[i].Codigo == equipo.Codigo)
                {
                    equipos[i] = equipo;
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                equipos.Add(equipo);
            }

            List<string> registros = new List<string>();

            foreach (Equipo elemento in equipos)
            {
                string registro =
                    elemento.Codigo + "|" +
                    elemento.Nombre + "|" +
                    elemento.Descripcion + "|" +
                    elemento.Disponible + "|" +
                    elemento.Marca + "|" +
                    elemento.Modelo + "|" +
                    elemento.NumeroSerie;

                registros.Add(registro);
            }

            archivo.GuardarArchivo(registros);
        }

        public bool Eliminar(string codigo)
        {
            List<Equipo> equipos = ObtenerTodos();

            bool eliminado = false;

            for (int i = 0; i < equipos.Count; i++)
            {
                if (equipos[i].Codigo == codigo)
                {
                    equipos.RemoveAt(i);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                List<string> registros = new List<string>();

                foreach (Equipo elemento in equipos)
                {
                    string registro =
                        elemento.Codigo + "|" +
                        elemento.Nombre + "|" +
                        elemento.Descripcion + "|" +
                        elemento.Disponible + "|" +
                        elemento.Marca + "|" +
                        elemento.Modelo + "|" +
                        elemento.NumeroSerie;

                    registros.Add(registro);
                }

                archivo.GuardarArchivo(registros);
            }

            return eliminado;
        }
    }
}

