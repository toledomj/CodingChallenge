using System;

namespace CodingChallenge.Data.Refactor
{
    public class Circulo : FormaGeometricaBase
    {
        public Circulo(decimal ancho) : base(FormaGeometricaEnum.Circulo, ancho)
        {
            // Constructor.
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }       

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
    }
}
