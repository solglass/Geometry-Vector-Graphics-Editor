using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometry_Vector_Graphics_Editor;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseUpRotate : IMouseHandler
    {

        public PictureBoxMouseUpRotate(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        public void HandleEvent()
        {
            MouseEventArgs eMouse = (MouseEventArgs)E;
            Canvas.Rotate(new PointF(eMouse.X, eMouse.Y));
        }
    }
}
