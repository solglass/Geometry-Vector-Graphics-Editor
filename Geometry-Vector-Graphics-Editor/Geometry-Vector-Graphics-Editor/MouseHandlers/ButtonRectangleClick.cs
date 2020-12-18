using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonRectangleClick : IMouseHandler
    {
        ButtonRectangleClick(object sender, EventArgs e, Canvas cnvs)
        {   
            canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas canvas { get; set; }
        RectangleFactory RectangleFactory{get; set;}
        public void HandleEvent(object sender, EventArgs e)
        {
            RectangleFactory = new RectangleFactory();
        }
    }
}
