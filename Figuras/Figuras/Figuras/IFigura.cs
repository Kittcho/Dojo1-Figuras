using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    public interface IFigura
    {
        double CalcularPerimetro(Dictionary<string, double> valores);
        double CalcularArea(Dictionary<string, double> valores);
    }
}
