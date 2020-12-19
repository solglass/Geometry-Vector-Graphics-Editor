using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonRectangularTriangleClick : IMouseHandler
    {
        public ButtonRectangularTriangleClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        RectangularTriangleFactory rectangularTriangleFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            rectangularTriangleFactory = new RectangularTriangleFactory();
        }
    }
}
