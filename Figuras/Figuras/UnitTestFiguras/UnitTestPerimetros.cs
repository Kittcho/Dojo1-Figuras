using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figuras;

namespace UnitTestFiguras
{
    [TestClass]
    public class UnitTestPerimetros
    {
        IFigura figura;

        [TestMethod]
        public void CalculaPerimetroCuadrado()
        {
           // CCuadrado cuadrado = new CCuadrado();
            this.figura = new CCuadrado();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("lado", 20d);
            double perimetro = figura.CalcularPerimetro(valores);

            Assert.AreEqual(80d, perimetro);
        }

        [TestMethod]
        public void ValidaValorCuadrado()
        {
            CCuadrado cuadrado = new CCuadrado();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            double perimetro = cuadrado.CalcularPerimetro(valores);

            Assert.AreEqual(0d, perimetro);
        }

        [TestMethod]
        public void CalculaPerimetroTrianguloEquilatero()
        {
            this.figura = new CTriangulo();
           // CTriangulo triangulo = new CTriangulo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("lado", 15d);
            double perimetro = figura.CalcularPerimetro(valores);

            Assert.AreEqual(45d, perimetro);

        }

        [TestMethod]
        public void CalculaPerimetroRectangulo()
        {
            CRectangulo rectangulo = new CRectangulo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("lado", 25d);
            valores.Add("ancho", 15d);
            double perimetro = rectangulo.CalcularPerimetro(valores);

            Assert.AreEqual(80d, perimetro);
        }

        //2*pi*radio 
        [TestMethod]
        public void CalculaPerimetroCirculoRadio()
        {
            CCirculo circulo = new CCirculo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("radio", 10d);
            double perimetro = circulo.CalcularPerimetro(valores);
            Assert.AreEqual(62.832d, perimetro);
        }

        //Diametro *pi 
        [TestMethod]
        public void CalculaPerimetroCirculoDiametro()
        {
            CCirculo circulo = new CCirculo();
            Dictionary<string, double> valores = new Dictionary<string, double>();
            valores.Add("diametro", 15d);
            double perimetro = circulo.CalcularPerimetro(valores);
            Assert.AreEqual(47.124d, perimetro);
        }
    }
}
