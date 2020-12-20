using Geometry_Vector_Graphics_Editor.FigureFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonRegularPolygonClick:IMouseHandler
    {
        public ButtonRegularPolygonClick(object sender, EventArgs e, Canvas cnvs)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public ButtonRegularPolygonClick(object sender, EventArgs e, Canvas cnvs, int pointsAmount)
        {
            Canvas = cnvs;
            E = e;
            Sender = sender;
            PointsAmount = pointsAmount;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        private RegularPolygonFactory polygonFactory;
        public int PointsAmount { get; set; }
        public void HandleEvent()
        {
            polygonFactory = new RegularPolygonFactory(PointsAmount);
            Canvas.CurFigureFactory = polygonFactory;
            Canvas.CurFigure = null;
            MouseEventArgs eMouse = (MouseEventArgs)E;
            Canvas.PrevPoint = new System.Drawing.PointF(eMouse.X, eMouse.Y);
        }
    }
}
