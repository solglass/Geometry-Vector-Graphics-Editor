using Geometry_Vector_Graphics_Editor.Actors;
using Geometry_Vector_Graphics_Editor.Updaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.FigureFactories
{
    public class ZigzagFactory : IFigureFactory
    {
        public Figure CreateFigure()
        {
            ZigzagUpdater updater = new ZigzagUpdater();
            LineDrawer drawer = new LineDrawer();
            RegularMover mover = new RegularMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            return new Figure(drawer, scaler, updater, mover, rotator);
        }
    }
}
