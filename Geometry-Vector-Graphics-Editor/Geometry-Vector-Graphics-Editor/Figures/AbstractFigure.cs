using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
   public abstract class AbstractFigure
    {
       public List<PointF> Points { get; private set; }
       public Color Color { get; private set; }
       public int Width { get;private set; }
        public abstract void UpdatePoints(PointF points);
        bool IsCompleted();
        bool IsChosen(PointF point);

        Bitmap Draw(Bitmap curBitmap /*Graphics graphics, Pen pen,*/ /*PointF prevPoint, Point mousePoint*/);
        void Move(PointF delta /*Bitmap curBitmap, Graphics graphics, Pen pen*/);
       // Bitmap Remove(Bitmap curBitmap, Graphics graphics, Pen pen);
       // Bitmap Rotate(Bitmap curBitmap, Graphics graphics, Pen pen);
       // Bitmap Scale(Bitmap curbitmap, Graphics graphics, Pen pen);  
    }
}
