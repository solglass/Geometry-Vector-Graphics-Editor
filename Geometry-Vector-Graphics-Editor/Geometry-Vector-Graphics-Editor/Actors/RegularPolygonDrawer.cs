using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    public class RegularPolygonDrawer : IDrawer
    {
        public void Draw(List<PointF> points, Pen pen, Graphics graphics)
        {
            PointF firstPoint = points[1];
            for (int i=2;i<points.Count;i++)
            {
                graphics.DrawLine(pen, points[i - 1], points[i]);
                if(i==points.Count-1)
                {
                    graphics.DrawLine(pen, points[i], firstPoint);
                }
            }
        }
    }
}
