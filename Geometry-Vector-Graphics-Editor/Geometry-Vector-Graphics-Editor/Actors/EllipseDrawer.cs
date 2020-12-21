using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    public class EllipseDrawer:IDrawer
    {
        public void Draw(List<PointF> points, Pen pen, Graphics graphics)
        {
            PointF rectLUPoint = points[0];
            PointF rectOppositePoint = points[1];
            RectangleF rect = new RectangleF(rectLUPoint.X, rectLUPoint.Y, rectOppositePoint.X - rectLUPoint.X, rectOppositePoint.Y - rectLUPoint.Y);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
