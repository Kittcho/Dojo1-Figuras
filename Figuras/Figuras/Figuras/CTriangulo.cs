using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    public class CTriangulo:IFigura
    {
        #region Miembros de IFigura

        public double CalcularPerimetro(Dictionary<string, double> valores)
        {
            return valores["lado"] *3;
        }

        #endregion

        #region Miembros de IFigura


        public double CalcularArea(Dictionary<string, double> valores)
        {
            return valores["base"] * valores["altura"] / 2;
        }

        #endregion
    }
}
