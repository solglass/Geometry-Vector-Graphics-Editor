using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class IsoscelesTriangleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure()
        {
            return Figure();
        }
    }
}
