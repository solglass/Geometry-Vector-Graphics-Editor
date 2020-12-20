using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor
{
    public class LineFactory : IFigureFactory
    {
        public int PointAmount { get; set; }
        public Figure CreateFigure()
        {
            LineDrawer drawer = new LineDrawer();
            LineUpdater updater = new LineUpdater();
            RegularMover mover = new RegularMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            return new Figure(drawer, scaler, updater, mover, rotator);
        }
    }
}
