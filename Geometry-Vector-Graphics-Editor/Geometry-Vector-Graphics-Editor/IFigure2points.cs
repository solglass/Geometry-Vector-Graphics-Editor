using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
    interface IFigure2points
    {
        List<PointF> Points { get; set; }

        Bitmap Draw(Bitmap curBitmap, Graphics graphics, Pen pen);
        Bitmap Move(Bitmap curBitmap, Graphics graphics, Pen pen);
        Bitmap Remove(Bitmap curBitmap, Graphics graphics, Pen pen);
        Bitmap Rotate(Bitmap curBitmap, Graphics graphics, Pen pen);
        Bitmap Scale(Bitmap curbitmap, Graphics graphics, Pen pen);

        void Update(PointF left, PointF right);

    }
}
