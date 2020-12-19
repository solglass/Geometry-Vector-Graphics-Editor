﻿using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Updater
{
   public class EllipseUpdater:IUpdater
    {
        public List<PointF> Update(int pointsAmount, List<PointF> points)
        {
            PointF rectLUPoint = points[0];
            PointF rectOppositePoint = points[2];
            RectangleF rect = new RectangleF(rectLUPoint.X, rectLUPoint.Y, rectOppositePoint.X - rectLUPoint.X, rectOppositePoint.Y - rectLUPoint.Y);
           return points = new List<PointF>(CoordinateRoutines.CalculateEllipseByRectangle(rectLUPoint, rectOppositePoint));
        }
    }
}
