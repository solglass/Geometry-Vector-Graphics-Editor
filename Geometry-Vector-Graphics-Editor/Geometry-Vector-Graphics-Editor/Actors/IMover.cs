﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Vector_Graphics_Editor.Actors
{
  public interface IMover
    {
        void Move(PointF delta, List<PointF> points);
    }
}
