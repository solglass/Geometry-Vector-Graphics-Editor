using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
  public  class LineFigure:IFigure
    {
        Bitmap tmpBitmap;
        public List<PointF> Points { get; private set; }
        public Color Color { get;  set; }
        public int Width { get;  set; }
        private Graphics graphics;
        private Pen pen;
        public bool IsChosen (PointF point)
        {
            if (Points != null && Points.Count() == 2)
            {
                PointF prevPoint = Points[0];
                PointF lastPoint = Points[1];
                if (Contain(prevPoint, lastPoint, point, Width))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Contain(PointF start, PointF end, PointF checkPoint, double accuracy)
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

       private bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
        //public LineFigure(Point startPoint, Point stopPoint)
        //{

        //    Points.Add(startPoint);
        //    Points.Add(stopPoint);
        //}

        public bool IsComplited()
        {
            if (Points != null && Points.Count() == 2) return true;
            else return false;
        }
        public void UpdatePoints(PointF start, PointF stop)
        {
            Points = new List<PointF>
            {
                start,
                stop
            };
        }
        public Bitmap Draw(Bitmap curBitmap, PointF start, Point mousePoint)
        {

            this.UpdatePoints(start, mousePoint);
            pen = new Pen(this.Color, this.Width);
            graphics = Graphics.FromImage(curBitmap);
            graphics.DrawLine(pen, this.Points[0], this.Points[1]);

            return curBitmap;
        }

    }
}
