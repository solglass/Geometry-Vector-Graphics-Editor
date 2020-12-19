using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class PictureBoxMouseDown: IMouseHandler
    {
        PictureBoxMouseDown(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            HandleEvent(sender, e);
        }
        public Canvas Canvas { get; set; }
        private IFigureFactory curFigureFactory;
        public void HandleEvent(object sender, EventArgs e)
        {
            curFigureFactory = Canvas.CurFigureFactory;
            Canvas.CurFigure = curFigureFactory.CreateFigure();
            MouseEventArgs eMouse = (MouseEventArgs)e;
            List<PointF> listPoints = new List<PointF>(new PointF[2] { new PointF(0f, 0f), new PointF(eMouse.Location.X,eMouse.Location.Y)});
            Canvas.CurFigure.Updater.Update(2, listPoints);
            Canvas.CurFigure.Drawer.Draw(listPoints, Canvas.Pen, Canvas.Graphics);
        }
    }
}
