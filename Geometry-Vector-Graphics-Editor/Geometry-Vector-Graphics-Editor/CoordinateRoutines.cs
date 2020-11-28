using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
    public  class CoordinateRoutines
    {

        public static Point[] CalculateSquareCoordinatesByTwoPoints(Point Point1, Point Point2)
        {
            Point[] arrPoints = new Point[4];
            Point Point3;
            Point Point4;
            double side = Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2);

            int ae = Point2.Y - Point1.Y;
            int be = -(Point2.X - Point1.X);
            int ce = -(Point1.X * Point2.Y - Point1.Y * Point2.X);

            var xleftDown = (int)((ae * (side - ce - be * Point1.Y) + be * be * Point1.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
            int yleftDown = (ae * Point1.Y - be * Point1.X + be * xleftDown) / ae;
            var xrightDown = (int)((ae * (side - ce - be * Point2.Y) + be * be * Point2.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
            int yrightDown = (ae * Point2.Y - be * Point2.X + be * xrightDown) / ae;


            Point3 = new Point(xrightDown, yrightDown);
            Point4 = new Point(xleftDown, yleftDown);

            arrPoints[0] = Point1;
            arrPoints[1] = Point2;
            arrPoints[2] = Point3;
            arrPoints[3] = Point4;

            Array.Sort(arrPoints);
            return arrPoints;
        }

        public static Point[] CalculateRectangleCoordinatesByTwoPoints(Point Point1, Point Point2)
        {
            Point[] arrPoints = new Point[4];
            //TODO Implement analytically
            Array.Sort(arrPoints);
            return arrPoints;
        }
    }
}
