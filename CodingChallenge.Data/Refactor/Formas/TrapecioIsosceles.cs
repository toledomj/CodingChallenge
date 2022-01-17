using System;

namespace CodingChallenge.Data.Refactor
{
    public class TrapecioIsosceles : FormaGeometricaBase
    {
        private decimal _baseSuperior;
        private decimal _baseInferior;

        public TrapecioIsosceles(decimal baseInferior, decimal baseSuperior, decimal ladoOblicuo) : base(FormaGeometricaEnum.TrapecioIsosceles, ladoOblicuo)
        {
            // Constructor.
            _baseSuperior = baseSuperior;
            _baseInferior = baseInferior;
        }

        public override decimal CalcularArea()
        {
            var baseTriangulo = (_baseSuperior - _baseInferior) / 2;
            var altura = Math.Sqrt(Math.Pow((double)_lado, 2) - Math.Pow((double)baseTriangulo, 2));

            return (decimal)((double)(_baseSuperior + _baseInferior) * altura / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return _baseSuperior + _baseInferior + (_lado * 2);
        }
    }
}
