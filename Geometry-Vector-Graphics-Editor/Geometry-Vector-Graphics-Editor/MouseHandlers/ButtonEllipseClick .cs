using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometry_Vector_Graphics_Editor.MouseHandlers
{
    class ButtonEllipseClick : IMouseHandler
    {
       public ButtonEllipseClick(object sender, EventArgs e, Canvas cnvs)
        {   
            Canvas = cnvs;
            E = e;
            Sender = sender;
            HandleEvent();
        }
        public object Sender { get; set; }
        public EventArgs E { get; set; }
        public Canvas Canvas { get; set; }
        private EllipseFactory ellipseFactory;
        public void HandleEvent()
        {
            ellipseFactory = new EllipseFactory();
            Canvas.CurFigureFactory = ellipseFactory;
        }
    }
}
