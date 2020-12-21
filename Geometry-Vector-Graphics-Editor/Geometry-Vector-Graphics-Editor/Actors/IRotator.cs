using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    public interface IRotator
    {
        public void Rotate(PointF prevPoint, PointF currentPoint, List<PointF> points);
    }
}
