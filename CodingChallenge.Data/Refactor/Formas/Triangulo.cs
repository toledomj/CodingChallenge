using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Refactor
{
    public class Triangulo : FormaGeometricaBase
    {
        public Triangulo(decimal ancho) : base(FormaGeometricaEnum.TrianguloEquilatero, ancho)
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
