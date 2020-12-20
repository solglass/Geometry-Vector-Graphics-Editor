﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
   class ButtonIsoscelesTriangleClick : IMouseHandler
    {
        public ButtonIsoscelesTriangleClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        IsoscelesTriangleFactory isoscelesTriangleFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            isoscelesTriangleFactory = new IsoscelesTriangleFactory();
            Canvas.CurFigureFactory = isoscelesTriangleFactory;
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
        }
    }
}
