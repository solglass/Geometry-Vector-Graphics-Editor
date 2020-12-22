using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class MoveFiguresMouseMove : IMouseHandler
    {
        public MoveFiguresMouseMove(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
        }
        public MoveFiguresMouseMove()
        {

        }
        public Canvas Canvas { get; set; }
        public object Sender { get; set; }
        public EventArgs E { get; set; }

        public void HandleEvent()
        {
            if (Canvas.CurFigure != null)
            {
                MouseEventArgs eMouse = (MouseEventArgs)E;
                PointF prefPoint = Canvas.CurFigure.Points[0];
                PointF delta = new PointF(eMouse.X - prefPoint.X, eMouse.Y - prefPoint.Y);
                Canvas.Move(delta);
                // Canvas.DrawCurrentFigure();
                Canvas.DrawCurrentFigurePreservingSettings();
                prefPoint = eMouse.Location;
            }
        }
    }
}
