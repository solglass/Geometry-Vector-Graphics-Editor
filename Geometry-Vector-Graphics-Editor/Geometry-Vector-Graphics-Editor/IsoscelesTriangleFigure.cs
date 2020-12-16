using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class IsoscelesTriangleFigure : IFigure2points
    {
        public List<PointF> Points { get; set; }

        public IsoscelesTriangleFigure()
        { Points = new List<PointF>(); }


        public bool Contains(PointF start, PointF end, PointF checkPoint, double accuracy)
        {
            return CoordinateRoutines.Contains(start, end, checkPoint, accuracy);
        }

        public bool IsSelected(PointF point, int accuracy)
        {
            PointF prevP = Points[0];
            foreach (PointF p in Points)
            {
                if (Contains(prevP, p, point, accuracy))
                {
                    return true;
                }
                prevP = p;
            }
            return false;
        }

        public bool IsCorrect()
        {
            if (Points == null)
            { return false; }
            return true;
        }

        public Bitmap Draw(Bitmap curBitmap, Graphics graphics, Pen pen)
        {
            graphics.DrawPolygon(pen, this.Points.ToArray());
            return curBitmap;
        }

        public Bitmap Move(Bitmap curBitmap, Graphics graphics, Pen pen, PointF delta)
        {
            for (int i = 0; i < Points.Count(); i++)
            {
                PointF p = Points[i];
                Points[i] = new PointF(p.X + delta.X, p.Y + delta.Y);
            }
            graphics.DrawPolygon(pen, this.Points.ToArray());
            return curBitmap;
        }




        public Bitmap Remove(Bitmap curBitmap, Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }

        public Bitmap Rotate(Bitmap curBitmap, Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }

        public Bitmap Scale(Bitmap curbitmap, Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
        }

        public void Update(PointF left, PointF right)
        {
            Points = new List<PointF>(CoordinateRoutines.CalculateIsoscelesTriangleCoordinatesByTwoPoints(left, right));
        }


    }
}
