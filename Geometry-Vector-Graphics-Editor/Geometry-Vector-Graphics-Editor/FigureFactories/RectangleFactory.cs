using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor.Actors;
using Geometry_Vector_Graphics_Editor.Updater;

namespace Geometry_Vector_Graphics_Editor
{
    class RectangleFactory : IFigureFactory
    {

        public Figure CreateFigure()
        {
            PolygonDrawer drawer = new PolygonDrawer();
            RectangleUpdater updater = new RectangleUpdater();
            RegularMover mover = new RegularMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);

            return figure;
        }
    }
}
