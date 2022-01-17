using System;

namespace CodingChallenge.Data.Refactor
{
    public class TrianguloEquilatero : FormaGeometricaBase
    {
        public TrianguloEquilatero(decimal ancho) : base(FormaGeometricaEnum.TrianguloEquilatero, ancho)
        {
            // Constructor.
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }       

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
