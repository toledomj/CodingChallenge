﻿using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Refactor;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            //Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
            //    FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 1));

            //--------------------------------------------------------------------
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometricaNew.Imprimir(new List<IFormaGeometrica>(), new IdiomaEspaniol()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            //Assert.AreEqual("<h1>Empty list of shapes!</h1>",
            //    FormaGeometrica.Imprimir(new List<FormaGeometrica>(), 2));

            //--------------------------------------------------------------------
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometricaNew.Imprimir(new List<IFormaGeometrica>(), new IdiomaIngles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            //var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(FormaGeometrica.Cuadrado, 5)};
            //var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Castellano);
            //Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);

            //--------------------------------------------------------------------
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };
            var resumen = FormaGeometricaNew.Imprimir(cuadrados, new IdiomaEspaniol());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            //var cuadrados = new List<FormaGeometrica>
            //{
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            //};

            //var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);

            //Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);

            //--------------------------------------------------------------------
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometricaNew.Imprimir(cuadrados, new IdiomaIngles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            //var formas = new List<FormaGeometrica>
            //{
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
            //    new FormaGeometrica(FormaGeometrica.Circulo, 3),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
            //    new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            //};

            //var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);

            //Assert.AreEqual(
            //    "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
            //    resumen);

            //--------------------------------------------------------------------
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaNew.Imprimir(formas, new IdiomaIngles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            //var formas = new List<FormaGeometrica>
            //{
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
            //    new FormaGeometrica(FormaGeometrica.Circulo, 3),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
            //    new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
            //    new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
            //};

            //var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Castellano);

            //Assert.AreEqual(
            //    "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
            //    resumen);

            //--------------------------------------------------------------------
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaNew.Imprimir(formas, new IdiomaEspaniol());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnAleman()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaNew.Imprimir(formas, new IdiomaAleman());

            Assert.AreEqual(
                "<h1>Formularbericht</h1>2 Quadrate | Bereich 29 | Umfang 28 <br/>2 Kreise | Bereich 13,01 | Umfang 18,06 <br/>3 Dreiecke | Bereich 49,64 | Umfang 51,6 <br/>TOTAL:<br/>7 formen Umfang 97,66 Bereich 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulo = new List<IFormaGeometrica> { new Rectangulo(5, 4) };
            var resumen = FormaGeometricaNew.Imprimir(rectangulo, new IdiomaEspaniol());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 20 | Perimetro 18 <br/>TOTAL:<br/>1 formas Perimetro 18 Area 20", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecio = new List<IFormaGeometrica> { new TrapecioIsosceles(28, 12, 10) };
            var resumen = FormaGeometricaNew.Imprimir(trapecio, new IdiomaEspaniol());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 120 | Perimetro 60 <br/>TOTAL:<br/>1 formas Perimetro 60 Area 120", resumen);
        }
    }
}
