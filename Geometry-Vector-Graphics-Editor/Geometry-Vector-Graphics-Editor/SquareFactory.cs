using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class SquareFactory : IFigureFactory2points
    {

        public IFigure2points CreateFigure()
        {
            SquareFigure Square = new SquareFigure();
            return (IFigure2points) Square;
        }

        public bool isCorrect(IFigure2points figure)
        {
            if (figure.Points == null)
            {
                return false;
            }
            return true;
        }




    }
}
