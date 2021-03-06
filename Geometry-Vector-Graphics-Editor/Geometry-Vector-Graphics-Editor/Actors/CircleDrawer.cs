﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    class CircleDrawer : IDrawer
    {
        public void Draw(List<PointF> points, Pen pen, Graphics graphics)
        {
            PointF rectLUPoint = points[0];
            PointF rectOppositePoint = points[2];
            RectangleF rect = new RectangleF(rectLUPoint.X, rectLUPoint.Y, rectOppositePoint.X - rectLUPoint.X, rectOppositePoint.X - rectLUPoint.X);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
