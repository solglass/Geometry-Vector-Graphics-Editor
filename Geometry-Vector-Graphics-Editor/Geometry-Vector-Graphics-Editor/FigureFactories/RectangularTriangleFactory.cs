using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.FigureFactories
{
    class RectangularTriangle : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return new Figure();
        }
    }
}
