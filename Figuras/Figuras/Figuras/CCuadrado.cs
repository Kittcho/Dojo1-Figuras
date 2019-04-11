using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class CCuadrado:IFigura
    {

        #region Miembros de IFigura

        public double CalcularPerimetro(Dictionary<string, double> valores)
        {
            double resultado = 0d;
            if (valores.Count > 0) { 
                resultado = valores["lado"] * 4;
            }
            return resultado;
        }

        #endregion

        #region Miembros de IFigura


        public double CalcularArea(Dictionary<string, double> valores)
        {
            return valores["lado"] * valores["lado"];
        }

        #endregion
    }
}
