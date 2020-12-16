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
        private IUpdater _updater;
        private IScaler __scaler;
        private IDrawer _drawer;
        private IMover _mover;
        private IRotator _rotator;
        public Figure(IDrawer drawer, IScaler scaler, IUpdater updater, IMover mover, IRotator rotator)
        {
            _updater = updater;
            __scaler = scaler;
            _drawer = drawer;
            _mover = mover;
            _rotator = rotator;
        }
      public void Draw()
        {
            _drawer.Draw(Points);
        }
    }
}
