using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry_Vector_Graphics_Editor.Actors;

namespace Geometry_Vector_Graphics_Editor
{
  public  class Figure:AbstractFigure
    {
        public IUpdater Updater { get; private set; }
        public IScaler Scaler { get; private set; }
        public IDrawer Drawer { get; private set; }
        public IMover Mover { get; private set; }
        public IRotator Rotator { get; private set; }

        public Figure()
        {
        }

        public Figure(IDrawer drawer, IScaler scaler, IUpdater updater, IMover mover, IRotator rotator)
        {
            Updater = updater;
            Scaler = scaler;
            Drawer = drawer;
            Mover = mover;
            Rotator = rotator;
        }

    }
}
