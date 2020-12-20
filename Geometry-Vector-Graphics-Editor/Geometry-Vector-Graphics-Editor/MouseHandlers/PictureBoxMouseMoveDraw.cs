using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
     class PictureBoxMouseMoveDraw:IMouseHandler
    {

        public Canvas Canvas { get; set; }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        private List<PointF> listPoints;

        public PictureBoxMouseMoveDraw(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            Sender = sender;
            E = e;
        }
        public PictureBoxMouseMoveDraw()
        {

        }

        public void HandleEvent()
        {
            if (Canvas.CurFigure != null)
            {
                MouseEventArgs eMouse = (MouseEventArgs)E;
               
                listPoints = new List<PointF>(new PointF[2] { Canvas.PrevPoint, new PointF(eMouse.Location.X, eMouse.Location.Y) });
                Canvas.Update(listPoints, 2);
                Canvas.DrawCurrentFigure();
               
            }
      }

        public void HandleEvent(object sender, EventArgs e)
        {
            Sender = sender;
            E = e;
            HandleEvent();
        }
    }
}
