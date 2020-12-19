using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    public class PolygonDrawer : IDrawer
    {
        public void Draw(List<PointF> points, Pen pen, Graphics graphics)
        {
            graphics.DrawPolygon(pen, points.ToArray());
        }
    }
}
