using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Updater
{
   public class CircleUpdater:IUpdater
    {
        public List<PointF> Update(int pointsAmount, List<PointF> points)
        {
            return  new List<PointF>(CoordinateRoutines.CalculateCicleBySquare(points[0], points[1]));
        }
    }
}
