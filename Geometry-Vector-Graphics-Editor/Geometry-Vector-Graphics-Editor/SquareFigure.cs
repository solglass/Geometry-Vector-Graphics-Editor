using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class SquareFigure: IFigure2points
    {
        public List<PointF> Points { get; set; }

        public SquareFigure()
        {  }



        public SquareFigure(PointF left, PointF right)
        { Points = new List<PointF>(CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(left, right)); }

        public Bitmap Draw(Bitmap curBitmap, Graphics graphics, Pen pen)
        {
            
            graphics.DrawPolygon(pen, this.Points.ToArray());
            return curBitmap;

        }

        public Bitmap Move(Bitmap curBitmap, Graphics graphics, Pen pen)
        {
            throw new NotImplementedException();
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
            Points = new List<PointF>(CoordinateRoutines.CalculateSquareCoordinatesByTwoOppositePoints(left, right));

        }
    }
}
