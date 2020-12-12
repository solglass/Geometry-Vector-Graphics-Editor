using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    interface IFigureFactory
    {
        bool Contains(Point start, Point end, Point checkPoint, double accuracy);


        bool CheckInside(double x, double a, double b, double accuracy);


    }
}
