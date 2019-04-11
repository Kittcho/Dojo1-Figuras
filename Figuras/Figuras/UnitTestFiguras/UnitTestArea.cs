using System;
using System.Collections.Generic;
using Figuras;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFiguras
{
    [TestClass]
    public class UnitTestArea
    {
        [TestMethod]
        public void CalculaAreaCuadrado()
        {
            CCuadrado cuadrado = new CCuadrado();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("lado", 10d);

            Assert.AreEqual(100d, cuadrado.CalcularArea(valores));
        }

        [TestMethod]
        public void CalculaAreaTriangulo()
        {
            CTriangulo triangulo = new CTriangulo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("base", 10d);
            valores.Add("altura", 10d);

            Assert.AreEqual(50d, triangulo.CalcularArea(valores));

        }
        [TestMethod]
        public void CalculaAreaRectangulo()
        {
            CRectangulo rectangulo = new CRectangulo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("base", 30d);
            valores.Add("altura", 10d);

            Assert.AreEqual(300d, rectangulo.CalcularArea(valores));
        }

        [TestMethod]
        public void CalculaAreaCirculo()
        {
            CCirculo circulo = new CCirculo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("radio", 30d);

            Assert.AreEqual(8882.685504d, circulo.CalcularArea(valores), 0.1d);
        }

        [TestMethod]
        public void CalculaAreaCirculoDiametro()
        {
            CCirculo circulo = new CCirculo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("diametro", 10d);

            Assert.AreEqual(246.741264d, circulo.CalcularArea(valores), 0.1d);
        }
    }
}
