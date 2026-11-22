using BiblioStock.Modelos;
using BiblioStock.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Servicios
{
    public class BibliotecarioServicio
    {
        private BibliotecarioRepositorio repositorio;
        private PrestamoRepositorio prestamos;

        public BibliotecarioServicio()
        {
            repositorio = new BibliotecarioRepositorio();
            prestamos = new PrestamoRepositorio();
        }

        public string RegistrarBibliotecario(Bibliotecario bibliotecario)
        {
            if (bibliotecario == null)
                return "No se recibieron los datos del bibliotecario.";

            if (!bibliotecario.Validar())
                return "Los datos del bibliotecario no son validos.";

            List<Bibliotecario> lista = repositorio.ObtenerTodos();

            foreach (Bibliotecario elemento in lista)
            {
                if (elemento.Identificacion == bibliotecario.Identificacion)
                    return "Ya existe un bibliotecario con esa identificacion.";

                if (elemento.Usuario == bibliotecario.Usuario)
                    return "Ese nombre de usuario ya esta registrado.";
            }

            repositorio.Guardar(bibliotecario);

            return "Bibliotecario registrado correctamente.";
        }

        public string ActualizarBibliotecario(Bibliotecario bibliotecario)
        {
            if (bibliotecario == null)
                return "No se recibieron los datos del bibliotecario.";

            if (!bibliotecario.Validar())
                return "Los datos del bibliotecario no son validos.";

            List<Bibliotecario> lista = repositorio.ObtenerTodos();
            bool encontrado = false;

            foreach (Bibliotecario elemento in lista)
            {
                if (elemento.Identificacion == bibliotecario.Identificacion)
                {
                    encontrado = true;
                }
                else if (elemento.Usuario == bibliotecario.Usuario)
                {
                    return "Ese nombre de usuario ya pertenece a otro bibliotecario.";
                }
            }

            if (!encontrado)
                return "El bibliotecario no esta registrado.";

            repositorio.Guardar(bibliotecario);

            return "Bibliotecario actualizado correctamente.";
        }

        public List<Bibliotecario> ObtenerBibliotecarios()
        {
            return repositorio.ObtenerTodos();
        }

        public Bibliotecario BuscarBibliotecario(string identificacion)
        {
            List<Bibliotecario> lista = repositorio.ObtenerTodos();

            foreach (Bibliotecario elemento in lista)
            {
                if (elemento.Identificacion == identificacion)
                    return elemento;
            }

            return null;
        }

        public string EliminarBibliotecario(string identificacion)
        {
            List<Prestamo> listaPrestamos = prestamos.ObtenerTodos();

            foreach (Prestamo elemento in listaPrestamos)
            {
                if (elemento.Bibliotecario.Identificacion == identificacion)
                {
                    return "No se puede eliminar porque tiene prestamos asociados.";
                }
            }

            bool eliminado = repositorio.Eliminar(identificacion);

            if (eliminado)
                return "Bibliotecario eliminado correctamente.";

            return "No se encontro el bibliotecario.";
        }
    }
}

