using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor
{
    class EllipseFactory : IFigureFactory
    {
        
        public Figure CreateFigure()
        {
            PolygonDrawer drawer = new PolygonDrawer();
            EllipseUpdater updater = new EllipseUpdater();
            RegularMover mover = new RegularMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);

            return figure;
        }
    }
}
