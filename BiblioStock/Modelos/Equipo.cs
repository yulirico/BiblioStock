using BiblioStock.Interfaces;
using BiblioStock.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioStock.Modelos
{
    public class Equipo : Recurso, IValidable
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }

        public Equipo(
            string codigo,
            string nombre,
            string descripcion,
            string marca,
            string modelo,
            string numeroSerie)
            : base(codigo, nombre, descripcion)
        {
            Marca = marca;
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion() +
                " - " + Marca + " - " + Modelo;
        }

        public override bool Validar()
        {
            if (!base.Validar())
                return false;

            if (string.IsNullOrWhiteSpace(Marca))
                return false;

            if (string.IsNullOrWhiteSpace(Modelo))
                return false;

            if (string.IsNullOrWhiteSpace(NumeroSerie))
                return false;

            return true;
        }
    }
}


