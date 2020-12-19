using System;
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
        public static PointF[] CalculateSquareCoordinatesByTwoAdjacentPoints(PointF pt1, PointF pt2)
        {
            PointF pt3;
            PointF pt4;
            PointF[] arrPoints;
            double side = Math.Pow(pt2.X - pt1.X, 2) + Math.Pow(pt2.Y - pt1.Y, 2);

            arrPoints = new PointF[4];
            float ae = pt2.Y - pt1.Y;
            if (ae != 0)
            {
                float be = pt1.X - pt2.X;
                float ce = pt1.Y * pt2.X - pt1.X * pt2.Y;

                float xleftDown = (int)((ae * (side - ce - be * pt1.Y) + be * be * pt1.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
                float yleftDown = (ae * pt1.Y - be * pt1.X + be * xleftDown) / ae;
                float xrightDown = (int)((ae * (side - ce - be * pt2.Y) + be * be * pt2.X) / (Math.Pow(ae, 2) + Math.Pow(be, 2)));
                float yrightDown = (ae * pt2.Y - be * pt2.X + be * xrightDown) / ae;


                pt3 = new PointF(xrightDown, yrightDown);
                pt4 = new PointF(xleftDown, yleftDown);

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
            float x2 = pt2.X;
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

        public static PointF[] CalculateRectangularTriangleCoordinatesByTwoPoints(PointF LeftPt, PointF RightPt)
        {
            PointF[] arrPoints = new PointF[3];
            PointF ThirdPoint = new PointF();
            if (LeftPt.Y > RightPt.Y)
            {
                ThirdPoint = new PointF(LeftPt.X, RightPt.Y);
            }
            else if (LeftPt.Y < RightPt.Y)
            { ThirdPoint = new PointF(RightPt.X, LeftPt.Y); }
            else { }
            arrPoints[0] = LeftPt;
            arrPoints[1] = RightPt;
            arrPoints[2] = ThirdPoint;
            return arrPoints;
        }

        public static PointF[] CalculateIsoscelesTriangleCoordinatesByTwoPoints(PointF LeftPt, PointF RightPt)
        {
            PointF[] arrPoints = new PointF[3];
            float delta =  2 * (RightPt.X - LeftPt.X);
            PointF ThirdPoint = new PointF();
            if (LeftPt.Y > RightPt.Y) 
            {
                ThirdPoint = new PointF(RightPt.X - delta, RightPt.Y);
            }
            else if (LeftPt.Y < RightPt.Y)
            {
                ThirdPoint = new PointF(LeftPt.X + delta, LeftPt.Y);
            }
            else { }

            arrPoints[0] = LeftPt;
            arrPoints[1] = RightPt;
            arrPoints[2] = ThirdPoint;

            return arrPoints;
        }

        public static PointF[] CalculateCicleBySquare(PointF rectLUPoint, PointF rectOppositePoint)
        {
            PointF[] points = CalculateSquareCoordinatesByTwoOppositePoints(rectLUPoint, rectOppositePoint);
            PointF LeftUpPt = points[0];
            PointF RightUpPt = points[1];
            PointF RightDownPt = points[2];
            PointF LeftDownPt = points[3];
            PointF UpCenterPt = new PointF((RightUpPt.X + LeftUpPt.X) / 2, RightUpPt.Y);
            PointF DownCenterPt = new PointF((RightUpPt.X + LeftUpPt.X) / 2, RightDownPt.Y);
            PointF LeftCenterPt = new PointF(LeftUpPt.X, (LeftDownPt.Y + LeftUpPt.Y) / 2);
            PointF RightCenterPt = new PointF(RightUpPt.X, (RightDownPt.Y + RightUpPt.Y) / 2);
            PointF CenterPt = new PointF((RightUpPt.X + LeftUpPt.X) / 2, (RightUpPt.Y + RightDownPt.Y) / 2);

            return new PointF[] { LeftUpPt, RightDownPt, RightUpPt, LeftDownPt, LeftCenterPt, RightCenterPt, CenterPt, DownCenterPt, UpCenterPt };
        }
        public static PointF[] CalculateEllipseByRectangle(PointF rectLUPoint, PointF rectOppositePoint)
        {
            PointF LeftUpPt = rectLUPoint;
            PointF RightUpPt =new PointF (rectOppositePoint.X,rectLUPoint.Y);
            PointF RightDownPt = rectOppositePoint;
            PointF LeftDownPt =new PointF (rectLUPoint.X, rectOppositePoint.Y);
            PointF UpCenterPt = new PointF ((RightUpPt.X + LeftUpPt.X)/2, RightUpPt.Y);
            PointF DownCenterPt = new PointF ((RightUpPt.X + LeftUpPt.X)/2, RightDownPt.Y);
            PointF LeftCenterPt = new PointF (LeftUpPt.X,(LeftDownPt.Y + LeftUpPt.Y)/2);
            PointF RightCenterPt = new PointF (RightUpPt.X,(RightDownPt.Y + RightUpPt.Y)/2);
            PointF CenterPt = new PointF((RightUpPt.X + LeftUpPt.X) / 2, (RightUpPt.Y + RightDownPt.Y) / 2);

            return new PointF[] {LeftUpPt, RightDownPt, RightUpPt,LeftDownPt, LeftCenterPt, RightCenterPt, CenterPt, DownCenterPt,UpCenterPt};
        }

        public static bool Contains(PointF start, PointF end, PointF checkPoint, double accuracy)
        {
            double x1 = start.X;
            double y1 = start.Y;
            double x2 = end.X;
            double y2 = end.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

        public static bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }

    }

}


