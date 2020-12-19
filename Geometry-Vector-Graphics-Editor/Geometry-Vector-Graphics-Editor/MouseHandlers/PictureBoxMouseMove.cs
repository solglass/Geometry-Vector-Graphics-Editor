using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
     class PictureBoxMouseMove:IMouseHandler
    {


       public PictureBoxMouseMove(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private IFigureFactory curFigureFactory;
        private  List<PointF> listPoints;
        public void HandleEvent(object sender, EventArgs e)
        {
            if (Canvas.CurFigureFactory != null)
            {
                curFigureFactory = Canvas.CurFigureFactory;
                Canvas.CurFigure = curFigureFactory.CreateFigure();
                MouseEventArgs eMouse = (MouseEventArgs)e;
                listPoints = new List<PointF>(new PointF[2] { new PointF(0, 0), new PointF(eMouse.Location.X, eMouse.Location.Y) });
                Canvas.CurFigure.Updater.Update(2, listPoints, Canvas.CurFigure);
                Canvas.DrawCurrentFigure();
            }
      }
    }
}
