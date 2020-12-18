using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class RectangularTriangleFactory : DELETEIFigureFactory2points
    {
        public IFigure2points CreateFigure()
        {
            return (IFigure2points)new RectangularTriangleFigure();
        }
    }
}
