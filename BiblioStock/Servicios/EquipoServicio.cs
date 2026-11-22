using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class EquipoServicio
    {
        private EquipoRepositorio repositorio;
        private PrestamoRepositorio prestamos;

        public EquipoServicio()
        {
            repositorio = new EquipoRepositorio();
            prestamos = new PrestamoRepositorio();
        }

        // Registrar un equipo
        public string RegistrarEquipo(Equipo equipo)
        {
            if (equipo == null)
                return "No se recibieron los datos del equipo.";

            if (!equipo.Validar())
                return "Los datos del equipo no son validos.";

            List<Equipo> equipos = repositorio.ObtenerTodos();

            foreach (Equipo elemento in equipos)
            {
                if (elemento.Codigo == equipo.Codigo)
                    return "Ya existe un equipo con ese codigo.";

                if (elemento.NumeroSerie == equipo.NumeroSerie)
                    return "Ya existe un equipo con ese numero de serie.";
            }

            repositorio.Guardar(equipo);

            return "Equipo registrado correctamente.";
        }

        // Actualizar un equipo
        public string ActualizarEquipo(Equipo equipo)
        {
            if (equipo == null)
                return "No se recibieron los datos del equipo.";

            if (!equipo.Validar())
                return "Los datos del equipo no son validos.";

            List<Equipo> equipos = repositorio.ObtenerTodos();

            Equipo equipoEncontrado = null;

            foreach (Equipo elemento in equipos)
            {
                if (elemento.Codigo == equipo.Codigo)
                {
                    equipoEncontrado = elemento;
                    break;
                }
            }

            if (equipoEncontrado == null)
                return "El equipo no esta registrado.";

            // Comprobar que el numero de serie no este repetido
            foreach (Equipo elemento in equipos)
            {
                if (elemento.Codigo != equipo.Codigo &&
                    elemento.NumeroSerie == equipo.NumeroSerie)
                {
                    return "Ese numero de serie pertenece a otro equipo.";
                }
            }

            // Conservar la disponibilidad actual
            equipo.Disponible = equipoEncontrado.Disponible;

            repositorio.Guardar(equipo);

            return "Equipo actualizado correctamente.";
        }

        // Consultar todos los equipos
        public List<Equipo> ObtenerEquipos()
        {
            return repositorio.ObtenerTodos();
        }

        // Buscar un equipo por codigo
        public Equipo BuscarEquipo(string codigo)
        {
            List<Equipo> equipos = repositorio.ObtenerTodos();

            foreach (Equipo elemento in equipos)
            {
                if (elemento.Codigo == codigo)
                    return elemento;
            }

            return null;
        }

        // Eliminar un equipo
        public string EliminarEquipo(string codigo)
        {
            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Recurso != null &&
                    elemento.Recurso.Codigo == codigo &&
                    elemento.Recurso is Equipo)
                {
                    return "No se puede eliminar el equipo porque tiene historial de prestamos.";
                }
            }

            bool eliminado = repositorio.Eliminar(codigo);

            if (eliminado)
                return "Equipo eliminado correctamente.";

            return "No se encontro el equipo.";
        }
    }
}

