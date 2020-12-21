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
            PointF firstPoint = points.First();
            for (int i=1;i<points.Count-1;i++)
            {
                graphics.DrawLine(pen, points[i - 1], points[i]);
                if(i==points.Count-2)
                {
                    graphics.DrawLine(pen, points[i], firstPoint);
                }
            }
        }
    }
}
