using System;

namespace CodingChallenge.Data.Refactor
{
    public class Rectangulo : FormaGeometricaBase
    {
        private decimal _base;

        public Rectangulo(decimal ancho, decimal alto) : base(FormaGeometricaEnum.Rectangulo, ancho)
        {
            // Constructor.
            _base = alto;
        }

        public override decimal CalcularArea()
        {
            return _lado * _base;
        }

        public override decimal CalcularPerimetro()
        {
            return (_lado * 2) + (_base * 2);
        }
    }
}
