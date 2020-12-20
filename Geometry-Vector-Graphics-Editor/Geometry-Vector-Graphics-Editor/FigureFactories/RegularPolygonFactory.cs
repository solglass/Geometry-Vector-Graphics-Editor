using Geometry_Vector_Graphics_Editor.Actors;
using Geometry_Vector_Graphics_Editor.Updaters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.FigureFactories
{
    public class RegularPolygonFactory : IFigureFactory
    {
        public int PointAmount { get ; set ; }

        public RegularPolygonFactory(int pointsAmount)
        {
            PointAmount = pointsAmount;
        }
        public Figure CreateFigure()
        {
            RegularPolygonUpdater updater = new RegularPolygonUpdater();
            RegularPolygonDrawer drawer = new RegularPolygonDrawer();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            RegularMover mover = new RegularMover();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);
            figure.PointsAmount = PointAmount;
            return figure;

        }
    }
}
