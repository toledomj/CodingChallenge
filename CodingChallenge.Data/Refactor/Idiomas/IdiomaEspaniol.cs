using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Refactor
{
    public class IdiomaEspaniol : ITraduccionReporte
    {
        public string ListaVacia()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string LabelTitulo()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string LabelFormas()
        {
            return "formas";
        }

        public string LabelPerimetro()
        {
            return "Perimetro";
        }

        public string LabelArea()
        {
            return "Area";
        }

        public List<TraduccionForma> ListaFormas()
        {
            List<TraduccionForma> lista = new List<TraduccionForma>();

            lista.Add(new TraduccionForma(FormaGeometricaEnum.Cuadrado, "Cuadrado", "Cuadrados"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.TrianguloEquilatero, "Triángulo", "Triángulos"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Circulo, "Círculo", "Círculos"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Trapecio, "Trapecio", "Trapecios"));

            return lista;
        }
    }
}
