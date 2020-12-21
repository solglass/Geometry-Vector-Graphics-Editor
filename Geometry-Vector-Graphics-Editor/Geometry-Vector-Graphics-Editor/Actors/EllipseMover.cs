using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    public  class EllipseMover:IMover
    {
        public void Move(PointF delta, List<PointF> points)
        {
            for (int i = 0; i < points.Count(); i++)
            {
                PointF p = points[i];
                points[i] = new PointF(p.X + delta.X, p.Y + delta.Y);
            }
        }
    }
}
