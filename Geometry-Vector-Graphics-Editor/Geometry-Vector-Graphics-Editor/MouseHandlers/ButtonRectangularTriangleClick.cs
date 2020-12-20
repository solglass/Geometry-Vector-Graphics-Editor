using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonRectangularTriangleClick : IMouseHandler
    {


        public ButtonRectangularTriangleClick(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        private RectangularTriangleFactory rectangularTriangleFactory;
        public void HandleEvent()
        {
            rectangularTriangleFactory = new RectangularTriangleFactory();
            Canvas.CurFigureFactory = rectangularTriangleFactory;
            MouseEventArgs eMouse = (MouseEventArgs)E;
            Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
        }
    }
}
