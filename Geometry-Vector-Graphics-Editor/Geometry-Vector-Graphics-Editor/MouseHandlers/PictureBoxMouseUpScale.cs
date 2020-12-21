using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseUpScale : IMouseHandler
    {

        public PictureBoxMouseUpScale(object sender, EventArgs e, Canvas cnvs)
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
            if (Canvas.CurFigure != null && Canvas.CurFigure.IsCorrect())
            {
                Canvas.Figures.Add(Canvas.CurFigure);
            }
            Canvas.CurFigure = null;
        }
    }
}
