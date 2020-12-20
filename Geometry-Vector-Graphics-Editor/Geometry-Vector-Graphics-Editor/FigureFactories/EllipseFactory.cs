using Geometry_Vector_Graphics_Editor.Actors;
using Geometry_Vector_Graphics_Editor.Updater;
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
        public int PointAmount { get; set; }
        public Figure CreateFigure()
        {
            EllipseDrawer drawer = new EllipseDrawer();
            EllipseUpdater updater = new EllipseUpdater();
            EllipseMover mover = new EllipseMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);

            return figure;
        }
    }
}
