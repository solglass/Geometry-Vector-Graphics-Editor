using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor
{
    class CircleFactory : IFigureFactory
    {
        public Figure CreateFigure()
        {
            EllipseDrawer drawer = new EllipseDrawer();
            CircleUpdater updater = new CircleUpdater();
            EllipseMover mover = new EllipseMover();
            EllipseRotator rotator = new EllipseRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer,scaler,updater,mover,rotator);

            return figure;
        }
    }
}
