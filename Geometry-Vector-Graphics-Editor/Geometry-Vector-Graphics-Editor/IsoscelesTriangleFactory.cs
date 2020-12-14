using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class IsoscelesTriangleFactory : IFigureFactory2points
    {
        

        public bool CheckInside(double x, double a, double b, double accuracy)
        {
            return CoordinateRoutines.CheckInside(x, a, b, accuracy);
        }

        public bool Contains(PointF start, PointF end, PointF checkPoint, double accuracy)
        {
            return CoordinateRoutines.Contains(start, end, checkPoint, accuracy);
        }

        public IFigure2points CreateFigure(PointF left, PointF right)
        {
            return (IFigure2points)new IsoscelesTriangleFigure(left, right);
        }
    }
}
