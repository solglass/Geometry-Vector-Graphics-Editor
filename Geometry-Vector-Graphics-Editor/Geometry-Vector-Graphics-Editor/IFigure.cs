using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry_Vector_Graphics_Editor
{
    interface IFigure
    {
        ArrayList Points { get; set; }

        Bitmap Draw(Bitmap curBitmap);
        Bitmap Move(Bitmap curBitmap);
        Bitmap Remove(Bitmap curBitmap);
        Bitmap Rotate(Bitmap curBitmap);
        Bitmap Scale(Bitmap bitmap);  
    }
}
