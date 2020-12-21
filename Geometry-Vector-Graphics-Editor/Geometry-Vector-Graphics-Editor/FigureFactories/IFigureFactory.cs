using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
  public  interface IFigureFactory
    {
        int PointAmount { get; set; }
        Figure CreateFigure();

    }
}
