using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometry_Vector_Graphics_Editor;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonLineClick : IMouseHandler
    {
        public ButtonLineClick(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private LineFactory lineFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            lineFactory = new LineFactory();
            Canvas.CurFigureFactory = lineFactory;
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Canvas.Prevpoint = new System.Drawing.PointF(eMouse.X, eMouse.Y);
        }
    }
}
