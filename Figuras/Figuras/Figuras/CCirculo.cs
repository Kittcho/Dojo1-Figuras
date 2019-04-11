using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class CCirculo:IFigura
    {
        const double PI = 3.1416;
        #region Miembros de IFigura

        public double CalcularPerimetro(Dictionary<string, double> valores)
        {
            double resultado = 0d;
            if (valores.Keys.First().Equals("radio"))
            {
                resultado = valores["radio"] * 2 * PI;
            }
            else
            {
                resultado = valores["diametro"] * PI;
            }
            return resultado;
        }

        #endregion

        #region Miembros de IFigura


        public double CalcularArea(Dictionary<string, double> valores)
        {
            if (valores.Keys.First().Equals("radio"))
            {
                return Math.Pow((valores["radio"] * PI), 2d);
            }
            else 
            {
                return Math.Pow((valores["diametro"] / 2  * PI), 2d);
            }
        }

        #endregion
    }
}
