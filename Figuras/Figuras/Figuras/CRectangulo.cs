using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class CRectangulo:IFigura
    {
        #region Miembros de IFigura

        public double CalcularPerimetro(Dictionary<string, double> valores)
        {
            return valores["lado"] * 2 + valores["ancho"] * 2;
        }

        #endregion

        #region Miembros de IFigura


        public double CalcularArea(Dictionary<string, double> valores)
        {
            return valores["base"] * valores["altura"];
        }

        #endregion
    }
}
