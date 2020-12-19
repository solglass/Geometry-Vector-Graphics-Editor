﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor.Updater
{
    public class RectangleUpdater : IUpdater
    {
        public void Update(int pointsAmount, List<PointF> points, Figure figure)
        {
            figure.Points = new List<PointF>(CoordinateRoutines.CalculateRectangleCoordinatesByTwoOppositePoints(points[0], points[1]));
        }
    }
}
