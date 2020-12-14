﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class RectangleFactory : IFigureFactory2points
    {
       
        public IFigure2points CreateFigure(PointF left, PointF right)
        {
            return (IFigure2points) new RectangleFigure(left,right);
        }
        public bool CheckInside(double x, double a, double b, double accuracy)
        {
            return CoordinateRoutines.CheckInside(x, a, b, accuracy);
        }

        public bool Contains(PointF start, PointF end, PointF checkPoint, double accuracy)
        {
            double x1 = start.X;
            double y1 = start.Y;
            double x2 = end.X;
            double y2 = end.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

  
    }
}
