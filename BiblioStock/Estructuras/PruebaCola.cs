using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Estructuras
{
    public class PruebaCola
    {
        public static string Ejecutar()
        {
            Cola<int> cola = new Cola<int>();
            StringBuilder resultado = new StringBuilder();

            resultado.AppendLine("PRUEBA DE COLA ENLAZADA");
            resultado.AppendLine();

            cola.Encolar(10);
            cola.Encolar(20);
            cola.Encolar(30);

            resultado.AppendLine("Elementos agregados: 10, 20, 30");
            resultado.AppendLine("Cantidad: " + cola.Contar());
            resultado.AppendLine("Primero: " + cola.VerPrimero());
            resultado.AppendLine();

            resultado.AppendLine("Retirado: " + cola.Desencolar());
            resultado.AppendLine("Nuevo primero: " + cola.VerPrimero());
            resultado.AppendLine("Cantidad: " + cola.Contar());
            resultado.AppendLine();

            resultado.AppendLine("Retirado: " + cola.Desencolar());
            resultado.AppendLine("Retirado: " + cola.Desencolar());

            resultado.AppendLine("¿Está vacía?: " + cola.EstaVacia());

            cola.Encolar(40);

            resultado.AppendLine();
            resultado.AppendLine("Se agregó el 40 nuevamente.");
            resultado.AppendLine("Primero: " + cola.VerPrimero());
            resultado.AppendLine("Cantidad: " + cola.Contar());

            return resultado.ToString();
        }
    }
}

