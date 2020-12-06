using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
  public  class Line
    {
        Bitmap tmpBitmap;
        public ArrayList Points { get; private set; }

        public Line(Point startPoint, Point stopPoint)
        {
            Points = new ArrayList();
            Points.Add(startPoint);
            Points.Add(stopPoint);
        }

        public Bitmap Draw(Bitmap curBitmap)
        {

            return curBitmap;
        }

    }
}
