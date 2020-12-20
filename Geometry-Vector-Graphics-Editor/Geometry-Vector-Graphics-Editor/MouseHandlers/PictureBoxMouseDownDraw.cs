using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseDownDraw: IMouseHandler
    {
       public PictureBoxMouseDownDraw(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }

        public Canvas Canvas { get; set; }
        private IFigureFactory curFigureFactory;

        public void HandleEvent()
        {
            if (Canvas.CurFigureFactory != null)
            {
                if (Canvas.CurFigureFactory.PointAmount!=0 && Canvas.CurFigure!=null)
                {
                    if(Canvas.CurFigure.Points!=null&& Canvas.CurFigure.Points.Count()>0)
                    {
                        Canvas.PrevPoint = Canvas.CurFigure.Points.Last();
                    }
                    else
                    {
                        MouseEventArgs eMouse = (MouseEventArgs)E;
                        Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
                    }

                }
                else
                {
                    Canvas.CurFigure = Canvas.CurFigureFactory.CreateFigure();
                    MouseEventArgs eMouse = (MouseEventArgs)E;
                    Canvas.PrevPoint = new PointF(eMouse.X, eMouse.Y);
                }
            }
        }
    }
}
