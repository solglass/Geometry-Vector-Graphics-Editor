using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
    [Serializable]
    public class RegularRotator : IRotator
    {
        public void Rotate(PointF prevPoint, PointF currentPoint, List<PointF> points, bool direction)
        {

            PointF figureCenter = FindFigureCenter(points);
            double angle = FindRotateAngle(figureCenter, prevPoint, currentPoint, direction);
            for (int i = 0; i < points.Count(); i++)
            {
                PointF point = points[i];
                PointF delta = new PointF(point.X - figureCenter.X, point.Y - figureCenter.Y);
                points[i] = new PointF(
                    (float)(figureCenter.X + delta.X * Math.Cos(angle) - delta.Y * Math.Sin(angle)),
                    (float)(figureCenter.Y + delta.X * Math.Sin(angle) + delta.Y * Math.Cos(angle))
                    );
            }
        }

        public PointF FindFigureCenter(List<PointF> points)
        {
            float x = 0;
            float y = 0;
            int count = 0;
            PointF figureCenter;
            foreach (PointF point in points)
            {
                x += point.X;
                y += point.Y;
                count += 1;
            }
            x = x / count;
            y = y / count;

            figureCenter = new PointF(x, y);

            return figureCenter;
        }

            public double FindRotateAngle(PointF center, PointF prevPoint, PointF currentPoint, bool direction)
        {
             double angle = 0;
            double a = Math.Sqrt(Math.Pow(prevPoint.X - center.X, 2) + Math.Pow(prevPoint.Y - center.Y, 2));
            double b = Math.Sqrt(Math.Pow(currentPoint.X - center.X, 2) + Math.Pow(currentPoint.Y - center.Y, 2));
            double c = Math.Sqrt(Math.Pow(currentPoint.X - prevPoint.X, 2) + Math.Pow(currentPoint.Y - prevPoint.Y, 2));
            angle = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * Math.PI / 180;

            if (direction)
            return angle;
            else return -angle;
        }
    }
}

