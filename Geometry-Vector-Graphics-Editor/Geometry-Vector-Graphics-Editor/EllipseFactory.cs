using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class EllipseFactory : IFigureFactory2points
    {
        
        public IFigure2points CreateFigure(PointF rectLUPoint, PointF rectOppositePoint)
        {
            return (IFigure2points) new EllipseFigure(rectLUPoint, rectOppositePoint);
        }
    }
}
