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
    class PictureBoxMouseUpDraw : IMouseHandler
    {
       
        public PictureBoxMouseUpDraw(object sender, EventArgs e, Canvas cnvs)
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

            try
            {
                if (Canvas.CurFigure != null && Canvas.CurFigure.PointsAmount == 0 || Canvas.CurFigure.PointsAmount == 1000)
                {
                    Canvas.Figures.Add(Canvas.CurFigure);
                    Canvas.CurFigure = null;
                    Canvas.check = false;
                }
            }
            catch { }
        }
    }
}
