using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Geometry_Vector_Graphics_Editor
{
    public class CoordinateRoutines
    {

        public static Point[] CalculateSquareCoordinatesByTwoAdjacentPoints(Point pt1, Point pt2)
        {
            Point[] arrPoints = new Point[4];
            Point pt3;
            Point pt4;
            double side = Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2);


            int ae = pt2.Y - pt1.Y;
            if (ae != 0)
            {
                int be = pt1.X - pt2.X;
                int ce = pt1.Y * pt2.X - pt1.X * pt2.Y;

                int xleftDown = (int)((ae * (side - ce - be * pt1.Y) + be * be * pt1.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
                int yleftDown = (ae * pt1.Y - be * pt1.X + be * xleftDown) / ae;
                int xrightDown = (int)((ae * (side - ce - be * pt2.Y) + be * be * pt2.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
                int yrightDown = (ae * pt2.Y - be * pt2.X + be * xrightDown) / ae;


                pt3 = new Point(xrightDown, yrightDown);
                pt4 = new Point(xleftDown, yleftDown);

                arrPoints[0] = pt1;
                arrPoints[1] = pt2;
                arrPoints[2] = pt3;
                arrPoints[3] = pt4;

            }
            else { throw new DivideByZeroException("Two points must be of different heights!"); }
            return arrPoints;
        }

        public static Point[] CalculateSquareCoordinatesByTwoOppositePoints(Point pt1, Point pt2)
        {
            Point[] arrPoints = new Point[4];
            Point pt3 = new Point(); 
            Point pt4 = new Point();
            int x1 = pt1.X; 
            int y1 = pt1.Y ;    // First diagonal point
            int x2 = pt2.Y  ; 
            int y2 = pt2.Y ;
            int xc = (x1 + x2) / 2;
            int yc = (y1 + y2) / 2;    // Center point
            int xd = (x1 - x2) / 2; 
            int yd = (y1 - y2) / 2;    // Half-diagonal

            int x3 = xc - yd; 
            int y3 = yc + xd;    // Third corner
            int x4 = xc + yd; 
            int y4 = yc - xd;    // Fourth corner
            pt3.X = x3;
            pt3.Y = y3;
            pt4.X = x4;
            pt4.Y = y4;

            arrPoints[0] = pt1;
            arrPoints[1] = pt3;
            arrPoints[2] = pt2;
            arrPoints[3] = pt4;

            return arrPoints;
        }


        public static Point[] CalculateRectangleCoordinatesByTwoPoints(Point bottomLeft, Point topRight)
            {
                Point[] arrPoints = new Point[4];
                Point topLeft = new Point(bottomLeft.X, topRight.Y);
                Point bottomRight = new Point(topRight.X, bottomLeft.Y);
                arrPoints[0] = bottomLeft;
                arrPoints[1] = topLeft;
                arrPoints[2] = topRight;
                arrPoints[3] = bottomRight;
               // Rectangle.FromLTRB(0, 0, dist, dist);
                return arrPoints;
            }

            public static Point[] CalculateRectangularTriangleCoordinatesByTwoPoints(Point bottomLeft, Point topRight)
            {
                Point[] arrPoints = new Point[4];
            //TODO implement
                return arrPoints;
            }
        }
    }


