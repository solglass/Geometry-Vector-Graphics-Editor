using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class MoveFiguresMouseDown : IMouseHandler
    {
        public MoveFiguresMouseDown(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public Canvas Canvas { get ; set ; }
        public object Sender { get ; set ; }
        public EventArgs E { get ; set ; }

        public void HandleEvent()
        {
            MouseEventArgs eMouse = (MouseEventArgs)E;
            Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
            foreach (Figure figure in Canvas.Figures)
            {
                if (figure.IsCorrect() && figure.IsSelected(Canvas.PrevPoint, 50))
                {
                    Canvas.CurFigure = figure;
                    Canvas.Figures.Remove(Canvas.CurFigure);
                    Canvas.DrawAll();
                    break;
                }
            }
        }
    }
}
