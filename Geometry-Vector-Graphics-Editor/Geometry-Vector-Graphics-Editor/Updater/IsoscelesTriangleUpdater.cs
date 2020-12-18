using System;
using System.Collections.Generic;
using System.Drawing;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor.Updater
{
    public class IsoscelesTriangleUpdater : IUpdater
    {
        public void Update(List<PointF> points)
        {
            CoordinateRoutines.CalculateIsoscelesTriangleCoordinatesByTwoPoints(points[0], points[1]);
        }
    }
}
