﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Geometry_Vector_Graphics_Editor.Actors
{
   public interface IDrawer
    {
        void Draw(List<PointF> points, Pen pen, Graphics graphics);         //2DO PARAMETER CANVAS think about either
    }
}
