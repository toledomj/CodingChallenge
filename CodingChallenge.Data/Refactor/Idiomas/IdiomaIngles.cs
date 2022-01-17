using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Refactor
{
    public class IdiomaIngles : ITraduccionReporte
    {
        public string ListaVacia()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string LabelTitulo()
        {
            return "<h1>Shapes report</h1>";
        }

        public string LabelFormas()
        {
            return "shapes";
        }

        public string LabelPerimetro()
        {
            return "Perimeter";
        }

        public string LabelArea()
        {
            return "Area";
        }

        public List<TraduccionForma> ListaFormas()
        {
            List<TraduccionForma> lista = new List<TraduccionForma>();

            lista.Add(new TraduccionForma(FormaGeometricaEnum.Cuadrado, "Square", "Squares"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.TrianguloEquilatero, "Triangle", "Triangles"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Circulo, "Circle", "Circles"));
            lista.Add(new TraduccionForma(FormaGeometricaEnum.Trapecio, "Trapeze", "Trapezoids"));

            return lista;
        }
    }
}
