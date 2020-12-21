using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Updaters
{
    [Serializable]
    public class RegularPolygonUpdater:IUpdater
    {
        
        public List<PointF> Update(int pointsAmount, List<PointF> points)
        {
            List<PointF> points1 = CoordinateRoutines.RotatePoint(pointsAmount, points.Last(), points.First());
            
            return points1;
        }
    }
}
