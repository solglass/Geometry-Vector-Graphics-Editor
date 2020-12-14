using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
   public interface IFigure
    {
        List<PointF> Points { get;  }
        Color Color { get; set; }
        int Width { get; set; }
        void UpdatePoints(PointF start, PointF stop);
        


        Bitmap Draw(Bitmap curBitmap, /*Graphics graphics, Pen pen,*/ PointF prevPoint, Point mousePoint);
       // Bitmap Move(Bitmap curBitmap, Graphics graphics, Pen pen);
       // Bitmap Remove(Bitmap curBitmap, Graphics graphics, Pen pen);
       // Bitmap Rotate(Bitmap curBitmap, Graphics graphics, Pen pen);
       // Bitmap Scale(Bitmap curbitmap, Graphics graphics, Pen pen);  
    }
}
