﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor
{
    class SquareFactory : IFigureFactory
    {
        public int PointAmount { get; set; }
        public Figure CreateFigure()
        {
            PolygonDrawer drawer = new PolygonDrawer();
            SquareUpdater updater = new SquareUpdater();
            RegularMover mover = new RegularMover();
            RegularRotator rotator = new RegularRotator();
            RegularScaler scaler = new RegularScaler();
            Figure figure = new Figure(drawer, scaler, updater, mover, rotator);

            return figure;
        }



    }
}
