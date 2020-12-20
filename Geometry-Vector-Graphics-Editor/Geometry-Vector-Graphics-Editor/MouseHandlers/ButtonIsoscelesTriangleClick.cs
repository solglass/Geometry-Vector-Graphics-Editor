using System;
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
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        IsoscelesTriangleFactory isoscelesTriangleFactory;
        public void HandleEvent()
        {
            isoscelesTriangleFactory = new IsoscelesTriangleFactory();
            Canvas.CurFigureFactory = isoscelesTriangleFactory;
            MouseEventArgs eMouse = (MouseEventArgs)E;
            Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
        }
    }
}
