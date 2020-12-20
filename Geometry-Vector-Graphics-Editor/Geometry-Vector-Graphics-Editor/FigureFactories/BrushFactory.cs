using Geometry_Vector_Graphics_Editor.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.FigureFactories
{
    class BrushFactory : IFigureFactory
    {
        public int PointAmount { get; set; }

        public Figure CreateFigure()
        {
            BrushUpdater updater = new BrushUpdater();
            RegularMover mover = new RegularMover();
            LineDrawer drawer = new LineDrawer();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);
            figure.PointsAmount = 1000;
            return figure;


        }
    }
}
