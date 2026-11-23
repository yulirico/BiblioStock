using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BiblioStock.Estructuras
{
    public class Cola<T>
    {
        private Nodo<T>? primero;
        private Nodo<T>? ultimo;
        private int cantidad;

        public Cola()
        {
            primero = null;
            ultimo = null;
            cantidad = 0;
        }

        public bool EstaVacia()
        {
            return primero == null;
        }

        public int Contar()
        {
            return cantidad;
        }

        public void Encolar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);

            if (EstaVacia())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo!.Siguiente = nuevo;
                ultimo = nuevo;
            }

            cantidad++;
        }

        public T? VerPrimero()
        {
            if (EstaVacia())
            {
                return default;
            }

            return primero!.Dato;
        }

        public T? Desencolar()
        {
            if (EstaVacia())
            {
                return default;
            }

            T dato = primero!.Dato;

            primero = primero.Siguiente;
            cantidad--;

            if (primero == null)
            {
                ultimo = null;
            }

            return dato;
        }

        public bool Eliminar(T dato)
        {
            Nodo<T>? actual = primero;
            Nodo<T>? anterior = null;

            while (actual != null)
            {
                if (EqualityComparer<T>.Default.Equals(actual.Dato, dato))
                {
                    if (anterior == null)
                    {
                        primero = actual.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }

                    if (actual == ultimo)
                    {
                        ultimo = anterior;
                    }

                    cantidad--;

                    if (primero == null)
                    {
                        ultimo = null;
                    }

                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }

        public List<T> ObtenerElementos()
        {
            List<T> elementos = new List<T>();

            Nodo<T>? actual = primero;

            while (actual != null)
            {
                elementos.Add(actual.Dato);
                actual = actual.Siguiente;
            }

            return elementos;
        }
    }
}


