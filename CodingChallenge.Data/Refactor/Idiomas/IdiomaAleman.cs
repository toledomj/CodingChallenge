using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Refactor
{
    public class IdiomaAleman : ITraduccionReporte
    {
        public string ListaVacia()
        {
            return "<h1>Leere liste von formen!</h1>";
        }

        public string LabelTitulo()
        {
            return "<h1>Formularbericht</h1>";
        }

        public string LabelFormas()
        {
            return "formen";
        }

        public string LabelPerimetro()
        {
            return "Umfang";
        }

        public string LabelArea()
        {
            return "Bereich";
        }

        public List<TraduccionForma> ListaFormas()
        {
            List<TraduccionForma> lista = new List<TraduccionForma>();

            lista.Add(new TraduccionForma(FormaGeometricaEnum.Cuadrado, "Platz", "Quadrate"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.TrianguloEquilatero, "Dreieck", "Dreiecke"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Circulo, "Kreis", "Kreise"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Trapecio, "Trapez", "Trapeze"));

            return lista;
        }
    }
}
