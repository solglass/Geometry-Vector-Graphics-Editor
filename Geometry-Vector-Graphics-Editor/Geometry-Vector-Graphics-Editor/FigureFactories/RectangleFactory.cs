using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class RectangleFactory : IFigureFactory
    {
       
        public AbstractFigure CreateFigure()
        {
           
            return new Figure();
        }
    }
}
