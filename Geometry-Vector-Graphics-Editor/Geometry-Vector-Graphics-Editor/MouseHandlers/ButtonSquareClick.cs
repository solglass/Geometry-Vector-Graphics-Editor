﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonSquareClick : IMouseHandler
    {
        ButtonSquareClick(object sender, EventArgs e, Canvas cnvs)
        {   
            canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas canvas { get; set; }
        private SquareFactory squareFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            squareFactory = new SquareFactory();
        }
    }
}
