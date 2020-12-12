﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Geometry_Vector_Graphics_Editor
{
    public static class CoordinateRoutines
    {
        //For future use, not in currnet version
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

        public static PointF[] CalculateSquareCoordinatesByTwoOppositePoints(PointF pt1, PointF pt2)
        {
            PointF[] arrPoints = new PointF[4];
            PointF pt3 = new PointF();
            PointF pt4 = new PointF();
            float x1 = pt1.X;
            float y1 = pt1.Y;    // First diagonal point
            float x2 = pt2.Y;
            float y2 = pt2.Y;
            float xc = (x1 + x2) / 2;
            float yc = (y1 + y2) / 2;    // Center point
            float xd = (x1 - x2) / 2;
            float yd = (y1 - y2) / 2;    // Half-diagonal

            float x3 = xc - yd;
            float y3 = yc + xd;    // Third corner
            float x4 = xc + yd;
            float y4 = yc - xd;    // Fourth corner
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


        public static PointF[] CalculateRectangleCoordinatesByTwoOppositePoints(PointF LeftPt, PointF RightPt)
        {
            PointF[] arrPoints = new PointF[4];
            PointF topLeft = new PointF();
            PointF bottomRight= new PointF();
            PointF bottomLeft = new PointF();
            PointF topRight = new PointF();
            if (LeftPt.X > RightPt.X) 
            {
                topLeft = LeftPt;
                bottomRight = RightPt;
                bottomLeft = new PointF(topLeft.X, bottomRight.Y);
                topRight = new PointF(bottomRight.X, topLeft.Y);
            }
            else if(LeftPt.X < RightPt.X)
                {
                bottomLeft = LeftPt;
                topRight = RightPt;
                topLeft = new PointF(bottomLeft.X, topRight.Y);
                bottomRight = new PointF(topRight.X, bottomLeft.Y);
                }
            else { }
            

            arrPoints[0] = bottomLeft;
            arrPoints[1] = topLeft;
            arrPoints[2] = topRight;
            arrPoints[3] = bottomRight;
            return arrPoints;
        }

        public static Point[] CalculateRectangularTriangleCoordinatesByTwoPoints(Point LeftPt, Point RightPt)
        {
            Point[] arrPoints = new Point[3];
            Point ThirdPoint = new Point();
            if (LeftPt.Y > RightPt.Y)
            {
                ThirdPoint = new Point(LeftPt.X, RightPt.Y);
            }
            else if (LeftPt.Y < RightPt.Y)
            { ThirdPoint = new Point(RightPt.X, LeftPt.Y); }
            else { }
            arrPoints[0] = LeftPt;
            arrPoints[1] = RightPt;
            arrPoints[2] = ThirdPoint;
            return arrPoints;
        }

        public static Point[] CalculateIsoscelesTriangleCoordinatesByTwoPoints(Point LeftPt, Point RightPt)
        {
            Point[] arrPoints = new Point[3];
            int delta = 2 * (RightPt.X - LeftPt.X);
            Point ThirdPoint = new Point();
            if (LeftPt.Y > RightPt.Y) 
            {
                ThirdPoint = new Point(RightPt.X - delta, RightPt.Y);
            }
            else if (LeftPt.Y < RightPt.Y)
            {
                ThirdPoint = new Point(LeftPt.X + delta, LeftPt.Y);
            }
            else { }

            arrPoints[0] = LeftPt;
            arrPoints[1] = RightPt;
            arrPoints[2] = ThirdPoint;

            return arrPoints;
        }


        public static Point[] CalculateCirclePointBySquare(Point squareLUPoint, Point squareOppositePoint)
        {

            int circleCenterX = (squareOppositePoint.X + squareLUPoint.X) / 2;
            int circleCenterY = (squareOppositePoint.Y + squareLUPoint.Y) / 2;
            Point circleCenter = new Point(circleCenterX, circleCenterY);
            Point circleRadius = new Point(circleCenterX, squareLUPoint.Y);
            return new Point[] { circleCenter, circleRadius };
        }

        public static Point[] CalculateEllipseByRectangle(Point rectLUPoint, Point rectOppositePoint)
        {
            int ellipseCenterX = ((rectOppositePoint.X + rectLUPoint.X) / 2);
            int ellipseCenterY = ((rectOppositePoint.Y + rectLUPoint.Y) / 2);
            Point ellipseCenter = new Point(ellipseCenterX, ellipseCenterY);
            Point ellipseRadiusHeight = new Point(rectLUPoint.X, ellipseCenterY);
            Point ellipseRadiusWeight = new Point(ellipseCenterX, rectLUPoint.Y);
            return new Point[] { ellipseCenter, ellipseRadiusHeight, ellipseRadiusWeight };
        }





    }

}


