﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Refactor
{
    public class Cuadrado : FormaGeometricaBase
    {
        public Cuadrado(decimal ancho) : base(FormaGeometricaEnum.Cuadrado, ancho)
        {
            // Constructor.
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }       

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
