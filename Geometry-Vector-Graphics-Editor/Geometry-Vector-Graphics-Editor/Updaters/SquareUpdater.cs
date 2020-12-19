using System.Collections.Generic;
using System.Drawing;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor.Updater
{
    public class SquareUpdater : IUpdater
    {
        public void Update(int pointsAmount, List<PointF> points, Figure figure)
        {
            CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(points[0], points[1]);
        }
    }
}
