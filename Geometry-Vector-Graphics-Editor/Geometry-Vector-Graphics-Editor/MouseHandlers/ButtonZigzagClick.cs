using Geometry_Vector_Graphics_Editor.FigureFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
   public class ButtonZigzagClick : IMouseHandler
    {
        public ButtonZigzagClick(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private ZigzagFactory zigzagFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            zigzagFactory = new ZigzagFactory();
            Canvas.CurFigureFactory = zigzagFactory;
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Canvas.Prevpoint = new System.Drawing.PointF(eMouse.X, eMouse.Y);
        }
    }
}
