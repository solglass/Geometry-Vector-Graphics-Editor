
using System.Collections.Generic;
using System.Drawing;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor.Updater
{
    public class RectangularTriangleUpdater : IUpdater
    {
        public void Update(List<PointF> points)
        {
            CoordinateRoutines.CalculateRectangularTriangleCoordinatesByTwoPoints(points[0], points[1]);
        }
    }
}
