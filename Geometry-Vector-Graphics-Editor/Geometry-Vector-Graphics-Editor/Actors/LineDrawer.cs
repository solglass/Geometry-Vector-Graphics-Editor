using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    class LineDrawer: IDrawer
    {
        public void Draw(List<PointF> points, Pen pen, Graphics graphics)
        {
            for (int i=1;i<points.Count;i++)
            {
                graphics.DrawLine(pen, points[i-1], points[i]);
            }
            
        }
    }
}
