using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonRectangleClick : IMouseHandler
    {
        public ButtonRectangleClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private RectangleFactory rectangleFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            rectangleFactory = new RectangleFactory();
            Canvas.CurFigureFactory = rectangleFactory;
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Canvas.Prevpoint = new PointF(eMouse.X, eMouse.Y);
        }
    }
}
