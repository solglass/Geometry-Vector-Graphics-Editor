using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class MoveFiguresMouseUp : IMouseHandler
    {
        public MoveFiguresMouseUp(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public Canvas Canvas { get; set; }
        public object Sender { get; set; }
        public EventArgs E { get; set; }

        public void HandleEvent()
        {
            
            Canvas.CurFigure = null;
        }
    }
}
