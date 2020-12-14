using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
  public  class LineFigure
    {
        Bitmap tmpBitmap;
        public List<PointF> Points { get; private set; }

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
        public void Update(PointF start, PointF stop)
        {
            Points = new List<PointF>
            {
                start,
                stop
            };
        }
        public Bitmap Draw(Bitmap curBitmap)
        {

            return curBitmap;
        }

    }
}
