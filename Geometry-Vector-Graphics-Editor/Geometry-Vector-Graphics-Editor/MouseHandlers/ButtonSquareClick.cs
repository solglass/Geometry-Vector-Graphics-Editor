using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonSquareClick : IMouseHandler
    {
        public ButtonSquareClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private SquareFactory squareFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            squareFactory = new SquareFactory();
            Canvas.CurFigureFactory = squareFactory;
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Canvas.Prevpoint = new PointF(eMouse.X, eMouse.Y);
        }
    }
}
